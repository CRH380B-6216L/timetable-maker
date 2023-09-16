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
    [DefaultEvent(nameof(ValueChanged))]
    public partial class KilometerInput : UserControl
    {
        [Browsable(true)]
        public Kilometer Value
        {
            get => new(Convert.ToInt32(numericKM.Value), Convert.ToInt32(numericM.Value));
            set
            {
                numericKM.Value = value.KM;
                numericM.Value = value.M;
            }
        }
        public KilometerInput()
        {
            InitializeComponent();
            numericM.Text = numericM.Value.ToString().PadLeft(3, '0');
        }

        public event EventHandler? ValueChanged
        {
            add
            {
                numericKM.TextChanged += value;
                numericM.TextChanged += value;
            }
            remove
            {
                numericKM.TextChanged -= value;
                numericM.TextChanged -= value;
            }
        }

        private void NumericM_ValueChanged(object sender, EventArgs e)
        {
            if (numericM.Value == 1000)
            {
                numericM.Value = 0;
                numericKM.Value++;
            }
            else if (numericM.Value == -1)
            {
                numericM.Value = 999;
                numericKM.Value--;
            }
            else
            {
                numericM.Text = numericM.Value.ToString().PadLeft(3, '0');
            }
        }
    }
}
