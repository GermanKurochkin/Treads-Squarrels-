using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace Treads_Squarrels_
{
  
    public partial class Form1 : Form
    {
        Random rnd = new Random(3);
        const string filenameTXT = @"C:\SomeDir\squarrels.txt";
        const int cSize = 20;
        const int cCount = 20;
        const int constSpeed = 10;
        Task[] SquarrelsX2=null;
       int speed = 5;
        int nuts = 0;
        int nutsSpeed=5;
        int scrat = 0, black=0,ground=0,brown=0,orange=0;
        static AutoResetEvent stop = new AutoResetEvent(false);
        static object locker = new object();
        delegate void Del();
        delegate void DelStr(string txt);
        private void ChangeImage(int row, int col, int img)
        {
            dataGridView1.Rows[row].Cells[col].Value = imageList1.Images[img];
            dataGridView1.Rows[row].Cells[col].Tag = img;
          
        }
        private bool Empty(int row, int col)
        {
            return (int)dataGridView1.Rows[row].Cells[col].Tag==1;
        }
        private bool Nut(int row, int col)
        {
            return (int)dataGridView1.Rows[row].Cells[col].Tag == 0;
        }
        private bool Squarrel(int row, int col)
        {
            return (int)dataGridView1.Rows[row].Cells[col].Tag > 1;
        }
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns[0].Width = cSize;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Height = cSize;
            for (int i = 2; i <= cCount; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewImageColumn());
                dataGridView1.Columns[i - 1].Width = cSize;
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i - 1].Height = cSize;
            }
            for (int i = 0; i < cCount; i++)
            {
                for (int j = 0; j < cCount; j++)
                {
                    ChangeImage(i, j, 1);
                }
            }
            //for(int i= 0;i<imageList1.Images.Count;i++)           
            //dataGridView1.Rows[i].Cells[i].Value = imageList1.Images[i];


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filenameTXT, string.Empty);         
            buttonStart.Enabled = true;
            rnd = new Random(DateTime.Now.Hour+ DateTime.Now.Day+ DateTime.Now.Millisecond);
            for (int i = 0; i < 30; i++)
            {
                int x = rnd.Next(20), y = rnd.Next(20);
                ChangeImage(y,x, 0);
                nuts++;
                Task file = Task.Factory.StartNew(() => FileAct($"row {y}, col {x} - nut appear"));
            }
            dataGridView1.Update();
            Task[] taskArray = { Task.Factory.StartNew(() => Nuts()),
                                 Task.Factory.StartNew(() => Scrat(rnd.Next(20), rnd.Next(20))),
                                 Task.Factory.StartNew(() => Black(rnd.Next(18)+1, rnd.Next(18)+1)),
                                 Task.Factory.StartNew(() => Ground(rnd.Next(18)+1, rnd.Next(18)+1)),
                                 Task.Factory.StartNew(() => Brown(rnd.Next(14), rnd.Next(4))),
                                 Task.Factory.StartNew(() => Orange(rnd.Next(20), rnd.Next(20))) };
            //while(true)
            //{
            //    Thread.Sleep(speed * 50);
            //    dataGridView1.Refresh();
            //}

        }
        private void Orange(int y, int x)
        {

            int img = 7;
            int targetX, targetY;
            int searchResult=0;
            while (true)
            {
                int way = 40;
                if (speed != 0) Thread.Sleep(speed * 20 * constSpeed);
                else stop.WaitOne(Timeout.Infinite);
                ChangeImage(y, x, 12);
                Task<int[]>[] taskArray = { Task<int[]>.Factory.StartNew(() => Search(y,x,1)),
                                 Task<int[]>.Factory.StartNew(() => Search(y,x,2)),
                                 Task<int[]>.Factory.StartNew(() => Search(y,x,3)),
                                 Task<int[]>.Factory.StartNew(() => Search(y,x,4))
                               };

                Task.WaitAny(taskArray);
                for (int i = 0; i < taskArray.Length; i++)
                    if (taskArray[i].IsCompleted)
                    {
                        if (taskArray[i].Result[1] < way)
                        {
                            searchResult = taskArray[i].Result[0];
                            way = taskArray[i].Result[1];
                        }
                        break;
                    }
                targetX = searchResult % 20;
                targetY = searchResult / 20;

                int dirX = targetX > x ? 1 : -1;
                int dirY = targetY > y ? 1 : -1;
                dirX = targetX == x ? 0 : dirX;
                dirY = targetY == y ? 0 : dirY;
                while (dirX != 0 || dirY != 0)              
                {
                    if (speed != 0) Thread.Sleep(speed * 20 * constSpeed);
                    else stop.WaitOne(Timeout.Infinite);
                    int yy = 0, xx = 0;
                    if (dirX!=0)
                    {
                        x += dirX;
                        xx=dirX;
                        if (x == targetX) dirX = 0;
                        if (dirX==1) img = 7;
                        else img = 6;
                    }
                    else if(dirY!=0)
                    {
                        y += dirY;
                       yy=dirY;
                        if (y == targetY) dirY = 0;
                    }

                    while (Squarrel(y, x))
                    {
                        Thread.Sleep(speed * 5 * constSpeed);

                    }
                    ChangeImage(y-yy, x-xx, 1);
                    if (Nut(y, x))
                    {
                        orange++;
                        nuts--;
                        Task file = Task.Factory.StartNew(() => FileAct($"row {y}, col {x} - orange eat nut"));
                    }
                    ChangeImage(y, x, img);



                    dataGridView1.Invoke(new Del(() => dataGridView1.Update()));
                    labelOrange.Invoke(new DelStr((A) => labelOrange.Text = A), orange.ToString());
                }
            }
        }
        private int[] Search(int y, int x, int dir)
        {
            int startX = x, startY = y;
            int i = 0;
            int dirX = dir > 2 ? 1 : -1;
            int dirY = dir % 2==1 ? 1 : -1;
            List<int> coord = new List<int> { 1, 20 };
            do
            {
                if (speed != 0) Thread.Sleep(speed * 10 * constSpeed);
                else stop.WaitOne(Timeout.Infinite);
                do
                {
                    x = startX + dirX*(coord[i] % 20);
                    y = startY + dirY*(coord[i] / 20);
                    i++;
                    if(i==coord.Count)
                    {
                        coord.Add(coord[coord.Count - 1] + 20);
                        for(int j=0;j<coord.Count-1;j++)
                        {
                            coord[j]++;
                        }
                       
                        i = 0;
                    }
                }
                while (x < 0 || x >= 20 || y < 0 || y >= 20);
          
            }
            while (coord.Count<15&& !Nut(y,x));
            

            

            return new int[2] { y * 20 + x, Math.Abs(startY-y)+ Math.Abs(startY - y) };
        }

        private void Brown(int y, int x)
        {

            int img = 2;
            int startX = x, startY = y;
            int dirx = 1, diry = 1;
            bool goX = true;
            while (true)
            {

                if (speed != 0) Thread.Sleep(speed * 10 * constSpeed);
                else stop.WaitOne(Timeout.Infinite);

                int yy = 0, xx = 0;
                if (goX)
                {
                    x += dirx;
                    xx = dirx;
                    if (x == startX || x == startX+6)
                    {
                        dirx *= -1;
                        goX = false;
                    }
                    if (dirx == 1) img = 2;
                    else img = 3;
                }
                else
                {
                    y += diry;
                    yy = diry;
                    goX = true;
                    if (y == startY || y == startY+6)
                    {
                        diry *= -1;

                    }
                }



                if (x >= 0 && x < 20 && y >= 0 && y < 20 && !Squarrel(y, x))
                {
                    ChangeImage(y - yy, x - xx, 1);
                    if (Nut(y, x))
                    {
                        brown++;
                        nuts--;
                        Task file = Task.Factory.StartNew(() => FileAct($"row {y}, col {x} - brown eat nut"));
                    }
                    ChangeImage(y, x, img);
                }
                else
                {
                    y -= yy;
                    x -= xx;
                    Thread.Sleep(speed * 10 * constSpeed);
                    if (xx == 0)
                    {
                        diry *= -1;
                        goX = false;
                    }
                    else
                    {
                        if (y == startY + 6) diry = -1;
                        else diry = 1;
                        goX = false;
                    }

                }

                dataGridView1.Invoke(new Del(() => dataGridView1.Update()));
                labelBrown.Invoke(new DelStr((A) => labelBrown.Text = A), brown.ToString());
            }
        }
        private void Ground(int y, int x)
        {

            int img = 5;
            int dirx = 1, diry = 1;
            bool goX = true;
            while (true)
            {

                if (speed != 0) Thread.Sleep(speed * 20 * constSpeed);
                else stop.WaitOne(Timeout.Infinite);

                int yy = 0, xx = 0;
                if(goX)
                {
                    x += dirx;
                    xx = dirx;
                    if (x == 0 || x == 19)
                    {
                        dirx *= -1;
                        goX = false;
                    }
                    if (dirx == 1) img = 5;
                    else img = 4;
                }
                else
                {
                    y += diry;
                    yy = diry;
                    goX = true;
                    if (y == 0 || y == 19)
                    {
                        diry *= -1;
                      
                    }
                }



                if (x >= 0 && x < 20 && y >= 0 && y < 20 && !Squarrel(y, x))
                {
                    ChangeImage(y - yy, x - xx, 1);
                    if (Nut(y, x))
                    {
                        ground++;
                        nuts--;
                        Task file = Task.Factory.StartNew(() => FileAct($"row {y}, col {x} - ground eat nut"));
                    }
                    ChangeImage(y, x, img);
                }
                else
                {
                    y -= yy;
                    x -= xx;
                    Thread.Sleep(speed * 10 * constSpeed);
                    if (xx == 0)
                    {
                        diry *= -1;
                        goX = false;
                    }
                    else
                    {
                        if (y == 19) diry = -1;
                        else diry = 1;
                        goX = false;
                    }
                }

                dataGridView1.Invoke(new Del(() => dataGridView1.Update()));
                labelGround.Invoke(new DelStr((A) => labelGround.Text = A), ground.ToString());
            }
        }
        private void Black(int y, int x)
        {
           
            int img = 9;
            int hungry = 0;
            bool vertical = false;
            int dir = 1;
            while (true)
            {
                if (speed != 0) Thread.Sleep(speed * 10* constSpeed);
                else stop.WaitOne(Timeout.Infinite);

                int yy=0,xx=0;

                if (vertical)
                {
                    y += dir;
                    yy = dir;
                    if (y == 0 || y==19)
                    {
                        dir *= -1;
                    }
                }
                else
                {
                    x += dir;
                    xx = dir;
                    if (x == 0 || x == 19)
                    {
                        dir *= -1;
                    }
                    if (dir == 1) img = 9;
                    else img = 8;
                }

                if (x >= 0 && x < 20 && y >= 0 && y < 20 && !Squarrel(y, x))
                {
                    ChangeImage(y - yy, x - xx, 1);
                    if (Nut(y, x))
                    {
                        black++;
                        hungry = 0;
                        nuts--;
                        Task file = Task.Factory.StartNew(() => FileAct($"row {y}, col {x} - black eat nut"));
                    }
                    else hungry++;
                    ChangeImage(y, x, img);
                    if (hungry > 10)
                    {
                        hungry = 2;
                        vertical = !vertical;
                    }
                }
                else
                {
                    y -= yy;
                    x -= xx;
                    Thread.Sleep(speed * 10* constSpeed);
                    vertical = !vertical;
                }

                dataGridView1.Invoke(new Del(() => dataGridView1.Update()));
                labelBlack.Invoke(new DelStr((A) => labelBlack.Text = A), black.ToString());
            }
        }
        private void Scrat(int y, int x)
        {
           
            int img = 11;
            while (true)
            {
                if (speed != 0) Thread.Sleep(speed * 5* constSpeed);
                else stop.WaitOne(Timeout.Infinite);

                int yy = rnd.Next(2)*2-1;
                int xx = rnd.Next(2)*2-1;
                if(rnd.Next(2)==1 )
                {
                    if (y + yy >= 0 & y + yy < 20)
                    {
                        y += yy;
                        xx = 0;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (x + xx >= 0 & x + xx < 20)
                    {
                        x += xx;
                        yy = 0;
                        if (xx == 1) img = 10;
                        else img = 11;
                    }
                    else continue;
                }

                if (x >= 0 && x < 20 && y >= 0 && y < 20 && !Squarrel(y, x))
                {
                    ChangeImage(y - yy, x - xx, 1);
                    if (Nut(y, x))
                    {
                        scrat++;
                        nuts--;
                        Task file = Task.Factory.StartNew(() => FileAct($"row {y}, col {x} - scrat eat nut"));
                    }
                    ChangeImage(y, x, img);
                   
                }
                else
                {
                    y -= yy;
                    x -= xx;
                    Thread.Sleep(speed * 5* constSpeed);
                }


                dataGridView1.Invoke(new Del(() => dataGridView1.Update()));
                labelScrat.Invoke(new DelStr((A) => labelScrat.Text = A), scrat.ToString());
            }
        }
        private void Nuts()
        {
           
            while (true)
            {
                if (speed != 0) Thread.Sleep(speed * nutsSpeed*4*constSpeed);
                else stop.WaitOne(Timeout.Infinite);

                if (nuts < 20) numbox2.Invoke(new DelStr((A) => numbox2.Text = A), "10");
                else if (nuts < 50) numbox2.Invoke(new DelStr((A) => numbox2.Text = A), "8");
                else if (nuts < 100) numbox2.Invoke(new DelStr((A) => numbox2.Text = A), "6");
                else if (nuts < 200) numbox2.Invoke(new DelStr((A) => numbox2.Text = A), "4");
                else numbox2.Invoke(new DelStr((A) => numbox2.Text = A), "2");
                int y = rnd.Next(20);
                int x = rnd.Next(20);
                if (Empty(y, x))
                {
                    ChangeImage(y, x, 0);
                    nuts++;
                    Task file = Task.Factory.StartNew(() => FileAct($"row {y}, col {x} - nut appear"));
                    labelNuts.Invoke(new DelStr((A) => labelNuts.Text = A), nuts.ToString());
                }
                dataGridView1.Invoke(new Del(() => dataGridView1.Refresh()));
            }
        }
        private void FileAct(string str)
        {
            lock (locker)
            {
                using (StreamWriter sw = new StreamWriter(filenameTXT, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(str);
                }
            }
        }

        private void buttonSqrlX2_Click(object sender, EventArgs e)
        {
            if (SquarrelsX2 == null && !buttonStart.Enabled)
            {
                nutsSpeed = 10;
                SquarrelsX2 = new Task[]{  Task.Factory.StartNew(() => Scrat(rnd.Next(20), rnd.Next(20))),
                                 Task.Factory.StartNew(() => Black(rnd.Next(18)+1, rnd.Next(18)+1)),
                                 Task.Factory.StartNew(() => Ground(rnd.Next(18)+1, rnd.Next(18)+1)),
                                 Task.Factory.StartNew(() => Brown(rnd.Next(14), rnd.Next(14))),
                                 Task.Factory.StartNew(() => Orange(rnd.Next(20), rnd.Next(20))) };
            }
            else
            {
                MessageBox.Show("Количество белок уже удвоено или игра не начата");
            }
        }

        private void buttonAllNut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cSize; i++)
            {
                for (int j = 0; j < cSize; j++)
                {
                    if (Empty(j,i))
                    {
                        ChangeImage(j, i, 0);
                            nuts++;
                    }
                    
                    Task file = Task.Factory.StartNew(() => FileAct($"all field in nuts"));
                }
            }
            labelNuts.Invoke(new DelStr((A) => labelNuts.Text = A), nuts.ToString());
            dataGridView1.Invoke(new Del(() => dataGridView1.Refresh()));
        }

        private void numbox1_TextChanged(object sender, EventArgs e)
        {
            if (numbox1.Text != "")
            {
               
               
                if (numbox1.Text == "0")
                {
                    speed = 0;
                    stop = new AutoResetEvent(false);
                    labelInfo.Text = "Поменяйте скорость, чтобы продолжить";
                }
                else
                {
                    if (int.Parse(numbox1.Text) > 10) numbox1.Text = "10";
                    speed = 11 - int.Parse(numbox1.Text);
                    stop.Set();
                    labelInfo.Text = "";
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
           
                numbox1.Text = "0";
            
          
          
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("scrat - беспорядочно бегает\n\n" +
                "black - бегает по одной линии, иногда её меняя\n\n" +
                "ground - оббегает все клетки\n\n" +
                "brown - оббегает клетки своего квадрата 7x7\n\n" +
                "orange - ищет и бежит к ближайшему ореху");
        }

        private void numbox2_TextChanged(object sender, EventArgs e)
        {
            if (numbox2.Text != "")
            {


                if (numbox2.Text == "0")
                {
                    numbox2.Text = "1";
                }
                else
                {
                    if (int.Parse(numbox2.Text) > 10) numbox2.Text = "10";
                    nutsSpeed = 11 - int.Parse(numbox2.Text);
                }
            }
        }
    }
}
