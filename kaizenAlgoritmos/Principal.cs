using System;
using System.Drawing;
using System.Windows.Forms;
using kaizenAlgoritmos.View;

namespace kaizenAlgoritmos
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        #region Principal
        /// <summary>
        /// contenido de la ventana principal
        /// </summary>
        public Principal()
        {
            InitializeComponent();

            Random rand = new Random();
            int num = rand.Next(1, 4);

            //string fullpath = Path.Combine(Application.StartupPath, "Img\\fondo"+num.ToString()+".jpg");
            string fullpath = "..\\..\\Img\\fondo" + num.ToString() + ".jpg";
            //Bitmap mi = new System.Drawing.Bitmap(fullpath);
            Image miImg = Bitmap.FromFile(fullpath);
            this.BackgroundImage = miImg;

            /*
            diseño de algoritmos:

            dividr para conquistar
            algoritmo aleatorizado
            program dinamica
            algoritmo goloso (greedy)
            algoritmo heuristico (basado en experiencia)
            redccion a un problema conocido
            uso de estructura de datos
            */
        }
        #endregion 

        #region Menu
        /// <summary>
        /// funciones del Menu
        /// </sumary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesClipboard miClipb = new gesClipboard();
            miClipb.MdiParent = this;
            miClipb.Visible = true;


        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesArchivo miGA = new gesArchivo();
            miGA.MdiParent = this;
            miGA.Visible = true;
        }

        private void imagenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesImagenes miGI = new gesImagenes();
            miGI.MdiParent = this;
            miGI.Visible = true;
        }

        private void commandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesConectividad miGC = new gesConectividad();
            miGC.MdiParent = this;
            miGC.Visible = true;
        }

        private void pixelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesPixeles miGPx = new gesPixeles();
            miGPx.MdiParent = this;
            miGPx.Visible = true;
        }

        private void controlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesCSharpControles miGCC = new gesCSharpControles();
            miGCC.MdiParent = this;
            miGCC.Visible = true;
        }

        private void patronesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesReconocimiento miGR = new gesReconocimiento();
            miGR.MdiParent = this;
            miGR.Visible = true;
        }

        private void componentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesCSharpComponents miCSC = new gesCSharpComponents();
            miCSC.MdiParent = this;
            miCSC.Visible = true;
        }

        private void impresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesCSharpPrinting miGCSP = new gesCSharpPrinting();
            miGCSP.MdiParent = this;
            miGCSP.Visible = true;
        }

        private void firewallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesFirewall miFirewall = new gesFirewall();
            miFirewall.MdiParent = this;
            miFirewall.Visible = true;
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesCSharpEventos miGCSE = new gesCSharpEventos();
            miGCSE.MdiParent = this;
            miGCSE.Visible = true;
        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesNavegador miNav = new gesNavegador();
            miNav.MdiParent = this;
            miNav.Visible = true;
        }

        private void mCDMCMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesMegaCalculadora miMCalc = new gesMegaCalculadora();
            miMCalc.MdiParent = this;
            miMCalc.Visible = true;
        }

        private void velocidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesVelocidad miGV = new gesVelocidad();
            miGV.MdiParent = this;
            miGV.Visible = true;
        }

        private void estrucDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesEstructuraDatos miGEDatos = new gesEstructuraDatos();
            miGEDatos.MdiParent = this;
            miGEDatos.Visible = true;
        }

        private void bATCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* pra borrar los temporales de windows */
            /// se escribe %temp% en un comando cmd    

            /* SCRIPTS
                un comando es un pequeño archivo almaceando en system32 de windows
                algunos comandos requieren parametros , otros no, como help.
                COMANDOS
                cd.. vuelve atrsa
                cd dir de carpeta
                dir muestra carpetas
                dir /p muestra archivos en forma pausada
                parametros: / letra
                /? ayuda
                -letra
                cls limpia pantalla

                MAS USADOS
                attrib, ftp, ipconfig, hostname, netstat, nbtstat, net, user, telnet, doskey, edline
                help, xcopy, etc..

                */

            /* CARPETA
            notacion: C:\..\carpeta
            md nombrecarpeta (crear carpeta)
            rd nombrecarpeta (borrarcarpeta que debe estar vacia)
            rd nombrecarpeta /s (borra con todo)
            rd *.jpg (borra las imagenes con esa extension) con Pause Inter - muestra la ventana MSDOS
            dir *.xtension muestra direcotrior con tipo de archivo con esa extension
            dir nombre.* muestra archivo con una extension variable
            dir ????.txt muestra archivo con 4 simbolos y de tipo text
            dir ????.* muestra sin la extension
            dir *.??? muestra con cualquier extension y cualquier nombre
            path nombrearchivo
            */

            /*ARCHIVOS
            notacion: C:/../archivo
            copy con nombrearchivo.extension (crea yarchivo y presionar F6 para lograrlo)
            type nombreachivo.extension (muestra archivo de texto solo lectura)
            del nombrearchivo.extension (borra archivo)
            move nombrearchivo carpeta archivo (copia y pega)
            move nombrearchivo ../ para que veula a la dir original
            move nombrecarpeta nuevonombre (cambia el nombre)
            ren nombrearchivo nombrearchivo2 (cambia nombre)
            ren A.txt A.doc (cambia extension)

            attrib sirve para modificar las propiedades de los archivos
            attrib muestra los archivosc on sus propiedades
            attrib C: muestra los archivos de una unidad en especifico.
            attrib +R muestra los de solo lectura
            attrib -R muestra los editables
            attrib +A muestra los de respaldo
            attrib -A muestra los que no son de respaldo
            attrib +H muestra que esta oculto
            attrib -H muestra que no esta oculto (es visible)
            attrib nombrearchivo +H hace que el archivo se haga oculto
            attrib /s permite que la propiedade se aplique a la carpeta y sus subcarpetas
            attrib /d procesa una carpeta (no siempre esta disponible)

            copy sirve para copiar archivos
            xcopy sirve para copiar varios archivos
            xcopy dirorigen dirdestino [parametros] [/exclude] archivosexcluidos
            xcopy dirorigen dirdestino copia todos los archivos y carpetas de origen a destino
            xcopy dirorigen archivodestino copia todos los archivos en un solo archivo destino
            */

            /* FORMATO DE ARCHIVO
            format C: /FS: NTFS
            format E: /all : FAT
            */

            /* SISTEMA OPERATIVO
            ver nombre.txt muestra la version en un archivo txt
            type nombre.txt mues
            */

            /* REGEDIT
            reg query cadenaregistro /modificador permite visualizar cadenas y valores
            la mayoria de los virus se aloja en HKEYLOCALMACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run
            cadenas basicas: HKLM (HKEYLOCALMACHINE) Y HKCU (HKEYCURRENTUSER)
            Despues siguen HKCR, HKU, HKCC
            Se puede abreviar
            Ejemplo: reg query HKLM\Software\Microsoft\Windows\CurrentVersion\Run
            reg query HKLM.. /s para revisar si hay subcadenas y subclaves
            reg query HKLM.. /v para revisar una sola clave especirfica.
            reg query HKLM.. /ve es para evitar ver todas las claves dentro de una cadena.

            reg delete cadena /modificador /clave borra la clave de una cadena y todas las subclaves y valores
            reg delete HKLM\Software\Microsoft\Windows\CurrentVersion\Run\programa.exe
            reg delete HKLM\Software\Microsoft\Windows\CurrentVersion\Run\QuickT~1 borra las tareas de quicktime
            reg export cadena archivo.reg sirve para exportar una cadena en caso de que quieramos instalar y reinstalar
            reg export HKLM\Software\Microsoft\Windows\CurrentVersion\Run registro.reg guarda las claves del inicio en un archivo
            reg import archivo.reg para importar un archivo externo al registro
            reg 
            reg 
            */
        }

        private void aSCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            int ascii = Encoding.ASCII.GetBytes("B")[0];
            char ascii2 = (char)66;

            o tambien
            int i = 65;
            char c = (char) i;
            */
        }
        #endregion

        private void auxiliarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///Area para realizar pruebas en el código con
            ///algunas de las funciones especificas
            ///</summary>
            ///
            double ejem = 0.4;

            ejem = 0.09;

            Console.WriteLine("el valor redondeado es: " + Math.Round(ejem).ToString());
            Console.WriteLine("el valor truncado es: " + Math.Truncate(ejem).ToString());

            string cadenaDec = Convert.ToString(98.00045);
            cadenaDec = cadenaDec.Substring(0, cadenaDec.IndexOf(','));
            int num = Convert.ToInt32(cadenaDec);
            Console.WriteLine(num);

            cadenaDec = Convert.ToString(98.00045);
            cadenaDec = cadenaDec.Substring(cadenaDec.IndexOf(','), cadenaDec.Length - cadenaDec.IndexOf(','));
            Console.WriteLine(cadenaDec);
        }

        private void mathExerciserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesMathExerciser mMathExerciser = new gesMathExerciser();
            mMathExerciser.Visible = true;
        }

        private void tareasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string command = "net start";
            string cadenaComando = "Programador de Tareas";
            string cadena2 = "task scheduler";
            //SINTAXIS
            // AT \\nombreequipo hora cmd  
        }

        private void clasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enumeradoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            diasdelaSemana midia = diasdelaSemana.Lunes;
                        
            switch(midia) {
                case diasdelaSemana.Lunes:
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case diasdelaSemana.Martes:
                    Console.WriteLine("Hoy es Martes");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

            Console.ReadLine();
        }

        public enum diasdelaSemana {Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo};
        public enum statusConexion {Offline, Online};

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* pi = 3,14
    1rad = 57,3 grados = 0,159 rev
    pi rad = 180 grados = 0,5 rev
    2 pi rad = 360 grados = 1 rev

    sistema medicion angular sexagesimal
    1 grado = 1 r / 90 
    1 min = 1 grado / 60
    1 seg = 1 min / 60

sistema centesimal
1G = 1r / 100
1M = 1G / 100
1S = 1M / 100

relacion sexag cant rad
90 = 100G = pi/2 rad
180 = 200G = pi rad
360 = 400G = 2 pi rad
*/
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}