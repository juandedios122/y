namespace restaurante.Forms
{
    partial class FormGestionMesas
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
            this.dataGridViewMesas = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.numCapacidad = new System.Windows.Forms.NumericUpDown();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.chkCombinable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMesas
            // 
            this.dataGridViewMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesas.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewMesas.Name = "dataGridViewMesas";
            this.dataGridViewMesas.RowHeadersWidth = 51;
            this.dataGridViewMesas.RowTemplate.Height = 24;
            this.dataGridViewMesas.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewMesas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 168);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // numCapacidad
            // 
            this.numCapacidad.Location = new System.Drawing.Point(93, 169);
            this.numCapacidad.Name = "numCapacidad";
            this.numCapacidad.Size = new System.Drawing.Size(120, 22);
            this.numCapacidad.TabIndex = 2;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(219, 169);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(100, 22);
            this.txtUbicacion.TabIndex = 3;
            // 
            // chkCombinable
            // 
            this.chkCombinable.AutoSize = true;
            this.chkCombinable.Location = new System.Drawing.Point(325, 171);
            this.chkCombinable.Name = "chkCombinable";
            this.chkCombinable.Size = new System.Drawing.Size(94, 21);
            this.chkCombinable.TabIndex = 4;
            this.chkCombinable.Text = "Combinable";
            this.chkCombinable.UseVisualStyleBackColor = true;
            // 
            // FormGestionMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkCombinable);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.numCapacidad);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewMesas);
            this.Name = "FormGestionMesas";
            this.Text = "Gestión de Mesas";
            this.Load += new System.EventHandler(this.FormGestionMesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMesas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.NumericUpDown numCapacidad;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.CheckBox chkCombinable;
    }
}