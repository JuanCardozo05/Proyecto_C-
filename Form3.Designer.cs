namespace ProyectoFinalPrg
{
    partial class Form3
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
            this.checkBox_iva = new System.Windows.Forms.CheckBox();
            this.checkBox_sinIVA = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_iva
            // 
            this.checkBox_iva.AutoSize = true;
            this.checkBox_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_iva.Location = new System.Drawing.Point(86, 380);
            this.checkBox_iva.Name = "checkBox_iva";
            this.checkBox_iva.Size = new System.Drawing.Size(55, 24);
            this.checkBox_iva.TabIndex = 1;
            this.checkBox_iva.Text = "IVA";
            this.checkBox_iva.UseVisualStyleBackColor = true;
            this.checkBox_iva.CheckedChanged += new System.EventHandler(this.checkBox_iva_CheckedChanged);
            // 
            // checkBox_sinIVA
            // 
            this.checkBox_sinIVA.AutoSize = true;
            this.checkBox_sinIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_sinIVA.Location = new System.Drawing.Point(86, 410);
            this.checkBox_sinIVA.Name = "checkBox_sinIVA";
            this.checkBox_sinIVA.Size = new System.Drawing.Size(82, 24);
            this.checkBox_sinIVA.TabIndex = 2;
            this.checkBox_sinIVA.Text = "Sin IVA";
            this.checkBox_sinIVA.UseVisualStyleBackColor = true;
            this.checkBox_sinIVA.CheckedChanged += new System.EventHandler(this.checkBox_sinIVA_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(86, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 318);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(226, 381);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(442, 381);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Precio Total=";
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.AutoSize = true;
            this.PrecioTotal.Location = new System.Drawing.Point(618, 362);
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.Size = new System.Drawing.Size(37, 13);
            this.PrecioTotal.TabIndex = 8;
            this.PrecioTotal.Text = "$$$$$";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Agregar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PrecioTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.checkBox_sinIVA);
            this.Controls.Add(this.checkBox_iva);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_iva;
        private System.Windows.Forms.CheckBox checkBox_sinIVA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PrecioTotal;
        private System.Windows.Forms.Button button2;
    }
}