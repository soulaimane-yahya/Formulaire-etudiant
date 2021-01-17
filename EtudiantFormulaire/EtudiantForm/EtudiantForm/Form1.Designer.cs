namespace EtudiantForm
{
    partial class Form1
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
            this.cNEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPrenomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAcademicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etudiantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new EtudiantForm.DataSet();
            this.etudiantTableAdapter = new EtudiantForm.DataSetTableAdapters.EtudiantTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNEDataGridViewTextBoxColumn,
            this.cINDataGridViewTextBoxColumn,
            this.nomPrenomeDataGridViewTextBoxColumn,
            this.emailAcademicDataGridViewTextBoxColumn,
            this.oPTIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etudiantBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(454, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // cNEDataGridViewTextBoxColumn
            // 
            this.cNEDataGridViewTextBoxColumn.DataPropertyName = "CNE";
            this.cNEDataGridViewTextBoxColumn.HeaderText = "CNE";
            this.cNEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNEDataGridViewTextBoxColumn.Name = "cNEDataGridViewTextBoxColumn";
            this.cNEDataGridViewTextBoxColumn.Width = 125;
            // 
            // cINDataGridViewTextBoxColumn
            // 
            this.cINDataGridViewTextBoxColumn.DataPropertyName = "CIN";
            this.cINDataGridViewTextBoxColumn.HeaderText = "CIN";
            this.cINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cINDataGridViewTextBoxColumn.Name = "cINDataGridViewTextBoxColumn";
            this.cINDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomPrenomeDataGridViewTextBoxColumn
            // 
            this.nomPrenomeDataGridViewTextBoxColumn.DataPropertyName = "Nom & Prenome";
            this.nomPrenomeDataGridViewTextBoxColumn.HeaderText = "Nom & Prenome";
            this.nomPrenomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomPrenomeDataGridViewTextBoxColumn.Name = "nomPrenomeDataGridViewTextBoxColumn";
            this.nomPrenomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailAcademicDataGridViewTextBoxColumn
            // 
            this.emailAcademicDataGridViewTextBoxColumn.DataPropertyName = "Email Academic";
            this.emailAcademicDataGridViewTextBoxColumn.HeaderText = "Email Academic";
            this.emailAcademicDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAcademicDataGridViewTextBoxColumn.Name = "emailAcademicDataGridViewTextBoxColumn";
            this.emailAcademicDataGridViewTextBoxColumn.Width = 125;
            // 
            // oPTIONDataGridViewTextBoxColumn
            // 
            this.oPTIONDataGridViewTextBoxColumn.DataPropertyName = "OPTION";
            this.oPTIONDataGridViewTextBoxColumn.HeaderText = "OPTION";
            this.oPTIONDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oPTIONDataGridViewTextBoxColumn.Name = "oPTIONDataGridViewTextBoxColumn";
            this.oPTIONDataGridViewTextBoxColumn.Width = 125;
            // 
            // etudiantBindingSource
            // 
            this.etudiantBindingSource.DataMember = "Etudiant";
            this.etudiantBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etudiantTableAdapter
            // 
            this.etudiantTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(47, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(263, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Modifier";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(155, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(155, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 37);
            this.button5.TabIndex = 9;
            this.button5.Text = "Fermer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CNE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "CNE", true));
            this.textBox1.Location = new System.Drawing.Point(125, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "CIN";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "CIN", true));
            this.textBox2.Location = new System.Drawing.Point(126, 48);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(155, 29);
            this.textBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom & Prenom";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Nom & Prenome", true));
            this.textBox3.Location = new System.Drawing.Point(126, 83);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 29);
            this.textBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email ac";
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "Email Academic", true));
            this.textBox4.Location = new System.Drawing.Point(126, 118);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(311, 29);
            this.textBox4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Option";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.etudiantBindingSource, "OPTION", true));
            this.textBox5.Location = new System.Drawing.Point(125, 153);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(155, 29);
            this.textBox5.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(11, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 195);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etudiant Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource etudiantBindingSource;
        private DataSetTableAdapters.EtudiantTableAdapter etudiantTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPrenomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAcademicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
    }
}

