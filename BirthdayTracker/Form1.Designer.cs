
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BirthdayTracker
{
    partial class Form1
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
            this.Birthday = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.person_textbox = new System.Windows.Forms.TextBox();
            this.dislikes_textbox = new System.Windows.Forms.TextBox();
            this.likes_textbox = new System.Windows.Forms.TextBox();
            this.day_textbox = new System.Windows.Forms.TextBox();
            this.month_textbox = new System.Windows.Forms.TextBox();
            this.find_textbox = new System.Windows.Forms.TextBox();
            this.find_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.new_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.to_latest_button = new System.Windows.Forms.Button();
            this.later_button = new System.Windows.Forms.Button();
            this.former_button = new System.Windows.Forms.Button();
            this.to_oldest_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.month_display_textbox = new System.Windows.Forms.TextBox();
            this.change_month_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Likes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dislikes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(194, 114);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(0, 25);
            this.Birthday.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birthday Tracker";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Person\'s name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Likes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "B/Day Day:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 517);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 31);
            this.label6.TabIndex = 6;
            this.label6.Text = "B/Day Month:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(891, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Find:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dislikes:";
            // 
            // person_textbox
            // 
            this.person_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.person_textbox.Location = new System.Drawing.Point(287, 141);
            this.person_textbox.Name = "person_textbox";
            this.person_textbox.Size = new System.Drawing.Size(394, 38);
            this.person_textbox.TabIndex = 9;
            // 
            // dislikes_textbox
            // 
            this.dislikes_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislikes_textbox.Location = new System.Drawing.Point(287, 325);
            this.dislikes_textbox.Name = "dislikes_textbox";
            this.dislikes_textbox.Size = new System.Drawing.Size(394, 38);
            this.dislikes_textbox.TabIndex = 10;
            // 
            // likes_textbox
            // 
            this.likes_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likes_textbox.Location = new System.Drawing.Point(287, 230);
            this.likes_textbox.Name = "likes_textbox";
            this.likes_textbox.Size = new System.Drawing.Size(394, 38);
            this.likes_textbox.TabIndex = 11;
            // 
            // day_textbox
            // 
            this.day_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_textbox.Location = new System.Drawing.Point(287, 431);
            this.day_textbox.Name = "day_textbox";
            this.day_textbox.Size = new System.Drawing.Size(394, 38);
            this.day_textbox.TabIndex = 12;
            // 
            // month_textbox
            // 
            this.month_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_textbox.Location = new System.Drawing.Point(287, 520);
            this.month_textbox.Name = "month_textbox";
            this.month_textbox.Size = new System.Drawing.Size(394, 38);
            this.month_textbox.TabIndex = 13;
            // 
            // find_textbox
            // 
            this.find_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_textbox.Location = new System.Drawing.Point(1036, 138);
            this.find_textbox.Name = "find_textbox";
            this.find_textbox.Size = new System.Drawing.Size(294, 38);
            this.find_textbox.TabIndex = 14;
            // 
            // find_button
            // 
            this.find_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.find_button.Location = new System.Drawing.Point(897, 224);
            this.find_button.Name = "find_button";
            this.find_button.Size = new System.Drawing.Size(433, 58);
            this.find_button.TabIndex = 16;
            this.find_button.Text = "Find";
            this.find_button.UseVisualStyleBackColor = true;
            this.find_button.Click += new System.EventHandler(this.find_button_Click);
            // 
            // update_button
            // 
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(897, 394);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(433, 54);
            this.update_button.TabIndex = 17;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // new_button
            // 
            this.new_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_button.Location = new System.Drawing.Point(897, 322);
            this.new_button.Name = "new_button";
            this.new_button.Size = new System.Drawing.Size(433, 57);
            this.new_button.TabIndex = 18;
            this.new_button.Text = "New";
            this.new_button.UseVisualStyleBackColor = true;
            this.new_button.Click += new System.EventHandler(this.new_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(897, 464);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(433, 56);
            this.delete_button.TabIndex = 19;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // to_latest_button
            // 
            this.to_latest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_latest_button.Location = new System.Drawing.Point(42, 589);
            this.to_latest_button.Name = "to_latest_button";
            this.to_latest_button.Size = new System.Drawing.Size(76, 50);
            this.to_latest_button.TabIndex = 20;
            this.to_latest_button.Text = "|<";
            this.to_latest_button.UseVisualStyleBackColor = true;
            this.to_latest_button.Click += new System.EventHandler(this.to_latest_button_Click);
            // 
            // later_button
            // 
            this.later_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.later_button.Location = new System.Drawing.Point(140, 589);
            this.later_button.Name = "later_button";
            this.later_button.Size = new System.Drawing.Size(76, 50);
            this.later_button.TabIndex = 21;
            this.later_button.Text = "<";
            this.later_button.UseVisualStyleBackColor = true;
            this.later_button.Click += new System.EventHandler(this.later_button_Click);
            // 
            // former_button
            // 
            this.former_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.former_button.Location = new System.Drawing.Point(235, 589);
            this.former_button.Name = "former_button";
            this.former_button.Size = new System.Drawing.Size(76, 50);
            this.former_button.TabIndex = 22;
            this.former_button.Text = ">";
            this.former_button.UseVisualStyleBackColor = true;
            this.former_button.Click += new System.EventHandler(this.former_button_Click);
            // 
            // to_oldest_button
            // 
            this.to_oldest_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_oldest_button.Location = new System.Drawing.Point(332, 589);
            this.to_oldest_button.Name = "to_oldest_button";
            this.to_oldest_button.Size = new System.Drawing.Size(76, 50);
            this.to_oldest_button.TabIndex = 23;
            this.to_oldest_button.Text = ">|";
            this.to_oldest_button.UseVisualStyleBackColor = true;
            this.to_oldest_button.Click += new System.EventHandler(this.to_oldest_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.month_display_textbox);
            this.panel1.Controls.Add(this.change_month_button);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1098, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 227);
            this.panel1.TabIndex = 25;
            // 
            // month_display_textbox
            // 
            this.month_display_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_display_textbox.Location = new System.Drawing.Point(44, 163);
            this.month_display_textbox.Name = "month_display_textbox";
            this.month_display_textbox.Size = new System.Drawing.Size(370, 38);
            this.month_display_textbox.TabIndex = 27;
            this.month_display_textbox.Text = "All";
            this.month_display_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // change_month_button
            // 
            this.change_month_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_month_button.Location = new System.Drawing.Point(44, 75);
            this.change_month_button.Name = "change_month_button";
            this.change_month_button.Size = new System.Drawing.Size(370, 50);
            this.change_month_button.TabIndex = 28;
            this.change_month_button.Text = "Birthdays in month of:";
            this.change_month_button.UseVisualStyleBackColor = true;
            this.change_month_button.Click += new System.EventHandler(this.change_month_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(169, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 31);
            this.label9.TabIndex = 27;
            this.label9.Text = "Search";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(1098, 1059);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(433, 49);
            this.exit_button.TabIndex = 26;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 678);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birthday List:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Person,
            this.Likes,
            this.Dislikes,
            this.Day,
            this.Month});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(42, 753);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(618, 366);
            this.dataGridView1.TabIndex = 27;
            // 
            // Person
            // 
            this.Person.HeaderText = "Person";
            this.Person.MinimumWidth = 10;
            this.Person.Name = "Person";
            this.Person.Width = 125;
            // 
            // Likes
            // 
            this.Likes.HeaderText = "Likes";
            this.Likes.MinimumWidth = 10;
            this.Likes.Name = "Likes";
            this.Likes.Width = 108;
            // 
            // Dislikes
            // 
            this.Dislikes.HeaderText = "Dislikes";
            this.Dislikes.MinimumWidth = 10;
            this.Dislikes.Name = "Dislikes";
            this.Dislikes.Width = 132;
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.MinimumWidth = 10;
            this.Day.Name = "Day";
            this.Day.Width = 95;
            // 
            // Month
            // 
            this.Month.HeaderText = "Month";
            this.Month.MinimumWidth = 10;
            this.Month.Name = "Month";
            this.Month.Width = 117;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1606, 1131);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.to_oldest_button);
            this.Controls.Add(this.former_button);
            this.Controls.Add(this.later_button);
            this.Controls.Add(this.to_latest_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.new_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.find_button);
            this.Controls.Add(this.find_textbox);
            this.Controls.Add(this.month_textbox);
            this.Controls.Add(this.day_textbox);
            this.Controls.Add(this.likes_textbox);
            this.Controls.Add(this.dislikes_textbox);
            this.Controls.Add(this.person_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Birthday);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            load_csv();

        }

        #endregion

        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox person_textbox;
        private System.Windows.Forms.TextBox dislikes_textbox;
        private System.Windows.Forms.TextBox likes_textbox;
        private System.Windows.Forms.TextBox day_textbox;
        private System.Windows.Forms.TextBox month_textbox;
        private System.Windows.Forms.TextBox find_textbox;
        private System.Windows.Forms.Button find_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button new_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button to_latest_button;
        private System.Windows.Forms.Button later_button;
        private System.Windows.Forms.Button former_button;
        private System.Windows.Forms.Button to_oldest_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox month_display_textbox;
        private System.Windows.Forms.Button change_month_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label2;

        public List<String[]> friend_info_list = null;



        public void load_csv()
        {
            friend_info_list = new List<String[]>();



            try
            {

                StreamReader get_data = new StreamReader("MyFriendData.csv");
                while (!get_data.EndOfStream)
                {
                    string each_line = get_data.ReadLine();

                    string[] each_array = each_line.Split(',');

                    dataGridView1.Rows.Add(each_array[0], each_array[1], each_array[2], each_array[3], each_array[4]);



                    //Console.WriteLine(each_array[0]);

                    friend_info_list.Add(each_array);


                }

                get_data.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be loaded.");
                Console.WriteLine(e.Message);
                return;
            }



        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Person;
        private DataGridViewTextBoxColumn Likes;
        private DataGridViewTextBoxColumn Dislikes;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Month;
    }
}

