namespace timetable_maker
{
    public partial class Form1 : Form
    {
        internal Line line;
        internal Spot sp;
        public Form1()
        {
            InitializeComponent();
        }

        private void 新建线路NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogNewLine newline = new();
            newline.ShowDialog();
            if (newline.DialogResult == DialogResult.OK)
            {
                FirstStation first = new(newline.FirstStation, newline.KilometerStart);
                sp = first;
                line = new Line(newline.LineName, first);
                string[] strings = new string[5];
                strings[0] = first.ToString();
                strings[1] = first.StKilometer.ToString();
                strings[2] = "XXX.XXX";
                strings[3] = "XXXX";
                strings[4] = "X:XX:XX";
                listView1.Items.Add(new ListViewItem(strings));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Station st = new(textBox1.Text, kilometerInput1.Value, Convert.ToInt32(numericUpDown1.Value));
            st.Attach(sp);
            sp = st;
            string[] strings = new string[5];
            strings[0] = st.ToString();
            strings[1] = st.StKilometer.ToString();
            strings[2] = (Convert.ToDouble(st.CalculateZhanjianKM().Value()) / 1000).ToString("0.000");
            strings[3] = st.MaxSpeed.ToString();
            strings[4] = st.CalculatePassageTime().ToString("T");
            listView1.Items.Add(new ListViewItem(strings));
        }
    }
}