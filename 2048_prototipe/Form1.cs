using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048_prototipe
{
    public partial class Form1 : Form
    {
        private string[,] array;
        private const int size_box = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void initializate()
        {
            box_1 .Text = array[0, 0];
            box_2 .Text = array[0, 1];
            box_3 .Text = array[0, 2];
            box_4 .Text = array[0, 3];

            box_5 .Text = array[1, 0];
            box_6 .Text = array[1, 1];
            box_7 .Text = array[1, 2];
            box_8 .Text = array[1, 3];

            box_9 .Text = array[2, 0];
            box_10.Text = array[2, 1];
            box_11.Text = array[2, 2];
            box_12.Text = array[2, 3];

            box_13.Text = array[3, 0];
            box_14.Text = array[3, 1];
            box_15.Text = array[3, 2];
            box_16.Text = array[3, 3];
        }

        private void set_box_null()
        {
            box_1.Text = "";
            box_2.Text = "";
            box_3.Text = "";
            box_4.Text = "";

            box_5.Text = "";
            box_6.Text = "";
            box_7.Text = "";
            box_8.Text = "";

            box_9 .Text = "";
            box_10.Text = "";
            box_11.Text = "";
            box_12.Text = "";

            box_13.Text = "";
            box_14.Text = "";
            box_15.Text = "";
            box_16.Text = "";
        }

        private void set_array()
        {
            array = new string[4, 4] { { box_1 .Text, box_2 .Text, box_3 .Text, box_4 .Text }, 
                                       { box_5 .Text, box_6 .Text, box_7 .Text, box_8 .Text },
                                       { box_9 .Text, box_10.Text, box_11.Text, box_12.Text }, 
                                       { box_13.Text, box_14.Text, box_15.Text, box_16.Text } };
        }

        private void generate_random_place(int number)
        {
            set_array();
            Random rand = new Random();
            int vertical = 0, horizont = 0, counter = 0;
            bool value = false;
            while (counter < number)
            {
                while (value == false)
                {
                    vertical = rand.Next(0, 4);
                    horizont = rand.Next(0, 4);
                    value = check(vertical, horizont);
                }
                array[horizont, vertical] = "2";
                value = false;
                counter++;
            }
            initializate();
        }

        private bool check(int vertical, int horizont)
        {
            bool result = false;
            if (array[horizont, vertical] == "")
                result = true;
            else
                result = false;
            return result;
        }

        private void swap<type>(ref type left_operand, ref type right_operand)
        {
            type temp;
            temp = left_operand;
            left_operand = right_operand;
            right_operand = temp;
        }

        private void join_numbers_up()
        {
            set_array();
            int value = 0, score = 0;
            string current_value = null, next_value = null;
            for (int vertical_counter = 0; vertical_counter < size_box; vertical_counter++)
            {
                for (int horizont_counter = 0; horizont_counter < size_box; horizont_counter++)
                {
                    if (horizont_counter + 1 < size_box)
                    {
                        current_value = array[horizont_counter, vertical_counter];
                        next_value = array[horizont_counter + 1, vertical_counter];
                        if (current_value == next_value && current_value != "" && next_value != "")
                        {
                            value = Convert.ToInt32(current_value);
                            value *= 2;
                            score = Convert.ToInt32(score_value.Text) + value;
                            score_value.Text = Convert.ToString(score);
                            array[horizont_counter, vertical_counter] = Convert.ToString(value);
                            array[horizont_counter + 1, vertical_counter] = "";
                        }
                    }
                }
            }
            initializate();
        }

        private void join_numbers_down()
        {
            set_array();
            int value = 0, score = 0;
            string current_value = null, next_value = null;
            for (int vertical_counter = 0; vertical_counter < size_box; vertical_counter++)
            {
                for (int horizont_counter = size_box - 1; horizont_counter >= 0; horizont_counter--)
                {
                    if (horizont_counter < size_box - 1)
                    {
                        current_value = array[horizont_counter, vertical_counter];
                        next_value = array[horizont_counter + 1, vertical_counter];
                        if (current_value == next_value && current_value != "" && next_value != "")
                        {
                            value = Convert.ToInt32(current_value);
                            value *= 2;
                            score = Convert.ToInt32(score_value.Text) + value;
                            score_value.Text = Convert.ToString(score);
                            array[horizont_counter, vertical_counter] = Convert.ToString(value);
                            array[horizont_counter + 1, vertical_counter] = "";
                        }
                    }
                }
            }
            initializate();
        }

        private void join_numbers_left()
        {
            set_array();
            int value = 0, score = 0;
            string current_value = null, next_value = null;
            for (int vertical_counter = 0; vertical_counter < size_box; vertical_counter++)
            {
                for (int horizont_counter = size_box - 1; horizont_counter >= 0; horizont_counter--)
                {
                    if (vertical_counter - 1 >= 0)
                    {
                        current_value = array[horizont_counter, vertical_counter];
                        next_value = array[horizont_counter, vertical_counter - 1];
                        if (current_value == next_value && current_value != "" && next_value != "")
                        {
                            value = Convert.ToInt32(current_value);
                            value *= 2;
                            score = Convert.ToInt32(score_value.Text) + value;
                            score_value.Text = Convert.ToString(score);
                            array[horizont_counter, vertical_counter] = Convert.ToString(value);
                            array[horizont_counter, vertical_counter - 1] = "";
                        }
                    }
                }
            }
            initializate();
        }

        private void join_numbers_right()
        {
            set_array();
            int value = 0, score = 0;
            string current_value = null, next_value = null;
            for (int horizont_counter = 0; horizont_counter < size_box; horizont_counter++)
            {
                for (int vertical_counter = size_box - 1; vertical_counter >= 0; vertical_counter--)
                {
                    if (vertical_counter < size_box - 1)
                    {
                        current_value = array[horizont_counter, vertical_counter];
                        next_value = array[horizont_counter, vertical_counter + 1];
                        if (current_value == next_value && current_value != "" && next_value != "")
                        {
                            value = Convert.ToInt32(current_value);
                            value *= 2;
                            score = Convert.ToInt32(score_value.Text) + value;
                            score_value.Text = Convert.ToString(score);
                            array[horizont_counter, vertical_counter] = Convert.ToString(value);
                            array[horizont_counter, vertical_counter + 1] = "";
                        }
                    }
                }
            }
            initializate();
        }

        private void all_move_down()
        {
            set_array();
            int counter = 0;
            for (int vertical_counter = 0; vertical_counter < size_box; vertical_counter++)
            {
                for (int horizont_counter = size_box - 1; horizont_counter >= 0; horizont_counter--)
                {
                    if (array[horizont_counter, vertical_counter] != "")
                    {
                        counter = horizont_counter;
                        while (horizont_counter < size_box - 1)
                        {
                            if (array[horizont_counter + 1, vertical_counter] == "")
                                swap<string>(ref array[horizont_counter, vertical_counter], ref array[horizont_counter + 1, vertical_counter]);
                            else
                                horizont_counter = size_box - 1;
                            horizont_counter++;
                        }
                        horizont_counter = counter;
                    }
                }
            }
            initializate();
        }

        private void all_move_up()
        {
            set_array();
            int counter = 0;
            for (int vertical_counter = 0; vertical_counter < size_box; vertical_counter++)
            {
                for (int horizont_counter = size_box - 1; horizont_counter >= 0; horizont_counter--)
                {
                    if (array[horizont_counter, vertical_counter] != "")
                    {
                        counter = horizont_counter;
                        while (horizont_counter > 0)
                        {
                            if (array[horizont_counter - 1, vertical_counter] == "")
                                swap<string>(ref array[horizont_counter, vertical_counter], ref array[horizont_counter - 1, vertical_counter]);
                            else
                                horizont_counter = -1;
                            horizont_counter--;
                        }
                        horizont_counter = counter;
                    }
                }
            }
            initializate();
        }

        private void all_move_left()
        {
            set_array();
            int counter = 0;
            for (int vertical_counter = 0; vertical_counter < size_box; vertical_counter++)
            {
                for (int horizont_counter = size_box - 1; horizont_counter >= 0; horizont_counter--)
                {
                    if (array[horizont_counter, vertical_counter] != "")
                    {
                        counter = vertical_counter;
                        while (vertical_counter > 0)
                        {
                            if (array[horizont_counter, vertical_counter - 1] == "")
                                swap<string>(ref array[horizont_counter, vertical_counter], ref array[horizont_counter, vertical_counter - 1]);
                            else
                                vertical_counter = 0;
                            vertical_counter--;
                        }
                        vertical_counter = counter;
                    }
                }
            }
            initializate();
        }

        private void all_move_right()
        {
            set_array();
            int counter = 0;
            for (int horizont_counter = 0; horizont_counter < size_box; horizont_counter++)
            {
                for (int vertical_counter = size_box - 1; vertical_counter >= 0; vertical_counter--)
                {
                    if (array[horizont_counter, vertical_counter] != "")
                    {
                        counter = vertical_counter;
                        while (vertical_counter < size_box - 1)
                        {
                            if (array[horizont_counter, vertical_counter + 1] == "")
                                swap<string>(ref array[horizont_counter, vertical_counter], ref array[horizont_counter, vertical_counter + 1]);
                            else
                                vertical_counter = size_box - 1;
                            vertical_counter++;
                        }
                        vertical_counter = counter;
                    }
                }
            }
            initializate();
        }

        private void check_array()
        {
            set_array();
            int counter = 0;
            for (int vertical_counter = 0; vertical_counter < size_box; vertical_counter++)
            {
                for (int horizont_counter = size_box - 1; horizont_counter >= 0; horizont_counter--)
                {
                    if (array[horizont_counter, vertical_counter] != "")
                    {
                        counter++;
                    }
                    else if(array[horizont_counter, vertical_counter] == "2048") 
                    {
                        MessageBox.Show("You`ve gained 2048 points, good job! Start a new game, or continue.");
                    }
                }
            }
            if (counter == size_box * size_box)
            {
                MessageBox.Show("Game Over. You score is: " + score_value.Text);
            }
            initializate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generate_random_place(2);
        }    

        private void score_Click(object sender, EventArgs e)
        {

        }

        private void start_a_new_game(object sender, EventArgs e)
        {
            set_box_null();
            generate_random_place(2);
        }

        private void control(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    all_move_down();
                    join_numbers_down();
                    all_move_down();
                }
                else if (e.KeyCode == Keys.Up)
                {
                    all_move_up();
                    join_numbers_up();
                    all_move_up();
                    all_move_up();
                }
                else if (e.KeyCode == Keys.Left)
                {
                    all_move_left();
                    join_numbers_left();
                    all_move_left();
                }
                else if (e.KeyCode == Keys.Right)
                {
                    all_move_right();
                    join_numbers_right();
                    all_move_right();
                }
                else if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Right && e.KeyCode != Keys.Left)
                    throw new Exception("Use arrows on keyboard.");
                generate_random_place(1);
                check_array();
            }
            catch(Exception obj_except)
            {
                MessageBox.Show(obj_except.Message);
            }
        }
        
        private void box_16_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
