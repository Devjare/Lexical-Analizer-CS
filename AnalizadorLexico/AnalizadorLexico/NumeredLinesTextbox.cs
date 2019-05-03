using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class NumeredLinesTextbox : UserControl
    {
        public NumeredLinesTextbox()
        {
            InitializeComponent();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            txtNumbers.Text += txtCode.Lines.Count() + "\n\r";
        }
    }
}
