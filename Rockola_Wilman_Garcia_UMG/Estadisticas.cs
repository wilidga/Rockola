using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Estadisticas : Form
    {
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {

            // fecha,      albun,    cancion,   artista, tiemp
            lstv1.GridLines = true;
            lstv1.View = View.Details;
            lstv1.Columns.Add("Indice", 45);
            lstv1.Columns.Add("Fecha", 200);
            lstv1.Columns.Add("Albun", 100);
            lstv1.Columns.Add("Cancion", 100);
            lstv1.Columns.Add("Artista", 100);
            lstv1.Columns.Add("Tiempo", 100);


            Cargar_estadistica();


        }

        public void Cargar_estadistica() {
            String line;
            Int64 x;
            int icol;
            x = 1;
            icol = 0;
            ListViewItem lst = new ListViewItem();
            try
            {


                StreamReader sr = new StreamReader("C:\\Gif\\estadistica.txt");


                line = sr.ReadLine();


                while (line != null)
                {


                   
                    

                    if (icol == 0)
                    {
                        lst = lstv1.Items.Add(Convert.ToString(x));
                        lst.SubItems.Add(line);
                        
                        icol += 1;
                    }
                    else if (icol == 1)
                    {
                        lst.SubItems.Add(line);

                        
                        icol += 1;
                   }
                    else if (icol == 2)
                    {
                        lst.SubItems.Add(line);


                        icol += 1;
                    }
                    else if (icol == 3)
                    {
                        lst.SubItems.Add(line);
                        icol += 1;
                    }
                    else if (icol == 4)
                    {
                        lst.SubItems.Add(line);
                        icol = 0 ;
                        x += 1;
                    }


                  
                    line = sr.ReadLine();
                }
              
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

                
        }
    }
}
