namespace ProyectoFinalPrg
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.Articulos = new System.Windows.Forms.ListBox();
            this.cmb_ArticuloComprar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.limpiar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nombreProducto = new System.Windows.Forms.TextBox();
            this.textBox_precioProducto = new System.Windows.Forms.TextBox();
            this.btn_facturar = new System.Windows.Forms.Button();
            this.btn_pasar = new System.Windows.Forms.Button();
            this.btn_devolver = new System.Windows.Forms.Button();
            this.lisBox_carritoCompra = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(365, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Size = new System.Drawing.Size(96, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "El vecinito";
            // 
            // Articulos
            // 
            this.Articulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Articulos.FormattingEnabled = true;
            this.Articulos.ItemHeight = 18;
            this.Articulos.Location = new System.Drawing.Point(177, 69);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(237, 328);
            this.Articulos.TabIndex = 1;
            // 
            // cmb_ArticuloComprar
            // 
            this.cmb_ArticuloComprar.FormattingEnabled = true;
            this.cmb_ArticuloComprar.Location = new System.Drawing.Point(432, 68);
            this.cmb_ArticuloComprar.Name = "cmb_ArticuloComprar";
            this.cmb_ArticuloComprar.Size = new System.Drawing.Size(157, 21);
            this.cmb_ArticuloComprar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Articulos Disponibles";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(213, 405);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 7;
            this.limpiar.Text = "limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.LimeGreen;
            this.Agregar.Location = new System.Drawing.Point(47, 207);
            this.Agregar.Margin = new System.Windows.Forms.Padding(0);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.BackColor = System.Drawing.Color.Red;
            this.Eliminar.Location = new System.Drawing.Point(316, 405);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 9;
            this.Eliminar.TabStop = false;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Articulos a comprar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nombre del producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Precio del producto";
            // 
            // textBox_nombreProducto
            // 
            this.textBox_nombreProducto.Location = new System.Drawing.Point(43, 92);
            this.textBox_nombreProducto.Name = "textBox_nombreProducto";
            this.textBox_nombreProducto.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombreProducto.TabIndex = 15;
            // 
            // textBox_precioProducto
            // 
            this.textBox_precioProducto.Location = new System.Drawing.Point(43, 154);
            this.textBox_precioProducto.Name = "textBox_precioProducto";
            this.textBox_precioProducto.Size = new System.Drawing.Size(100, 20);
            this.textBox_precioProducto.TabIndex = 16;
            // 
            // btn_facturar
            // 
            this.btn_facturar.Location = new System.Drawing.Point(630, 405);
            this.btn_facturar.Name = "btn_facturar";
            this.btn_facturar.Size = new System.Drawing.Size(119, 33);
            this.btn_facturar.TabIndex = 17;
            this.btn_facturar.Text = "Facturar";
            this.btn_facturar.UseVisualStyleBackColor = true;
            this.btn_facturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pasar
            // 
            this.btn_pasar.Location = new System.Drawing.Point(432, 317);
            this.btn_pasar.Name = "btn_pasar";
            this.btn_pasar.Size = new System.Drawing.Size(75, 23);
            this.btn_pasar.TabIndex = 18;
            this.btn_pasar.Text = "---->";
            this.btn_pasar.UseVisualStyleBackColor = true;
            this.btn_pasar.Click += new System.EventHandler(this.btn_pasar_Click);
            // 
            // btn_devolver
            // 
            this.btn_devolver.Location = new System.Drawing.Point(432, 346);
            this.btn_devolver.Name = "btn_devolver";
            this.btn_devolver.Size = new System.Drawing.Size(75, 23);
            this.btn_devolver.TabIndex = 19;
            this.btn_devolver.Text = "<-----";
            this.btn_devolver.UseVisualStyleBackColor = true;
            this.btn_devolver.Click += new System.EventHandler(this.btn_devolver_Click);
            // 
            // lisBox_carritoCompra
            // 
            this.lisBox_carritoCompra.FormattingEnabled = true;
            this.lisBox_carritoCompra.Location = new System.Drawing.Point(604, 68);
            this.lisBox_carritoCompra.Name = "lisBox_carritoCompra";
            this.lisBox_carritoCompra.Size = new System.Drawing.Size(157, 329);
            this.lisBox_carritoCompra.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Carrito de compra";
            // 
            // btn_comprar
            // 
            this.btn_comprar.Location = new System.Drawing.Point(522, 335);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(67, 21);
            this.btn_comprar.TabIndex = 22;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lisBox_carritoCompra);
            this.Controls.Add(this.btn_devolver);
            this.Controls.Add(this.btn_pasar);
            this.Controls.Add(this.btn_facturar);
            this.Controls.Add(this.textBox_precioProducto);
            this.Controls.Add(this.textBox_nombreProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_ArticuloComprar);
            this.Controls.Add(this.Articulos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox Articulos;
        public System.Windows.Forms.ComboBox cmb_ArticuloComprar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox textBox_nombreProducto;
        public System.Windows.Forms.TextBox textBox_precioProducto;
        public System.Windows.Forms.Button btn_facturar;
        public System.Windows.Forms.Button btn_pasar;
        public System.Windows.Forms.Button btn_devolver;
        public System.Windows.Forms.ListBox lisBox_carritoCompra;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Button btn_comprar;
    }
}