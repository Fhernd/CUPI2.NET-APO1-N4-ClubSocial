namespace N4_ClubSocial.GUI
{
    partial class ControlConsumos
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
            this.gbxRegistroConsumos = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.cbxClientes = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.controlBusquedaSocio1 = new N4_ClubSocial.GUI.ControlBusquedaSocio();
            this.gbxRegistroConsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRegistroConsumos
            // 
            this.gbxRegistroConsumos.Controls.Add(this.btnRegistrar);
            this.gbxRegistroConsumos.Controls.Add(this.txtValor);
            this.gbxRegistroConsumos.Controls.Add(this.txtConcepto);
            this.gbxRegistroConsumos.Controls.Add(this.lblValor);
            this.gbxRegistroConsumos.Controls.Add(this.lblConcepto);
            this.gbxRegistroConsumos.Controls.Add(this.cbxClientes);
            this.gbxRegistroConsumos.Controls.Add(this.lblCliente);
            this.gbxRegistroConsumos.Location = new System.Drawing.Point(0, 100);
            this.gbxRegistroConsumos.Name = "gbxRegistroConsumos";
            this.gbxRegistroConsumos.Size = new System.Drawing.Size(309, 136);
            this.gbxRegistroConsumos.TabIndex = 2;
            this.gbxRegistroConsumos.TabStop = false;
            this.gbxRegistroConsumos.Text = "groupBox1";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(157, 100);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(146, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "button2";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(157, 75);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(146, 20);
            this.txtValor.TabIndex = 5;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(15, 75);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(135, 20);
            this.txtConcepto.TabIndex = 4;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(157, 55);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 16);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "label3";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(12, 55);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(36, 16);
            this.lblConcepto.TabIndex = 2;
            this.lblConcepto.Text = "label2";
            // 
            // cbxClientes
            // 
            this.cbxClientes.FormattingEnabled = true;
            this.cbxClientes.Location = new System.Drawing.Point(157, 23);
            this.cbxClientes.Name = "cbxClientes";
            this.cbxClientes.Size = new System.Drawing.Size(146, 24);
            this.cbxClientes.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(12, 29);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(36, 16);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "label1";
            // 
            // controlBusquedaSocio1
            // 
            this.controlBusquedaSocio1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlBusquedaSocio1.Location = new System.Drawing.Point(0, 0);
            this.controlBusquedaSocio1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlBusquedaSocio1.Name = "controlBusquedaSocio1";
            this.controlBusquedaSocio1.Size = new System.Drawing.Size(310, 96);
            this.controlBusquedaSocio1.TabIndex = 3;
            // 
            // ControlConsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.controlBusquedaSocio1);
            this.Controls.Add(this.gbxRegistroConsumos);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlConsumos";
            this.Size = new System.Drawing.Size(310, 345);
            this.gbxRegistroConsumos.ResumeLayout(false);
            this.gbxRegistroConsumos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxRegistroConsumos;
        private System.Windows.Forms.ComboBox cbxClientes;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblConcepto;
        private ControlBusquedaSocio controlBusquedaSocio1;
    }
}
