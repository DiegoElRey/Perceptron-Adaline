using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2IA
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                labelAbrir.Text = openFileDialog1.FileName;
                progressBar1.Value = 10;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void green(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBoxAlgoritmoEntrenaimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAlgoritmoEntrenaimento.Text == "Adaline")
            {
                tbFuncionActivacion.Text = "Lineal";
            }
            else
            {
                tbFuncionActivacion.Text = "Delta";
            }
            if (tbFuncionActivacion.Text != null && comboBoxAlgoritmoEntrenaimento != null && textTipoRed.Text != null)
            {
                progressBar1.Value = 70;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void labelEntradas_Click(object sender, EventArgs e)
        {
            if (labelEntradas.Text != "0")
            {
                progressBar1.Value = 20;
            }
        }

        private void labelSalidas_Click(object sender, EventArgs e)
        {
            if (labelSalidas.Text != "0")
            {
                progressBar1.Value = 30;
            }
        }

        private void labelPatrones_Click(object sender, EventArgs e)
        {
            if (labelPatrones.Text != "0")
            {
                progressBar1.Value = 40;
            }
        }

        private void buttonEntrenar_Click(object sender, EventArgs e)
        {
            
        }

        private void textTipoRed_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (tbNumeroIteracion.Text != null)
            {
                progressBar1.Value = 80;
            }
        }

        private void tbErrorMax_TextChanged(object sender, EventArgs e)
        {
            if (tbErrorMax.Text != null)
            {
                progressBar1.Value = 90;
            }
        }

        private void tbRtAprendizaje_TextChanged(object sender, EventArgs e)
        {
            if (tbRtAprendizaje.Text != null)
            {
                progressBar1.Value = 100;
                buttonEntrenar.BackColor = Color.LimeGreen;
                if (progressBar1.Value == 100)
                {
                    buttonEntrenar.Enabled = true;
                }
            }
        }
}
}
