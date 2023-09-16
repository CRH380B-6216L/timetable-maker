namespace timetable_maker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            listView1 = new ListView();
            chStationName = new ColumnHeader();
            chKM = new ColumnHeader();
            chZhanjianKM = new ColumnHeader();
            chMaxSpeed = new ColumnHeader();
            chPassageTime = new ColumnHeader();
            tabAAAA = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            kilometerInput1 = new KilometerInput();
            tabPage2 = new TabPage();
            menuStrip1 = new MenuStrip();
            新建线路NToolStripMenuItem = new ToolStripMenuItem();
            打开OToolStripMenuItem = new ToolStripMenuItem();
            保存SToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            tabAAAA.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(110, 31);
            label1.TabIndex = 1;
            label1.Text = "中心里程";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 38);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 3);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 3;
            label2.Text = "车站名称";
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { chStationName, chKM, chZhanjianKM, chMaxSpeed, chPassageTime });
            listView1.Location = new Point(12, 288);
            listView1.Name = "listView1";
            listView1.Size = new Size(1027, 436);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chStationName
            // 
            chStationName.Text = "车站名称";
            chStationName.Width = 240;
            // 
            // chKM
            // 
            chKM.Text = "中心里程";
            chKM.TextAlign = HorizontalAlignment.Right;
            chKM.Width = 120;
            // 
            // chZhanjianKM
            // 
            chZhanjianKM.Text = "站间里程";
            chZhanjianKM.TextAlign = HorizontalAlignment.Right;
            chZhanjianKM.Width = 120;
            // 
            // chMaxSpeed
            // 
            chMaxSpeed.Text = "允许速度";
            chMaxSpeed.TextAlign = HorizontalAlignment.Right;
            chMaxSpeed.Width = 120;
            // 
            // chPassageTime
            // 
            chPassageTime.Text = "区间通通用时";
            chPassageTime.TextAlign = HorizontalAlignment.Right;
            chPassageTime.Width = 180;
            // 
            // tabAAAA
            // 
            tabAAAA.Controls.Add(tabPage1);
            tabAAAA.Controls.Add(tabPage2);
            tabAAAA.Location = new Point(12, 42);
            tabAAAA.Name = "tabAAAA";
            tabAAAA.SelectedIndex = 0;
            tabAAAA.Size = new Size(438, 240);
            tabAAAA.TabIndex = 10;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(numericUpDown1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(kilometerInput1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(8, 45);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(422, 187);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "车站·线路所";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(261, 132);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 16;
            button2.Text = "添加线路所";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(105, 132);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 15;
            button1.Text = "添加车站";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 90);
            label4.Name = "label4";
            label4.Size = new Size(74, 31);
            label4.TabIndex = 14;
            label4.Text = "km/h";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Location = new Point(218, 88);
            numericUpDown1.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(118, 38);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 90);
            label3.Name = "label3";
            label3.Size = new Size(206, 31);
            label3.TabIndex = 12;
            label3.Text = "与前站之区间限速";
            // 
            // kilometerInput1
            // 
            kilometerInput1.Location = new Point(122, 44);
            kilometerInput1.Margin = new Padding(0);
            kilometerInput1.MaximumSize = new Size(289, 38);
            kilometerInput1.MinimumSize = new Size(289, 38);
            kilometerInput1.Name = "kilometerInput1";
            kilometerInput1.Size = new Size(289, 38);
            kilometerInput1.TabIndex = 11;
            kilometerInput1.Value = (Kilometer)resources.GetObject("kilometerInput1.Value");
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(8, 45);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(422, 187);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "里程突变点";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 新建线路NToolStripMenuItem, 打开OToolStripMenuItem, 保存SToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1051, 39);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // 新建线路NToolStripMenuItem
            // 
            新建线路NToolStripMenuItem.Name = "新建线路NToolStripMenuItem";
            新建线路NToolStripMenuItem.Size = new Size(166, 35);
            新建线路NToolStripMenuItem.Text = "新建线路(&N)";
            新建线路NToolStripMenuItem.Click += 新建线路NToolStripMenuItem_Click;
            // 
            // 打开OToolStripMenuItem
            // 
            打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            打开OToolStripMenuItem.Size = new Size(118, 35);
            打开OToolStripMenuItem.Text = "打开(&O)";
            // 
            // 保存SToolStripMenuItem
            // 
            保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            保存SToolStripMenuItem.Size = new Size(112, 35);
            保存SToolStripMenuItem.Text = "保存(&S)";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 736);
            Controls.Add(tabAAAA);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            tabAAAA.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader chStationName;
        private ColumnHeader chKM;
        private ColumnHeader chZhanjianKM;
        private ColumnHeader chMaxSpeed;
        private TabControl tabAAAA;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private KilometerInput kilometerInput1;
        private ColumnHeader chPassageTime;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 新建线路NToolStripMenuItem;
        private Button button2;
        private Button button1;
        private ToolStripMenuItem 打开OToolStripMenuItem;
        private ToolStripMenuItem 保存SToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}