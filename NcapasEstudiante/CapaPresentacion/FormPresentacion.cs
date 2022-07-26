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
//Llmar la Capa
using CapaLogica;

namespace CapaPresentacion
{
    public partial class FormPresentacion : Form
    {
        public FormPresentacion()
        {
            InitializeComponent();
        }



        //Listado:
        public void Listar(){
            ClaseLogica obj = new ClaseLogica();
            GridListar.DataSource = obj.LogicaListar();

        }

        private void FormPresentacion_Load(object sender, EventArgs e)
        {
            try
            {
               ClaseLogica obj = new ClaseLogica();
               obj.Base();              
               Listar();
                TxtSex.MaxLength = 1;
                TxtTele.MaxLength = 7;
                TxtCel.MaxLength = 9;
            }
            catch{
                MessageBox.Show("!Conexion Fallida en la Base de Datos¡");
            }
        }

        //Insertado:

        public void Inse()

        {
            String Cod = TxtCod.Text;
            String PriN = TxtPrimNo.Text;
            String SegN = TxtSegNo.Text;
            String PriA = TxtPrimApel.Text;
            String SegA = TxtSegApel.Text;
            String Tel = TxtTele.Text;
            String Cel = TxtCel.Text;
            String Dir = TxtDirec.Text;
            String Ema = TxtEma.Text;
            String Se = TxtSex.Text;
            String Ob = TxtObser.Text;
            DateTime d = DateTime.Parse(dateTimePicker2.Text);


            if (Cod == "" && PriN =="" && SegN == "" && PriA =="" && SegA=="" && Tel =="" && Cel=="" && Dir=="" && Ema =="" && Se=="" && Ob =="" )
            {

                MessageBox.Show(" !DEBES RELLENAR LAS CASILLAS¡");
                Nuevo();
            }

            else
            {
                ClaseLogica obj = new ClaseLogica();
                obj.LogicaInsertar(Cod, PriN, SegN, PriA, SegA, Tel, Cel, Dir, Ema, d, Se, Ob);
                Listar();
                Nuevo();
                Curso ob = new Curso();
                ob.txtid.Text = Cod;    

                ob.ShowDialog();
                Hide();
              
            }
        
        }


        private void BtnInsertar_Click(object sender, EventArgs e)
        {

            Inse();
        }


        //Modificacion:

        public void Modificar()

        {
            String Cod = TxtCod.Text;
            String PriN = TxtPrimNo.Text;
            String SegN = TxtSegNo.Text;
            String PriA = TxtPrimApel.Text;
            String SegA = TxtSegApel.Text;
            String Tel = TxtTele.Text;
            String Cel = TxtCel.Text;
            String Dir = TxtDirec.Text;
            String Ema = TxtEma.Text;
            String Se = TxtSex.Text;
            DateTime d = DateTime.Parse(dateTimePicker2.Text);
            String Ob = TxtObser.Text;

            if (Cod == "" && PriN == "" && SegN == "" && PriA == "" && SegA == "" && Tel == "" && Cel == "" && Dir == "" && Ema == "" &&Se == "" && Ob=="")
            {

                MessageBox.Show("¡DEBES RELLENAR CASILLA!");
                Nuevo();
            }

            else
            {
                ClaseLogica obj = new ClaseLogica();
                obj.LogicaModificar(Cod, PriN, SegN, PriA, SegA, Tel, Cel, Dir, Ema, d, Se,Ob);
                MessageBox.Show("¡MODIFICACION EXITOSA!");
                Nuevo();
                Listar();



            }
         
        }

        private void BtnModificar_Click(object sender, EventArgs e)

        {
            Modificar();
        }


        // Nuevo

        public void Nuevo()
        {
            
            TxtCod.Clear();
            TxtPrimNo.Clear();
            TxtSegNo.Clear();
            TxtPrimApel.Clear();
            TxtSegApel.Clear();
            TxtTele.Clear();
            TxtCel.Clear();
            TxtDirec.Clear();
            TxtEma.Clear();
            TxtSex.Clear();
            TxtObser.Clear();

            TxtCod.Focus();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }       //

