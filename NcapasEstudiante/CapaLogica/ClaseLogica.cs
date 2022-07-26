using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using System.Windows.Forms;

namespace CapaLogica
{
    public class ClaseLogica
    {
        public DataTable  LogicaListar()
        {
            ClaseDatos obj = new ClaseDatos();
            DataTable tabla;
            tabla = obj.MListar();
            return tabla;
           
        }


        public DataTable LogicaListarNotas()
        {
            ClaseDatos obj = new ClaseDatos();
            DataTable tabla;
            tabla = obj.ListarNotas();
            return tabla;

        }


        public void LogicaInsertar(string cod, string priN, string segN, string priA, string segA, string tel, string cel, string dir, string ema, DateTime d, string Se,String Ob)
        {
            ClaseDatos obj = new ClaseDatos();
            obj.Insertar(cod, priN, segN, priA, segA, tel, cel, dir, ema, d, Se,Ob);
        }

        public void LogicaModificar(string cod, string priN, string segN, string priA, string segA, string tel, string cel, string dir, string ema, DateTime d, string Se,String Ob)
        {
            ClaseDatos obj = new ClaseDatos();
            obj.Modificar(cod, priN, segN, priA, segA, tel, cel, dir, ema, d, Se,Ob);

        }

        public void LogicaEliminar(string Cod)
        {
            ClaseDatos obj = new ClaseDatos();
            obj.Eliminar(Cod);

        }

        public void Base()
        {
            ClaseDatos obj = new ClaseDatos();
            obj.Conexion();
        }


        public DataTable LogicaBuscar(String Cod)
        {
            ClaseDatos obj = new ClaseDatos();
            DataTable tabla;
            tabla = obj.Buscar(Cod);
            return tabla;
        }

        public void Notas(string id , string curso,string nota1,string nota2,string nota3)
        {
            ClaseDatos obj = new ClaseDatos();
            obj.subirnotas(id,curso,nota1,nota2,nota3);

        }


        public void LogicaEliminarCur(string Cod, string cur )
        {
            ClaseDatos obj = new ClaseDatos();
            obj.eliminarCur(Cod, cur);

        }



    }
}
