namespace loginn
{
    partial class agent
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
            this.bt_ajouter = new System.Windows.Forms.Button();
            this.bt_nouveau = new System.Windows.Forms.Button();
            this.bt_modifier = new System.Windows.Forms.Button();
            this.bt_supprimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_num = new System.Windows.Forms.TextBox();
            this.tb_empM = new System.Windows.Forms.TextBox();
            this.tb_frais = new System.Windows.Forms.TextBox();
            this.tb_acte = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bt_chercher = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ajouter
            // 
            this.bt_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_ajouter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bt_ajouter.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajouter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_ajouter.Location = new System.Drawing.Point(517, 27);
            this.bt_ajouter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_ajouter.Name = "bt_ajouter";
            this.bt_ajouter.Size = new System.Drawing.Size(168, 47);
            this.bt_ajouter.TabIndex = 0;
            this.bt_ajouter.Text = "Ajouter";
            this.bt_ajouter.UseVisualStyleBackColor = false;
            this.bt_ajouter.Click += new System.EventHandler(this.bt_ajouter_Click);
            // 
            // bt_nouveau
            // 
            this.bt_nouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_nouveau.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nouveau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_nouveau.Location = new System.Drawing.Point(620, 235);
            this.bt_nouveau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_nouveau.Name = "bt_nouveau";
            this.bt_nouveau.Size = new System.Drawing.Size(179, 49);
            this.bt_nouveau.TabIndex = 1;
            this.bt_nouveau.Text = "Actualiser";
            this.bt_nouveau.UseVisualStyleBackColor = false;
            this.bt_nouveau.Click += new System.EventHandler(this.bt_nouveau_Click);
            // 
            // bt_modifier
            // 
            this.bt_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_modifier.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modifier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_modifier.Location = new System.Drawing.Point(747, 25);
            this.bt_modifier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_modifier.Name = "bt_modifier";
            this.bt_modifier.Size = new System.Drawing.Size(188, 49);
            this.bt_modifier.TabIndex = 2;
            this.bt_modifier.Text = "Modifier";
            this.bt_modifier.UseVisualStyleBackColor = false;
            this.bt_modifier.Click += new System.EventHandler(this.bt_modifier_Click);
            // 
            // bt_supprimer
            // 
            this.bt_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_supprimer.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_supprimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_supprimer.Location = new System.Drawing.Point(747, 137);
            this.bt_supprimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_supprimer.Name = "bt_supprimer";
            this.bt_supprimer.Size = new System.Drawing.Size(188, 49);
            this.bt_supprimer.TabIndex = 3;
            this.bt_supprimer.Text = "Supprimer";
            this.bt_supprimer.UseVisualStyleBackColor = false;
            this.bt_supprimer.Click += new System.EventHandler(this.bt_supprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(32, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MinimumSize = new System.Drawing.Size(133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numéro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MinimumSize = new System.Drawing.Size(133, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 123);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date de depot";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(32, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Acte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(30, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Frais ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(27, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employé";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_num
            // 
            this.tb_num.Location = new System.Drawing.Point(179, 57);
            this.tb_num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_num.Name = "tb_num";
            this.tb_num.Size = new System.Drawing.Size(132, 22);
            this.tb_num.TabIndex = 9;
            // 
            // tb_empM
            // 
            this.tb_empM.Location = new System.Drawing.Point(179, 199);
            this.tb_empM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_empM.Name = "tb_empM";
            this.tb_empM.Size = new System.Drawing.Size(132, 22);
            this.tb_empM.TabIndex = 11;
            // 
            // tb_frais
            // 
            this.tb_frais.Location = new System.Drawing.Point(179, 252);
            this.tb_frais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_frais.Name = "tb_frais";
            this.tb_frais.Size = new System.Drawing.Size(132, 22);
            this.tb_frais.TabIndex = 12;
            this.tb_frais.TextChanged += new System.EventHandler(this.tb_frais_TextChanged);
            // 
            // tb_acte
            // 
            this.tb_acte.Location = new System.Drawing.Point(179, 148);
            this.tb_acte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_acte.Name = "tb_acte";
            this.tb_acte.Size = new System.Drawing.Size(132, 22);
            this.tb_acte.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(60, 333);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(834, 244);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 103);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(132, 22);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // bt_chercher
            // 
            this.bt_chercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bt_chercher.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chercher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_chercher.Location = new System.Drawing.Point(517, 130);
            this.bt_chercher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_chercher.Name = "bt_chercher";
            this.bt_chercher.Size = new System.Drawing.Size(168, 49);
            this.bt_chercher.TabIndex = 17;
            this.bt_chercher.Text = "Chercher";
            this.bt_chercher.UseVisualStyleBackColor = false;
            this.bt_chercher.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Black;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(0, 0);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(103, 28);
            this.back.TabIndex = 18;
            this.back.Text = "<<<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(951, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.bt_chercher);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_acte);
            this.Controls.Add(this.tb_frais);
            this.Controls.Add(this.tb_empM);
            this.Controls.Add(this.tb_num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_supprimer);
            this.Controls.Add(this.bt_modifier);
            this.Controls.Add(this.bt_nouveau);
            this.Controls.Add(this.bt_ajouter);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "agent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "agent";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ajouter;
        private System.Windows.Forms.Button bt_nouveau;
        private System.Windows.Forms.Button bt_modifier;
        private System.Windows.Forms.Button bt_supprimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_num;
        private System.Windows.Forms.TextBox tb_empM;
        private System.Windows.Forms.TextBox tb_frais;
        private System.Windows.Forms.TextBox tb_acte;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bt_chercher;
        private System.Windows.Forms.Button back;
    }
}

