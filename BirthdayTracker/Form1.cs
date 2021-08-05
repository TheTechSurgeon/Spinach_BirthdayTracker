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

namespace BirthdayTracker
{
    public partial class Form1 : Form
    {

        String[] month_array = new String[13] { "All", "1 - Jan", "2 - Feb", "3 - Mar", "4 - Apr", "5 - May", "6 - Jun",
                                               "7 - Jul", "8 - Aug", "9 - Sep", "10 - Oct", "11 - Nov", "12 - Des" };

        int month_index = 0;
        public int current_list_num = -1;



        public Form1()
        {

            InitializeComponent();
        }




        public void insert_to_textboxes(int given_num)
        {

            person_textbox.Text = friend_info_list[given_num][0];

            likes_textbox.Text = friend_info_list[given_num][1];

            dislikes_textbox.Text = friend_info_list[given_num][2];

            day_textbox.Text = friend_info_list[given_num][3];

            month_textbox.Text = friend_info_list[given_num][4];


        }













        public void move_record(int given_num)
        {


            current_list_num += given_num;

            if (current_list_num < 0)
            {
                current_list_num = 0;
                return;

            }
            else if (current_list_num > friend_info_list.Count - 1)
            {
                current_list_num = friend_info_list.Count - 1;
                return;
            }


            insert_to_textboxes(current_list_num);



        }






        private void find_button_Click(object sender, EventArgs e)
        {
            binary_search_name(find_textbox.Text);

        }

        private void former_button_Click(object sender, EventArgs e)
        {
            move_record(1);

        }

        private void to_oldest_button_Click(object sender, EventArgs e)
        {
            insert_to_textboxes(friend_info_list.Count - 1);
            current_list_num = friend_info_list.Count - 1;
        }

        private void later_button_Click(object sender, EventArgs e)
        {
            move_record(-1);
        }

        private void to_latest_button_Click(object sender, EventArgs e)
        {
            insert_to_textboxes(0);
            current_list_num = 0;

        }





        private String[] check_error()
        {

            String person = person_textbox.Text;
            String likes = likes_textbox.Text;
            String dislikes = dislikes_textbox.Text;
            String day = day_textbox.Text;
            String month = month_textbox.Text;



            String[] error_array = { "", "", "", "", "" };


            if (person == "")
            {

                error_array[0] = "Person's name is blunk.";
            }

            if (likes == "")
            {
                error_array[1] = "Likes is blunk.";
            }

            if (dislikes == "")
            {
                error_array[2] = "Dislikes is blunk.";

            }

            if (day == "")
            {
                error_array[3] = "Day of birth is blunk.";
            }
            else
            {
                try
                {

                    if (Int32.Parse(day) < 1 || Int32.Parse(day) > 31)
                    {
                        error_array[3] = "Day of birth must be 1 ~ 31.";

                    }
                }
                catch (System.FormatException)
                {
                    error_array[3] = "Day of birth must be 1 ~ 31.";

                }


            }




            if (month == "")
            {
                error_array[4] = "Month of birth is blunk.";
            }
            else
            {
                try
                {

                    if (Int32.Parse(month) < 1 || Int32.Parse(month) > 12)
                    {
                        error_array[4] = "Month of birth must be 1 ~ 12.";

                    }
                }
                catch (System.FormatException)
                {
                    error_array[4] = "Month of birth must be 1 ~ 12.";

                }


            }


            String error_message = "";

            foreach (String each_error in error_array)
            {
                if (each_error != "")
                {

                    error_message += each_error + "\n";
                }

            }

            return new String[6] { person, likes, dislikes, day, month, error_message };

        }



        public void update_raws(List<String[]> given_list)
        {

            dataGridView1.Rows.Clear();

            foreach (String[] each_array in given_list)
            {
                dataGridView1.Rows.Add(each_array[0], each_array[1], each_array[2], each_array[3], each_array[4]);

            }


        }














        public void binary_search_name(String person_name)
        {
            List<String[]> sorted_friend_info_list = new List<string[]>(friend_info_list);

            String[] memo;

            for (int i = 0; i < sorted_friend_info_list.Count - 1; i++)
            {

                int minimum = i;

                for (int j = i + 1; j < sorted_friend_info_list.Count; j++)
                {
                    if (String.Compare(sorted_friend_info_list[j][0], sorted_friend_info_list[minimum][0], true) == -1)
                    {
                        minimum = j;
                    }

                }

                memo = sorted_friend_info_list[i];
                sorted_friend_info_list[i] = sorted_friend_info_list[minimum];
                sorted_friend_info_list[minimum] = memo;

            }




            int Min = 0;
            int Max = sorted_friend_info_list.Count - 1;

            while (true)
            {

          

               
                 if (String.Compare(person_name, sorted_friend_info_list[Min + ((Max - Min) / 2)][0], true) == 0)
                {


                    for (int i = 0; i < friend_info_list.Count; i++)
                    {
                        if (friend_info_list[i][0] == sorted_friend_info_list[Min + ((Max - Min) / 2)][0])
                        {
                            current_list_num = i;
                            insert_to_textboxes(i);
                            return;

                        }

                    }



                  
                }

                else if (Max == Min)
                {

                    MessageBox.Show("Sorry, no name was found for " + person_name, "NOT FOUND", MessageBoxButtons.OK);

                    return;
                }


                else if (String.Compare(person_name, sorted_friend_info_list[Min + ((Max - Min) / 2)][0], true) == -1)
                {
                    Max -= (((Max - Min) / 2) + 1);
                }
                else
                {

                    Min += (((Max - Min) / 2) + 1);

                }




            }



        }





