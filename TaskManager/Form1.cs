using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskManager
{
    public partial class Main_form : Form
    {
        class task_inf
        {
            public string name { get; }
            int exp;
            DateTime deadline;
            DateTime settime;
            DateTime starttime;
            public int type { get; set; }
            string more;
            int interval;
            int[] weekday = new int[7];
            int advance;
            public task_inf(string Name,string startTime,string deadLine,int Type,string More,int Interval,int[]WeekDay,int Advance)
            {
                if (Type == 2 && Interval == 1)
                    Type = 1;
                if (Type == 4)
                {
                    int tag = 0;
                    for (int i = 0; i < 7; i++)
                        if (WeekDay[i] == 0)
                        {
                            tag = 1;
                            break;
                        }
                    if (tag == 0)
                        Type = 1;
                }
                name = Name;
                settime = DateTime.Now;
                starttime = str_to_time(startTime);
                deadline = str_to_time(deadLine);
                type = Type;
                if (More.Length > 0 && More[0] == '|')
                    more = More.Substring(1);
                else
                    more = More;
                interval = Interval;
                for (int i = 0; i < 7; i++)
                    weekday[i] = WeekDay[i];
                advance = Advance;
                switch (type)
                {
                    case 0:exp = 100;break;
                    case 1:
                        exp = 10;
                        deadline = deadline.AddDays(1);
                        deadline = new DateTime(deadline.Year, deadline.Month, deadline.Day);
                        deadline = deadline.AddSeconds(-1);
                        break;
                    case 2:
                        exp = 20;
                        deadline = deadline.AddDays(Interval);
                        deadline = new DateTime(deadline.Year, deadline.Month, deadline.Day);
                        deadline = deadline.AddSeconds(-1);
                        break;
                    case 3:
                        exp = 20;
                        deadline = deadline.AddDays(1);
                        while(deadline.DayOfWeek!=DayOfWeek.Sunday)
                            deadline = deadline.AddDays(1);
                        deadline = new DateTime(deadline.Year, deadline.Month, deadline.Day);
                        deadline = deadline.AddSeconds(-1);
                        break;
                    case 4:
                        exp = 15;
                        string[] weekday_list = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
                        int i =(int)deadline.DayOfWeek;
                        for(int j = i; j < i + 7; j++)
                        {
                            if ((j<7&&weekday[j] == 1)||(j>=7&&weekday[j-7]==1))
                            {
                                deadline = deadline.AddDays(j - i + 1);
                                break;
                            }
                        }
                        deadline = new DateTime(deadline.Year, deadline.Month, deadline.Day);
                        deadline = deadline.AddSeconds(-1);
                        break;
                    case 5:
                        exp = 50;
                        deadline = deadline.AddMonths(1);
                        deadline = new DateTime(deadline.Year, deadline.Month,1);
                        deadline = deadline.AddSeconds(-1);
                        break;
                    case 6:
                        exp = 0;
                        deadline = deadline.AddDays(1);
                        deadline = new DateTime(deadline.Year, deadline.Month, deadline.Day);
                        deadline = deadline.AddSeconds(-1);
                        break;
                    case 7:
                        exp = 70;
                        deadline = new DateTime(deadline.Year+1, 1, 1);
                        deadline = deadline.AddSeconds(-1);
                        break;
                }
                
            }
            public task_inf(string str)
            {
                string week;
                int tag = 0;
                int j = 2, i = 2;
                for (; i < str.Length; i++)
                {
                    if (str[i] == '|')
                    {
                        switch (tag)
                        {
                            case 0: name = str.Substring(j, i - j); break;
                            case 1: exp = int.Parse(str.Substring(j, i - j)); break;
                            case 2: type = int.Parse(str.Substring(j, i - j)); break;
                            case 3: settime = str_to_time(str.Substring(j, i - j)); break;
                            case 4: starttime = str_to_time(str.Substring(j, i - j)); break;
                            case 5: deadline = str_to_time(str.Substring(j, i - j)); break;
                            case 6:
                                if (str[i - 1] != '\"')
                                    tag--;
                                else
                                    more = str.Substring(j + 1, i - j - 2);
                                break;
                            case 7: interval = int.Parse(str.Substring(j, i - j)); break;
                            case 8:
                                week = str.Substring(j, i - j);
                                week += "0000000";
                                for(int k = 0; k < 7; k++)
                                    weekday[k] = week[k] - '0';
                                break;
                            case 9: advance = int.Parse(str.Substring(j, i - j)); break;
                        }
                        tag++;
                        j = i + 1;
                        i++;
                    }
                }
      

            }
            DateTime str_to_time(string str)
            {
                int year = 0, month = 0, day = 0, hour = 0, min = 0, sec = 0;
                int tag = 0;
                for(int i = 0; i < str.Length; i++)
                {
                    if (!('0'<=str[i]&&str[i]<='9'))
                    {
                        tag++;
                        continue;
                    }
                    switch (tag)
                    {
                        case 0:
                            year *= 10;
                            year += str[i] - '0';
                            break;
                        case 1:
                            month *= 10;
                            month += str[i] - '0';
                            break;
                        case 2:
                            day *= 10;
                            day += str[i] - '0';
                            break;
                        case 3:
                            hour *= 10;
                            hour += str[i] - '0';
                            break;
                        case 4:
                            min *= 10;
                            min += str[i] - '0';
                            break;
                        case 5:
                            sec *= 10;
                            sec += str[i] - '0';
                            break;

                    }
                }
                return new DateTime(year, month, day, hour, min, sec);
            }
            public string Tosting()
            {
                string str = "/_" + name + "|" + exp.ToString() + "|" + type.ToString() + "|" + settime.ToString() + "|"
                    + starttime.ToString() + "|" + deadline.ToString() + "|\"" + more +"\"|"+ interval.ToString() +
                    "|";
                for (int i = 0; i < 7; i++)
                    str += weekday[i].ToString();
                return str+ "|" + advance.ToString() + "|\r\n";
            }  
            public string History_tostring(DateTime finishtime,int Exp)
            {
                return "/_" + name + "|" + finishtime.ToString() + "|\"" + more + "\"|" + Exp.ToString() + "|\r\n"; 
            }
            public string Label_text()
            {
                if (emergy() == 0)
                    return "---";
                switch (type)
                {
                    case 2:
                    case 0:return deadline.ToString();
                    case 1:return"每日";
                    case 3: return"每周";
                    case 4:
                        int count = 0;
                        string str = "";
                        string[] weekday_list = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
                        for (int i = 1; i < 7; i++)
                            if (weekday[i] == 1)
                            {
                                count++;
                                str += weekday_list[i] + "、";
                            }
                        if (weekday[0] == 1)
                        {
                            count++;
                            str += weekday_list[0] + "、";
                        }
                        if (count==2&&weekday[0] == weekday[6] && weekday[0] == 1)
                            return "双休日";
                        if(count==5&&weekday[0]==0&&weekday[6]==0)
                            return "工作日";                      
                        return str.Substring(0, str.Length - 1);
                    case 5: return"每月";
                    case 6: return deadline.ToShortDateString();
                    case 7: return "每年";              
                }
                return "";
            }
            public int EXP()
            {
                int k = (int)(deadline - DateTime.Now).Days;
                if (k > 100) return exp * 3;
                if (k > 20) return exp * 2;
                if (k > 10) return (int)(exp * 1.5);
                if (k > 5) return (int)(exp * 1.1);
                return exp;
            }
            public void finished()
            {
                switch (type)
                {
                    case 0: deadline = DateTime.Now.AddDays(-1);
                        break;
                    case 1:
                    case 2:
                    case 3:
                        deadline = deadline.AddDays(interval);
                        break;
                    case 4:
                        deadline = deadline.AddDays(1);
                        string[] weekday_list = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
                        int i = (int)deadline.DayOfWeek;
                        for (int j = i; j < i + 7; j++)
                        {
                            if ((j < 7 && weekday[j] == 1) || (j >= 7 && weekday[j - 7] == 1))
                            {
                                deadline.AddDays(j - i );
                                break;
                            }
                        }
                        break;
                    case 5:
                        deadline = deadline.AddMonths(1);
                        break;
                    case 6:
                        if (deadline.Month == 2 && deadline.Day == 29)
                        {
                            if ((deadline.Year + 4) % 100 == 0 && (deadline.Year + 4) % 400 != 0)
                                deadline = deadline.AddYears(8);
                            else
                                deadline = deadline.AddYears(4);
                        }
                        else
                            deadline = deadline.AddYears(1);
                        break;
                    case 7:
                        deadline = deadline.AddYears(1);
                        break;
                }
                switch (type)
                {
                    case 1:exp += (int)(exp * 0.2)+1;break;
                    case 2: exp += (int)(exp * 0.15)+1; break;
                    case 3: exp += (int)(exp * 0.25)+1; break;
                    case 4: exp += (int)(exp * 0.15)+1; break;
                    case 5: exp += (int)(exp * 0.1)+1; break;
                    case 7: exp += (int)(exp * 0.1)+1; break;
                }
            }
            public void end()
            {
                switch (type)
                {
                    case 1:
                    case 2:
                    case 3:
                        deadline = deadline.AddDays(interval);
                        break;
                    case 4:
                        deadline = deadline.AddDays(1);
                        string[] weekday_list = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
                        int i = (int)deadline.DayOfWeek;
                        for (int j = i; j < i + 7; j++)
                        {
                            if ((j < 7 && weekday[j] == 1) || (j >= 7 && weekday[j - 7] == 1))
                            {
                                deadline.AddDays(j - i);
                                break;
                            }
                        }
                        break;
                    case 5:
                        deadline = deadline.AddMonths(1);
                        break;
                    case 6:
                        if (deadline.Month == 2 && deadline.Day == 29)
                        {
                            if ((deadline.Year + 4) % 100 == 0 && (deadline.Year + 4) % 400 != 0)
                                deadline = deadline.AddYears(8);
                            else
                                deadline = deadline.AddYears(4);
                        }
                        else
                            deadline = deadline.AddYears(1);
                        break;
                    case 7:
                        deadline = deadline.AddYears(1);
                        break;
                }
                exp /= 2;
            }
            public void delete()
            {
                deadline = DateTime.Now.AddDays(-1);
                type = 0;
            }
            public int emergy()// 0 无 1 正常 2 注意 3 重要
            {
                if (starttime > DateTime.Now||DateTime.Now>deadline)
                    return 0;
                switch (type)
                {
                    case 3:
                    case 2:
                        if (deadline > DateTime.Now.AddDays(interval))
                            return 0;
                        break;
                    case 4:
                    case 1:
                        if (deadline > DateTime.Now.AddDays(interval))
                            return 0;
                        return 2;
                    case 5:
                        if (deadline > DateTime.Now.AddMonths(1))
                            return 0;
                        break;
                    case 7:
                        if (deadline > DateTime.Now.AddYears(1))
                            return 0;
                        break;
                    case 6:
                        if (deadline.AddDays(-1 * advance) <= DateTime.Now)
                            return 2;
                        return 0;
                }
                if (deadline > DateTime.Now.AddDays(2))
                    return 1;
                else if (deadline > DateTime.Now.AddHours(30))
                    return 2;
                else
                    return 3;
            }
            public bool isend()
            {
                if (deadline < DateTime.Now)
                    return true;
                return false;
            }
        }
        //*************** end of class ***************//
        List<task_inf> TASK_LIST_inf = new List<task_inf>();
        string person_name;
        int lv;
        int exp;//  exp/71*lv*lv
        set_form ALLSET;
        min_form MIN = new min_form();
        string[] type_list = { "一次", "每日", "每……天", "每周", "每周……", "每月", "纪念日", "每年" };
        string[] weekday_list = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
        List<FlowLayoutPanel> Task_list = new List<FlowLayoutPanel>();
        void set_person_inf_label()
        {
            name_label.Text = person_name;
            lv_label.Text = "lv." + lv.ToString();
            exp_label.Text = "EXP:" + exp.ToString() + "/" + (71 * lv * lv + 1).ToString();
        }
        //***********form inf****************//
        int form_width = 0;
        int form_height = 0;
        int tag = 0;
        //************** file operator ***************//
        public void set_person_inf()
        {
            // name/0/0/
            try
            {
                lv = 0;
                exp = 0;
                string str = File.ReadAllText("./person_inf.txt");
                for (int i = 0, tag = 0; i < str.Length&&tag<5; i++)
                {
                    if (str[i] == '/')
                    {
                        if (tag == 0)
                            person_name = str.Substring(0, i);
                        tag++;
                        continue;
                    }
                    switch (tag)
                    {
                        case 1:
                            lv *= 10;
                            lv += str[i] - '0';
                            break;
                        case 2:
                            exp *= 10;
                            exp += str[i] - '0';
                            break;
                        case 3:
                            form_width *= 10;
                            form_width += str[i] - '0';
                            break;
                        case 4:
                            form_height *= 10;
                            form_height += str[i] - '0';
                            break;
                    }
                }
            }
            catch (FileNotFoundException)
            {
                person_name = "请设置姓名";
                lv = 0;
                exp = 0;
            }
            set_person_inf_label();
        }
        void save()
        {
            StreamWriter tasks_writer = new StreamWriter("./task_list.txt");
            for(int i = 0; i < Task_list.Count; i++)
            {
                if (Task_list[i].Visible == true)
                    tasks_writer.Write(TASK_LIST_inf[i].Tosting());
                else if(TASK_LIST_inf[i].type!=0)
                    tasks_writer.Write(TASK_LIST_inf[i].Tosting());
            }
            tasks_writer.Close();
            tasks_writer = new StreamWriter("./person_inf.txt");
            tasks_writer.Write(person_name + "/" + lv.ToString() + "/" + exp.ToString() + "/" + form_width + "/" + form_height + "/");
            tasks_writer.Close();
        }
        void load()
        {
            StreamReader tasks_reader;
            try
            {
                tasks_reader = new StreamReader("./task_list.txt");                
                for (int i=0;tasks_reader.Peek()>=0;i++)
                {
                    string str = tasks_reader.ReadLine();
                    TASK_LIST_inf.Add(new task_inf(str));
                    add_new_task_in_studio(TASK_LIST_inf[i]);
                }
                tasks_reader.Close();
            }
            catch (FileNotFoundException){
                
            }
        }
        //*************** button set *****************//
        private void close_form_Click(object sender, EventArgs e)
        {

            save();
            MIN.Show();
            Hide();          
        }
        private void add_task_button_Click(object sender, EventArgs e)
        {
            add_area.Visible = true;
        }
        private void set_button_Click(object sender, EventArgs e)
        {
            ALLSET = new set_form();
            ALLSET.Show();
        }
        private void updown_button_Click(object sender, EventArgs e)
        {
            person_inf.Visible = !person_inf.Visible;
            set_button_location();
            task_panel.Focus();           
        }
        void set_button_location()
        {
            close_form.Left = person_inf.Width - 78;
            set_button.Left = person_inf.Width - 78;
            add_task_button.Width = Task_studio.Width;
        }
        private void Main_form_SizeChanged(object sender, EventArgs e)
        {
            set_button_location();
            if (tag < 10)
                tag++;
            else
            {
                form_width = Width;
                form_height = Height;
            }
          
        }
        private void person_pic_Click(object sender, EventArgs e)
        {
            task_manage(1);
        }
        //*************** form set *******************//
        public Main_form()
        {
            InitializeComponent();
            task_panel.Focus();
            add_task_time_blank();
            set_person_inf();
            set_button_location();
            load();
            Main_container.Focus();
            find_end_task();
            task_manage();           
        }
        //*************** add_task_area set *********// 
        int string_stay_length(string str)
        {
            int count = 3;
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] > 127)
                    count += 14;
                else
                    count += 7;
            }
            return count;
        }
        void add_new_task_in_studio(task_inf newtask)
        {
            FlowLayoutPanel task_panel = new FlowLayoutPanel();
            task_panel.BackColor = Color.LightBlue;
            task_panel.Height = 25;
            task_panel.Tag = Task_list.Count;
            Button button = new Button();
            button.Tag = Task_list.Count;
            button.Click += finish_task_Click;
            button.Text = "√";
            button.Width = 25;
            button.Height = 25;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            task_panel.Controls.Add(button);
            Label text = new Label();
            text.Text = newtask.name;
            text.Margin = new Padding(3, 7, 0, 3);
            text.Width = string_stay_length(text.Text);
            task_panel.Controls.Add(text);
            text.DoubleClick += delete_task;
            Label text2 = new Label();
            text2.Text = newtask.Label_text();
            text2.Margin = new Padding(3, 7, 0, 3);
            text2.Width = string_stay_length(text2.Text);
            text2.DoubleClick += delete_task; 
            task_panel.Controls.Add(text2);
            task_panel.Width = 40 + text.Width + text2.Width;
            Task_list.Add(task_panel);
            Task_studio.Controls.Add(task_panel);
        }//
        private void add_task_ok_Click(object sender, EventArgs e)
        {
            int tag = 0;
            for(int i=0;i<add_task_name.Text.Length;i++)
                if(add_task_name.Text[i]!=' ')
                {
                    tag = 1;
                    break;
                }
            if (tag == 0)
            {
                add_task_name.Text = "请输入有效的名字";
                add_task_name.ForeColor = Color.Red;
                return;
            }
            int type = 0;
            for (int i = 0; i < type_list.Length; i++)
                if (type_list[i] == add_task_type.Text)
                {
                    type = i;
                    break;
                }
            task_inf newtask;
            int[] weekday = { 0, 0, 0, 0, 0, 0, 0 };
            switch (type)
            {
                case 0:
                    newtask = new task_inf(add_task_name.Text, DateTime.Now.ToString(), add_task_time_text.Text, type, add_task_more_text.Text, 0,weekday, 0);
                    break;
                case 1:
                    newtask = new task_inf(add_task_name.Text, add_task_time_text.Text, add_task_time_text.Text, type, add_task_more_text.Text, 1, weekday, 0);
                    break;
                case 2:
                    newtask = new task_inf(add_task_name.Text, add_task_time_text.Text, add_task_time_text.Text, type, add_task_more_text.Text, int.Parse(interval_or_advance_text.Value.ToString()), weekday, 0);
                    break;
                case 3:
                    newtask = new task_inf(add_task_name.Text, add_task_time_text.Text, add_task_time_text.Text, type, add_task_more_text.Text, 7, weekday, 0);
                    break;
                case 4:
                    tag = 0;
                    for(int i=0;i< add_task_weekdaychoose.CheckedItems.Count; i++)
                    {
                        for(int j = 0; j < weekday_list.Length; j++)
                        {
                            if (add_task_weekdaychoose.CheckedItems[i].ToString() == weekday_list[j])
                            {
                                tag = 1;
                                weekday[j] = 1;
                                break;
                            }
                        }
                    }
                    if (tag == 0) return;
                    newtask = new task_inf(add_task_name.Text, add_task_time_text.Text, add_task_time_text.Text, type, add_task_more_text.Text, 1, weekday, 0);
                    break;
                case 5: newtask = new task_inf(add_task_name.Text, add_task_time_text.Text, add_task_time_text.Text, type, add_task_more_text.Text, 30, weekday, 0);
                    break;
                case 6:
                    newtask = new task_inf(add_task_name.Text, DateTime.Now.ToString(), add_task_time_text.Text, type, add_task_more_text.Text, 0, weekday, int.Parse(interval_or_advance_text.Value.ToString()));
                    break;
                case 7: newtask = new task_inf(add_task_name.Text, add_task_time_text.Text, add_task_time_text.Text, type, add_task_more_text.Text, 365, weekday, 0);
                    break;
                default:
                    return;
            }
            TASK_LIST_inf.Add(newtask);
            add_new_task_in_studio(newtask);
            add_area.Visible = false;
            add_task_name.Text = "";
            add_task_more_text.Text = "";
            task_manage();
        }
        private void add_task_cancel_Click(object sender, EventArgs e)
        {
            add_area.Visible = false;
        }
        private void finish_task_Click(object sender,EventArgs e)
        {
            Button this_button = (Button)sender;
            int i = (int)this_button.Tag;
            Task_list[i].Hide();
            int Exp=TASK_LIST_inf[i].EXP();
            exp += Exp;
            TASK_LIST_inf[i].finished();
            while (exp >= 71 * lv * lv + 1)
            {
                exp -= 71 * lv * lv + 1;
                lv++;
                StreamWriter history_p = new StreamWriter("./person_inf_lv.txt", true);
                history_p.Write(DateTime.Now.ToString() + "|" + lv + "|\r\n");
                history_p.Close();
            }
            set_person_inf_label();
            StreamWriter history = new StreamWriter("./task_history.txt",true);
            history.Write(TASK_LIST_inf[i].History_tostring(DateTime.Now, Exp));
            history.Close();
            save();
            Main_container.Focus();
        }
        private void delete_task(object sender,EventArgs e)
        {
            Label this_label = (Label)sender;
            int i = (int)this_label.Parent.Tag;
            Task_list[i].Hide();
            TASK_LIST_inf[i].delete();
        }
        //************* 格式设置 **************//
        private void set_add_task_area(object sender, EventArgs e)
        {
            add_task_time.Text = "开始时间";
            add_task_weekdaychoose_area.Visible = false;
            add_task_every__day.Visible = false;
            add_task_more.Top = 169;
            add_task_ok.Top = add_task_cancel.Top = 276;
            if (add_task_type.Text == "一次")
            {
                add_task_time.Text = "截止时间";
            }
            else if (add_task_type.Text == "每日")
            {

            }
            else if (add_task_type.Text == "每……天")
            {
                add_task_weekdaychoose_area.Visible = false;
                add_task_every__day.Visible = true;
                add_task_more.Top = 224;
                add_task_ok.Top = add_task_cancel.Top = 331;
                interal_or_advance.Text = "间隔";
            }
            else if (add_task_type.Text == "每周")
            {

            }
            else if (add_task_type.Text == "每周……")
            {
                add_task_weekdaychoose_area.Visible = true;
                add_task_every__day.Visible = false;
                add_task_more.Top = 316;
                add_task_ok.Top = add_task_cancel.Top = 423;
            }
            else if (add_task_type.Text == "每月")
            {

            }
            else if (add_task_type.Text == "纪念日")
            {
                add_task_time.Text = "提醒日期";
                interal_or_advance.Text = "提前几天提醒";
                add_task_weekdaychoose_area.Visible = false;
                add_task_every__day.Visible = true;
                add_task_more.Top = 224;
                add_task_ok.Top = add_task_cancel.Top = 331;
            }
            else if (add_task_type.Text == "每年")
            {

            }
            else
            {

            }

        }
        private void add_task_time_blank()
        {
            // 2016/12/11 11:00:00
            string str = add_task_time_text.Text;
            int year = 0, month = 0, day = 0, hour = 0, min = 0, sec = 0;
            int tag = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (!('0' <= str[i] && str[i] <= '9'))
                {
                    tag++;
                    continue;
                }
                switch (tag)
                {
                    case 0:
                        year *= 10;
                        year += str[i] - '0';
                        break;
                    case 1:
                        month *= 10;
                        month += str[i] - '0';
                        break;
                    case 2:
                        day *= 10;
                        day += str[i] - '0';
                        break;
                    case 3:
                        hour *= 10;
                        hour += str[i] - '0';
                        break;
                    case 4:
                        min *= 10;
                        min += str[i] - '0';
                        break;
                    case 5:
                        sec *= 10;
                        sec += str[i] - '0';
                        break;

                }
            }
            if (year < DateTime.Now.Year)
                year = DateTime.Now.Year;
            else if (year > DateTime.Now.Year + 10)
                year = DateTime.Now.Year + 10;
            if (year == DateTime.Now.Year)
            {
                if (month < DateTime.Now.Month)
                    month = DateTime.Now.Month;
                if (month == DateTime.Now.Month && day < DateTime.Now.Day)
                    day = DateTime.Now.Day;
            }
            if (month < 1) month = 1;
            else if (month > 12) month = 12;
            int[] monthday = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day < 1) day = 1;
            else if (day > monthday[month]) day = monthday[month];
            if (month == 2 && day == 29 && !(year % 4 == 0 && year % 100 != 0 || year % 400 == 0))
                day = 28;
            if (hour < 0) hour = 0;
            else if (hour > 23) hour = 23;
            if (min < 0) min = 0;
            else if (min > 59) min = 59;
            if (sec < 0) sec = 0;
            else if (sec > 59) sec = 59;
            str = year.ToString() + "/" + month.ToString() + "/" +
                day.ToString() + " ";
            if (hour < 10) str += "0" + hour.ToString();
            else str += hour.ToString();
            str += ":";
            if (min < 10) str += "0" + min.ToString();
            else str += min.ToString();
            str += ":";
            if (sec < 10) str += "0" + sec.ToString();
            else str += sec.ToString();
            add_task_time_text.Text = str;
        }
        private void add_task_time_text_MouseDown(object sender, MouseEventArgs e)
        {
            add_task_time_blank();
            int start = add_task_time_text.SelectionStart-1, end = start+1;
            if (start < 0) { start = 0;end = 1; }
            string str = add_task_time_text.Text;
            for (; start >= 0 && str[start] <= '9' && str[start] >= '0'; start--) ;
            for (; end < str.Length && str[end] <= '9' && str[end] >= '0'; end++) ;
            start++;
            add_task_time_text.SelectionStart = start;
            add_task_time_text.SelectionLength = (end - start);
        }
        private void add_task_time_text_Leave(object sender, EventArgs e)
        {
            add_task_time_blank();
        }
        private void add_task_name_MouseDown(object sender, MouseEventArgs e)
        {
            if (add_task_name.ForeColor == Color.Red)
            {
                add_task_name.ForeColor = Color.Black;
                add_task_name.Text = "";
            }
        }
        //*************more*******************//
        void task_manage(int mode = 0)
        {
            save();
            for (int i = 0; i < Task_list.Count; i++)
            {
                Task_list[i].Controls[0].Enabled = true;
                Task_list[i].Controls[2].Text = TASK_LIST_inf[i].Label_text();
                Task_list[i].Controls[2].Width = string_stay_length(Task_list[i].Controls[2].Text);
                Task_list[i].Width = 40 + Task_list[i].Controls[1].Width + Task_list[i].Controls[2].Width;
                switch (TASK_LIST_inf[i].emergy())
                {
                    case 0:
                        Task_list[i].BackColor = Color.Wheat;
                        Task_list[i].Controls[0].Enabled = false;
                        if (mode == 0)
                            Task_list[i].Hide();
                        else if (mode == 1)
                            Task_list[i].Show();
                        break;
                    case 1:
                        Task_list[i].BackColor = Color.LightBlue;
                        Task_list[i].Show();
                        break;
                    case 2:
                        Task_list[i].BackColor = Color.Orange;
                        Task_list[i].Show();
                        break;
                    case 3:
                        Task_list[i].BackColor = Color.OrangeRed;
                        Task_list[i].Show();
                        break;
                }
            }


        }
        void find_end_task()
        {
            for (int i = 0; i < Task_list.Count; i++)
            {
                if (TASK_LIST_inf[i].isend())
                {
                    TASK_LIST_inf[i].end();
                    Task_list[i].Hide();
                }
            }
        }
        //**************************************//
        private void timer2_Tick(object sender, EventArgs e)
        {
            find_end_task();
            task_manage();
        }

        private void updown_button_DragDrop(object sender, DragEventArgs e)
        {
            this.Top = MousePosition.X;
            this.Left = MousePosition.Y;
        }

        private void Main_form_Leave(object sender, EventArgs e)
        {
        }

        private void Main_form_Deactivate(object sender, EventArgs e)
        {
            save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MIN.Visible == false)
                Show();
            else
            {
                MIN.show_string("点击展开",0);
            }
        }
    }
}
