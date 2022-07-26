using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CapaDatos

{
    //La clase tiene d
    public class ClaseDatos
    {
        public SqlConnection Conexion()
        {
           
            
                SqlConnection con = new SqlConnection("Data Source =DESKTOP-CJKCLLM; Initial Catalog = BaseCrudEstudiantes2; Integrated Security = True");
                con.Open();

                return con;
           

        }

        public DataTable MListar()
        {
            SqlCommand comando = new SqlCommand("select Codigo,PrimNomb,SeguNomb,PrimApell,SeguoApell,Telefo,Celular,Direcc,Email,FecNac,Sexo,Observa as 'Observacion',curso,nota1,nota2,nota3 from Alumnos  join Notas on (Codigo = idalumno); ", Conexion());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public DataTable ListarNotas()
        {
            SqlCommand comando = new SqlCommand("select * from Notas", Conexion());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public void Insertar(string cod, string priN, string segN, string priA, string segA, string tel, string cel, string dir, string ema, DateTime d, string Se,String Ob)
        {

           
            SqlCommand commandToCheckProductoID = new SqlCommand("SELECT Codigo from Alumnos where Codigo='" + cod + "'",Conexion());

            string id =(string)commandToCheckProductoID.ExecuteScalar();
            if (id == cod)
            {
                MessageBox.Show("¡Acepta para ingresar Nuevo Curso¡", "Ya tenemos Registrado con ese Codigo un curso");
            }
            else
            {

                String insertar = "insert into Alumnos(Codigo,PrimNomb,SeguNomb,PrimApell,SeguoApell,Telefo,Celular,Direcc,Email,FecNac,Sexo,Observa)values" +
                    "(@Codigo,@PrimNomb,@SeguNomb,@PrimApell,@SeguApell,@Telefo,@Celular,@Direcc,@Email,@FecNac,@Sexo,@Obser)";

                SqlCommand sq = new SqlCommand(insertar, Conexion());
                sq.Parameters.AddWithValue("@Codigo", cod);
                sq.Parameters.AddWithValue("@PrimNomb", priN);
                sq.Parameters.AddWithValue("@SeguNomb", segN);
                sq.Parameters.AddWithValue("@PrimApell", priA);
                sq.Parameters.AddWithValue("@SeguApell", segA);
                sq.Parameters.AddWithValue("@Telefo", tel);
                sq.Parameters.AddWithValue("@Celular", cel);
                sq.Parameters.AddWithValue("@Direcc", dir);
                sq.Parameters.AddWithValue("@Email", ema);
                sq.Parameters.AddWithValue("@FecNac", d);
                sq.Parameters.AddWithValue("@Sexo ", Se);
                sq.Parameters.AddWithValue("@Obser ", Ob);

                sq.ExecuteNonQuery();
                //MessageBox.Show("!Insertacion Exitosa!");
            }
        }


        public void Modificar(string cod, string priN, string segN, string priA, string segA, string tel, string cel, string dir, string ema, DateTime d, string Se,String Ob)
        {
            String actualizar = "UPDATE  Alumnos SET PrimNomb=@PrimNomb,SeguNomb=@SeguNomb,PrimApell=@PrimApell,SeguoApell=@SeguApell,Telefo=@Telefo,Celular=@Celular,Direcc=@Direcc,Email=@Email,FecNac=@FecNac,Sexo=@Sexo,Observa=@Obser WHERE Codigo=@Codigo";
            SqlCommand sq = new SqlCommand(actualizar, Conexion());
            sq.Parameters.AddWithValue("@Codigo", cod);
            sq.Parameters.AddWithValue("@PrimNomb", priN);
            sq.Parameters.AddWithValue("@SeguNomb", segN);
            sq.Parameters.AddWithValue("@PrimApell", priA);
            sq.Parameters.AddWithValue("@SeguApell", segA);
            sq.Parameters.AddWithValue("@Telefo", tel);
            sq.Parameters.AddWithValue("@Celular", cel);
            sq.Parameters.AddWithValue("@Direcc", dir);
            sq.Parameters.AddWithValue("@Email", ema);
            sq.Parameters.AddWithValue("@FecNac", d);
            sq.Parameters.AddWithValue("@Sexo ", Se);
            sq.Parameters.AddWithValue("@Obser ", Ob);

            sq.ExecuteNonQuery();
            
        }


        public void Eliminar(string Cod)
        {


            string Eliminar = "delete from Alumnos where Codigo =@Codigo";
            SqlCommand eli = new SqlCommand(Eliminar, Conexion());
            eli.Parameters.AddWithValue("@Codigo", Cod);

            eli.ExecuteNonQuery();

        }


        public DataTable Buscar(string Cod)
        {
            SqlCommand comando = new SqlCommand("SELECT * FROM Alumnos WHERE Codigo = @Codigo", Conexion());
            comando.Parameters.AddWithValue("@Codigo", Cod);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public void subirnotas(string ids,string curso,string nota1,string nota2 ,string nota3)



        {
            
          
                string query = "execute Insertar_Notas '" + ids + "','" + curso + "','" + nota1 + "','" + nota2 + "','" + nota3 + "'";
                SqlCommand eli = new SqlCommand(query, Conexion());
                eli.ExecuteNonQuery();
               
           


        }



        public void eliminarCur(string Cod,string cur)
        {


            string Eliminar = "delete from Notas where idalumno = @Cod  and curso =@cur";
            SqlCommand eli = new SqlCommand(Eliminar, Conexion());
            eli.Parameters.AddWithValue("@Cod", Cod);
            eli.Parameters.AddWithValue("@cur", cur);

            eli.ExecuteNonQuery();

        }



    }
}

//https://www.youtube.com/watch?v=tnIEHVF7-_M
// https://www.youtube.com/watch?v=tsqZIttwQ48