namespace kaizenAlgoritmos.View
{
    partial class gesArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gesArchivo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtDirArchivo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripArchivos = new System.Windows.Forms.ToolStripDropDownButton();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtPropFile = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.txtDirArchivo);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(151, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directorio";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(76, 321);
            this.btnExaminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(68, 19);
            this.btnExaminar.TabIndex = 1;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtDirArchivo
            // 
            this.txtDirArchivo.Location = new System.Drawing.Point(4, 297);
            this.txtDirArchivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDirArchivo.Name = "txtDirArchivo";
            this.txtDirArchivo.Size = new System.Drawing.Size(140, 20);
            this.txtDirArchivo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.checkedListBox1);
            this.groupBox3.Location = new System.Drawing.Point(4, 221);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(141, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Herramientas";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(62, 72);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 19);
            this.button5.TabIndex = 1;
            this.button5.Text = "EJECUTAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Solo Lectura",
            "Ocultar",
            "De Sistema",
            "Encriptar"});
            this.checkedListBox1.Location = new System.Drawing.Point(4, 17);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(128, 34);
            this.checkedListBox1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(7, 20);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(140, 276);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Size = new System.Drawing.Size(466, 353);
            this.splitContainer1.SplitterDistance = 155;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripArchivos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(308, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripArchivos
            // 
            this.toolStripArchivos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripArchivos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.readToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.toolStripArchivos.Image = ((System.Drawing.Image)(resources.GetObject("toolStripArchivos.Image")));
            this.toolStripArchivos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripArchivos.Name = "toolStripArchivos";
            this.toolStripArchivos.Size = new System.Drawing.Size(51, 22);
            this.toolStripArchivos.Text = "CRUD";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.createToolStripMenuItem1.Text = "Create";
            // 
            // readToolStripMenuItem1
            // 
            this.readToolStripMenuItem1.Name = "readToolStripMenuItem1";
            this.readToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.readToolStripMenuItem1.Text = "Read";
            this.readToolStripMenuItem1.Click += new System.EventHandler(this.readToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Location = new System.Drawing.Point(2, 25);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(304, 326);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Archivos";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtPropFile);
            this.groupBox5.Location = new System.Drawing.Point(4, 130);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox5.Size = new System.Drawing.Size(295, 91);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Propiedades";
            // 
            // txtPropFile
            // 
            this.txtPropFile.Location = new System.Drawing.Point(4, 17);
            this.txtPropFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPropFile.Name = "txtPropFile";
            this.txtPropFile.Size = new System.Drawing.Size(282, 70);
            this.txtPropFile.TabIndex = 0;
            this.txtPropFile.Text = "";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 109);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            // 
            // gesArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "gesArchivo";
            this.Text = "gesArchivo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtDirArchivo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox txtPropFile;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripArchivos;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}