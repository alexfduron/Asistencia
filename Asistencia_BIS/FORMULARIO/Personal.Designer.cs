namespace Asistencia_BIS.FORMULARIO
{
    partial class Personal
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnl_Buscar = new System.Windows.Forms.Panel();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.DGV_Personal = new System.Windows.Forms.DataGridView();
            this.Pnl_Paginado = new System.Windows.Forms.Panel();
            this.TLP_Navegador = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_Btn_Nav1 = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_Btn_Nav2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pnl_RegistroInf = new System.Windows.Forms.Panel();
            this.btn_Pag_Ant = new System.Windows.Forms.Button();
            this.btn_Pag_Sig = new System.Windows.Forms.Button();
            this.btn_Pri_Pag = new System.Windows.Forms.Button();
            this.btn_Ult_Pag = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Personal)).BeginInit();
            this.Pnl_Paginado.SuspendLayout();
            this.TLP_Navegador.SuspendLayout();
            this.TLP_Btn_Nav1.SuspendLayout();
            this.TLP_Btn_Nav2.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Titulo);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btn_Agregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 133);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Titulo.Font = new System.Drawing.Font("Consolas", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(1234, 87);
            this.lbl_Titulo.TabIndex = 10;
            this.lbl_Titulo.Text = "Titulo";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnl_Buscar);
            this.panel6.Controls.Add(this.txt_Buscar);
            this.panel6.Controls.Add(this.panel20);
            this.panel6.Controls.Add(this.btn_Buscar);
            this.panel6.Controls.Add(this.panel19);
            this.panel6.Controls.Add(this.btn_Borrar);
            this.panel6.Controls.Add(this.panel15);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1234, 46);
            this.panel6.TabIndex = 6;
            // 
            // pnl_Buscar
            // 
            this.pnl_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_Buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Buscar.Location = new System.Drawing.Point(0, 43);
            this.pnl_Buscar.Name = "pnl_Buscar";
            this.pnl_Buscar.Size = new System.Drawing.Size(1088, 3);
            this.pnl_Buscar.TabIndex = 5;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.Black;
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Buscar.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar.ForeColor = System.Drawing.Color.White;
            this.txt_Buscar.Location = new System.Drawing.Point(0, 0);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(1088, 43);
            this.txt_Buscar.TabIndex = 1;
            this.txt_Buscar.Enter += new System.EventHandler(this.txt_Buscar_Enter);
            this.txt_Buscar.Leave += new System.EventHandler(this.txt_Buscar_Leave);
            this.txt_Buscar.MouseLeave += new System.EventHandler(this.txt_Buscar_MouseLeave);
            this.txt_Buscar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txt_Buscar_MouseMove);
            // 
            // panel20
            // 
            this.panel20.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel20.Location = new System.Drawing.Point(1088, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(10, 46);
            this.panel20.TabIndex = 12;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel19.Location = new System.Drawing.Point(1156, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(10, 46);
            this.panel19.TabIndex = 11;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(1224, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 46);
            this.panel15.TabIndex = 10;
            // 
            // DGV_Personal
            // 
            this.DGV_Personal.AllowUserToAddRows = false;
            this.DGV_Personal.AllowUserToDeleteRows = false;
            this.DGV_Personal.AllowUserToResizeRows = false;
            this.DGV_Personal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_Personal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_Personal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Personal.Location = new System.Drawing.Point(1033, 183);
            this.DGV_Personal.Name = "DGV_Personal";
            this.DGV_Personal.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DGV_Personal.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.DGV_Personal.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Gray;
            this.DGV_Personal.RowTemplate.Height = 24;
            this.DGV_Personal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Personal.Size = new System.Drawing.Size(133, 101);
            this.DGV_Personal.TabIndex = 1;
            // 
            // Pnl_Paginado
            // 
            this.Pnl_Paginado.Controls.Add(this.TLP_Navegador);
            this.Pnl_Paginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Paginado.Location = new System.Drawing.Point(0, 668);
            this.Pnl_Paginado.Name = "Pnl_Paginado";
            this.Pnl_Paginado.Size = new System.Drawing.Size(1363, 102);
            this.Pnl_Paginado.TabIndex = 2;
            // 
            // TLP_Navegador
            // 
            this.TLP_Navegador.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TLP_Navegador.ColumnCount = 3;
            this.TLP_Navegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TLP_Navegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.TLP_Navegador.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TLP_Navegador.Controls.Add(this.TLP_Btn_Nav1, 0, 0);
            this.TLP_Navegador.Controls.Add(this.TLP_Btn_Nav2, 2, 0);
            this.TLP_Navegador.Controls.Add(this.panel21, 1, 0);
            this.TLP_Navegador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Navegador.Location = new System.Drawing.Point(0, 0);
            this.TLP_Navegador.Name = "TLP_Navegador";
            this.TLP_Navegador.RowCount = 1;
            this.TLP_Navegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Navegador.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.TLP_Navegador.Size = new System.Drawing.Size(1363, 102);
            this.TLP_Navegador.TabIndex = 0;
            // 
            // TLP_Btn_Nav1
            // 
            this.TLP_Btn_Nav1.ColumnCount = 3;
            this.TLP_Btn_Nav1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Btn_Nav1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Btn_Nav1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Btn_Nav1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Btn_Nav1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Btn_Nav1.Controls.Add(this.btn_Pag_Ant, 0, 1);
            this.TLP_Btn_Nav1.Controls.Add(this.btn_Pag_Sig, 2, 1);
            this.TLP_Btn_Nav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Btn_Nav1.Location = new System.Drawing.Point(4, 4);
            this.TLP_Btn_Nav1.Name = "TLP_Btn_Nav1";
            this.TLP_Btn_Nav1.RowCount = 3;
            this.TLP_Btn_Nav1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Btn_Nav1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Btn_Nav1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Btn_Nav1.Size = new System.Drawing.Size(442, 94);
            this.TLP_Btn_Nav1.TabIndex = 0;
            // 
            // TLP_Btn_Nav2
            // 
            this.TLP_Btn_Nav2.ColumnCount = 3;
            this.TLP_Btn_Nav2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Btn_Nav2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Btn_Nav2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Btn_Nav2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Btn_Nav2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Btn_Nav2.Controls.Add(this.btn_Pri_Pag, 0, 1);
            this.TLP_Btn_Nav2.Controls.Add(this.btn_Ult_Pag, 2, 1);
            this.TLP_Btn_Nav2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Btn_Nav2.Location = new System.Drawing.Point(916, 4);
            this.TLP_Btn_Nav2.Name = "TLP_Btn_Nav2";
            this.TLP_Btn_Nav2.RowCount = 3;
            this.TLP_Btn_Nav2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Btn_Nav2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Btn_Nav2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.TLP_Btn_Nav2.Size = new System.Drawing.Size(443, 94);
            this.TLP_Btn_Nav2.TabIndex = 1;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(453, 4);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(456, 94);
            this.panel21.TabIndex = 2;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.label5);
            this.panel22.Controls.Add(this.label4);
            this.panel22.Controls.Add(this.label3);
            this.panel22.Controls.Add(this.label2);
            this.panel22.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel22.Location = new System.Drawing.Point(68, 22);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(313, 52);
            this.panel22.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(227, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 52);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(179, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 52);
            this.label4.TabIndex = 9;
            this.label4.Text = "de";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 52);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pagina:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 535);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1353, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 535);
            this.panel4.TabIndex = 4;
            // 
            // Pnl_RegistroInf
            // 
            this.Pnl_RegistroInf.Location = new System.Drawing.Point(39, 150);
            this.Pnl_RegistroInf.Name = "Pnl_RegistroInf";
            this.Pnl_RegistroInf.Size = new System.Drawing.Size(954, 487);
            this.Pnl_RegistroInf.TabIndex = 8;
            // 
            // btn_Pag_Ant
            // 
            this.btn_Pag_Ant.BackgroundImage = global::Asistencia_BIS.Properties.Resources.Btn_L2_transparent;
            this.btn_Pag_Ant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pag_Ant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pag_Ant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Pag_Ant.FlatAppearance.BorderSize = 0;
            this.btn_Pag_Ant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Pag_Ant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Pag_Ant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pag_Ant.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pag_Ant.ForeColor = System.Drawing.Color.White;
            this.btn_Pag_Ant.Location = new System.Drawing.Point(3, 13);
            this.btn_Pag_Ant.Name = "btn_Pag_Ant";
            this.btn_Pag_Ant.Size = new System.Drawing.Size(205, 68);
            this.btn_Pag_Ant.TabIndex = 3;
            this.btn_Pag_Ant.Text = "Pagina\r\nAnterior";
            this.btn_Pag_Ant.UseVisualStyleBackColor = true;
            this.btn_Pag_Ant.MouseLeave += new System.EventHandler(this.btn_Pag_Ant_MouseLeave);
            this.btn_Pag_Ant.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Pag_Ant_MouseMove);
            // 
            // btn_Pag_Sig
            // 
            this.btn_Pag_Sig.BackgroundImage = global::Asistencia_BIS.Properties.Resources.Btn_R2_transparent;
            this.btn_Pag_Sig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pag_Sig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pag_Sig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Pag_Sig.FlatAppearance.BorderSize = 0;
            this.btn_Pag_Sig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Pag_Sig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Pag_Sig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pag_Sig.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pag_Sig.ForeColor = System.Drawing.Color.White;
            this.btn_Pag_Sig.Location = new System.Drawing.Point(234, 13);
            this.btn_Pag_Sig.Name = "btn_Pag_Sig";
            this.btn_Pag_Sig.Size = new System.Drawing.Size(205, 68);
            this.btn_Pag_Sig.TabIndex = 4;
            this.btn_Pag_Sig.Text = "Pagina\r\nSiguiente";
            this.btn_Pag_Sig.UseVisualStyleBackColor = true;
            this.btn_Pag_Sig.MouseLeave += new System.EventHandler(this.btn_Pag_Sig_MouseLeave);
            this.btn_Pag_Sig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Pag_Sig_MouseMove);
            // 
            // btn_Pri_Pag
            // 
            this.btn_Pri_Pag.BackgroundImage = global::Asistencia_BIS.Properties.Resources.Btn_LL2_transparent;
            this.btn_Pri_Pag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pri_Pag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pri_Pag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Pri_Pag.FlatAppearance.BorderSize = 0;
            this.btn_Pri_Pag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Pri_Pag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Pri_Pag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pri_Pag.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pri_Pag.ForeColor = System.Drawing.Color.White;
            this.btn_Pri_Pag.Location = new System.Drawing.Point(3, 13);
            this.btn_Pri_Pag.Name = "btn_Pri_Pag";
            this.btn_Pri_Pag.Size = new System.Drawing.Size(205, 68);
            this.btn_Pri_Pag.TabIndex = 3;
            this.btn_Pri_Pag.Text = "Primera\r\nPagina\r\n";
            this.btn_Pri_Pag.UseVisualStyleBackColor = true;
            this.btn_Pri_Pag.MouseLeave += new System.EventHandler(this.btn_Pri_Pag_MouseLeave);
            this.btn_Pri_Pag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Pri_Pag_MouseMove);
            // 
            // btn_Ult_Pag
            // 
            this.btn_Ult_Pag.BackgroundImage = global::Asistencia_BIS.Properties.Resources.Btn_RR2_transparent;
            this.btn_Ult_Pag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ult_Pag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ult_Pag.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Ult_Pag.FlatAppearance.BorderSize = 0;
            this.btn_Ult_Pag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Ult_Pag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Ult_Pag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ult_Pag.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ult_Pag.ForeColor = System.Drawing.Color.White;
            this.btn_Ult_Pag.Location = new System.Drawing.Point(234, 13);
            this.btn_Ult_Pag.Name = "btn_Ult_Pag";
            this.btn_Ult_Pag.Size = new System.Drawing.Size(206, 68);
            this.btn_Ult_Pag.TabIndex = 4;
            this.btn_Ult_Pag.Text = "Ultima\r\nPagina\r\n";
            this.btn_Ult_Pag.UseVisualStyleBackColor = true;
            this.btn_Ult_Pag.MouseLeave += new System.EventHandler(this.btn_Ult_Pag_MouseLeave);
            this.btn_Ult_Pag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Ult_Pag_MouseMove);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Image = global::Asistencia_BIS.Properties.Resources.buscar_2;
            this.btn_Buscar.Location = new System.Drawing.Point(1098, 0);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(58, 46);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Borrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Borrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Borrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Borrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Borrar.Image = global::Asistencia_BIS.Properties.Resources.borrador;
            this.btn_Borrar.Location = new System.Drawing.Point(1166, 0);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(58, 46);
            this.btn_Borrar.TabIndex = 8;
            this.btn_Borrar.UseVisualStyleBackColor = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Agregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Agregar.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Agregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Agregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Image = global::Asistencia_BIS.Properties.Resources.mas3;
            this.btn_Agregar.Location = new System.Drawing.Point(1234, 0);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(129, 133);
            this.btn_Agregar.TabIndex = 9;
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Pnl_RegistroInf);
            this.Controls.Add(this.DGV_Personal);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Pnl_Paginado);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(1363, 770);
            this.Load += new System.EventHandler(this.Personal_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Personal)).EndInit();
            this.Pnl_Paginado.ResumeLayout(false);
            this.TLP_Navegador.ResumeLayout(false);
            this.TLP_Btn_Nav1.ResumeLayout(false);
            this.TLP_Btn_Nav2.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Personal;
        private System.Windows.Forms.Panel Pnl_Paginado;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnl_Buscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TableLayoutPanel TLP_Navegador;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TableLayoutPanel TLP_Btn_Nav1;
        private System.Windows.Forms.Button btn_Pag_Ant;
        private System.Windows.Forms.Button btn_Pag_Sig;
        private System.Windows.Forms.TableLayoutPanel TLP_Btn_Nav2;
        private System.Windows.Forms.Button btn_Pri_Pag;
        private System.Windows.Forms.Button btn_Ult_Pag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Panel Pnl_RegistroInf;
    }
}
