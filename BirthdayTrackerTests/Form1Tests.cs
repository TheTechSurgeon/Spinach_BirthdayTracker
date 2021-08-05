/*
This is for testing "binary_search_name(String person_name)" in class "Form1".

This method is partly changed in this file in order to adjust test conduct.

*/



using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;



namespace BirthdayTracker.Tests
{
    [TestClass()]
    public class Form1Tests
    {


        //prepare sample friend data.
        public List<String[]> get_friend_info_list()
        {
            

            string[] each_array1 = { "Tom", "baseball", "vegetable", "7", "9" };
            string[] each_array2 = { "Wendy", "baseball", "vegetable", "7", "9" };
            string[] each_array3 = { "Andy", "baseball", "vegetable", "7", "9" };
            string[] each_array4 = { "Panda", "baseball", "vegetable", "7", "9" };
            string[] each_array5 = { "Cathy", "icecream", "vegetable", "7", "9" };
            string[] each_array6 = { "Happy", "lemon", "vegetable", "7", "9" };

            List<String[]> friend_info_list = new List<string[]>();

            friend_info_list.Add(each_array1);
            friend_info_list.Add(each_array2);
            friend_info_list.Add(each_array3);
            friend_info_list.Add(each_array4);
            friend_info_list.Add(each_array5);
            friend_info_list.Add(each_array6);

            return friend_info_list;


        }



        // binary_search_name(String person_name) *partly changed for testing.

        public Boolean binary_search_name(String person_name)
        {
            List<String[]> sorted_friend_info_list = new List<string[]>(this.get_friend_info_list());

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
                    /*

                    for (int i = 0; i < friend_info_list.Count; i++)
                    {
                        if (friend_info_list[i][0] == sorted_friend_info_list[Min + ((Max - Min) / 2)][0])
                        {
                            current_list_num = i;
                            insert_to_textboxes(i);
                            return;

                        }

                    }
                    */


                    // If person is founed, "true" returned.
                    return true;



                }

                else if (Max == Min)
                {

                    /*   MessageBox.Show("Sorry, no name was found for " + person_name, "NOT FOUND", MessageBoxButtons.OK); */

                    // If person is not founed, "false" returned.
                    return false;
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





        [TestMethod()]

        public void binary_search_name_test_1()
        {
            //"Tom" exists in the sample, true is expected.
            Assert.AreEqual(this.binary_search_name("Tom"), true);

        }


        [TestMethod()]
        public void binary_search_name_test_2()
        {
            //"Bob" does not exist in the sample, false is expected.
            Assert.AreEqual(this.binary_search_name("Bob"), false);

        }


        [TestMethod()]
        public void binary_search_name_test_3()
        {
            // When input "", false is expected.
            Assert.AreEqual(this.binary_search_name(""), false);

        }





    }
}