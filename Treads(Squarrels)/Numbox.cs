using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treads_Squarrels_
{
    public partial class Numbox : TextBox
    {
        public Numbox()
        {
            InitializeComponent();
        }

        public Numbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnKeyPress( KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !e.KeyChar.Equals((char)8))
                e.Handled = true;
        }
    }
}
