using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_soluation01
{
    public partial class Form1 : Form
    {
        List<Movie> movies = new List<Movie>();
        User user;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
            private void btnAddMovie_Click(object sender, EventArgs e)
        {
            try
            {
                Movie m = new Movie(
                    txtTitle.Text,
                    txtGenre.Text,
                    int.Parse(txtRating.Text)
                );

                movies.Add(m);
                listBoxMovies.Items.Add(m.Title);

                MessageBox.Show("Movie Added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        

        private void btnWatch_Click(object sender, EventArgs e)
        {
            if (user == null)
                user = new User(txtName.Text);

            if (listBoxMovies.SelectedIndex == -1)
            {
                MessageBox.Show("Select a movie");
                return;
            }

            Movie m = movies[listBoxMovies.SelectedIndex];
            user.WatchMovie(m);

            MessageBox.Show($"{user.Name} is watching {m.Title}");
        }
        

        private void btnRate_Click(object sender, EventArgs e)
        {

            try
            {
                if (listBoxMovies.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a movie");
                    return;
                }

                Movie m = movies[listBoxMovies.SelectedIndex];
                int rate = int.Parse(txtRating.Text);

                user.RateMovie(m, rate);

                MessageBox.Show("Movie Rated!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
