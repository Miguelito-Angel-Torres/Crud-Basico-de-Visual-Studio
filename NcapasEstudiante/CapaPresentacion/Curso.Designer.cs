
namespace CapaPresentacion
{
    partial class Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curso));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Afirmacion = new System.Windows.Forms.CheckBox();
            this.Afirmacion1 = new System.Windows.Forms.CheckBox();
            this.Afirmacion2 = new System.Windows.Forms.CheckBox();
            this.ComboCurso = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.BtnSubir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LblC = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(44, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Practica N1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(43, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Practica N2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Italic);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.Location = new System.Drawing.Point(44, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Practica N3:";
            // 
            // Afirmacion
            // 
            this.Afirmacion.AutoSize = true;
            this.Afirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afirmacion.Location = new System.Drawing.Point(210, 256);
            this.Afirmacion.Name = "Afirmacion";
            this.Afirmacion.Size = new System.Drawing.Size(98, 24);
            this.Afirmacion.TabIndex = 4;
            this.Afirmacion.Text = "Realizo?";
            this.Afirmacion.UseVisualStyleBackColor = true;
            // 
            // Afirmacion1
            // 
            this.Afirmacion1.AutoSize = true;
            this.Afirmacion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afirmacion1.Location = new System.Drawing.Point(210, 157);
            this.Afirmacion1.Name = "Afirmacion1";
            this.Afirmacion1.Size = new System.Drawing.Size(98, 24);
            this.Afirmacion1.TabIndex = 5;
            this.Afirmacion1.Text = "Realizo?";
            this.Afirmacion1.UseVisualStyleBackColor = true;
            // 
            // Afirmacion2
            // 
            this.Afirmacion2.AutoSize = true;
            this.Afirmacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afirmacion2.Location = new System.Drawing.Point(210, 208);
            this.Afirmacion2.Name = "Afirmacion2";
            this.Afirmacion2.Size = new System.Drawing.Size(98, 24);
            this.Afirmacion2.TabIndex = 6;
            this.Afirmacion2.Text = "Realizo?";
            this.Afirmacion2.UseVisualStyleBackColor = true;
            // 
            // ComboCurso
            // 
            this.ComboCurso.FormattingEnabled = true;
            this.ComboCurso.Items.AddRange(new object[] {
            "Matematica",
            "Quimica",
            "Comunicacion",
            "Ingles"});
            this.ComboCurso.Location = new System.Drawing.Point(191, 101);
            this.ComboCurso.Name = "ComboCurso";
            this.ComboCurso.Size = new System.Drawing.Size(153, 21);
            this.ComboCurso.TabIndex = 7;
            this.ComboCurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(368, 51);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(106, 27);
            this.txtid.TabIndex = 8;
            // 
            // BtnSubir
            // 
            this.BtnSubir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BtnSubir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubir.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnSubir.Location = new System.Drawing.Point(48, 311);
            this.BtnSubir.Name = "BtnSubir";
            this.BtnSubir.Size = new System.Drawing.Size(125, 45);
            this.BtnSubir.TabIndex = 9;
            this.BtnSubir.Text = "Subir Notas";
            this.BtnSubir.UseVisualStyleBackColor = false;
            this.BtnSubir.Click += new System.EventHandler(this.BtnSubir_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(48, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "Formulario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblC.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.LblC.Location = new System.Drawing.Point(42, 47);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(302, 31);
            this.LblC.TabIndex = 11;
            this.LblC.Text = "Codigo de Estudiante:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(936, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(936, 441);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSubir);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.ComboCurso);
            this.Controls.Add(this.Afirmacion2);
            this.Controls.Add(this.Afirmacion1);
            this.Controls.Add(this.Afirmacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Curso";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Afirmacion;
        private System.Windows.Forms.CheckBox Afirmacion1;
        private System.Windows.Forms.CheckBox Afirmacion2;
        private System.Windows.Forms.ComboBox ComboCurso;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button BtnSubir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}