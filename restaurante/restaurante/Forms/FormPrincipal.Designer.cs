using System;
using System.Drawing;
using System.Windows.Forms;

namespace restaurante.Forms
{
    partial class FormPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRecordatorios = new System.Windows.Forms.Button();
            this.btnCelebraciones = new System.Windows.Forms.Button();
            this.btnPromociones = new System.Windows.Forms.Button();
            this.btnGestionMenus = new System.Windows.Forms.Button();
            this.btnGestionMesas = new System.Windows.Forms.Button();
            this.btnNuevaReservaMenu = new System.Windows.Forms.Button();
            this.dataGridViewReservas = new System.Windows.Forms.DataGridView();
            this.timerNoShow = new System.Windows.Forms.Timer(this.components);
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelSidebar.Controls.Add(this.btnSalir);
            this.panelSidebar.Controls.Add(this.btnRecordatorios);
            this.panelSidebar.Controls.Add(this.btnCelebraciones);
            this.panelSidebar.Controls.Add(this.btnPromociones);
            this.panelSidebar.Controls.Add(this.btnGestionMenus);
            this.panelSidebar.Controls.Add(this.btnGestionMesas);
            this.panelSidebar.Controls.Add(this.btnNuevaReservaMenu);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 561);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(10, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 40);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // btnRecordatorios
            // 
            this.btnRecordatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnRecordatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordatorios.ForeColor = System.Drawing.Color.White;
            this.btnRecordatorios.Location = new System.Drawing.Point(10, 390);
            this.btnRecordatorios.Name = "btnRecordatorios";
            this.btnRecordatorios.Size = new System.Drawing.Size(180, 40);
            this.btnRecordatorios.TabIndex = 5;
            this.btnRecordatorios.Text = "Recordatorios";
            this.btnRecordatorios.UseVisualStyleBackColor = false;
            this.btnRecordatorios.Click += new System.EventHandler(this.BtnRecordatorios_Click);
            // 
            // btnCelebraciones
            // 
            this.btnCelebraciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnCelebraciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCelebraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCelebraciones.ForeColor = System.Drawing.Color.White;
            this.btnCelebraciones.Location = new System.Drawing.Point(10, 330);
            this.btnCelebraciones.Name = "btnCelebraciones";
            this.btnCelebraciones.Size = new System.Drawing.Size(180, 40);
            this.btnCelebraciones.TabIndex = 4;
            this.btnCelebraciones.Text = "Celebraciones";
            this.btnCelebraciones.UseVisualStyleBackColor = false;
            this.btnCelebraciones.Click += new System.EventHandler(this.BtnCelebraciones_Click);
            // 
            // btnPromociones
            // 
            this.btnPromociones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnPromociones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromociones.ForeColor = System.Drawing.Color.White;
            this.btnPromociones.Location = new System.Drawing.Point(10, 270);
            this.btnPromociones.Name = "btnPromociones";
            this.btnPromociones.Size = new System.Drawing.Size(180, 40);
            this.btnPromociones.TabIndex = 3;
            this.btnPromociones.Text = "Promociones";
            this.btnPromociones.UseVisualStyleBackColor = false;
            this.btnPromociones.Click += new System.EventHandler(this.BtnGestionPromociones_Click);
            // 
            // btnGestionMenus
            // 
            this.btnGestionMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnGestionMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionMenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionMenus.ForeColor = System.Drawing.Color.White;
            this.btnGestionMenus.Location = new System.Drawing.Point(10, 210);
            this.btnGestionMenus.Name = "btnGestionMenus";
            this.btnGestionMenus.Size = new System.Drawing.Size(180, 40);
            this.btnGestionMenus.TabIndex = 2;
            this.btnGestionMenus.Text = "Gestión de Menús";
            this.btnGestionMenus.UseVisualStyleBackColor = false;
            this.btnGestionMenus.Click += new System.EventHandler(this.BtnGestionMenus_Click);
            // 
            // btnGestionMesas
            // 
            this.btnGestionMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnGestionMesas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionMesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionMesas.ForeColor = System.Drawing.Color.White;
            this.btnGestionMesas.Location = new System.Drawing.Point(10, 150);
            this.btnGestionMesas.Name = "btnGestionMesas";
            this.btnGestionMesas.Size = new System.Drawing.Size(180, 40);
            this.btnGestionMesas.TabIndex = 1;
            this.btnGestionMesas.Text = "Gestión de Mesas";
            this.btnGestionMesas.UseVisualStyleBackColor = false;
            this.btnGestionMesas.Click += new System.EventHandler(this.BtnGestionMesas_Click);
            // 
            // btnNuevaReservaMenu
            // 
            this.btnNuevaReservaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnNuevaReservaMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaReservaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaReservaMenu.ForeColor = System.Drawing.Color.White;
            this.btnNuevaReservaMenu.Location = new System.Drawing.Point(10, 90);
            this.btnNuevaReservaMenu.Name = "btnNuevaReservaMenu";
            this.btnNuevaReservaMenu.Size = new System.Drawing.Size(180, 40);
            this.btnNuevaReservaMenu.TabIndex = 0;
            this.btnNuevaReservaMenu.Text = "Nueva Reserva";
            this.btnNuevaReservaMenu.UseVisualStyleBackColor = false;
            this.btnNuevaReservaMenu.Click += new System.EventHandler(this.BtnNuevaReservaMenu_Click);
            // 
            // dataGridViewReservas
            // 
            this.dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReservas.Location = new System.Drawing.Point(210, 70);
            this.dataGridViewReservas.Name = "dataGridViewReservas";
            this.dataGridViewReservas.Size = new System.Drawing.Size(650, 450);
            this.dataGridViewReservas.TabIndex = 7;
            this.dataGridViewReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewReservas_CellContentClick);
            // 
            // timerNoShow
            // 
            this.timerNoShow.Enabled = true;
            this.timerNoShow.Interval = 60000;
            this.timerNoShow.Tick += new System.EventHandler(this.TimerNoShow_Tick);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(684, 60);
            this.panelHeader.TabIndex = 8;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelHeader_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(300, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 24);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Sabor Compañía";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dataGridViewReservas);
            this.Controls.Add(this.panelSidebar);
            this.Name = "FormPrincipal";
            this.Text = "Sabor & Compañía - Sistema de Reservas";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReservas)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnNuevaReservaMenu;
        private System.Windows.Forms.Button btnGestionMesas;
        private System.Windows.Forms.Button btnGestionMenus;
        private System.Windows.Forms.Button btnPromociones;
        private System.Windows.Forms.Button btnCelebraciones;
        private System.Windows.Forms.Button btnRecordatorios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridViewReservas;
        private System.Windows.Forms.Timer timerNoShow;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
    }
}