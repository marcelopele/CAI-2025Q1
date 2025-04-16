using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facultad.Persistencia
{
    public class PersistenciaUtils
    {
        string ruta = @".\Datos\";

        //Encontrar un registro por columna y valor
        public String[] EncontrarRegPorColVal(String archivo, int col, String valor)
        {
            String[] salida = new String[0];

            archivo = Path.GetFullPath(ruta + archivo);            //archivo = ruta + archivo;
            FileInfo fi = new FileInfo(archivo);
            if (!fi.Exists)
            {
                MessageBox.Show("No se pudo leer el archivo");
            }
            else
            {
                StreamReader sr = fi.OpenText();
                while (!sr.EndOfStream)
                {
                    String[] linea = sr.ReadLine().ToString().Split(';');
                    if (linea[col] == valor)
                    {
                        salida = linea;
                        sr.Close();
                        break;
                    }
                }
                sr.Close();
            }
            return salida;

        }



        //listar el contenido de un archivo
        public List<String> ListarArchivo(String archivo)
        {
            archivo = Path.GetFullPath(ruta + archivo);

            List<String> salida = new List<String>();

            FileInfo fi = new FileInfo(archivo);
            if (!fi.Exists)
            {
                MessageBox.Show("...No se pudo leer el archivo...");
            }
            else
            {
                StreamReader sr = fi.OpenText();
                while (!sr.EndOfStream)
                {
                    String linea = sr.ReadLine().ToString();
                    salida.Add(linea);
                }
                sr.Close();
            }

            return salida;
        }



        //agregar un registro al archivo
        public void AgregarRegistro(String archivo, String[] nuevo_registro)
        {
            archivo = Path.GetFullPath(ruta + archivo);

            FileInfo fi = new FileInfo(archivo);
            if (!fi.Exists)
            {
                MessageBox.Show("No se pudo leer el archivo");
            }
            else
            {
                StreamWriter sw = fi.AppendText();
                sw.WriteLine(string.Join(";", nuevo_registro));
                sw.Close();
            }
        }



        //modificar un registro del archivo
        public void ModificarRegistroCompleto(String archivo, int col_id, String valor_id, String[] nuevo_registro)
        {
            archivo = Path.GetFullPath(ruta + archivo);

            FileInfo fi = new FileInfo(archivo);
            if (!fi.Exists)
            {
                MessageBox.Show("No se pudo leer el archivo");
            }
            else
            {
                StreamReader sr = fi.OpenText();

                // Leo el archivo y lo guardo en una lista con el registro modificado
                List<String> listado = new List<String>();
                while (!sr.EndOfStream)
                {
                    String[] datos = sr.ReadLine().ToString().Split(';');
                    if (datos[col_id] == valor_id)
                    {
                        listado.Add(string.Join(";", nuevo_registro));
                    }
                    else
                    {
                        listado.Add(string.Join(";", datos));
                    }
                }
                sr.Close();

                // Escribo el archivo con el registro modificado
                StreamWriter sw = fi.CreateText();
                foreach (String item in listado)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
        }


        //borrar un registro del archivo
        public void BorrarRegistro(String archivo, int col_id, String valor_id)
        {
            archivo = Path.GetFullPath(ruta + archivo);
            FileInfo fi = new FileInfo(archivo);
            if (!fi.Exists)
            {
                MessageBox.Show("No se pudo leer el archivo");
            }
            else
            {
                StreamReader sr = fi.OpenText();
                // Leo el archivo y lo guardo en una lista sin el registro a borrar
                List<String> listado = new List<String>();
                while (!sr.EndOfStream)
                {
                    String linea = sr.ReadLine().ToString();
                    String[] datos = linea.Split(';');
                    if (datos[col_id] != valor_id)
                    {
                        listado.Add(linea);
                    }
                }
                sr.Close();
                // Escribo el archivo sin el registro a borrar
                StreamWriter sw = fi.CreateText();
                foreach (String item in listado)
                {
                    sw.WriteLine(item);
                }
                sw.Close();
            }
        }


    }
}
