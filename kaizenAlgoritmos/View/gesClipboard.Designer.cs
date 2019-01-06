namespace kaizenAlgoritmos.View
{
    partial class gesClipboard
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbnDatoRtf = new System.Windows.Forms.RadioButton();
            this.rtbnDatoHtml = new System.Windows.Forms.RadioButton();
            this.rtbnDatoText = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtDirArchivo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnActivar = new System.Windows.Forms.Button();
            this.txtAreaEstado = new System.Windows.Forms.RichTextBox();
            this.timerAutoCopiar = new System.Windows.Forms.Timer(this.components);
            this.rbtnArchText = new System.Windows.Forms.RadioButton();
            this.rtbnArchHtml = new System.Windows.Forms.RadioButton();
            this.rbtnArchWord = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAreaEstado, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(598, 416);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(391, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 410);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(190, 404);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbnDatoRtf);
            this.groupBox1.Controls.Add(this.rtbnDatoHtml);
            this.groupBox1.Controls.Add(this.rtbnDatoText);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Dato";
            // 
            // rtbnDatoRtf
            // 
            this.rtbnDatoRtf.AutoSize = true;
            this.rtbnDatoRtf.Location = new System.Drawing.Point(6, 74);
            this.rtbnDatoRtf.Name = "rtbnDatoRtf";
            this.rtbnDatoRtf.Size = new System.Drawing.Size(56, 21);
            this.rtbnDatoRtf.TabIndex = 2;
            this.rtbnDatoRtf.TabStop = true;
            this.rtbnDatoRtf.Text = "RTF";
            this.rtbnDatoRtf.UseVisualStyleBackColor = true;
            // 
            // rtbnDatoHtml
            // 
            this.rtbnDatoHtml.AutoSize = true;
            this.rtbnDatoHtml.Location = new System.Drawing.Point(6, 48);
            this.rtbnDatoHtml.Name = "rtbnDatoHtml";
            this.rtbnDatoHtml.Size = new System.Drawing.Size(67, 21);
            this.rtbnDatoHtml.TabIndex = 1;
            this.rtbnDatoHtml.TabStop = true;
            this.rtbnDatoHtml.Text = "HTML";
            this.rtbnDatoHtml.UseVisualStyleBackColor = true;
            // 
            // rtbnDatoText
            // 
            this.rtbnDatoText.AutoSize = true;
            this.rtbnDatoText.Location = new System.Drawing.Point(6, 21);
            this.rtbnDatoText.Name = "rtbnDatoText";
            this.rtbnDatoText.Size = new System.Drawing.Size(56, 21);
            this.rtbnDatoText.TabIndex = 0;
            this.rtbnDatoText.TabStop = true;
            this.rtbnDatoText.Text = "Text";
            this.rtbnDatoText.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnArchWord);
            this.groupBox2.Controls.Add(this.rtbnArchHtml);
            this.groupBox2.Controls.Add(this.rbtnArchText);
            this.groupBox2.Location = new System.Drawing.Point(3, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 95);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Archivo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExaminar);
            this.groupBox3.Controls.Add(this.txtDirArchivo);
            this.groupBox3.Location = new System.Drawing.Point(3, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(184, 95);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Guardar";
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(43, 49);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(94, 23);
            this.btnExaminar.TabIndex = 1;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtDirArchivo
            // 
            this.txtDirArchivo.Location = new System.Drawing.Point(6, 21);
            this.txtDirArchivo.Name = "txtDirArchivo";
            this.txtDirArchivo.Size = new System.Drawing.Size(172, 22);
            this.txtDirArchivo.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDetener);
            this.groupBox4.Controls.Add(this.btnActivar);
            this.groupBox4.Location = new System.Drawing.Point(3, 306);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 95);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acciones";
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(43, 50);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(94, 23);
            this.btnDetener.TabIndex = 1;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnActivar
            // 
            this.btnActivar.Location = new System.Drawing.Point(43, 21);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(94, 23);
            this.btnActivar.TabIndex = 2;
            this.btnActivar.Text = "ACTIVAR";
            this.btnActivar.Click += new System.EventHandler(this.btnActivar_Click);
            // 
            // txtAreaEstado
            // 
            this.txtAreaEstado.Location = new System.Drawing.Point(3, 3);
            this.txtAreaEstado.Name = "txtAreaEstado";
            this.txtAreaEstado.Size = new System.Drawing.Size(382, 410);
            this.txtAreaEstado.TabIndex = 1;
            this.txtAreaEstado.Text = "";
            // 
            // timerAutoCopiar
            // 
            this.timerAutoCopiar.Tick += new System.EventHandler(this.timerAutoCopiar_Tick);
            // 
            // rbtnArchText
            // 
            this.rbtnArchText.AutoSize = true;
            this.rbtnArchText.Location = new System.Drawing.Point(6, 21);
            this.rbtnArchText.Name = "rbtnArchText";
            this.rbtnArchText.Size = new System.Drawing.Size(56, 21);
            this.rbtnArchText.TabIndex = 0;
            this.rbtnArchText.TabStop = true;
            this.rbtnArchText.Text = "Text";
            this.rbtnArchText.UseVisualStyleBackColor = true;
            // 
            // rtbnArchHtml
            // 
            this.rtbnArchHtml.AutoSize = true;
            this.rtbnArchHtml.Location = new System.Drawing.Point(6, 48);
            this.rtbnArchHtml.Name = "rtbnArchHtml";
            this.rtbnArchHtml.Size = new System.Drawing.Size(67, 21);
            this.rtbnArchHtml.TabIndex = 1;
            this.rtbnArchHtml.TabStop = true;
            this.rtbnArchHtml.Text = "HTML";
            this.rtbnArchHtml.UseVisualStyleBackColor = true;
            // 
            // rbtnArchWord
            // 
            this.rbtnArchWord.AutoSize = true;
            this.rbtnArchWord.Location = new System.Drawing.Point(6, 75);
            this.rbtnArchWord.Name = "rbtnArchWord";
            this.rbtnArchWord.Size = new System.Drawing.Size(63, 21);
            this.rbtnArchWord.TabIndex = 2;
            this.rbtnArchWord.TabStop = true;
            this.rbtnArchWord.Text = "Word";
            this.rbtnArchWord.UseVisualStyleBackColor = true;
            // 
            // gesClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 440);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "gesClipboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clipboard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rtbnDatoRtf;
        private System.Windows.Forms.RadioButton rtbnDatoHtml;
        private System.Windows.Forms.RadioButton rtbnDatoText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtDirArchivo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.RichTextBox txtAreaEstado;
        private System.Windows.Forms.Timer timerAutoCopiar;
        private System.Windows.Forms.RadioButton rbtnArchWord;
        private System.Windows.Forms.RadioButton rtbnArchHtml;
        private System.Windows.Forms.RadioButton rbtnArchText;
    }
}