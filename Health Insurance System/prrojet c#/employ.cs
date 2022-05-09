using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace loginn
{
    public partial class employ : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=desktop-0spp7dj\sqlexpress;Initial Catalog=climentB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public employ()
        {
            InitializeComponent();
        }
        public int trouverRep()
        {
            cnx.Open();
            int x = 0;
            if (int.TryParse(matricule.Text, out int k))
            {
                cmd = new SqlCommand("Select count(*) from rapport where matricule='" + matricule.Text + "' and date_Depot='" + dateTimePicker1.Text + "' ", cnx);
                x = (int)cmd.ExecuteScalar();
            }
            cnx.Close();
            return x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (trouverRep() != 0)
            {
                cnx.Open();
                string sql = ("Select rapport_ligne, reste from rapport where matricule='" + matricule.Text + "' and date_Depot='" + dateTimePicker1.Text + "' ");
                SqlCommand cmd = new SqlCommand(sql, cnx);
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        label5.Text = dr["rapport_ligne"].ToString();
                        label7.Text = dr["reste"].ToString();
                    }

                }
                cnx.Close();

            }
            else
            {
                MessageBox.Show("pas de reponse");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void depot_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            login lgg = new login();
            lgg.Show();
            this.Hide();
        }
    }
}
