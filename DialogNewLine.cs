using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetable_maker
{
    public partial class DialogNewLine : Form
    {
        internal string LineName;
        internal string FirstStation;
        internal Kilometer KilometerStart;

        public DialogNewLine()
        {
            InitializeComponent();
            LineName = textBox1.Text;
            FirstStation = textBox2.Text;
            KilometerStart = kilometerInput1.Value;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LineName = textBox1.Text;
            FirstStation = textBox2.Text;
            KilometerStart = kilometerInput1.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
