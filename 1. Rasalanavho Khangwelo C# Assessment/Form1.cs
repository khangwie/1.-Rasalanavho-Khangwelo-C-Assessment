using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Rasalanavho_Khangwelo_C__Assessment
{
    public partial class Form1 : Form
    {
        List<string> wordList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            button2.Text = "Concatenate";
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newWord = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newWord))
            {
                MessageBox.Show("Please enter a word.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (wordList.Contains(newWord))
            {
                MessageBox.Show("This word has already been added.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            wordList.Add(newWord);

            textBox1.Clear();

            // Update comboSelectWord
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(wordList.ToArray());

            // Update comboSelectAnotherWord
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(wordList.ToArray());

            MessageBox.Show("New word added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        
    }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                button2.Text = "Remove Item";

            }
            else
            {
                button2.Text = "Concatenate";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button2.Text = "Remove Item";
            }
            else
            {
             
                button2.Text = "Concatenate";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                string selectedWord = null;

                if (radioButton1.Checked) 
                {
                    selectedWord = comboBox1.SelectedItem as string;

                }
                else if (radioButton2.Checked)
                   
                {
                    selectedWord = comboBox2.SelectedItem as string;

                }

                if (selectedWord == null)
                {
                    MessageBox.Show("Please select a word from the ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (radioButton1.Checked)
                {
                    comboBox1.Items.Remove(selectedWord);

                }
                else if (radioButton2.Checked)
                {
                    comboBox2.Items.Remove(selectedWord);

                }

                MessageBox.Show("Word removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {
                string selectedWord1 = comboBox1.SelectedItem as string;
                string selectedWord2 = comboBox2.SelectedItem as string;

                if (selectedWord1 == null || selectedWord2 == null)
                {
                    MessageBox.Show("Please select words from both ComboBoxes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string concatenatedWords = selectedWord1 + selectedWord2;

                textBox2.Text = concatenatedWords;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
        
    
