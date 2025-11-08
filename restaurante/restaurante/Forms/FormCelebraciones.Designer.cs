namespace restaurante.Forms
{
    partial class FormCelebraciones
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
            this.dataGridViewCelebraciones = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.dtpFechaHora = new System.Windows.Forms.DateTimePicker();
            this.numPersonas = new System.Windows.Forms.NumericUpDown();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCelebraciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCelebraciones
            // 
            this.dataGridViewCelebraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCelebraciones.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCelebraciones.Name = "dataGridViewCelebraciones";
            this.dataGridViewCelebraciones.RowHeadersWidth = 51;
            this.dataGridViewCelebraciones.RowTemplate.Height = 24;
            this.dataGridViewCelebraciones.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewCelebraciones.TabIndex = 0;
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
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(93, 169);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(100, 22);
            this.txtClienteID.TabIndex = 2;
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(199, 169);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(100, 22);
            this.txtNombreEvento.TabIndex = 3;
            // 
            // dtpFechaHora
            // 
            this.dtpFechaHora.Location = new System.Drawing.Point(305, 169);
            this.dtpFechaHora.Name = "dtpFechaHora";
            this.dtpFechaHora.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaHora.TabIndex = 4;
            // 
            // numPersonas
            // 
            this.numPersonas.Location = new System.Drawing.Point(511, 169);
            this.numPersonas.Name = "numPersonas";
            this.numPersonas.Size = new System.Drawing.Size(120, 22);
            this.numPersonas.TabIndex = 5;
            // 
            // txtNotas
            // 
            this.txtNotas.Location = new System.Drawing.Point(637, 169);
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(100, 22);
            this.txtNotas.TabIndex = 6;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(743, 169);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 22);
            this.txtEstado.TabIndex = 7;
            // 
            // FormCelebraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.numPersonas);
            this.Controls.Add(this.dtpFechaHora);
            this.Controls.Add(this.txtNombreEvento);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewCelebraciones);
            this.Name = "FormCelebraciones";
            this.Text = "Gestión de Celebraciones";
            this.Load += new System.EventHandler(this.FormCelebraciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCelebraciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCelebraciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.DateTimePicker dtpFechaHora;
        private System.Windows.Forms.NumericUpDown numPersonas;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtEstado;
    }
}