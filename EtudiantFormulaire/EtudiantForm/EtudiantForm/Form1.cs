using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtudiantForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.Etudiant' table. You can move, or remove it, as needed.
            this.etudiantTableAdapter.Fill(this.dataSet.Etudiant);
            etudiantBindingSource.DataSource = this.dataSet.Etudiant;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                etudiantBindingSource.EndEdit();
                etudiantTableAdapter.Update(this.dataSet.Etudiant);
                panel1.Enabled = false;

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                etudiantBindingSource.ResetBindings(false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous quitez ?", "Confirmation", MessageBoxButtons.YesNo) 
                == DialogResult.Yes)
            {
                this.Close();
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            textBox1.Focus();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                if (MessageBox.Show("Are u sure want to delete this record ? ", "Message",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) etudiantBindingSource.RemoveCurrent();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                textBox1.Focus();
                this.dataSet.Etudiant.AddEtudiantRow(this.dataSet.Etudiant.NewEtudiantRow());
                etudiantBindingSource.MoveLast();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                etudiantBindingSource.ResetBindings(false);
            }
        }
    }
}
