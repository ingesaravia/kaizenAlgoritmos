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

        private void blenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            1. CREAR PERSONAJE CON MAKEHUMAN
            2. CREAR HUESOS PARA EL PERSONAJE
            3. CREAR PESOS PARA EL PERSONAJE
            4. CREAR ROPA PARA EL PERSONAJE
            5. ESTABLECER COLORES PARA EL PERSONAJE
            6. CREAR ESCENA 3D CON EL PERSONAJE Y OTROS
            */
        }

        private void tesisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            1. INTRODUCCION
            1.1 Introduccion
            1.2. Antecedentes
            1.2.1 En España
            1.2.2 En Mexico
            1.2.3 En Argentina
            1.3 Organizacion del trabajo
            2. MARCO TEORICO
            2.1 Realidad Aumentada
            2.1.1 Que es 
            2.2 Diagrama de una aplicacion de RA
            2.3 Tracking de RA
            2.3.1 Tipos de tracking
            2.3.2 Tracking basado en vision
            2.4 RA en moviles
            2.4.1 Caracteristicas de HW y SW
            2.5 SW de RA
            2.5.1 Libreria de RA  (pag 17)
            3. CAP 3 
            3.1 casa de gobierno y el salon de la bandera
            3.1.1 La inauguracion
            3.1.2 Cambios posteriores
            3.2 La Bandera de Libertad Civil
            3.2.1 Elementos de la Bandera
            3.3 El Escudo para la escuela
            3.4 El General Manuel Belgrano
            3.4.1 La bandera celeste y blanca flamea en Jujuy
            3.4.2 El Exodo Jujeño
            4. DEFINICION DEL PROYECTO
            4.1 Identificacion del problema
            4.2 Objetivos del Proyecto
            4.2.1 Objetivo General
            4.2.2 Objetivos Especificos
            4.2.3 Metodos y tecnicas propuestas para el logro del objetivo
            4.3 Alcance
            4.4 Restricciones
            4.5 Ambito del Proyecto
            4.6 Metodologia RUP
            4.7 Gestion del Proyecto
            4.7.1 Planificacion
            4.7.2 Estimacion de Recursos
            4.7.3 SW utilizado
            4.7.4 Evaluacion del Proyecto
            5. JUSTIFICACION
            5.1 ¿Por qué una aplicacion movil nativa?
            5.1.1 Aplicaciones Nativas
            5.1.2 Aplicaciones Web Moviles y Web Nativas Moviles
            5.1.3 Conclusion
            5.2 ¿Por qué Android?
            5.2.1 Sistema operativo basado en Linux (82 paginas)
            5.2.2 Evolucion Constante
            5.2.3 Cuota de Mercado
            5.2.4 Mercado de dispositivos moviles en Argentina
            5.2.5 Conclusion
            5.3 ¿Por qué Unity?
            5.3.1 Caracteristicas destacadas
            5.3.2 Conclusion
            5.4 ¿Por qué se utiliza tracking sin marcadores?	
            5.4.1 Tracking mediante dispositivos fisicos
            5.4.2 Tracking basado en vision
            5.4.3 Conclusion
            5.5 ¿Por qué MAXStarSDK?
            5.5.1 Maxstardsk
            5.5.2 Vuforia
            5.5.3 Conclusion
            5.6 Herramientas para el modelado y diseño grafico
            5.6.1 Autodesk 3dSMax
            5.6.2 Cinema 4d
            5.6.3 ZBrush
            5.6.4 makehuman
            5.6.5 Blender
            5.6.6 Conclusion
            6. FASE DE INICIO
            6.1 Casos de Uso
            6.2 Especificacion de Requisitos basada en el Ansi/ieee std 830-1998
            6.2.1 Introduccion
            6.2.2 Descripcion general
            6.2.3 Requisitos especificos
            6.2.4 Especificacion de Requisitos
            6.3 Prototipo de Interfaz
            6.3.1 Pantalla Principal de la App
            6.3.2 Opcion Explorar Ruta de Hechos Historicos
            6.3.3 Opcion Virtualizar Escena 3D (pag 110)
            6.3.4 Informacion sobre la aplicacion
            6.3.5 Instrucciones de uso
            6.4 Analisis de Viabilidad
            6.4.1 Valor Presente Neto
            6.4.2 Tasa Interna de Rendimiento
            6.4.3 Periodo de recuperacion de la inversion
            7. FASE DE ELABORACION
            7.1 Casos de uso detallado
            7.2 Diagrama de clases
            7.3 Diagrama de Secuencias
            7.3.1 Diag de Sec: Explorar Ruta de HH
            7.3.2 Diag de Sec: Virtualizar Objeto H
            7.4 Diag de Actividades
            7.5 Diag de Navegacion
            7.6 Refinacion del prototipo interfaz(pag 128)
            7.6.1 Opcion Virtualizar Escena 3D
            7.7 Plan de Pruebas
            7.7.1 Pruebas Unitarias
            7.7.2 Pruebas de Integracion
            7.7.3 Prueba de Funcionalidad y Desempeño
            7.7.4 Prueba de Aceptacion
            8. FASE DE CONSTRUCCION
            8.1 Primera Iteracion
            8.1.1 Generacion de Diseños
            8.1.2 Generacion de la App
            8.1.3 Generacion del codigo del prototipo
            8.2 Segunda Iteracion
            8.2.1 Planificacion y Diseño de las pruebas
            8.2.2 Realizacion de las Pruebas Unitarias (pag 153)
            8.2.3 Realizacion de Pruebas de Integracion
            9. FASE DE TRANSICION
            9.1 Prueba de Funcionalidad y desempeño
            9.1.1 Caracteristicas fisicas del entorno
            9.1.2 Elaboracion de la planilla para recoleccion de datos de prueba
            9.1.3 Dispositivos empleados en las pruebas
            9.1.4 Marcador utilizado
            9.2 Realizacion de pruebas de funcionalidad
            9.2.1 Poblacion usada
            9.3 Conclusiones de Pruebas de la Fase de Construccion
            9.3.1 Con respecto a...
            9.3.2 Con respecto a la distancia soportada
            9.3.3 Con respecto a la escena 3D
            9.4 Prueba de Aceptacion
            9.4.1 Elaboracion del cuestionario de la prueba de aceptacion
            9.4.2 Realizacion de la prueba de aceptacion
            9.5 Conclusiones de la Prueba de Aceptacion (pag 178)
            CONCLUSIONES
            TRABAJOS A FUTURO
            ANEXO A: TECNICAS DE RECOPILACION DE INFORMACION
            *OBSERVACIONES 
            *REVISION DE REGISTROS
            *ESTADISTICAS DE TURISMO DE JUJUY
            ANEXO B: ACTIVIDADES Y CRONOGRAMA DEL PROYECTO
            * CRONOGRAMA
            ANEXO C: DOCUMENTACION LEGISLATIVA
            1 Antecedentes Ley N° 5772 (pag 213)
            2 Inserciones
            3 Votacion
            4 Camara de Senadores de la Nacion -ley N!
            4.1 Sesion ordinaria 13/10/2013 Version taquigrafica
            4.2 Orden del dia proyecto de ley
            4.3 Boletin oficial
            5 Declaracion de interes legislativo
            6 Perdida de Reconocimiento por el Escudo de la Escuela Legada
            ANEXO D:
            1. Modelo de encuesta dispositivos moviles
            2. Informacion recopilada
            3. Graficos
            ANEXO E:
            1. Modelo de Planilla de Prueba Funcionalidad y Desempeñ
            2. Pruebas de Funcionalidad y Desempeño
            3. Modelo Cuestionario Pruebas de Aceptacion
            4. Prueba de Aceptacion
            BIBLIOGRAFIA, REFERENCIAS, GLOSARIO Y ABREVIATURAS
            1. Referencias a sitios web
            2. Glosario
            3. Abreviaturas
            */
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesOfficeExcel miOfficeExcel = new gesOfficeExcel();
            miOfficeExcel.Visible = true;
        }
    }
}