using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using TagLib;
using WMPLib;
using System.Timers;




namespace WindowsFormsApplication1
{
    
    
    public partial class Form1 : Form
    {
       
        WindowsMediaPlayer wplayer = new WindowsMediaPlayer();

     
        cMiMp3 Objmp3 = new cMiMp3();
        String sCancion,sArtista;
        const string path1 = "C:/Gif/";
        const int imax = 8;
           int iInit,imp3,iAlbun,iprod ,iMonedas,imgmp3,iIni;
        const int imax1 = 4000;
        Int64 seg,seg1,iDura;
        string[,] arrmp3 = new string[2,imax1];
        string[] arralbunes = new string[imax1];
        string[,] arrreprod = new string[2,imax1];
        string[] arr = new string[imax];
        Image im = Image.FromFile(path1 + "z.gif");
        Image prin = Image.FromFile(path1 + "c.gif");
        Image noimagen = Image.FromFile(path1 + "noimg.jpg"); 
        public static int segundos=0;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "";
            label4.Text = "";
            label6.Text = "";
            iInit = 0;
            iIni = -1;
            imp3 = 0;
            seg = 0;
            seg1 = 0;
            iprod = 0;
            iAlbun = 0;
            iMonedas = 0;
          
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            cargarlstv();
            cargarlstv2();
            load_txt();            
            Sub_gif();
            llenar_gif();
           
           
        }



