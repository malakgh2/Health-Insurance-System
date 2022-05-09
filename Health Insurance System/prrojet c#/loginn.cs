using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace loginn
{
    public partial class login : Form
    {  SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-0SPP7DJ\SQLEXPRESS;Initial Catalog=climentB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table= new DataTable();
        
        public login()
        {
            InitializeComponent();

        }

        public void Deconnecter()
        {
            if(cnx.State==ConnectionState.Open)
            {
                cnx.Close();
            }
        }

       public void RemplirGrid()

        {
            Deconnecter();
            cnx.Open();
            cmd=new SqlCommand("select * from climentB", cnx);
            Reader=cmd.ExecuteReader();
            table.Load(Reader);
            cnx.Close();
        }
        public int trouverE()
        {
            Deconnecter();
            cnx.Open();
            int x = 0;
            if (int.TryParse(user.Text, out int k))
            {
                cmd = new SqlCommand("Select count(*)from employee where matricule='" + user.Text + "' and cin='"+mdp.Text+"' ", cnx);
                x = (int)cmd.ExecuteScalar();
            }
            cnx.Close();
            return x;
        }
        public int trouverA()
        {
            Deconnecter();
            cnx.Open();
            int s = 0;
            
                cmd = new SqlCommand("Select count(*)from agentsocial where id='" + user.Text + "' and password1='" + mdp.Text + "' ", cnx);
                s = (int)cmd.ExecuteScalar();
            
            cnx.Close();
            return s;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void form1_Load(object sender, EventArgs e)
        {

        }

       //verification de login et mot de passe selon les box 

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (user.Text == "admin" && mdp.Text == "admin")
            {
               
                admin m1=new admin();
                m1.Show();
                this.Hide();
            }
            else
                if (trouverE() != 0)
                 {
                employ empp = new employ();
                 empp.Show();
                this.Hide();
                  }
                else 
                   if(trouverA() !=0)
                    {
                        agent ag1=new agent();
                        ag1.Show();
                        this.Hide();

                    }
                else
                      {
                         MessageBox.Show("verifier vos informations svp ");
                      }



        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
