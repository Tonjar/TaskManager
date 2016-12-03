namespace TaskManager
{
    partial class Main_form
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.Main_container = new System.Windows.Forms.TableLayoutPanel();
            this.Head_part = new System.Windows.Forms.Panel();
            this.task_panel = new System.Windows.Forms.Panel();
            this.add_area = new System.Windows.Forms.Panel();
            this.add_task_cancel = new System.Windows.Forms.Button();
            this.add_task_ok = new System.Windows.Forms.Button();
            this.add_task_base = new System.Windows.Forms.GroupBox();
            this.add_task_time_text = new System.Windows.Forms.TextBox();
            this.add_task_time = new System.Windows.Forms.Label();
            this.label232 = new System.Windows.Forms.Label();
            this.add_task_type = new System.Windows.Forms.ComboBox();
            this.add_task_name = new System.Windows.Forms.TextBox();
            this.label00002 = new System.Windows.Forms.Label();
            this.add_task_every__day = new System.Windows.Forms.GroupBox();
            this.interal_or_advance = new System.Windows.Forms.Label();
            this.interval_or_advance_text = new System.Windows.Forms.NumericUpDown();
            this.add_task_more = new System.Windows.Forms.GroupBox();
            this.add_task_more_text = new System.Windows.Forms.RichTextBox();
            this.add_task_weekdaychoose_area = new System.Windows.Forms.GroupBox();
            this.add_task_weekdaychoose = new System.Windows.Forms.CheckedListBox();
            this.Task_studio = new System.Windows.Forms.FlowLayoutPanel();
            this.add_task_button = new System.Windows.Forms.Button();
            this.person_inf = new System.Windows.Forms.Panel();
            this.close_form = new System.Windows.Forms.Button();
            this.set_button = new System.Windows.Forms.Button();
            this.exp_label = new System.Windows.Forms.Label();
            this.lv_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.check_task = new System.Windows.Forms.Timer(this.components);
            this.updown_button = new System.Windows.Forms.Button();
            this.person_pic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Main_container.SuspendLayout();
            this.Head_part.SuspendLayout();
            this.task_panel.SuspendLayout();
            this.add_area.SuspendLayout();
            this.add_task_base.SuspendLayout();
            this.add_task_every__day.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval_or_advance_text)).BeginInit();
            this.add_task_more.SuspendLayout();
            this.add_task_weekdaychoose_area.SuspendLayout();
            this.Task_studio.SuspendLayout();
            this.person_inf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.person_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_container
            // 
            this.Main_container.ColumnCount = 1;
            this.Main_container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_container.Controls.Add(this.Head_part, 0, 0);
            this.Main_container.Controls.Add(this.task_panel, 0, 1);
            this.Main_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_container.Location = new System.Drawing.Point(0, 0);
            this.Main_container.Name = "Main_container";
            this.Main_container.RowCount = 2;
            this.Main_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.Main_container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main_container.Size = new System.Drawing.Size(477, 462);
            this.Main_container.TabIndex = 0;
            // 
            // Head_part
            // 
            this.Head_part.Controls.Add(this.updown_button);
            this.Head_part.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Head_part.Location = new System.Drawing.Point(3, 3);
            this.Head_part.Name = "Head_part";
            this.Head_part.Size = new System.Drawing.Size(471, 16);
            this.Head_part.TabIndex = 0;
            // 
            // task_panel
            // 
            this.task_panel.Controls.Add(this.add_area);
            this.task_panel.Controls.Add(this.Task_studio);
            this.task_panel.Controls.Add(this.person_inf);
            this.task_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task_panel.Location = new System.Drawing.Point(3, 25);
            this.task_panel.Name = "task_panel";
            this.task_panel.Size = new System.Drawing.Size(471, 434);
            this.task_panel.TabIndex = 1;
            // 
            // add_area
            // 
            this.add_area.AutoScroll = true;
            this.add_area.Controls.Add(this.add_task_cancel);
            this.add_area.Controls.Add(this.add_task_ok);
            this.add_area.Controls.Add(this.add_task_base);
            this.add_area.Controls.Add(this.add_task_every__day);
            this.add_area.Controls.Add(this.add_task_more);
            this.add_area.Controls.Add(this.add_task_weekdaychoose_area);
            this.add_area.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_area.Location = new System.Drawing.Point(0, 77);
            this.add_area.Name = "add_area";
            this.add_area.Size = new System.Drawing.Size(212, 357);
            this.add_area.TabIndex = 2;
            this.add_area.Visible = false;
            // 
            // add_task_cancel
            // 
            this.add_task_cancel.Location = new System.Drawing.Point(111, 276);
            this.add_task_cancel.Name = "add_task_cancel";
            this.add_task_cancel.Size = new System.Drawing.Size(75, 23);
            this.add_task_cancel.TabIndex = 19;
            this.add_task_cancel.Text = "取消";
            this.add_task_cancel.UseVisualStyleBackColor = true;
            this.add_task_cancel.Click += new System.EventHandler(this.add_task_cancel_Click);
            // 
            // add_task_ok
            // 
            this.add_task_ok.Location = new System.Drawing.Point(10, 276);
            this.add_task_ok.Name = "add_task_ok";
            this.add_task_ok.Size = new System.Drawing.Size(75, 23);
            this.add_task_ok.TabIndex = 18;
            this.add_task_ok.Text = "确定";
            this.add_task_ok.UseVisualStyleBackColor = true;
            this.add_task_ok.Click += new System.EventHandler(this.add_task_ok_Click);
            // 
            // add_task_base
            // 
            this.add_task_base.Controls.Add(this.add_task_time_text);
            this.add_task_base.Controls.Add(this.add_task_time);
            this.add_task_base.Controls.Add(this.label232);
            this.add_task_base.Controls.Add(this.add_task_type);
            this.add_task_base.Controls.Add(this.add_task_name);
            this.add_task_base.Controls.Add(this.label00002);
            this.add_task_base.Location = new System.Drawing.Point(10, 6);
            this.add_task_base.Name = "add_task_base";
            this.add_task_base.Size = new System.Drawing.Size(176, 157);
            this.add_task_base.TabIndex = 17;
            this.add_task_base.TabStop = false;
            // 
            // add_task_time_text
            // 
            this.add_task_time_text.Location = new System.Drawing.Point(11, 120);
            this.add_task_time_text.Name = "add_task_time_text";
            this.add_task_time_text.Size = new System.Drawing.Size(148, 21);
            this.add_task_time_text.TabIndex = 7;
            this.add_task_time_text.Leave += new System.EventHandler(this.add_task_time_text_Leave);
            this.add_task_time_text.MouseDown += new System.Windows.Forms.MouseEventHandler(this.add_task_time_text_MouseDown);
            // 
            // add_task_time
            // 
            this.add_task_time.AutoSize = true;
            this.add_task_time.Location = new System.Drawing.Point(9, 96);
            this.add_task_time.Name = "add_task_time";
            this.add_task_time.Size = new System.Drawing.Size(53, 12);
            this.add_task_time.TabIndex = 2;
            this.add_task_time.Text = "截止时间";
            // 
            // label232
            // 
            this.label232.AutoSize = true;
            this.label232.Location = new System.Drawing.Point(9, 58);
            this.label232.Name = "label232";
            this.label232.Size = new System.Drawing.Size(29, 12);
            this.label232.TabIndex = 1;
            this.label232.Text = "类型";
            // 
            // add_task_type
            // 
            this.add_task_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.add_task_type.FormattingEnabled = true;
            this.add_task_type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_task_type.Items.AddRange(new object[] {
            "一次",
            "每日",
            "每……天",
            "每周",
            "每周……",
            "每月",
            "纪念日",
            "每年"});
            this.add_task_type.Location = new System.Drawing.Point(59, 55);
            this.add_task_type.Name = "add_task_type";
            this.add_task_type.Size = new System.Drawing.Size(100, 20);
            this.add_task_type.TabIndex = 12;
            this.add_task_type.SelectedIndexChanged += new System.EventHandler(this.set_add_task_area);
            // 
            // add_task_name
            // 
            this.add_task_name.Location = new System.Drawing.Point(59, 20);
            this.add_task_name.MaxLength = 20;
            this.add_task_name.Name = "add_task_name";
            this.add_task_name.Size = new System.Drawing.Size(100, 21);
            this.add_task_name.TabIndex = 5;
            this.add_task_name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.add_task_name_MouseDown);
            // 
            // label00002
            // 
            this.label00002.AutoSize = true;
            this.label00002.Location = new System.Drawing.Point(9, 26);
            this.label00002.Name = "label00002";
            this.label00002.Size = new System.Drawing.Size(41, 12);
            this.label00002.TabIndex = 0;
            this.label00002.Text = "任务名";
            // 
            // add_task_every__day
            // 
            this.add_task_every__day.Controls.Add(this.interal_or_advance);
            this.add_task_every__day.Controls.Add(this.interval_or_advance_text);
            this.add_task_every__day.Location = new System.Drawing.Point(10, 169);
            this.add_task_every__day.Name = "add_task_every__day";
            this.add_task_every__day.Size = new System.Drawing.Size(176, 51);
            this.add_task_every__day.TabIndex = 15;
            this.add_task_every__day.TabStop = false;
            this.add_task_every__day.Visible = false;
            // 
            // interal_or_advance
            // 
            this.interal_or_advance.AutoSize = true;
            this.interal_or_advance.Location = new System.Drawing.Point(9, 21);
            this.interal_or_advance.Name = "interal_or_advance";
            this.interal_or_advance.Size = new System.Drawing.Size(29, 12);
            this.interal_or_advance.TabIndex = 3;
            this.interal_or_advance.Text = "间隔";
            // 
            // interval_or_advance_text
            // 
            this.interval_or_advance_text.Location = new System.Drawing.Point(110, 17);
            this.interval_or_advance_text.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.interval_or_advance_text.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.interval_or_advance_text.Name = "interval_or_advance_text";
            this.interval_or_advance_text.Size = new System.Drawing.Size(49, 21);
            this.interval_or_advance_text.TabIndex = 9;
            this.interval_or_advance_text.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_task_more
            // 
            this.add_task_more.Controls.Add(this.add_task_more_text);
            this.add_task_more.Location = new System.Drawing.Point(10, 169);
            this.add_task_more.Name = "add_task_more";
            this.add_task_more.Size = new System.Drawing.Size(176, 100);
            this.add_task_more.TabIndex = 14;
            this.add_task_more.TabStop = false;
            this.add_task_more.Text = "备注";
            // 
            // add_task_more_text
            // 
            this.add_task_more_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_task_more_text.Location = new System.Drawing.Point(3, 17);
            this.add_task_more_text.Name = "add_task_more_text";
            this.add_task_more_text.Size = new System.Drawing.Size(170, 80);
            this.add_task_more_text.TabIndex = 0;
            this.add_task_more_text.Text = "";
            // 
            // add_task_weekdaychoose_area
            // 
            this.add_task_weekdaychoose_area.Controls.Add(this.add_task_weekdaychoose);
            this.add_task_weekdaychoose_area.Location = new System.Drawing.Point(10, 169);
            this.add_task_weekdaychoose_area.Name = "add_task_weekdaychoose_area";
            this.add_task_weekdaychoose_area.Size = new System.Drawing.Size(176, 145);
            this.add_task_weekdaychoose_area.TabIndex = 20;
            this.add_task_weekdaychoose_area.TabStop = false;
            this.add_task_weekdaychoose_area.Text = "具体哪几天？";
            this.add_task_weekdaychoose_area.Visible = false;
            // 
            // add_task_weekdaychoose
            // 
            this.add_task_weekdaychoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_task_weekdaychoose.FormattingEnabled = true;
            this.add_task_weekdaychoose.Items.AddRange(new object[] {
            "星期日",
            "星期一",
            "星期二",
            "星期三",
            "星期四",
            "星期五",
            "星期六"});
            this.add_task_weekdaychoose.Location = new System.Drawing.Point(3, 17);
            this.add_task_weekdaychoose.Name = "add_task_weekdaychoose";
            this.add_task_weekdaychoose.Size = new System.Drawing.Size(170, 125);
            this.add_task_weekdaychoose.TabIndex = 0;
            // 
            // Task_studio
            // 
            this.Task_studio.Controls.Add(this.add_task_button);
            this.Task_studio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Task_studio.Location = new System.Drawing.Point(0, 77);
            this.Task_studio.Name = "Task_studio";
            this.Task_studio.Size = new System.Drawing.Size(471, 357);
            this.Task_studio.TabIndex = 1;
            // 
            // add_task_button
            // 
            this.add_task_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_task_button.FlatAppearance.BorderSize = 0;
            this.add_task_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_task_button.Font = new System.Drawing.Font("华文琥珀", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.add_task_button.Location = new System.Drawing.Point(3, 3);
            this.add_task_button.Name = "add_task_button";
            this.add_task_button.Size = new System.Drawing.Size(468, 26);
            this.add_task_button.TabIndex = 0;
            this.add_task_button.Text = "+";
            this.add_task_button.UseVisualStyleBackColor = true;
            this.add_task_button.Click += new System.EventHandler(this.add_task_button_Click);
            // 
            // person_inf
            // 
            this.person_inf.Controls.Add(this.close_form);
            this.person_inf.Controls.Add(this.set_button);
            this.person_inf.Controls.Add(this.person_pic);
            this.person_inf.Controls.Add(this.exp_label);
            this.person_inf.Controls.Add(this.lv_label);
            this.person_inf.Controls.Add(this.name_label);
            this.person_inf.Dock = System.Windows.Forms.DockStyle.Top;
            this.person_inf.Location = new System.Drawing.Point(0, 0);
            this.person_inf.Name = "person_inf";
            this.person_inf.Size = new System.Drawing.Size(471, 77);
            this.person_inf.TabIndex = 0;
            this.person_inf.Visible = false;
            // 
            // close_form
            // 
            this.close_form.Location = new System.Drawing.Point(150, 48);
            this.close_form.Name = "close_form";
            this.close_form.Size = new System.Drawing.Size(75, 23);
            this.close_form.TabIndex = 5;
            this.close_form.Text = "最小化";
            this.close_form.UseVisualStyleBackColor = true;
            this.close_form.Click += new System.EventHandler(this.close_form_Click);
            // 
            // set_button
            // 
            this.set_button.Location = new System.Drawing.Point(150, 12);
            this.set_button.Name = "set_button";
            this.set_button.Size = new System.Drawing.Size(75, 23);
            this.set_button.TabIndex = 4;
            this.set_button.Text = "设置";
            this.set_button.UseVisualStyleBackColor = true;
            this.set_button.Click += new System.EventHandler(this.set_button_Click);
            // 
            // exp_label
            // 
            this.exp_label.AutoSize = true;
            this.exp_label.Location = new System.Drawing.Point(79, 38);
            this.exp_label.Name = "exp_label";
            this.exp_label.Size = new System.Drawing.Size(23, 12);
            this.exp_label.TabIndex = 2;
            this.exp_label.Text = "exp";
            // 
            // lv_label
            // 
            this.lv_label.AutoSize = true;
            this.lv_label.Location = new System.Drawing.Point(79, 26);
            this.lv_label.Name = "lv_label";
            this.lv_label.Size = new System.Drawing.Size(17, 12);
            this.lv_label.TabIndex = 1;
            this.lv_label.Text = "lv";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(79, 13);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(29, 12);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "name";
            // 
            // check_task
            // 
            this.check_task.Enabled = true;
            this.check_task.Interval = 300000;
            this.check_task.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // updown_button
            // 
            this.updown_button.BackgroundImage = global::TaskManager.Properties.Resources.down;
            this.updown_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.updown_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updown_button.Location = new System.Drawing.Point(0, 0);
            this.updown_button.Name = "updown_button";
            this.updown_button.Size = new System.Drawing.Size(471, 16);
            this.updown_button.TabIndex = 0;
            this.updown_button.UseVisualStyleBackColor = true;
            this.updown_button.Click += new System.EventHandler(this.updown_button_Click);
            this.updown_button.DragDrop += new System.Windows.Forms.DragEventHandler(this.updown_button_DragDrop);
            // 
            // person_pic
            // 
            this.person_pic.BackgroundImage = global::TaskManager.Properties.Resources.github;
            this.person_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.person_pic.Location = new System.Drawing.Point(3, 3);
            this.person_pic.Name = "person_pic";
            this.person_pic.Size = new System.Drawing.Size(70, 74);
            this.person_pic.TabIndex = 3;
            this.person_pic.TabStop = false;
            this.person_pic.Click += new System.EventHandler(this.person_pic_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 462);
            this.ControlBox = false;
            this.Controls.Add(this.Main_container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "Main_form";
            this.Opacity = 0.75D;
            this.ShowInTaskbar = false;
            this.Tag = "1";
            this.Text = "TaskManager";
            this.Deactivate += new System.EventHandler(this.Main_form_Deactivate);
            this.SizeChanged += new System.EventHandler(this.Main_form_SizeChanged);
            this.Leave += new System.EventHandler(this.Main_form_Leave);
            this.Main_container.ResumeLayout(false);
            this.Head_part.ResumeLayout(false);
            this.task_panel.ResumeLayout(false);
            this.add_area.ResumeLayout(false);
            this.add_task_base.ResumeLayout(false);
            this.add_task_base.PerformLayout();
            this.add_task_every__day.ResumeLayout(false);
            this.add_task_every__day.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval_or_advance_text)).EndInit();
            this.add_task_more.ResumeLayout(false);
            this.add_task_weekdaychoose_area.ResumeLayout(false);
            this.Task_studio.ResumeLayout(false);
            this.person_inf.ResumeLayout(false);
            this.person_inf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.person_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Main_container;
        private System.Windows.Forms.Panel Head_part;
        private System.Windows.Forms.Panel task_panel;
        private System.Windows.Forms.Button updown_button;
        private System.Windows.Forms.Panel person_inf;
        private System.Windows.Forms.FlowLayoutPanel Task_studio;
        private System.Windows.Forms.Panel add_area;
        private System.Windows.Forms.NumericUpDown interval_or_advance_text;
        private System.Windows.Forms.TextBox add_task_time_text;
        private System.Windows.Forms.TextBox add_task_name;
        private System.Windows.Forms.Label interal_or_advance;
        private System.Windows.Forms.Label add_task_time;
        private System.Windows.Forms.Label label232;
        private System.Windows.Forms.Label label00002;
        private System.Windows.Forms.ComboBox add_task_type;
        private System.Windows.Forms.GroupBox add_task_base;
        private System.Windows.Forms.GroupBox add_task_every__day;
        private System.Windows.Forms.GroupBox add_task_more;
        private System.Windows.Forms.RichTextBox add_task_more_text;
        private System.Windows.Forms.Button add_task_cancel;
        private System.Windows.Forms.Button add_task_ok;
        private System.Windows.Forms.GroupBox add_task_weekdaychoose_area;
        private System.Windows.Forms.CheckedListBox add_task_weekdaychoose;
        private System.Windows.Forms.Label exp_label;
        private System.Windows.Forms.Label lv_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button close_form;
        private System.Windows.Forms.Button set_button;
        private System.Windows.Forms.PictureBox person_pic;
        private System.Windows.Forms.Button add_task_button;
        private System.Windows.Forms.Timer check_task;
        private System.Windows.Forms.Timer timer1;
    }
}

