using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void music_CheckedChanged(object sender, EventArgs e)
        {
            if (music.Checked == true)
                listBox1.Items.Add(music.Text);
            else
                listBox1.Items.Remove(music.Text);
        }

        private void game_CheckedChanged(object sender, EventArgs e)
        {
            if (game.Checked == true)
                listBox1.Items.Add(game.Text);
            else
                listBox1.Items.Remove(game.Text);
        }

        private void film_CheckedChanged(object sender, EventArgs e)
        {
            if (film.Checked == true)
                listBox1.Items.Add(film.Text);
            else
                listBox1.Items.Remove(film.Text);
        }

        private void book_CheckedChanged(object sender, EventArgs e)
        {
            if (book.Checked == true)
                listBox1.Items.Add(book.Text);
            else
                listBox1.Items.Remove(book.Text);
        }

        private void train_CheckedChanged(object sender, EventArgs e)
        {
            if (train.Checked == true)
                listBox1.Items.Add(train.Text);
            else
                listBox1.Items.Remove(train.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                MessageBox.Show("You like " + radioButton1.Text , "Favourite color", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("You like " + radioButton2.Text , "Favourite color", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
