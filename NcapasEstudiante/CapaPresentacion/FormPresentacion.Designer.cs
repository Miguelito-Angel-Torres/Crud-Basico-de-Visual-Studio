
namespace CapaPresentacion
{
    partial class FormPresentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPresentacion));
            this.GridListar = new System.Windows.Forms.DataGridView();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.TxtCod = new System.Windows.Forms.TextBox();
            this.TxtPrimNo = new System.Windows.Forms.TextBox();
            this.TxtSegNo = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.TxtPriApel = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.TxtSex = new System.Windows.Forms.TextBox();
            this.TxtEma = new System.Windows.Forms.TextBox();
            this.TxtDirec = new System.Windows.Forms.TextBox();
            this.TxtCel = new System.Windows.Forms.TextBox();
            this.TxtTele = new System.Windows.Forms.TextBox();
            this.TxtSegApel = new System.Windows.Forms.TextBox();
            this.TxtPrimApel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblCodi = new System.Windows.Forms.Label();
            this.lblCur = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblObse = new System.Windows.Forms.Label();
            this.TxtObser = new System.Windows.Forms.TextBox();
            this.TxtCurso = new System.Windows.Forms.GroupBox();
            this.BtnBoNotas = new System.Windows.Forms.Button();
            this.TxtCur = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridListar)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.TxtPriApel.SuspendLayout();
            this.TxtCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridListar
            // 
            this.GridListar.AllowDrop = true;
            this.GridListar.AllowUserToOrderColumns = true;
            this.GridListar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridListar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListar.Location = new System.Drawing.Point(485, 397);
            this.GridListar.Name = "GridListar";
            this.GridListar.ReadOnly = true;
            this.GridListar.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GridListar.Size = new System.Drawing.Size(706, 272);
            this.GridListar.TabIndex = 1;
            this.GridListar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.BtnInsertar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnInsertar.Location = new System.Drawing.Point(1062, 147);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(84, 50);
            this.BtnInsertar.TabIndex = 2;
            this.BtnInsertar.Text = "Insertar Estudiante";
            this.BtnInsertar.UseVisualStyleBackColor = false;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // TxtCod
            // 
            this.TxtCod.Location = new System.Drawing.Point(283, 26);
            this.TxtCod.Name = "TxtCod";
            this.TxtCod.ReadOnly = true;
            this.TxtCod.Size = new System.Drawing.Size(100, 20);
            this.TxtCod.TabIndex = 3;
            // 
            // TxtPrimNo
            // 
            this.TxtPrimNo.Location = new System.Drawing.Point(283, 54);
            this.TxtPrimNo.Name = "TxtPrimNo";
            this.TxtPrimNo.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimNo.TabIndex = 4;
            this.TxtPrimNo.TextChanged += new System.EventHandler(this.TxtPrimNo_TextChanged);
            // 
            // TxtSegNo
            // 
            this.TxtSegNo.Location = new System.Drawing.Point(283, 93);
            this.TxtSegNo.Name = "TxtSegNo";
            this.TxtSegNo.Size = new System.Drawing.Size(100, 20);
            this.TxtSegNo.TabIndex = 5;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnModificar.Location = new System.Drawing.Point(1062, 203);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(84, 46);
            this.BtnModificar.TabIndex = 6;
            this.BtnModificar.Text = "Modificar Estudiante\r\n";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnEliminar.Location = new System.Drawing.Point(1062, 263);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(84, 40);
            this.BtnEliminar.TabIndex = 7;
            this.BtnEliminar.Text = "Eliminar Estudiante";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.SystemColors.GrayText;
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.BtnNuevo.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnNuevo.Location = new System.Drawing.Point(1062, 312);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(87, 48);
            this.BtnNuevo.TabIndex = 8;
            this.BtnNuevo.Text = "Nuevo Estudiante";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1198, 25);
            this.toolStrip1.TabIndex = 9;
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
            // TxtPriApel
            // 
            this.TxtPriApel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtPriApel.Controls.Add(this.button1);
            this.TxtPriApel.Controls.Add(this.BtnBuscar);
            this.TxtPriApel.Controls.Add(this.dateTimePicker2);
            this.TxtPriApel.Controls.Add(this.TxtSex);
            this.TxtPriApel.Controls.Add(this.TxtEma);
            this.TxtPriApel.Controls.Add(this.TxtDirec);
            this.TxtPriApel.Controls.Add(this.TxtCel);
            this.TxtPriApel.Controls.Add(this.TxtTele);
            this.TxtPriApel.Controls.Add(this.TxtSegApel);
            this.TxtPriApel.Controls.Add(this.TxtPrimApel);
            this.TxtPriApel.Controls.Add(this.label8);
            this.TxtPriApel.Controls.Add(this.label6);
            this.TxtPriApel.Controls.Add(this.label7);
            this.TxtPriApel.Controls.Add(this.label5);
            this.TxtPriApel.Controls.Add(this.label4);
            this.TxtPriApel.Controls.Add(this.label3);
            this.TxtPriApel.Controls.Add(this.label2);
            this.TxtPriApel.Controls.Add(this.label1);
            this.TxtPriApel.Controls.Add(this.label11);
            this.TxtPriApel.Controls.Add(this.LblNombre);
            this.TxtPriApel.Controls.Add(this.LblCodi);
            this.TxtPriApel.Controls.Add(this.TxtPrimNo);
            this.TxtPriApel.Controls.Add(this.TxtCod);
            this.TxtPriApel.Controls.Add(this.TxtSegNo);
            this.TxtPriApel.Location = new System.Drawing.Point(12, 93);
            this.TxtPriApel.Name = "TxtPriApel";
            this.TxtPriApel.Size = new System.Drawing.Size(467, 576);
            this.TxtPriApel.TabIndex = 11;
            this.TxtPriApel.TabStop = false;
            this.TxtPriApel.Enter += new System.EventHandler(this.TxtPriApel_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(337, 527);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 43);
            this.button1.TabIndex = 27;
            this.button1.Text = "Reporte ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnBuscar.Location = new System.Drawing.Point(389, 22);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(78, 27);
            this.BtnBuscar.TabIndex = 26;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(35, 487);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(260, 20);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // TxtSex
            // 
            this.TxtSex.Location = new System.Drawing.Point(283, 398);
            this.TxtSex.Name = "TxtSex";
            this.TxtSex.Size = new System.Drawing.Size(68, 20);
            this.TxtSex.TabIndex = 23;
            // 
            // TxtEma
            // 
            this.TxtEma.Location = new System.Drawing.Point(283, 339);
            this.TxtEma.Name = "TxtEma";
            this.TxtEma.Size = new System.Drawing.Size(100, 20);
            this.TxtEma.TabIndex = 21;
            // 
            // TxtDirec
            // 
            this.TxtDirec.Location = new System.Drawing.Point(283, 299);
            this.TxtDirec.Name = "TxtDirec";
            this.TxtDirec.Size = new System.Drawing.Size(100, 20);
            this.TxtDirec.TabIndex = 20;
            // 
            // TxtCel
            // 
            this.TxtCel.Location = new System.Drawing.Point(283, 256);
            this.TxtCel.Name = "TxtCel";
            this.TxtCel.Size = new System.Drawing.Size(100, 20);
            this.TxtCel.TabIndex = 19;
            // 
            // TxtTele
            // 
            this.TxtTele.Location = new System.Drawing.Point(283, 219);
            this.TxtTele.Name = "TxtTele";
            this.TxtTele.Size = new System.Drawing.Size(100, 20);
            this.TxtTele.TabIndex = 18;
            // 
            // TxtSegApel
            // 
            this.TxtSegApel.Location = new System.Drawing.Point(283, 181);
            this.TxtSegApel.Name = "TxtSegApel";
            this.TxtSegApel.Size = new System.Drawing.Size(100, 20);
            this.TxtSegApel.TabIndex = 17;
            // 
            // TxtPrimApel
            // 
            this.TxtPrimApel.Location = new System.Drawing.Point(283, 136);
            this.TxtPrimApel.Name = "TxtPrimApel";
            this.TxtPrimApel.Size = new System.Drawing.Size(100, 20);
            this.TxtPrimApel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(27, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sexo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(27, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 27);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(27, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha Nacimiento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(30, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Direccion :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(27, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Celular :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(27, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Telefono :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(27, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Segundo Apellido :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(30, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Primer Apellido :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(30, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(243, 27);
            this.label11.TabIndex = 7;
            this.label11.Text = "Segundo Nombre :";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblNombre.Location = new System.Drawing.Point(27, 47);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(219, 27);
            this.LblNombre.TabIndex = 7;
            this.LblNombre.Text = "Primer Nombre :";
            // 
            // LblCodi
            // 
            this.LblCodi.AutoSize = true;
            this.LblCodi.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblCodi.Location = new System.Drawing.Point(30, 19);
            this.LblCodi.Name = "LblCodi";
            this.LblCodi.Size = new System.Drawing.Size(43, 27);
            this.LblCodi.TabIndex = 6;
            this.LblCodi.Text = "ID";
            // 
            // lblCur
            // 
            this.lblCur.AutoSize = true;
            this.lblCur.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCur.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCur.Location = new System.Drawing.Point(303, 86);
            this.lblCur.Name = "lblCur";
            this.lblCur.Size = new System.Drawing.Size(90, 27);
            this.lblCur.TabIndex = 8;
            this.lblCur.Tag = "Curso";
            this.lblCur.Text = "Curso:";
            this.lblCur.Click += new System.EventHandler(this.lblCur_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.SystemColors.Menu;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblTitulo.Location = new System.Drawing.Point(12, 38);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(278, 34);
            this.LblTitulo.TabIndex = 10;
            this.LblTitulo.Text = "Registro Estudiantes";
            this.LblTitulo.Click += new System.EventHandler(this.LblTitulo_Click);
            // 
            // LblObse
            // 
            this.LblObse.AutoSize = true;
            this.LblObse.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.LblObse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LblObse.Location = new System.Drawing.Point(8, 26);
            this.LblObse.Name = "LblObse";
            this.LblObse.Size = new System.Drawing.Size(199, 27);
            this.LblObse.TabIndex = 12;
            this.LblObse.Text = "Observaciones:";
            // 
            // TxtObser
            // 
            this.TxtObser.Location = new System.Drawing.Point(23, 75);
            this.TxtObser.Multiline = true;
            this.TxtObser.Name = "TxtObser";
            this.TxtObser.Size = new System.Drawing.Size(274, 201);
            this.TxtObser.TabIndex = 12;
            this.TxtObser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TxtCurso
            // 
            this.TxtCurso.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtCurso.Controls.Add(this.BtnBoNotas);
            this.TxtCurso.Controls.Add(this.TxtCur);
            this.TxtCurso.Controls.Add(this.label9);
            this.TxtCurso.Controls.Add(this.TxtObser);
            this.TxtCurso.Controls.Add(this.label10);
            this.TxtCurso.Controls.Add(this.LblObse);
            this.TxtCurso.Controls.Add(this.lblCur);
            this.TxtCurso.Location = new System.Drawing.Point(485, 93);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(545, 298);
            this.TxtCurso.TabIndex = 13;
            this.TxtCurso.TabStop = false;
            this.TxtCurso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnBoNotas
            // 
            this.BtnBoNotas.BackColor = System.Drawing.Color.Bisque;
            this.BtnBoNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic);
            this.BtnBoNotas.Location = new System.Drawing.Point(415, 123);
            this.BtnBoNotas.Name = "BtnBoNotas";
            this.BtnBoNotas.Size = new System.Drawing.Size(100, 44);
            this.BtnBoNotas.TabIndex = 14;
            this.BtnBoNotas.Text = "Eliminar Curso";
            this.BtnBoNotas.UseVisualStyleBackColor = false;
            this.BtnBoNotas.Click += new System.EventHandler(this.BtnBoNotas_Click);
            // 
            // TxtCur
            // 
            this.TxtCur.Location = new System.Drawing.Point(399, 92);
            this.TxtCur.Name = "TxtCur";
            this.TxtCur.Size = new System.Drawing.Size(116, 20);
            this.TxtCur.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(364, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = ".";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(232, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cant de Letras:";
            // 
            // FormPresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1198, 681);
            this.Controls.Add(this.TxtCurso);
            this.Controls.Add(this.TxtPriApel);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.GridListar);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Name = "FormPresentacion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPresentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListar)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.TxtPriApel.ResumeLayout(false);
            this.TxtPriApel.PerformLayout();
            this.TxtCurso.ResumeLayout(false);
            this.TxtCurso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView GridListar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.TextBox TxtPrimNo;
        private System.Windows.Forms.TextBox TxtSegNo;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox TxtPriApel;
        private System.Windows.Forms.Label lblCur;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblCodi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSex;
        private System.Windows.Forms.TextBox TxtEma;
        private System.Windows.Forms.TextBox TxtDirec;
        private System.Windows.Forms.TextBox TxtCel;
        private System.Windows.Forms.TextBox TxtTele;
        private System.Windows.Forms.TextBox TxtSegApel;
        private System.Windows.Forms.TextBox TxtPrimApel;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label LblObse;
        private System.Windows.Forms.TextBox TxtObser;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox TxtCod;
        private System.Windows.Forms.Button BtnBoNotas;
        private System.Windows.Forms.TextBox TxtCur;
        public System.Windows.Forms.GroupBox TxtCurso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

