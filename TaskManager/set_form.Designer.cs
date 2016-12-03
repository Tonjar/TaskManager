namespace TaskManager
{
    partial class set_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cancel_button = new System.Windows.Forms.Button();
            this.apply_button = new System.Windows.Forms.Button();
            this.ok_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main_frame = new System.Windows.Forms.TabControl();
            this.person = new System.Windows.Forms.TabPage();
            this.history = new System.Windows.Forms.TabPage();
            this.about = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lv = new System.Windows.Forms.Label();
            this.exp = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Main_frame.SuspendLayout();
            this.person.SuspendLayout();
            this.history.SuspendLayout();
            this.about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(338, 5);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 0;
            this.cancel_button.Text = "取消";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(418, 5);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 1;
            this.apply_button.Text = "应用";
            this.apply_button.UseVisualStyleBackColor = true;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(258, 5);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 2;
            this.ok_button.Text = "确定";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Main_frame, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(506, 409);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ok_button);
            this.panel1.Controls.Add(this.apply_button);
            this.panel1.Controls.Add(this.cancel_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 371);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 35);
            this.panel1.TabIndex = 1;
            // 
            // Main_frame
            // 
            this.Main_frame.Controls.Add(this.person);
            this.Main_frame.Controls.Add(this.history);
            this.Main_frame.Controls.Add(this.about);
            this.Main_frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_frame.Location = new System.Drawing.Point(3, 3);
            this.Main_frame.Name = "Main_frame";
            this.Main_frame.SelectedIndex = 0;
            this.Main_frame.Size = new System.Drawing.Size(500, 362);
            this.Main_frame.TabIndex = 2;
            // 
            // person
            // 
            this.person.Controls.Add(this.exp);
            this.person.Controls.Add(this.lv);
            this.person.Controls.Add(this.pic);
            this.person.Controls.Add(this.name);
            this.person.Location = new System.Drawing.Point(4, 22);
            this.person.Name = "person";
            this.person.Padding = new System.Windows.Forms.Padding(3);
            this.person.Size = new System.Drawing.Size(492, 336);
            this.person.TabIndex = 0;
            this.person.Text = "个人";
            this.person.UseVisualStyleBackColor = true;
            // 
            // history
            // 
            this.history.Controls.Add(this.toolStrip1);
            this.history.Controls.Add(this.chart1);
            this.history.Location = new System.Drawing.Point(4, 22);
            this.history.Name = "history";
            this.history.Padding = new System.Windows.Forms.Padding(3);
            this.history.Size = new System.Drawing.Size(492, 336);
            this.history.TabIndex = 1;
            this.history.Text = "历史";
            this.history.UseVisualStyleBackColor = true;
            // 
            // about
            // 
            this.about.Controls.Add(this.label1);
            this.about.Location = new System.Drawing.Point(4, 22);
            this.about.Name = "about";
            this.about.Padding = new System.Windows.Forms.Padding(3);
            this.about.Size = new System.Drawing.Size(492, 336);
            this.about.TabIndex = 2;
            this.about.Text = "关于";
            this.about.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(95, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "作者       Tonjar\r\nweibo      @Tonjar\r\nqq         469331862\r\ne-mail     Tonjar_tyz@" +
    "163.com\r\n微信公众号 @豆土椅长";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(142, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(29, 12);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(27, 24);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(91, 84);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            // 
            // lv
            // 
            this.lv.AutoSize = true;
            this.lv.Location = new System.Drawing.Point(142, 46);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(17, 12);
            this.lv.TabIndex = 2;
            this.lv.Text = "lv";
            // 
            // exp
            // 
            this.exp.AutoSize = true;
            this.exp.Location = new System.Drawing.Point(142, 58);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(23, 12);
            this.exp.TabIndex = 3;
            this.exp.Text = "exp";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 31);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.Name = "经验获取";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "任务完成";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(486, 302);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(486, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "今天",
            "近三天",
            "本周",
            "近七天",
            "近十天",
            "本月",
            "本年",
            "近五年",
            "所有"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // set_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 409);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "set_form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "0";
            this.Text = "设置";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Main_frame.ResumeLayout(false);
            this.person.ResumeLayout(false);
            this.person.PerformLayout();
            this.history.ResumeLayout(false);
            this.history.PerformLayout();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl Main_frame;
        private System.Windows.Forms.TabPage person;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exp;
        private System.Windows.Forms.Label lv;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}