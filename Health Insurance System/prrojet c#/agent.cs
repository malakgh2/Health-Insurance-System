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
using System.IO;
using System.Collections;


namespace loginn
{
    public partial class agent : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-0SPP7DJ\SQLEXPRESS;Initial Catalog=climentB;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader Reader;
        DataTable table = new DataTable();
        public agent()
        {
            InitializeComponent();
            RemplirGrid();
        }

        public void Deconnecter()
        {
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
        }
        public void RemplirGrid()
        {
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select * from bulletin", cnx);
            Reader = cmd.ExecuteReader();
            table.Load(Reader);
            dataGridView1.DataSource = table;
            cnx.Close();
        }
        public void RemplirGridE()
        {
            Deconnecter();
            cnx.Open();
            DateTime date = dateTimePicker1.Value; ;
            date.ToString("yyyy,MM,dd");
           

            if (tb_num.Text != "")
            {

                cmd = new SqlCommand("select * from bulletin where  numéro='" + tb_num.Text + "'", cnx);
                Reader = cmd.ExecuteReader();
                table.Clear();
                table.Load(Reader);
                dataGridView1.DataSource = table;
                cnx.Close();
            }
            else
            {
               
                cmd = new SqlCommand("select * from bulletin where employé='" + tb_empM.Text + "' and date_depot='"+date+"'", cnx);
               
                Reader = cmd.ExecuteReader();
                table.Clear();
                table.Load(Reader);
                dataGridView1.DataSource = table;
                cnx.Close();
            }
        }
        // methode qui cree un rapport pour un bulletin donné
        public void remplirRapport()
           
        {
            Deconnecter();
            cnx.Open();
           
            DateTime date;
            float solde;
            string decision1=decision();
            float reste;

            date = dateTimePicker1.Value;
            string dt2 = date.ToString("yyyy-MM-dd");
            string dt = (string)date.ToString("yyyy-MM-dd");
            cmd = new SqlCommand("select reste from bulletin where numéro='" + tb_num.Text + "'", cnx);
            object obj7 = (object)cmd.ExecuteScalar();
            solde = (float)Convert.ToDouble(obj7);
            cmd = new SqlCommand("select reste from bulletin where numéro ='" + tb_num.Text + "'", cnx);
            object obj8 = (object)cmd.ExecuteScalar();
            reste = (float)Convert.ToDouble(obj8);




           
           ;
            
            cmd = new SqlCommand("insert into rapport values('"+tb_num.Text+"','" + decision1 + "','" + tb_empM.Text + "','" + dt2 + "','"+reste+"')", cnx);
            int i = cmd.ExecuteNonQuery();
            cnx.Close();
                
            }
           

        
       
        //permet de connaitre si la date de depot a eté modifié
        public bool date1()
        {
            bool check = false;
            Deconnecter();
            cnx.Open();
            cmd = new SqlCommand("select date_Depot from bulletin where numéro='" + tb_num.Text + "'", cnx);
            object obj3 = (object)cmd.ExecuteScalar();
            DateTime dat = Convert.ToDateTime(obj3);
            string dt1 = (string)dat.ToString("MM,dd,YYYY");
            string dt2 = (string)dateTimePicker1.Value.ToString("MM,dd,YYYY");
            string dt3 = (string)dateTimePicker1.Value.Year.ToString();
            
            if (string.Compare(dt1, dt2) != 0&& dt3=="2022")
            {
                check = true;
            }
            return check;
                
           



        }
        //recherche le numero d'employe qui a la  numero de facture demandé
        public int recherche()
        {
            Deconnecter();
            cnx.Open();
           DateTime date = dateTimePicker1.Value;
            string dt2 = date.ToString("yyyy-MM-dd");
            cmd = new SqlCommand("select count(*) from bulletin  where date_Depot='" + dt2 + "'", cnx);
            object obj2 = (object)cmd.ExecuteScalar();
            int numb = (int)Convert.ToInt16(obj2);
            cnx.Close();
            return numb;

        }
        public int trouver()
        { Deconnecter();
            cnx.Open();
            int x = 0;
            if (int.TryParse(tb_num.Text, out int k))
            {
                cmd = new SqlCommand("Select count(*)from bulletin where numéro='" + tb_num.Text + "'", cnx);
                 x = (int)cmd.ExecuteScalar();
            }
            cnx.Close();
            return x;
        }
        public int trouverE()
        {
            int y = 0;
            Deconnecter();
            cnx.Open();
            if (int.TryParse(tb_empM.Text, out int ne)) { 
                cmd = new SqlCommand("select count(*) from employee where matricule ='" + tb_empM.Text + "'", cnx);
            y = (int)cmd.ExecuteScalar(); }
            cnx.Close();
            return y;
        }
        