        private void reset_textboxes()
        {

            person_textbox.Text = "";
            likes_textbox.Text = "";
            dislikes_textbox.Text = "";
            day_textbox.Text = "";
            month_textbox.Text = "";
            find_textbox.Text = "";

            month_display_textbox.Text = "All";
            month_index = 0;
            update_raws(friend_info_list);




        }






















        private void new_button_Click(object sender, EventArgs e)
        {

            String[] new_check_error = check_error();


            if (new_check_error[5] != "")
            {
                MessageBox.Show(new_check_error[5], "ERROR(S) FOUND", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Will you add information about " + new_check_error[0], "ADD NEW FRIEND",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    friend_info_list.Add(new string[] { new_check_error[0], new_check_error[1], new_check_error[2], new_check_error[3], new_check_error[4] });

                    update_raws(friend_info_list);

                    reset_textboxes();

                }

            }


        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (current_list_num == -1)
            {
                MessageBox.Show("Please select a record by using Find button.", "NOT SELECTED", MessageBoxButtons.OK);
                return;
            }



            String[] update_check_error = check_error();


            if (update_check_error[5] != "")
            {
                MessageBox.Show(update_check_error[5], "ERROR(S) FOUND", MessageBoxButtons.OK);
            }
            else
            {
                String update_info = "Person's name: " + friend_info_list[current_list_num][0] + " → " + update_check_error[0] + "\n"
                                    + "Liks: " + friend_info_list[current_list_num][1] + " → " + update_check_error[1] + "\n"
                                     + "Dislikes: " + friend_info_list[current_list_num][2] + " → " + update_check_error[2] + "\n"
                                     + "B/Day Day: " + friend_info_list[current_list_num][3] + " → " + update_check_error[3] + "\n"
                                     + "B/Day Month: " + friend_info_list[current_list_num][4] + " → " + update_check_error[4] + "\n";





                if (MessageBox.Show(update_info + "Will you update this information?", "UPDATE",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    friend_info_list[current_list_num] = new string[5] { update_check_error[0], update_check_error[1], update_check_error[2], update_check_error[3], update_check_error[4] };

                    update_raws(friend_info_list);

                    reset_textboxes();

                }

            }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            if (current_list_num == -1)
            {
                MessageBox.Show("Please select a record by using Find button.", "NOT SELECTED", MessageBoxButtons.OK);
                return;
            }



                String delete_info = "Person's name: " + friend_info_list[current_list_num][0] + "\n"
                                    + "Liks: " + friend_info_list[current_list_num][1] + "\n"
                                   + "Dislikes: " + friend_info_list[current_list_num][2] + "\n"
                                   + "B/Day Day: " + friend_info_list[current_list_num][3] + "\n"
                                   + "B/Day Month: " + friend_info_list[current_list_num][4] + "\n";


                if (MessageBox.Show("Will you delete this?\n" +delete_info  , "DELETE",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    friend_info_list.RemoveAt(current_list_num);

                    update_raws(friend_info_list);

                reset_textboxes();

                }


            


        }

        private void change_month_button_Click(object sender, EventArgs e)
        {

            if (month_index == 12)
            {
                month_index = 0;
            }
            else
            {
                month_index++;
            }

            month_display_textbox.Text = month_array[month_index];

            if (month_index == 0)
            {
                update_raws(friend_info_list);
            }

            else
            {

                List<String[]> found_friends = new List<String[]>();


                foreach (String[] each_friend in friend_info_list)
                {
                    if (Int32.Parse(each_friend[4]) == month_index)
                    {
                        found_friends.Add(each_friend);

                    }

                }

                update_raws(found_friends);

            }





        }

      

        private void exit_button_Click_1(object sender, EventArgs e)
        {




            if (MessageBox.Show("You are about to write all records to the external file and exit.\n Click YES if " +
                "you wish to write the records and exit. \n Click NO if you only want to exit (no writing)", "EXIT OPTIONS",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {


                StreamWriter file = new StreamWriter("MyFriendData.csv", false, Encoding.UTF8);
                for (int i = 0; i < friend_info_list.Count; i++)
                {

                    String each_record = friend_info_list[i][0] + "," + friend_info_list[i][1] + "," + friend_info_list[i][2] + "," + friend_info_list[i][3] + "," + friend_info_list[i][4];
                    file.WriteLine(each_record);
                }
                file.Close();

                MessageBox.Show("The file 'MyFriendData.csv' was updated", "APPLICATION CLOSE", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("This application was closed without any update.", "APPLICATION CLOSE", MessageBoxButtons.OK);

            }

            Application.Exit();


 










        }

      
    }
    }

