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


        private void mathExerciserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesMathExerciser mMathExerciser = new gesMathExerciser();
            mMathExerciser.Visible = true;
        }

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



        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gesOfficeExcel miOfficeExcel = new gesOfficeExcel();
            miOfficeExcel.Visible = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