       public void Eliminar()
        {
           
                String Cod = TxtCod.Text;
                String PriN = TxtPrimNo.Text;
                String SegN = TxtSegNo.Text;
                String PriA = TxtPrimApel.Text;
                String SegA = TxtSegApel.Text;
                String Tel = TxtTele.Text;
                String Cel = TxtCel.Text;
                String Dir = TxtDirec.Text;
                String Ema = TxtEma.Text;
                String Se = TxtSex.Text;
                String Ob = TxtObser.Text;

                if (Cod == "" )
                {

                    MessageBox.Show("!DEBES RELLENAR CASILLA DE CODIGO!");
                    
                }

                else if  (MessageBox.Show("¿CONFIRMA PARA ELIMINAR?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)
                

               {
                        ClaseLogica obj = new ClaseLogica();
                        obj.LogicaEliminar(Cod);
                        Nuevo();
                        Listar();
                        MessageBox.Show("¡ELIMINACION CON EXITO!");
                        Nuevo();                    
                }           
        }
         
        private void BtnEliminar_Click(object sender, EventArgs e)

        {
            Eliminar(); }

        //CLOSE

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                TxtCod.Text = GridListar.CurrentRow.Cells[0].Value.ToString();
                TxtPrimNo.Text = GridListar.CurrentRow.Cells[1].Value.ToString();
                TxtSegNo.Text = GridListar.CurrentRow.Cells[2].Value.ToString();
                TxtPrimApel.Text = GridListar.CurrentRow.Cells[3].Value.ToString();
                TxtSegApel.Text = GridListar.CurrentRow.Cells[4].Value.ToString();
                TxtTele.Text = GridListar.CurrentRow.Cells[5].Value.ToString();
                TxtCel.Text = GridListar.CurrentRow.Cells[6].Value.ToString();
                TxtDirec.Text = GridListar.CurrentRow.Cells[7].Value.ToString();
                TxtEma.Text = GridListar.CurrentRow.Cells[8].Value.ToString();
                dateTimePicker2.Text = GridListar.CurrentRow.Cells[9].Value.ToString();
                TxtSex.Text = GridListar.CurrentRow.Cells[10].Value.ToString();
                TxtObser.Text = GridListar.CurrentRow.Cells[11].Value.ToString();
                TxtCur.Text= GridListar.CurrentRow.Cells[13].Value.ToString();

            }
            catch
            {
                MessageBox.Show("¡ERROR DE SISTEMA¡");


            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        public void Buscar()
        {
            String Cod = TxtCod.Text;
            if (Cod == "")
            {

                MessageBox.Show("!DEBES RELLENAR LA CASILLA DE CODIGO!");
                Nuevo();
            }
            else { 



               ClaseLogica obj = new ClaseLogica();
               GridListar.DataSource = obj.LogicaBuscar(Cod);
                  Nuevo();
        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label9.Text = TxtObser.Text.Length.ToString();
            if (TxtObser.Text.Length ==100) {

                MessageBox.Show("MAXIMO 100 CARACTERS");
            }
                
           
        }

        private void BtnBoNotas_Click(object sender, EventArgs e)
        {
            EliminarCur();
            
        }

        public void EliminarCur()

        {
            String Cod = TxtCod.Text;
            String cur = TxtCur.Text;

            if (cur == "" )
            {

                MessageBox.Show("!DEBES RELLENAR CASILLA DE CURSO!");
                Nuevo();
            }

            else if (MessageBox.Show("¿CONFIRMA PARA ELIMINAR?", "DELETE", MessageBoxButtons.YesNo) == DialogResult.Yes)


            {
                ClaseLogica ob = new ClaseLogica();
                ob.LogicaEliminarCur(Cod, cur);
                MessageBox.Show("¡ELIMINACION CON EXITO!");
                Listar();
                Nuevo();

            }
       
            

        }

        private void lblCur_Click(object sender, EventArgs e){}
        private void LblTitulo_Click(object sender, EventArgs e)  { }
        private void BtnListar_Click(object sender, EventArgs e) { }
        private void TxtPriApel_Enter(object sender, EventArgs e){ }
        private void TxtPrimNo_TextChanged(object sender, EventArgs e){}
        private void label9_Click(object sender, EventArgs e){}
        private void BtnCursos_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e)
        {
            ListadodeEstudiante obj = new ListadodeEstudiante();
            obj.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //int numero = Convert.ToInt32(txtcodigo.Text);

        // Convertir en entero : int numero = int.Parse(txtCodigo.Text);
        // Entero : int numero = 
    }
}

