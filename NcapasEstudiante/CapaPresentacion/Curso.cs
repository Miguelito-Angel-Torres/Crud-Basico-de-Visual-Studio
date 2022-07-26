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
using CapaLogica;
namespace CapaPresentacion
  
{
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }

        public void Listar()
        {
            ClaseLogica obj = new ClaseLogica();
            dataGridView1.DataSource = obj.LogicaListarNotas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void BtnSubir_Click(object sender, EventArgs e)
        {
            if(ComboCurso.Text == "Matematica")
            {
                enviar();
            }
            if (ComboCurso.Text == "Comunicacion")
            {
                enviar();
            }
            if (ComboCurso.Text == "Quimica")
            {
                enviar();
            }
            if (ComboCurso.Text == "Ingles")
            {
                enviar();
            }
           

        }

        private void enviar()
        {
           
            
                string nota1 = "";
                string nota2 = "";
                string nota3 = "";
                if (Afirmacion.Checked)
                {

                    nota1 = "100%";


                }
                else
                {
                    nota1 = "0%";
                }

                if (Afirmacion1.Checked)
                {

                    nota2 = "100%";


                }
                else
                {
                    nota2 = "0%";
                }

                if (Afirmacion2.Checked)
                {

                    nota3 = "100%";


                }
                else
                {
                    nota3 = "0%";
                }


            try
            {
                
                ClaseLogica pas = new ClaseLogica();
                string DATO = txtid.Text;
                string CURSO = ComboCurso.Text;

                pas.Notas(DATO, CURSO, nota1, nota2, nota3);

            }
            catch
            {
               
            }

                FormPresentacion obj = new FormPresentacion();
                obj.Show();
                Hide();
               

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPresentacion obj = new FormPresentacion();
            obj.Show();
            Hide();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


       
    }
    }

