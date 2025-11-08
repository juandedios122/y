namespace restaurante.Forms
{
    partial class FormRecordatorios
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
            this.dataGridViewRecordatorios = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtEntidadID = new System.Windows.Forms.TextBox();
            this.dtpFechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecordatorios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRecordatorios
            // 
            this.dataGridViewRecordatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRecordatorios.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRecordatorios.Name = "dataGridViewRecordatorios";
            this.dataGridViewRecordatorios.RowHeadersWidth = 51;
            this.dataGridViewRecordatorios.RowTemplate.Height = 24;
            this.dataGridViewRecordatorios.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewRecordatorios.TabIndex = 0;
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
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(93, 169);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 22);
            this.txtTipo.TabIndex = 2;
            // 
            // txtEntidadID
            // 
            this.txtEntidadID.Location = new System.Drawing.Point(199, 169);
            this.txtEntidadID.Name = "txtEntidadID";
            this.txtEntidadID.Size = new System.Drawing.Size(100, 22);
            this.txtEntidadID.TabIndex = 3;
            // 
            // dtpFechaEnvio
            // 
            this.dtpFechaEnvio.Location = new System.Drawing.Point(305, 169);
            this.dtpFechaEnvio.Name = "dtpFechaEnvio";
            this.dtpFechaEnvio.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEnvio.TabIndex = 4;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(511, 169);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(100, 22);
            this.txtDestinatario.TabIndex = 5;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(617, 169);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(100, 22);
            this.txtMensaje.TabIndex = 6;
            // 
            // FormRecordatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.dtpFechaEnvio);
            this.Controls.Add(this.txtEntidadID);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridViewRecordatorios);
            this.Name = "FormRecordatorios";
            this.Text = "Gestión de Recordatorios";
            this.Load += new System.EventHandler(this.FormRecordatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecordatorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRecordatorios;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtEntidadID;
        private System.Windows.Forms.DateTimePicker dtpFechaEnvio;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}