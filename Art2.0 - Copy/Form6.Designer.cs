namespace Art2._0
{
    partial class Form6
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
            this.artaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artaDataSet = new Art2._0.ArtaDataSet();
            this.txt_titlu = new System.Windows.Forms.TextBox();
            this.txt_tema = new System.Windows.Forms.TextBox();
            this.txt_pret = new System.Windows.Forms.TextBox();
            this.txt_inceput = new System.Windows.Forms.TextBox();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expozitieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretBiletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInceputDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expozitiiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.artaDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.expozitiiTableAdapter = new Art2._0.ArtaDataSetTableAdapters.ExpozitiiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expozitiiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // artaDataSetBindingSource
            // 
            this.artaDataSetBindingSource.DataSource = this.artaDataSet;
            this.artaDataSetBindingSource.Position = 0;
            // 
            // artaDataSet
            // 
            this.artaDataSet.DataSetName = "ArtaDataSet";
            this.artaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_titlu
            // 
            this.txt_titlu.Location = new System.Drawing.Point(734, 73);
            this.txt_titlu.Name = "txt_titlu";
            this.txt_titlu.Size = new System.Drawing.Size(269, 22);
            this.txt_titlu.TabIndex = 1;
            // 
            // txt_tema
            // 
            this.txt_tema.Location = new System.Drawing.Point(734, 124);
            this.txt_tema.Name = "txt_tema";
            this.txt_tema.Size = new System.Drawing.Size(269, 22);
            this.txt_tema.TabIndex = 2;
            // 
            // txt_pret
            // 
            this.txt_pret.Location = new System.Drawing.Point(734, 188);
            this.txt_pret.Name = "txt_pret";
            this.txt_pret.Size = new System.Drawing.Size(269, 22);
            this.txt_pret.TabIndex = 3;
            // 
            // txt_inceput
            // 
            this.txt_inceput.Location = new System.Drawing.Point(734, 252);
            this.txt_inceput.Name = "txt_inceput";
            this.txt_inceput.Size = new System.Drawing.Size(269, 22);
            this.txt_inceput.TabIndex = 4;
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(734, 305);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(269, 22);
            this.txt_final.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(574, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Titlu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(574, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(574, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pret bilet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(574, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Inceput";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Vonique64", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(574, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Final";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(441, 408);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(175, 45);
            this.btn_Insert.TabIndex = 11;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(667, 408);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(175, 45);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(895, 408);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(175, 45);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expozitieIDDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.temaDataGridViewTextBoxColumn,
            this.pretBiletDataGridViewTextBoxColumn,
            this.dataInceputDataGridViewTextBoxColumn,
            this.dataFinalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expozitiiBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(389, 603);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // expozitieIDDataGridViewTextBoxColumn
            // 
            this.expozitieIDDataGridViewTextBoxColumn.DataPropertyName = "ExpozitieID";
            this.expozitieIDDataGridViewTextBoxColumn.HeaderText = "ExpozitieID";
            this.expozitieIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expozitieIDDataGridViewTextBoxColumn.Name = "expozitieIDDataGridViewTextBoxColumn";
            this.expozitieIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.expozitieIDDataGridViewTextBoxColumn.Visible = false;
            this.expozitieIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.Width = 125;
            // 
            // temaDataGridViewTextBoxColumn
            // 
            this.temaDataGridViewTextBoxColumn.DataPropertyName = "Tema";
            this.temaDataGridViewTextBoxColumn.HeaderText = "Tema";
            this.temaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temaDataGridViewTextBoxColumn.Name = "temaDataGridViewTextBoxColumn";
            this.temaDataGridViewTextBoxColumn.Width = 125;
            // 
            // pretBiletDataGridViewTextBoxColumn
            // 
            this.pretBiletDataGridViewTextBoxColumn.DataPropertyName = "PretBilet";
            this.pretBiletDataGridViewTextBoxColumn.HeaderText = "PretBilet";
            this.pretBiletDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pretBiletDataGridViewTextBoxColumn.Name = "pretBiletDataGridViewTextBoxColumn";
            this.pretBiletDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataInceputDataGridViewTextBoxColumn
            // 
            this.dataInceputDataGridViewTextBoxColumn.DataPropertyName = "DataInceput";
            this.dataInceputDataGridViewTextBoxColumn.HeaderText = "DataInceput";
            this.dataInceputDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataInceputDataGridViewTextBoxColumn.Name = "dataInceputDataGridViewTextBoxColumn";
            this.dataInceputDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataFinalDataGridViewTextBoxColumn
            // 
            this.dataFinalDataGridViewTextBoxColumn.DataPropertyName = "DataFinal";
            this.dataFinalDataGridViewTextBoxColumn.HeaderText = "DataFinal";
            this.dataFinalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataFinalDataGridViewTextBoxColumn.Name = "dataFinalDataGridViewTextBoxColumn";
            this.dataFinalDataGridViewTextBoxColumn.Width = 125;
            // 
            // expozitiiBindingSource
            // 
            this.expozitiiBindingSource.DataMember = "Expozitii";
            this.expozitiiBindingSource.DataSource = this.artaDataSetBindingSource1;
            // 
            // artaDataSetBindingSource1
            // 
            this.artaDataSetBindingSource1.DataSource = this.artaDataSet;
            this.artaDataSetBindingSource1.Position = 0;
            // 
            // expozitiiTableAdapter
            // 
            this.expozitiiTableAdapter.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_final);
            this.Controls.Add(this.txt_inceput);
            this.Controls.Add(this.txt_pret);
            this.Controls.Add(this.txt_tema);
            this.Controls.Add(this.txt_titlu);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expozitiiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artaDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource artaDataSetBindingSource;
        private ArtaDataSet artaDataSet;
        private System.Windows.Forms.TextBox txt_titlu;
        private System.Windows.Forms.TextBox txt_tema;
        private System.Windows.Forms.TextBox txt_pret;
        private System.Windows.Forms.TextBox txt_inceput;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource artaDataSetBindingSource1;
        private System.Windows.Forms.BindingSource expozitiiBindingSource;
        private ArtaDataSetTableAdapters.ExpozitiiTableAdapter expozitiiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn expozitieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretBiletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInceputDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFinalDataGridViewTextBoxColumn;
    }
}