namespace pjVentaBoletas
{
    partial class fmrBoletadeVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNRecibo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.btAnadir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion del producto";
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Items.AddRange(new object[] {
            "PS5 +1 MANDO DS5",
            "PS4 (1 TB) + 1 MANDO DS4",
            "MANDO PS5/DS5",
            "MANDO PS4/DS4"});
            this.cboTipoProducto.Location = new System.Drawing.Point(321, 64);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(121, 23);
            this.cboTipoProducto.TabIndex = 4;
            this.cboTipoProducto.Text = "(Seleccione uno)";
            this.cboTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cboTipoProducto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dirección";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(696, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "N° Recibo";
            // 
            // lblNRecibo
            // 
            this.lblNRecibo.AutoSize = true;
            this.lblNRecibo.Location = new System.Drawing.Point(763, 72);
            this.lblNRecibo.Name = "lblNRecibo";
            this.lblNRecibo.Size = new System.Drawing.Size(38, 15);
            this.lblNRecibo.TabIndex = 8;
            this.lblNRecibo.Text = "label6";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 327);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(183, 124);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estadisticas";
            // 
            // btAnadir
            // 
            this.btAnadir.Location = new System.Drawing.Point(321, 169);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 11;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(321, 248);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv.GridLines = true;
            this.lv.Location = new System.Drawing.Point(16, 169);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(267, 102);
            this.lv.TabIndex = 13;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Precio";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total Importes";
            this.columnHeader2.Width = 150;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad a llevar";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(41, 119);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(263, 122);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(38, 15);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "label9";
            // 
            // fmrBoletadeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 463);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblNRecibo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmrBoletadeVenta";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmrBoletadeVenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private ComboBox cboTipoProducto;
        private Label label4;
        private TextBox textBox2;
        private Label label5;
        private Label lblNRecibo;
        private ListView listView1;
        private Label label6;
        private Button btAnadir;
        private Button btnRegistrar;
        private ListView lv;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label label7;
        private TextBox txtCantidad;
        private Label label8;
        private Label lblPrecio;
    }
}