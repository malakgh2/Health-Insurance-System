namespace loginn
{
    partial class admin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.months = new System.Windows.Forms.TextBox();
            this.year_somme = new System.Windows.Forms.TextBox();
            this.CALC = new System.Windows.Forms.Button();
            this.consulteremp = new System.Windows.Forms.Button();
            this.consultebulletin = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.suprimer = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.getmat = new System.Windows.Forms.TextBox();
            this.getbtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numtel = new System.Windows.Forms.TextBox();
            this.updatebtn = new System.Windows.Forms.Button();
            this.bb = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.mat = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.TextBox();
            this.cnam = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.nc = new System.Windows.Forms.TextBox();
            this.pnc = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.TextBox();
            this.etatc = new System.Windows.Forms.TextBox();
            this.nenfant = new System.Windows.Forms.TextBox();
            this.pname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resultset = new System.Windows.Forms.TextBox();
            this.imprimer = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(185, 428);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(720, 283);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(938, 151);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 21);
            this.label16.TabIndex = 126;
            this.label16.Text = "Annee";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(864, 191);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 21);
            this.label17.TabIndex = 125;
            this.label17.Text = "Mois (Optionel)";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(882, 230);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 21);
            this.label18.TabIndex = 124;
            this.label18.Text = "Resultat";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // months
            // 
            this.months.Location = new System.Drawing.Point(1010, 191);
            this.months.Margin = new System.Windows.Forms.Padding(4);
            this.months.Name = "months";
            this.months.Size = new System.Drawing.Size(87, 22);
            this.months.TabIndex = 122;
            this.months.TextChanged += new System.EventHandler(this.months_TextChanged);
            // 
            // year_somme
            // 
            this.year_somme.Location = new System.Drawing.Point(1011, 149);
            this.year_somme.Margin = new System.Windows.Forms.Padding(4);
            this.year_somme.Name = "year_somme";
            this.year_somme.Size = new System.Drawing.Size(87, 22);
            this.year_somme.TabIndex = 121;
            this.year_somme.TextChanged += new System.EventHandler(this.year_somme_TextChanged);
            // 
            // CALC
            // 
            this.CALC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CALC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CALC.ForeColor = System.Drawing.Color.White;
            this.CALC.Location = new System.Drawing.Point(1022, 88);
            this.CALC.Margin = new System.Windows.Forms.Padding(4);
            this.CALC.Name = "CALC";
            this.CALC.Size = new System.Drawing.Size(83, 47);
            this.CALC.TabIndex = 120;
            this.CALC.Text = "Calculer Somme";
            this.CALC.UseVisualStyleBackColor = false;
            this.CALC.Click += new System.EventHandler(this.supp_Click);
            // 
            // consulteremp
            // 
            this.consulteremp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.consulteremp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consulteremp.ForeColor = System.Drawing.Color.White;
            this.consulteremp.Location = new System.Drawing.Point(22, 512);
            this.consulteremp.Margin = new System.Windows.Forms.Padding(4);
            this.consulteremp.Name = "consulteremp";
            this.consulteremp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.consulteremp.Size = new System.Drawing.Size(125, 51);
            this.consulteremp.TabIndex = 119;
            this.consulteremp.Text = "Consult Par emp";
            this.consulteremp.UseVisualStyleBackColor = false;
            this.consulteremp.Click += new System.EventHandler(this.consulteremp_Click);
            // 
            // consultebulletin
            // 
            this.consultebulletin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.consultebulletin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultebulletin.ForeColor = System.Drawing.Color.White;
            this.consultebulletin.Location = new System.Drawing.Point(943, 512);
            this.consultebulletin.Margin = new System.Windows.Forms.Padding(4);
            this.consultebulletin.Name = "consultebulletin";
            this.consultebulletin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.consultebulletin.Size = new System.Drawing.Size(145, 59);
            this.consultebulletin.TabIndex = 118;
            this.consultebulletin.Text = "Consulter Bulletins";
            this.consultebulletin.UseVisualStyleBackColor = false;
            this.consultebulletin.Click += new System.EventHandler(this.consulteragent_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(706, 237);
            this.ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.ajouter.Name = "ajouter";
            this.ajouter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ajouter.Size = new System.Drawing.Size(112, 37);
            this.ajouter.TabIndex = 117;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // suprimer
            // 
            this.suprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.suprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suprimer.ForeColor = System.Drawing.Color.White;
            this.suprimer.Location = new System.Drawing.Point(706, 286);
            this.suprimer.Margin = new System.Windows.Forms.Padding(4);
            this.suprimer.Name = "suprimer";
            this.suprimer.Size = new System.Drawing.Size(112, 37);
            this.suprimer.TabIndex = 116;
            this.suprimer.Text = "Supprimer";
            this.suprimer.UseVisualStyleBackColor = false;
            this.suprimer.Click += new System.EventHandler(this.suprimer_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(122, -16);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 16);
            this.label15.TabIndex = 115;
            this.label15.Text = "numero";
            // 
            // getmat
            // 
            this.getmat.Location = new System.Drawing.Point(223, 88);
            this.getmat.Margin = new System.Windows.Forms.Padding(4);
            this.getmat.Name = "getmat";
            this.getmat.Size = new System.Drawing.Size(115, 22);
            this.getmat.TabIndex = 114;
            this.getmat.TextChanged += new System.EventHandler(this.getmat_TextChanged);
            // 
            // getbtn
            // 
            this.getbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.getbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.getbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getbtn.ForeColor = System.Drawing.Color.White;
            this.getbtn.Location = new System.Drawing.Point(363, 80);
            this.getbtn.Margin = new System.Windows.Forms.Padding(4);
            this.getbtn.Name = "getbtn";
            this.getbtn.Size = new System.Drawing.Size(102, 44);
            this.getbtn.TabIndex = 113;
            this.getbtn.Text = "Rechercher";
            this.getbtn.UseMnemonic = false;
            this.getbtn.UseVisualStyleBackColor = false;
            this.getbtn.Click += new System.EventHandler(this.getbtn_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(389, 303);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 112;
            this.label13.Text = "N° Tel";
            // 
            // numtel
            // 
            this.numtel.Location = new System.Drawing.Point(494, 303);
            this.numtel.Margin = new System.Windows.Forms.Padding(4);
            this.numtel.Name = "numtel";
            this.numtel.Size = new System.Drawing.Size(136, 22);
            this.numtel.TabIndex = 111;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.Location = new System.Drawing.Point(706, 334);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(4);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(112, 36);
            this.updatebtn.TabIndex = 108;
            this.updatebtn.Text = "Modifier";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.Font = new System.Drawing.Font("Georgia", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bb.ForeColor = System.Drawing.Color.BurlyWood;
            this.bb.Location = new System.Drawing.Point(502, 29);
            this.bb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(270, 35);
            this.bb.TabIndex = 107;
            this.bb.Text = "- Ciment Bizert -";
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(269, 375);
            this.month.Margin = new System.Windows.Forms.Padding(4);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(40, 22);
            this.month.TabIndex = 106;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(317, 375);
            this.year.Margin = new System.Windows.Forms.Padding(4);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(61, 22);
            this.year.TabIndex = 105;
            // 
            // mat
            // 
            this.mat.Location = new System.Drawing.Point(225, 244);
            this.mat.Margin = new System.Windows.Forms.Padding(4);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(119, 22);
            this.mat.TabIndex = 104;
            // 
            // cin
            // 
            this.cin.Location = new System.Drawing.Point(225, 287);
            this.cin.Margin = new System.Windows.Forms.Padding(4);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(119, 22);
            this.cin.TabIndex = 103;
            // 
            // cnam
            // 
            this.cnam.Location = new System.Drawing.Point(226, 332);
            this.cnam.Margin = new System.Windows.Forms.Padding(4);
            this.cnam.Name = "cnam";
            this.cnam.Size = new System.Drawing.Size(119, 22);
            this.cnam.TabIndex = 102;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(215, 375);
            this.day.Margin = new System.Windows.Forms.Padding(4);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(40, 22);
            this.day.TabIndex = 101;
            // 
            // nc
            // 
            this.nc.Location = new System.Drawing.Point(494, 155);
            this.nc.Margin = new System.Windows.Forms.Padding(4);
            this.nc.Name = "nc";
            this.nc.Size = new System.Drawing.Size(136, 22);
            this.nc.TabIndex = 100;
            // 
            // pnc
            // 
            this.pnc.Location = new System.Drawing.Point(494, 194);
            this.pnc.Margin = new System.Windows.Forms.Padding(4);
            this.pnc.Name = "pnc";
            this.pnc.Size = new System.Drawing.Size(136, 22);
            this.pnc.TabIndex = 99;
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(494, 231);
            this.grade.Margin = new System.Windows.Forms.Padding(4);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(136, 22);
            this.grade.TabIndex = 98;
            // 
            // adr
            // 
            this.adr.Location = new System.Drawing.Point(493, 375);
            this.adr.Margin = new System.Windows.Forms.Padding(4);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(136, 22);
            this.adr.TabIndex = 97;
            // 
            // etatc
            // 
            this.etatc.Location = new System.Drawing.Point(493, 341);
            this.etatc.Margin = new System.Windows.Forms.Padding(4);
            this.etatc.Name = "etatc";
            this.etatc.Size = new System.Drawing.Size(136, 22);
            this.etatc.TabIndex = 96;
            this.etatc.TextChanged += new System.EventHandler(this.etatc_TextChanged);
            // 
            // nenfant
            // 
            this.nenfant.Location = new System.Drawing.Point(493, 265);
            this.nenfant.Margin = new System.Windows.Forms.Padding(4);
            this.nenfant.Name = "nenfant";
            this.nenfant.Size = new System.Drawing.Size(136, 22);
            this.nenfant.TabIndex = 95;
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(223, 207);
            this.pname.Margin = new System.Windows.Forms.Padding(4);
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(119, 22);
            this.pname.TabIndex = 94;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(222, 161);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(119, 22);
            this.name.TabIndex = 93;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(378, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 21);
            this.label12.TabIndex = 92;
            this.label12.Text = "NB Enfants";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(381, 195);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 21);
            this.label11.TabIndex = 91;
            this.label11.Text = "Pr Conjoint";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 231);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(59, 21);
            this.label10.TabIndex = 90;
            this.label10.Text = "Grade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(132, 243);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 89;
            this.label9.Text = "matricule";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(166, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 21);
            this.label8.TabIndex = 88;
            this.label8.Text = "cin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 87;
            this.label7.Text = "code cnam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 374);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 21);
            this.label6.TabIndex = 86;
            this.label6.Text = "date de naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 85;
            this.label5.Text = "Nom Conjoint";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(398, 376);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 84;
            this.label4.Text = "Adresse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 83;
            this.label3.Text = "Etat Civile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "Nom";
            // 
            // resultset
            // 
            this.resultset.Location = new System.Drawing.Point(972, 230);
            this.resultset.Margin = new System.Windows.Forms.Padding(4);
            this.resultset.Name = "resultset";
            this.resultset.Size = new System.Drawing.Size(127, 22);
            this.resultset.TabIndex = 128;
            this.resultset.TextChanged += new System.EventHandler(this.resultset_TextChanged);
            // 
            // imprimer
            // 
            this.imprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.imprimer.Enabled = false;
            this.imprimer.ForeColor = System.Drawing.Color.White;
            this.imprimer.Location = new System.Drawing.Point(964, 577);
            this.imprimer.Margin = new System.Windows.Forms.Padding(4);
            this.imprimer.Name = "imprimer";
            this.imprimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.imprimer.Size = new System.Drawing.Size(104, 50);
            this.imprimer.TabIndex = 129;
            this.imprimer.Text = "Imprimer Bulletin";
            this.imprimer.UseVisualStyleBackColor = false;
            this.imprimer.Click += new System.EventHandler(this.imprimer_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(13, 14);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(116, 28);
            this.back.TabIndex = 130;
            this.back.Text = "<<<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(167, 89);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 21);
            this.label14.TabIndex = 131;
            this.label14.Text = "Num";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1042, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(54, 32);
            this.button1.TabIndex = 132;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1107, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.back);
            this.Controls.Add(this.imprimer);
            this.Controls.Add(this.resultset);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.months);
            this.Controls.Add(this.year_somme);
            this.Controls.Add(this.CALC);
            this.Controls.Add(this.consulteremp);
            this.Controls.Add(this.consultebulletin);
            this.Controls.Add(this.ajouter);
            this.Controls.Add(this.suprimer);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.getmat);
            this.Controls.Add(this.getbtn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numtel);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.month);
            this.Controls.Add(this.year);
            this.Controls.Add(this.mat);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.cnam);
            this.Controls.Add(this.day);
            this.Controls.Add(this.nc);
            this.Controls.Add(this.pnc);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.etatc);
            this.Controls.Add(this.nenfant);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "admin";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "test";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox months;
        private System.Windows.Forms.TextBox year_somme;
        private System.Windows.Forms.Button CALC;
        private System.Windows.Forms.Button consulteremp;
        private System.Windows.Forms.Button consultebulletin;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button suprimer;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox getmat;
        private System.Windows.Forms.Button getbtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numtel;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Label bb;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.TextBox mat;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.TextBox cnam;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox nc;
        private System.Windows.Forms.TextBox pnc;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox adr;
        private System.Windows.Forms.TextBox etatc;
        private System.Windows.Forms.TextBox nenfant;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resultset;
        private System.Windows.Forms.Button imprimer;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
    }
}