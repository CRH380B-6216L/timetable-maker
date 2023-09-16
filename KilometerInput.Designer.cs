namespace timetable_maker
{
    partial class KilometerInput
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            numericM = new NumericUpDown();
            numericKM = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericKM).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 2);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(37, 31);
            label4.TabIndex = 12;
            label4.Text = "M";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 2);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(77, 31);
            label3.TabIndex = 11;
            label3.Text = "KM +";
            // 
            // numericM
            // 
            numericM.Location = new Point(174, 0);
            numericM.Margin = new Padding(0);
            numericM.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericM.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericM.Name = "numericM";
            numericM.Size = new Size(82, 38);
            numericM.TabIndex = 10;
            numericM.TextAlign = HorizontalAlignment.Right;
            numericM.ValueChanged += NumericM_ValueChanged;
            // 
            // numericKM
            // 
            numericKM.Location = new Point(0, 0);
            numericKM.Margin = new Padding(0);
            numericKM.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericKM.Name = "numericKM";
            numericKM.Size = new Size(97, 38);
            numericKM.TabIndex = 9;
            numericKM.TextAlign = HorizontalAlignment.Right;
            // 
            // KilometerInput
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(numericM);
            Controls.Add(numericKM);
            Margin = new Padding(0);
            MaximumSize = new Size(289, 38);
            MinimumSize = new Size(289, 38);
            Name = "KilometerInput";
            Size = new Size(289, 38);
            ((System.ComponentModel.ISupportInitialize)numericM).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericKM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private NumericUpDown numericM;
        private NumericUpDown numericKM;
    }
}