        public void renitialissation()
        {
            tb_num.Clear();
            tb_frais.Clear();
            tb_empM.Clear();
            tb_acte.Clear();
          
        }
      
        // decide si elle approuve ou rejette la demande selon le matricule dans la table employee
        public  string decision()
        {
            String date = dateTimePicker1.Value.Year.ToString();
            int grade;
            float solde;
            float soldecopy;
            int numb;
            float reste=0;
            DataTable table2 =  new DataTable();
            DataRow row = table2.NewRow();


            Deconnecter();
            cnx.Open();
           
            cmd = new SqlCommand("select grade from employee where matricule='" + tb_empM.Text + "'", cnx);
            object obj4 = (object)cmd.ExecuteScalar();
            grade = (int)Convert.ToInt16(obj4);

            string frais = tb_frais.Text.ToString().Trim();
            float f = float.Parse(frais);
            f = (float)(f * 0.3);
            string decision = "";
           
           
            cmd = new SqlCommand("select count(*) from bulletin where year(date_depot)='" + date + "' and employé ='"+tb_empM.Text+"'", cnx);
            object obj3 = (object)cmd.ExecuteScalar();
            numb = (int)Convert.ToInt16(obj3);

            if (numb == 1)
            {
                if (grade == 1)
                {
                    reste = 1800;
                    
                }
                else if (grade == 2)
                {
                    reste = 1400;
                }
                else if (grade == 3)
                {
                    reste = 1000;
                }
                else
                {
                    reste = 600;
                }
               
                if (reste<f )
                {
                    decision = "refusé";
                    cmd = new SqlCommand("update bulletin set reste='" + reste + "'where numéro ='" + tb_num.Text + "'", cnx);
                    int i = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update rapport set reste='" + reste + "'where num_demande ='" + tb_num.Text + "'", cnx);
                    i = cmd.ExecuteNonQuery();




                }
                else
                {  
                    reste = (float)(reste - f);
                    cmd = new SqlCommand("update bulletin set reste='" + reste + "' where employé='" + tb_empM.Text + "' and year(date_depot)='"+date+"' ", cnx);
                    int j = cmd.ExecuteNonQuery();
                    decision = "approuvé";
                    
                }
            }
            else
            {
                cmd = new SqlCommand("select reste from bulletin where employé ='" + tb_empM.Text + "' and year(date_depot)='"+date+"'", cnx);
                Reader = cmd.ExecuteReader();
                table2.Load(Reader);

                object obj7 = (object)table2.Rows[0][0] ;
                reste = (float)Convert.ToDouble(obj7);
               
                if ( reste<f)
                {
                    decision = "refusé";
                    


                }
                else
                {
                   
                    reste = (float)(reste - f);
                    decision = "approuvé";
                 
                    cmd = new SqlCommand("update bulletin set reste='" + reste + "' where year(date_depot)='" + date + "' and employé='"+tb_empM.Text+"' ", cnx);
                    int m = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update rapport set reste ='" + reste + "' where year(date_Depot)='" + date + "' and matricule='"+tb_empM.Text+"'", cnx);
                    m = cmd.ExecuteNonQuery();

                }


            }

            
            return decision ;
         
            cnx.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            string numero = tb_num.Text.ToString().Trim();
          
            string acte = tb_acte.Text.ToString().Trim();
            string matricule = tb_empM.Text.ToString().Trim();
            string frais = tb_frais.Text.ToString().Trim();
            
            DateTime date = dateTimePicker1.Value;
            date.ToString("yyyy-MM-dd");

            int num = 0;
           
            float fr;
            int matr;
           
            bool erreur = false;


                         if (!int.TryParse(numero, out num) || !int.TryParse(matricule, out matr) || !float.TryParse(frais, out fr))
            {
                erreur = true;
                MessageBox.Show("verifier vos donnes", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
           else if (numero == ""  || matricule == "" || frais == "" || float.Parse(frais) <= 0||acte=="" )
            {
                erreur = true;
                MessageBox.Show("veiller reesessir les donnes", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (trouver() != 0)
            {
                MessageBox.Show("ce numero de bulletin deja existe", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erreur = true;

            }
            else if (trouverE() == 0)
            {
                MessageBox.Show("employé inexistant!", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erreur = true;

            }
            if (erreur==false)
            {
                Deconnecter();
                cnx.Open();
                Double fraisprc = double.Parse(frais);
                fraisprc = fraisprc * 0.3 ;
            
                cmd = new SqlCommand("insert into bulletin values('" + tb_num.Text + "','" + tb_acte.Text + "','" + date + "','" + fraisprc+ "','" + tb_empM.Text + "','"+0+"')", cnx);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("ajout reussi", "felecitation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    remplirRapport();

                }
                else
                {
                    MessageBox.Show("probleme d'insertion", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cnx.Close();
                table.Clear();
                RemplirGrid();
                renitialissation();
            }
        }

        private void bt_nouveau_Click(object sender, EventArgs e)
        {
            renitialissation();
            table.Clear();
            RemplirGrid();
            
          
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            if (trouver() == 0)
            {
                MessageBox.Show("merci de verifier", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Deconnecter();
                cnx.Open();

                cmd = new SqlCommand("delete from bulletin where numéro='" + tb_num.Text + "'", cnx);
                int i = cmd.ExecuteNonQuery();

                MessageBox.Show("suppresion effectue avec succes", "bravo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                table.Clear();
                RemplirGrid();
                cnx.Close();
                renitialissation();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        // decide si elle approuve ou  rejette la demande selon le numero employé dans la table bulletin
        public int decisionB(int num,int niveau)
        {

            String date = dateTimePicker1.Value.Year.ToString();
            float grade=0;
            float grade2 = 0;
            float solde;
            float soldecopy;
            int numb;
            float reste = 0;
            float frais = 0;
            float reste2 = 0;
            float reste3 = 0;
            int numemp;
            int modif = 0;
            DataTable table2 = new DataTable();
            DataRow row = table2.NewRow();
            int j = 0;
            string fr = tb_frais.Text.ToString().Trim();
      
            Deconnecter();
            cnx.Open();

            cmd = new SqlCommand("select frais from bulletin where numéro='" + tb_num.Text + "'", cnx);
            object obj1 = (object)cmd.ExecuteScalar();
            frais= (float)Convert.ToDouble(obj1);
            cmd = new SqlCommand("select date_Depot from bulletin where numéro='" + tb_num.Text + "'", cnx);
            object obj2 = (object)cmd.ExecuteScalar();
            DateTime dat = Convert.ToDateTime(obj2);
            string dt1 = (string)dat.ToString("yyyy");
            
            cmd = new SqlCommand("select reste from bulletin where numéro ='" + tb_num.Text + "'", cnx);
            object obj7 = (object)cmd.ExecuteScalar();
            reste3 = (float)Convert.ToDouble(obj7);

            cmd = new SqlCommand("select count(*) from bulletin where year(date_depot)='" + dt1 + "' and employé ='" + tb_empM.Text + "'", cnx);
            object obj4 = (object)cmd.ExecuteScalar();
            numb = (int)Convert.ToInt16(obj4);

            if (tb_empM.Text != "" && numb>=1)
            {

                cmd = new SqlCommand("select reste from bulletin where employé='" + tb_empM.Text + "' and year(date_depot)='"+dt1+"'", cnx);
                Reader = cmd.ExecuteReader();
                table2.Load(Reader);

                object obj3 = (object)table2.Rows[0][0];
               

                reste = (float)Convert.ToDouble(obj3);
            }
            if (tb_empM.Text != "" && numb == 0)
            {
                cmd = new SqlCommand("select solde from employee where matricule='" + tb_empM.Text + "'", cnx);
                object obj12 = cmd.ExecuteScalar();
                reste = (int)Convert.ToInt16(obj12);
            }
            if (numb == 0)
            {
                cmd = new SqlCommand("select solde from employee where matricule ='" + num + "'", cnx);
                object obj5 = (object)cmd.ExecuteScalar();
               grade = (int)Convert.ToInt16(obj5);
                grade2 = grade;
                
            }
            if (niveau == 1)
            {

                if ((grade > frais) && numb == 0)
                {
                    grade2 -= frais;
                    cmd = new SqlCommand("update bulletin set reste='" + grade2 + "'where numéro='" + tb_num.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update rapport set reste='" + grade2 + "', matricule ='"+tb_empM.Text+"' where num_demande='"+tb_num.Text+"'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update  bulletin set frais='" + frais + "'where numéro='" + tb_num.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update  bulletin set employé='" + tb_empM.Text + "'where numéro='" + tb_num.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    modif++;
                    cmd = new SqlCommand("update bulletin set reste = reste +'" + frais + "' where employé ='" + num + "' and year(date_depot)= '"+dt1+"'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update rapport set reste = reste +'" + frais + "' where matricule ='" + num + "' and year(date_depot)= '" + dt1 + "'", cnx);
                    j = cmd.ExecuteNonQuery();




                }
                else if ((reste > frais) && niveau == 1 && numb != 0)

                {
                    reste -= frais;
                    cmd = new SqlCommand("update bulletin set reste='" + reste + "' where year(date_depot)='" + dt1 + "' and employé='" + tb_empM.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update bulletin set reste='" + reste + "' where numéro ='"+tb_num.Text+"'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update rapport set reste='" + reste + "' where num_demande='" + tb_num.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update  bulletin set frais='" + frais + "'where numéro='" + tb_num.Text + "'", cnx);
                    j= cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update  bulletin set employé='" + tb_empM.Text + "'where numéro='" + tb_num.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    modif++;
                    cmd = new SqlCommand("update bulletin set reste = reste +'" + frais + "' where employé ='" + num + "' and year(date_depot)= '" + dt1 + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update rapport set reste = reste +'" + frais + "' where matricule ='" + num + "' and year(date_depot)= '" + dt1 + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("modifcation impossible", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            if (niveau == 2)
            {
                Double f = double.Parse(fr);
                f = f * 0.3;
                if (reste3 > f )
                {
                    reste3 += frais;
                    reste3 = (float)(reste3 - f);
                    cmd = new SqlCommand("update bulletin set reste='" + reste3 + "' where year(date_depot)='" + dt1 + "' and employé='" +num + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update rapport set reste ='" + reste3 + "' where num_demande='" + tb_num.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("update  bulletin set frais='" + tb_frais.Text + "'where numéro='" + tb_num.Text + "'", cnx);
                    j = cmd.ExecuteNonQuery();
                    modif++;
                }

                else
                {
                    MessageBox.Show("modifcation impossible", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            return modif;
            Deconnecter();
            cnx.Open();
            cnx.Close();

        }
        private void bt_modifier_Click(object sender, EventArgs e)
        {
            int i, y, z,o,p, modif = 0;
            
            DateTime date;
            float solde;
            int numemp;
           


            

            if (tb_num.Text == "" && tb_frais.Text == "" && tb_empM.Text == "" && tb_acte.Text == "")
            {
                MessageBox.Show("ERREUR", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Deconnecter();
                cnx.Open();
                cmd = new SqlCommand("select employé from bulletin where numéro='" + tb_num.Text + "'", cnx);
                object obj10 = (object)cmd.ExecuteScalar();
                numemp = (int)Convert.ToInt16(obj10);

                date = dateTimePicker1.Value;
                string dt2 = date.ToString("yyyy-MM-dd");
                string dt = (string)date.ToString("yyyy-MM-dd");
                cmd = new SqlCommand("select reste from bulletin where numéro='" + tb_num.Text + "'", cnx);
                object obj7 = (object)cmd.ExecuteScalar();
                solde = (float)Convert.ToDouble(obj7);


                if (trouver() == 0)
                {
                    MessageBox.Show("facture inexistant", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if ((tb_frais.Text.ToString() != "") && (float.TryParse(tb_frais.Text, out float f)))
                    {

                        cnx.Open();
                        modif = decisionB(numemp, 2);

                    }
                    else if ((tb_empM.Text.ToString() != "") && (trouverE() != 0))
                    {
                        modif = decisionB(numemp, 1);
                        Deconnecter();
                        cnx.Open();


                    }
                    else if ((tb_acte.Text != "") && (!int.TryParse(tb_acte.Text, out int g)))
                    {
                        cnx.Open();
                        cmd = new SqlCommand("update  bulletin set acte ='" + tb_acte.Text + "'where numéro='" + tb_num.Text + "'", cnx);
                        o = cmd.ExecuteNonQuery();
                        modif++;
                    }
                    else if (date1() == true)
                    {
                        Deconnecter();
                        cnx.Open();
                        DateTime d = dateTimePicker1.Value;
                        d.ToString("yyyy-MM-dd");
                        cmd = new SqlCommand("update  bulletin set date_Depot ='" + d + "'where numéro='" + tb_num.Text + "'", cnx);
                        p = cmd.ExecuteNonQuery();
                        modif++;
                    }

                    else
                    {
                        MessageBox.Show("erreur de modification", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
               
            if (modif!=0) { 
                MessageBox.Show("modif reussi", "felecitation", MessageBoxButtons.OK, MessageBoxIcon.Information);}
                table.Clear();
                RemplirGrid();
                renitialissation();
                cnx.Close();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deconnecter();
            cnx.Open();
            if ((trouver()!=0)||(recherche()!=0))
            {
                
                RemplirGridE();
                
            }
            else
            {
                MessageBox.Show("employé inexistant", "attention", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            cnx.Close();
        }

        private void bt_rapport_Click(object sender, EventArgs e)
        {
            
        }

        private void tb_frais_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            login log= new login();
            log.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
