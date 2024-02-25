namespace Art2._0
{
    partial class Form8
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
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
            this.artistiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.artaDataSet = new Art2._0.ArtaDataSet();
            this.artistiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artistiTableAdapter = new Art2._0.ArtaDataSetTableAdapters.ArtistiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(811, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(371, 603);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(43, 383);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(381, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(43, 488);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(381, 24);
            this.comboBox3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vonique64", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(608, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Vonique64", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(608, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "SHOW";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Vonique64", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(608, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "SHOW";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Vonique64", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(608, 469);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 44);
            this.button4.TabIndex = 11;
            this.button4.Text = "SHOW";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView2.DataSource = this.artistiBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(43, 186);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(487, 118);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick_1);
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
            // artistiBindingSource1
            // 
            this.artistiBindingSource1.DataMember = "Artisti";
            this.artistiBindingSource1.DataSource = this.artaDataSet;
            // 
            // artaDataSet
            // 
            this.artaDataSet.DataSetName = "ArtaDataSet";
            this.artaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // artistiBindingSource
            // 
            this.artistiBindingSource.DataMember = "Artisti";
            this.artistiBindingSource.DataSource = this.artaDataSet;
            // 
            // artistiTableAdapter
            // 
            this.artistiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Afisare artisti in ordine crescatoare in functie de numarul \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(39, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(445, 66);
            this.label2.TabIndex = 14;
            this.label2.Text = "Afisare clienti ce au achizitionat tablouri de la artistul: (selectati artistul)\r" +
    "\n\r\n\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(39, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(409, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Afisare tablouri din cadrul unei expozitii cu tema:(selectati tema)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(39, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(436, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Afisare sali ce au fost folosite pentru expozitii in anul : (selectati anul)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "tablourilor aduse in cadrul muzeului";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artistiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ArtaDataSet artaDataSet;
        private System.Windows.Forms.BindingSource artistiBindingSource;
        private ArtaDataSetTableAdapters.ArtistiTableAdapter artistiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.BindingSource artistiBindingSource1;
    }
}