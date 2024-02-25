namespace Art2._0
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.txt_nume = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.artistIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoalaDomeniuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anDebutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.judetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artaDataSet = new Art2._0.ArtaDataSet();
            this.txt_prenume = new System.Windows.Forms.TextBox();
            this.txt_scoala = new System.Windows.Forms.TextBox();
            this.txt_stil = new System.Windows.Forms.TextBox();
            this.txt_an = new System.Windows.Forms.TextBox();
            this.txt_CNP = new System.Windows.Forms.TextBox();
            this.txt_sex = new System.Windows.Forms.TextBox();
            this.txt_oras = new System.Windows.Forms.TextBox();
            this.txt_telefon = new System.Windows.Forms.TextBox();
            this.txt_judet = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.artistiTableAdapter = new Art2._0.ArtaDataSetTableAdapters.ArtistiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_nume
            // 
            this.txt_nume.Location = new System.Drawing.Point(571, 64);
            this.txt_nume.Name = "txt_nume";
            this.txt_nume.Size = new System.Drawing.Size(222, 22);
            this.txt_nume.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artistIDDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.scoalaDomeniuDataGridViewTextBoxColumn,
            this.stilDataGridViewTextBoxColumn,
            this.anDebutDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.orasDataGridViewTextBoxColumn,
            this.judetDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.artistiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 603);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // artistIDDataGridViewTextBoxColumn
            // 
            this.artistIDDataGridViewTextBoxColumn.DataPropertyName = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.HeaderText = "ArtistID";
            this.artistIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.artistIDDataGridViewTextBoxColumn.Name = "artistIDDataGridViewTextBoxColumn";
            this.artistIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.artistIDDataGridViewTextBoxColumn.Visible = false;
            this.artistIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.Width = 125;
            // 
            // scoalaDomeniuDataGridViewTextBoxColumn
            // 
            this.scoalaDomeniuDataGridViewTextBoxColumn.DataPropertyName = "ScoalaDomeniu";
            this.scoalaDomeniuDataGridViewTextBoxColumn.HeaderText = "ScoalaDomeniu";
            this.scoalaDomeniuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.scoalaDomeniuDataGridViewTextBoxColumn.Name = "scoalaDomeniuDataGridViewTextBoxColumn";
            this.scoalaDomeniuDataGridViewTextBoxColumn.Width = 125;
            // 
            // stilDataGridViewTextBoxColumn
            // 
            this.stilDataGridViewTextBoxColumn.DataPropertyName = "Stil";
            this.stilDataGridViewTextBoxColumn.HeaderText = "Stil";
            this.stilDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stilDataGridViewTextBoxColumn.Name = "stilDataGridViewTextBoxColumn";
            this.stilDataGridViewTextBoxColumn.Width = 125;
            // 
            // anDebutDataGridViewTextBoxColumn
            // 
            this.anDebutDataGridViewTextBoxColumn.DataPropertyName = "AnDebut";
            this.anDebutDataGridViewTextBoxColumn.HeaderText = "AnDebut";
            this.anDebutDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.anDebutDataGridViewTextBoxColumn.Name = "anDebutDataGridViewTextBoxColumn";
            this.anDebutDataGridViewTextBoxColumn.Width = 125;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.Width = 125;
            // 
            // orasDataGridViewTextBoxColumn
            // 
            this.orasDataGridViewTextBoxColumn.DataPropertyName = "Oras";
            this.orasDataGridViewTextBoxColumn.HeaderText = "Oras";
            this.orasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orasDataGridViewTextBoxColumn.Name = "orasDataGridViewTextBoxColumn";
            this.orasDataGridViewTextBoxColumn.Width = 125;
            // 
            // judetDataGridViewTextBoxColumn
            // 
            this.judetDataGridViewTextBoxColumn.DataPropertyName = "Judet";
            this.judetDataGridViewTextBoxColumn.HeaderText = "Judet";
            this.judetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.judetDataGridViewTextBoxColumn.Name = "judetDataGridViewTextBoxColumn";
            this.judetDataGridViewTextBoxColumn.Width = 125;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.Width = 125;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // artistiBindingSource
            // 
            this.artistiBindingSource.DataMember = "Artisti";
            this.artistiBindingSource.DataSource = this.artaDataSet;
            // 
            // artaDataSet
            // 
            this.artaDataSet.DataSetName = "ArtaDataSet";
            this.artaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_prenume
            // 
            this.txt_prenume.Location = new System.Drawing.Point(938, 64);
            this.txt_prenume.Name = "txt_prenume";
            this.txt_prenume.Size = new System.Drawing.Size(222, 22);
            this.txt_prenume.TabIndex = 2;
            // 
            // txt_scoala
            // 
            this.txt_scoala.Location = new System.Drawing.Point(571, 142);
            this.txt_scoala.Name = "txt_scoala";
            this.txt_scoala.Size = new System.Drawing.Size(222, 22);
            this.txt_scoala.TabIndex = 3;
            // 
            // txt_stil
            // 
            this.txt_stil.Location = new System.Drawing.Point(938, 142);
            this.txt_stil.Name = "txt_stil";
            this.txt_stil.Size = new System.Drawing.Size(222, 22);
            this.txt_stil.TabIndex = 4;
            // 
            // txt_an
            // 
            this.txt_an.Location = new System.Drawing.Point(571, 211);
            this.txt_an.Name = "txt_an";
            this.txt_an.Size = new System.Drawing.Size(222, 22);
            this.txt_an.TabIndex = 5;
            // 
            // txt_CNP
            // 
            this.txt_CNP.Location = new System.Drawing.Point(938, 211);
            this.txt_CNP.Name = "txt_CNP";
            this.txt_CNP.Size = new System.Drawing.Size(222, 22);
            this.txt_CNP.TabIndex = 6;
            // 
            // txt_sex
            // 
            this.txt_sex.Location = new System.Drawing.Point(571, 343);
            this.txt_sex.Name = "txt_sex";
            this.txt_sex.Size = new System.Drawing.Size(222, 22);
            this.txt_sex.TabIndex = 8;
            // 
            // txt_oras
            // 
            this.txt_oras.Location = new System.Drawing.Point(571, 274);
            this.txt_oras.Name = "txt_oras";
            this.txt_oras.Size = new System.Drawing.Size(222, 22);
            this.txt_oras.TabIndex = 7;
            // 
            // txt_telefon
            // 
            this.txt_telefon.Location = new System.Drawing.Point(938, 343);
            this.txt_telefon.Name = "txt_telefon";
            this.txt_telefon.Size = new System.Drawing.Size(222, 22);
            this.txt_telefon.TabIndex = 10;
            // 
            // txt_judet
            // 
            this.txt_judet.Location = new System.Drawing.Point(938, 274);
            this.txt_judet.Name = "txt_judet";
            this.txt_judet.Size = new System.Drawing.Size(222, 22);
            this.txt_judet.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(571, 409);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(222, 22);
            this.txt_email.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vonique64", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(471, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(825, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Prenume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(471, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Scoala";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(836, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(471, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "An Debut";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(836, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "CNP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(471, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Oras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(836, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Judet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(471, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sex";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(825, 343);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Nr.Telefon";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(471, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Email";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(475, 477);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(180, 46);
            this.btn_Insert.TabIndex = 23;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click_1);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(731, 477);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(180, 46);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click_1);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(980, 477);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(180, 46);
            this.btn_Delete.TabIndex = 25;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click_1);
            // 
            // artistiTableAdapter
            // 
            this.artistiTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
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
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefon);
            this.Controls.Add(this.txt_judet);
            this.Controls.Add(this.txt_sex);
            this.Controls.Add(this.txt_oras);
            this.Controls.Add(this.txt_CNP);
            this.Controls.Add(this.txt_an);
            this.Controls.Add(this.txt_stil);
            this.Controls.Add(this.txt_scoala);
            this.Controls.Add(this.txt_prenume);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_nume);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nume;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_prenume;
        private System.Windows.Forms.TextBox txt_scoala;
        private System.Windows.Forms.TextBox txt_stil;
        private System.Windows.Forms.TextBox txt_an;
        private System.Windows.Forms.TextBox txt_CNP;
        private System.Windows.Forms.TextBox txt_sex;
        private System.Windows.Forms.TextBox txt_oras;
        private System.Windows.Forms.TextBox txt_telefon;
        private System.Windows.Forms.TextBox txt_judet;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private ArtaDataSet artaDataSet;
        private System.Windows.Forms.BindingSource artistiBindingSource;
        private ArtaDataSetTableAdapters.ArtistiTableAdapter artistiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoalaDomeniuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anDebutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}