        public void load_txt()
        {

            String line;
            Int64 x;
            int icol;
            x = 0;
            icol = 0;
            try
            {


                StreamReader sr = new StreamReader("C:\\Gif\\txt_lista.txt");


                line = sr.ReadLine();


                while (line != null)
                {


                    if (icol == 0)
                    {
                        arrmp3[icol, x] = line;
                        icol += 1;
                    }
                    else
                    {
                        arrmp3[icol, x] = line;
                        icol -= 1;
                        x += 1;

                        imp3 += 1;
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


            Cargar_albunes();
        }
                                   // fecha,      albun,    cancion,   artista, tiemp
       
        public void write_estadistica(DateTime a, string b, string c,string d,string e) {
     
            try
            {
               
                StreamWriter sw = new StreamWriter("C:\\Gif\\estadistica.txt", true, Encoding.ASCII);

                    sw.Write(a + "\r\n");
                    sw.Write(b + "\r\n");
                    sw.Write(c + "\r\n");
                    sw.Write(d + "\r\n");
                    sw.Write(e + "\r\n");
               
                sw.Close();
            }
            catch (Exception q)
            {
                Console.WriteLine("Exception: " + q.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        
        }



        public void write_txt() {

            Int64 x;

            try
            {
                var archivo = "C:\\Gif\\txt_lista.txt";

                // eliminar el fichero si ya existe
                if (System.IO.File.Exists(archivo))
                    System.IO.File.Delete(archivo);

                // crear el fichero
                using (var fileStream = System.IO.File.Create(archivo));


                
                StreamWriter sw = new StreamWriter("C:\\Gif\\txt_lista.txt", true, Encoding.ASCII);

                
                for (x = 0; x < imp3; x++)
                {
                    sw.Write(arrmp3[0, x] + "\r\n");
                    sw.Write(arrmp3[1, x] + "\r\n");
                }

               
                sw.Close();
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



        public void llenar_gif() {

            arr[0] = path1 + "a.gif";
            arr[1] = path1 + "b.gif";
            arr[2] = path1 + "c.gif";
            arr[3] = path1 + "d.gif";
            arr[4] = path1 + "f.gif";
            arr[5] = path1 + "g.gif";
            arr[6] = path1 + "h.gif";
            arr[7] = path1 + "i.gif";
            arr[8] = path1 + "j.gif";
            
            
          
        }

     

        public void Sub_gif() {
                  
            this.pb1.Image = im;
            this.pb2.Image = im;
            this.pb3.Image = prin;

            this.pb1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb3.SizeMode = PictureBoxSizeMode.StretchImage;          
                    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (iInit >= imax)
            {
                iInit = 0;
            }
          
              
                prin = Image.FromFile(arr[iInit]);
                this.pb3.Image = prin;           
                iInit += 1;


          
        }

    

        private void cargarMusicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
            this.opfd1.Filter = "Archivos Mp3 (*.mp3)|*.mp3|Wav|*.wav|Midi|*.mid";

            //imp3 = 0;
         
            this.opfd1.Multiselect = true;
            this.opfd1.Title = "Mi Buscador MP3";

            DialogResult dr = this.opfd1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
             
                foreach (String file in opfd1.FileNames)
                {
                    // Create a PictureBox. 
                    try
                    {
                        TagLib.File Mp3file = TagLib.File.Create(file);

                        arrmp3[0, imp3] = Mp3file.Name;
                        if (Mp3file.Tag.Album == null)
                        {
                            arrmp3[1, imp3] = "Sin Albun";
                        }
                        else
                        {
                            arrmp3[1, imp3] = Mp3file.Tag.Album;
                        }
                        imp3 += 1;

                    }

                    catch (Exception ex)
                    {
                      
                        MessageBox.Show("Error: No pudo seleccionar o recuperar nada..!: " + ex.Message);
                    }
                }
            }
            write_txt(); 
            Cargar_albunes();
           
        }

        public void Cargar_albunes() {
          Boolean  bbandera;
          bbandera = false;

            for (int i = 0; i < imp3; i++)
            {
                for (int x = 0; x < iAlbun; x++)
                {
                  

                    if (arralbunes[x] == arrmp3[1, i])
                    {
                        bbandera = true;
                    }
             
                    
                }
                if (bbandera == false) {
                    arralbunes[iAlbun] = arrmp3[1, i];
                 
                    iAlbun += 1;
                    
                }

                bbandera = false;
            }


            for (int h = 0; h < iAlbun; h++) {

                ltb.Items.Add(arralbunes[h]);
            }
                
            

        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



     private void ltb_DoubleClick(object sender, MouseEventArgs e)
        {
            MemoryStream memStream = null;
            int a;
            a = 0;            
            int j;
           
            int index = this.ltb.IndexFromPoint(e.Location);
            ListViewItem lst = new ListViewItem();
            lst1.Clear();
            cargarlstv();
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                try
                {
                 
                    for ( j = 0; j <= imp3; j++)
                    {
                        if (arrmp3[1, j] == arralbunes[Convert.ToInt32(index.ToString())])
                        {
                            imgmp3 = j;
                             TagLib.File Mp3file = TagLib.File.Create(arrmp3[0, j]);
                          
                           
                            lst = lst1.Items.Add(Convert.ToString(j));
                                    lst.SubItems.Add(Mp3file.Tag.Title);
                                    lst.SubItems.Add(Mp3file.Tag.FirstPerformer);
                                    lst.SubItems.Add(Mp3file.Tag.Album);
                                    lst.SubItems.Add(Mp3file.Properties.Duration.TotalSeconds.ToString() + "[s]");
                                

                            

                            
                        }



                    }

                    if (a == 0)
                    {
                        TagLib.File Mp3file1 = TagLib.File.Create(arrmp3[0, imgmp3]);
                        memStream = new MemoryStream(Mp3file1.Tag.Pictures[0].Data.Data);
                        pbalbun.Image = Image.FromStream(memStream);
                        this.pbalbun.SizeMode = PictureBoxSizeMode.StretchImage;
                        a = 1;
                    }

                }
                catch (Exception ex)
                {
                    label1.Text = ex.Message;
                    this.pbalbun.Image = noimagen;
                    this.pbalbun.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                finally
                {
                    if (memStream != null)
                        memStream.Close();
                   
                }


            }

        }

     public void cargarlstv() {

         lst1.GridLines = true;
         lst1.View = View.Details;
         lst1.Columns.Add("Indice", 45);
         lst1.Columns.Add("Titulo", 200);
         lst1.Columns.Add("Interprete", 100);
         lst1.Columns.Add("Album", 100);
         lst1.Columns.Add("Duracion", 100);

         

     }
     public void cargarlstv2()
     {
         lstv2.GridLines = true;
         lstv2.View = View.Details;
         lstv2.Columns.Add("Indice", 45);
         lstv2.Columns.Add("Titulo", 200);
         lstv2.Columns.Add("Interprete", 100);
         lstv2.Columns.Add("Album", 100);
         lstv2.Columns.Add("Duracion", 100);

     }



     private void lst1_MouseDoubleClick(object sender, EventArgs e)
     {
         
         if (iMonedas > 0)
         {
            
             ListViewItem ls2 = new ListViewItem();
             if (lst1.SelectedItems.Count > 0)
             {
                 ListViewItem lv = lst1.SelectedItems[0];
                 arrreprod[0, iprod] = lv.Text;
                 arrreprod[1, iprod] = arrmp3[0, Convert.ToInt64(lv.Text)];

                 if (iIni == -1) { 
                 iIni = 0;
                 }
                 TagLib.File Mp3file1 = TagLib.File.Create(arrmp3[0, Convert.ToInt64(lv.Text)]);
                 MessageBox.Show("La cancion seleccionada es " + Mp3file1.Tag.Title);
                 // fecha,      albun,    cancion,   artista, tiemp
                 write_estadistica(DateTime.Now, Mp3file1.Tag.Album, Mp3file1.Tag.Title, Mp3file1.Tag.FirstPerformer, Mp3file1.Properties.Duration.TotalSeconds.ToString());

                 lstv2.Clear();
                 cargarlstv2();
                 for (int t = 0; t <= iprod; t++)
                 {


                     TagLib.File Mp3file = TagLib.File.Create(arrreprod[1, t]);
                     ls2 = lstv2.Items.Add(arrreprod[0, t]);
                     ls2.SubItems.Add(Mp3file.Tag.Title);
                     ls2.SubItems.Add(Mp3file.Tag.FirstPerformer);
                     ls2.SubItems.Add(Mp3file.Tag.Album);
                     ls2.SubItems.Add(Mp3file.Properties.Duration.TotalSeconds.ToString() + "[s]");
                 }


                 iprod += 1;
              
                
                
             }


         }
         else {
             MessageBox.Show("Inserte Monedas");
         }

         if (iMonedas > 0)
         {
             iMonedas -= 1;
             this.label2.Text = Convert.ToString(iMonedas);
         }


         if (iprod > 0) {

              reprod_mus();
         }

        
     }
        
     private void reprod_mus()
     {
         string sseg;
         Thread.Sleep(10);
         if (iIni >-1  && iprod > 0 && iIni != iprod) {





             if (seg1 == seg)
             {
             
                 TagLib.File Mp3file = TagLib.File.Create(arrreprod[1, iIni]);
                 sCancion = Mp3file.Tag.Title;
                 sArtista = Mp3file.Tag.FirstPerformer;

                 seg = 0;
                 timer3.Start();
                 sseg = Mp3file.Properties.Duration.TotalSeconds.ToString();
                seg1 = Convert.ToInt64(Math.Round(Convert.ToDouble(sseg)));
                               
                 
                 iDura = seg1;
                 seg1 += 3;
                 wplayer.URL = arrreprod[1, iIni];
                 iIni += 1;
            
                 Objmp3.SetEnproduccion(true);
                 wplayer.controls.play();
                
                
             }
            

         }
        
     }
     

     private void btncoin_Click(object sender, EventArgs e)
     {
         if (Objmp3.GetEnproduccion() == false) {
             wplayer.URL = "C:\\Gif\\Ficha.mp3";
             wplayer.controls.play();
         }
         iMonedas += 1;
         label2.Text = Convert.ToString(iMonedas);
        
                
     }

     private void timer3_Tick(object sender, EventArgs e)
     {
         seg += 1;
         iDura -= 1;

         label3.Text = Convert.ToString(seg);
         label5.Text = Convert.ToString(iDura) + " Seg..";
         label4.Text = "Cancion en Produccion : " + sCancion;
         label6.Text = "Interprete : " + sArtista;
         if (seg1 == seg) {
             Objmp3.SetEnproduccion(false);             
             seg1 = 0;
             seg = 0;
             label5.Text = "";
             label4.Text = "";
             label6.Text = "";
             reprod_mus();             
         }

         if (Objmp3.GetEnproduccion()==false) {
             seg = 0;
             label5.Text = "";
             label4.Text = "";
             label6.Text = "";
             reprod_mus();             
         }



     }

     private void reproduccionesToolStripMenuItem_Click(object sender, EventArgs e)
     {
         Estadisticas esta = new Estadisticas();
         
         esta.Show();
       
         
     }




    }
}
