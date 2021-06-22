
namespace Treads_Squarrels_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelOrange = new System.Windows.Forms.Label();
            this.labelScrat = new System.Windows.Forms.Label();
            this.labelBrown = new System.Windows.Forms.Label();
            this.labelBlack = new System.Windows.Forms.Label();
            this.labelGround = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelNuts = new System.Windows.Forms.Label();
            this.buttonSqrlX2 = new System.Windows.Forms.Button();
            this.buttonAllNut = new System.Windows.Forms.Button();
            this.numbox2 = new Treads_Squarrels_.Numbox(this.components);
            this.numbox1 = new Treads_Squarrels_.Numbox(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(26, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(602, 617);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 20;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nut.png");
            this.imageList1.Images.SetKeyName(1, "4139066.png");
            this.imageList1.Images.SetKeyName(2, "brown-squarrel (2).png");
            this.imageList1.Images.SetKeyName(3, "brown-squarrel.png");
            this.imageList1.Images.SetKeyName(4, "ground-squirrel (2).png");
            this.imageList1.Images.SetKeyName(5, "ground-squirrel.png");
            this.imageList1.Images.SetKeyName(6, "squirrel (2).png");
            this.imageList1.Images.SetKeyName(7, "squirrel.png");
            this.imageList1.Images.SetKeyName(8, "black-squarrel (2).png");
            this.imageList1.Images.SetKeyName(9, "black-squarrel.png");
            this.imageList1.Images.SetKeyName(10, "squirrel-scrat (2).jpg");
            this.imageList1.Images.SetKeyName(11, "squirrel-scrat.jpg");
            this.imageList1.Images.SetKeyName(12, "squirrelSearch.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(954, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Скорость всего";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(833, 562);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(109, 58);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Treads_Squarrels_.Properties.Resources.black_squarrel;
            this.pictureBox5.Location = new System.Drawing.Point(689, 193);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Treads_Squarrels_.Properties.Resources.ground_squirrel;
            this.pictureBox4.Location = new System.Drawing.Point(689, 272);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Treads_Squarrels_.Properties.Resources.brown_squarrel__2_;
            this.pictureBox3.Location = new System.Drawing.Point(689, 349);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Treads_Squarrels_.Properties.Resources.squirrel;
            this.pictureBox2.Location = new System.Drawing.Point(689, 432);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Treads_Squarrels_.Properties.Resources.squirrel_scrat__2_;
            this.pictureBox1.Location = new System.Drawing.Point(689, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelOrange
            // 
            this.labelOrange.AutoSize = true;
            this.labelOrange.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOrange.Location = new System.Drawing.Point(811, 447);
            this.labelOrange.Name = "labelOrange";
            this.labelOrange.Size = new System.Drawing.Size(18, 20);
            this.labelOrange.TabIndex = 10;
            this.labelOrange.Text = "0";
            // 
            // labelScrat
            // 
            this.labelScrat.AutoSize = true;
            this.labelScrat.Location = new System.Drawing.Point(177, 29);
            this.labelScrat.Name = "labelScrat";
            this.labelScrat.Size = new System.Drawing.Size(18, 20);
            this.labelScrat.TabIndex = 11;
            this.labelScrat.Text = "0";
            // 
            // labelBrown
            // 
            this.labelBrown.AutoSize = true;
            this.labelBrown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBrown.Location = new System.Drawing.Point(811, 372);
            this.labelBrown.Name = "labelBrown";
            this.labelBrown.Size = new System.Drawing.Size(18, 20);
            this.labelBrown.TabIndex = 12;
            this.labelBrown.Text = "0";
            // 
            // labelBlack
            // 
            this.labelBlack.AutoSize = true;
            this.labelBlack.Location = new System.Drawing.Point(177, 109);
            this.labelBlack.Name = "labelBlack";
            this.labelBlack.Size = new System.Drawing.Size(18, 20);
            this.labelBlack.TabIndex = 13;
            this.labelBlack.Text = "0";
            // 
            // labelGround
            // 
            this.labelGround.AutoSize = true;
            this.labelGround.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelGround.Location = new System.Drawing.Point(811, 285);
            this.labelGround.Name = "labelGround";
            this.labelGround.Size = new System.Drawing.Size(18, 20);
            this.labelGround.TabIndex = 14;
            this.labelGround.Text = "0";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Location = new System.Drawing.Point(690, 80);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(0, 20);
            this.labelWin.TabIndex = 15;
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(961, 562);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(82, 58);
            this.buttonStop.TabIndex = 16;
            this.buttonStop.Text = "Стоп";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(954, 112);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 20);
            this.labelInfo.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(651, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(754, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "scrat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(754, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "black";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(747, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "ground";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(754, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "brown";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(746, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "orange";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(954, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Скорость появления орехов";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(970, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Всего орехов:";
            // 
            // labelNuts
            // 
            this.labelNuts.AutoSize = true;
            this.labelNuts.Location = new System.Drawing.Point(1082, 309);
            this.labelNuts.Name = "labelNuts";
            this.labelNuts.Size = new System.Drawing.Size(18, 20);
            this.labelNuts.TabIndex = 27;
            this.labelNuts.Text = "0";
            // 
            // buttonSqrlX2
            // 
            this.buttonSqrlX2.Location = new System.Drawing.Point(958, 363);
            this.buttonSqrlX2.Name = "buttonSqrlX2";
            this.buttonSqrlX2.Size = new System.Drawing.Size(203, 64);
            this.buttonSqrlX2.TabIndex = 28;
            this.buttonSqrlX2.Text = "Удвоить количество белок";
            this.buttonSqrlX2.UseVisualStyleBackColor = true;
            this.buttonSqrlX2.Click += new System.EventHandler(this.buttonSqrlX2_Click);
            // 
            // buttonAllNut
            // 
            this.buttonAllNut.Location = new System.Drawing.Point(958, 447);
            this.buttonAllNut.Name = "buttonAllNut";
            this.buttonAllNut.Size = new System.Drawing.Size(152, 66);
            this.buttonAllNut.TabIndex = 29;
            this.buttonAllNut.Text = "Заполнить все поле орехами";
            this.buttonAllNut.UseVisualStyleBackColor = true;
            this.buttonAllNut.Click += new System.EventHandler(this.buttonAllNut_Click);
            // 
            // numbox2
            // 
            this.numbox2.Enabled = false;
            this.numbox2.Location = new System.Drawing.Point(958, 256);
            this.numbox2.Name = "numbox2";
            this.numbox2.Size = new System.Drawing.Size(170, 26);
            this.numbox2.TabIndex = 25;
            this.numbox2.Text = "5";
            this.numbox2.TextChanged += new System.EventHandler(this.numbox2_TextChanged);
            // 
            // numbox1
            // 
            this.numbox1.Location = new System.Drawing.Point(958, 74);
            this.numbox1.Name = "numbox1";
            this.numbox1.Size = new System.Drawing.Size(170, 26);
            this.numbox1.TabIndex = 4;
            this.numbox1.Text = "5";
            this.numbox1.TextChanged += new System.EventHandler(this.numbox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.labelBlack);
            this.panel1.Controls.Add(this.labelScrat);
            this.panel1.Location = new System.Drawing.Point(634, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 410);
            this.panel1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 1050);
            this.Controls.Add(this.buttonAllNut);
            this.Controls.Add(this.buttonSqrlX2);
            this.Controls.Add(this.labelNuts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numbox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.labelGround);
            this.Controls.Add(this.labelBrown);
            this.Controls.Add(this.labelOrange);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numbox1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private Numbox numbox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label labelOrange;
        private System.Windows.Forms.Label labelScrat;
        private System.Windows.Forms.Label labelBrown;
        private System.Windows.Forms.Label labelBlack;
        private System.Windows.Forms.Label labelGround;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Numbox numbox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelNuts;
        private System.Windows.Forms.Button buttonSqrlX2;
        private System.Windows.Forms.Button buttonAllNut;
        private System.Windows.Forms.Panel panel1;
    }
}

