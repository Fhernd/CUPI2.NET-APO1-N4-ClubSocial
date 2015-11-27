namespace N4_ClubSocial.GUI
{
    partial class ControlFacturas
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
            this.gbxBusquedaSocio = new System.Windows.Forms.GroupBox();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.txtCedulaSocio = new System.Windows.Forms.TextBox();
            this.lblCedulaSocio = new System.Windows.Forms.Label();
            this.gbxFacturas = new System.Windows.Forms.GroupBox();
            this.lstFacturas = new System.Windows.Forms.ListBox();
            this.btnPagarFactura = new System.Windows.Forms.Button();
            this.gbxBusquedaSocio.SuspendLayout();
            this.gbxFacturas.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBusquedaSocio
            // 
            this.gbxBusquedaSocio.Controls.Add(this.btnBuscarSocio);
            this.gbxBusquedaSocio.Controls.Add(this.txtCedulaSocio);
            this.gbxBusquedaSocio.Controls.Add(this.lblCedulaSocio);
            this.gbxBusquedaSocio.Location = new System.Drawing.Point(4, 3);
            this.gbxBusquedaSocio.Name = "gbxBusquedaSocio";
            this.gbxBusquedaSocio.Size = new System.Drawing.Size(306, 90);
            this.gbxBusquedaSocio.TabIndex = 2;
            this.gbxBusquedaSocio.TabStop = false;
            this.gbxBusquedaSocio.Text = "groupBox1";
            // 
            // btnBuscarSocio
            // 
            this.btnBuscarSocio.Location = new System.Drawing.Point(154, 57);
            this.btnBuscarSocio.Name = "btnBuscarSocio";
            this.btnBuscarSocio.Size = new System.Drawing.Size(146, 23);
            this.btnBuscarSocio.TabIndex = 2;
            this.btnBuscarSocio.Text = "button1";
            this.btnBuscarSocio.UseVisualStyleBackColor = true;
            // 
            // txtCedulaSocio
            // 
            this.txtCedulaSocio.Location = new System.Drawing.Point(154, 30);
            this.txtCedulaSocio.Name = "txtCedulaSocio";
            this.txtCedulaSocio.Size = new System.Drawing.Size(146, 20);
            this.txtCedulaSocio.TabIndex = 1;
            // 
            // lblCedulaSocio
            // 
            this.lblCedulaSocio.AutoSize = true;
            this.lblCedulaSocio.Location = new System.Drawing.Point(6, 30);
            this.lblCedulaSocio.Name = "lblCedulaSocio";
            this.lblCedulaSocio.Size = new System.Drawing.Size(36, 16);
            this.lblCedulaSocio.TabIndex = 0;
            this.lblCedulaSocio.Text = "label1";
            // 
            // gbxFacturas
            // 
            this.gbxFacturas.Controls.Add(this.btnPagarFactura);
            this.gbxFacturas.Controls.Add(this.lstFacturas);
            this.gbxFacturas.Location = new System.Drawing.Point(4, 100);
            this.gbxFacturas.Name = "gbxFacturas";
            this.gbxFacturas.Size = new System.Drawing.Size(306, 206);
            this.gbxFacturas.TabIndex = 3;
            this.gbxFacturas.TabStop = false;
            this.gbxFacturas.Text = "groupBox1";
            // 
            // lstFacturas
            // 
            this.lstFacturas.FormattingEnabled = true;
            this.lstFacturas.ItemHeight = 16;
            this.lstFacturas.Location = new System.Drawing.Point(7, 20);
            this.lstFacturas.Name = "lstFacturas";
            this.lstFacturas.Size = new System.Drawing.Size(296, 148);
            this.lstFacturas.TabIndex = 0;
            // 
            // btnPagarFactura
            // 
            this.btnPagarFactura.Location = new System.Drawing.Point(88, 174);
            this.btnPagarFactura.Name = "btnPagarFactura";
            this.btnPagarFactura.Size = new System.Drawing.Size(123, 23);
            this.btnPagarFactura.TabIndex = 1;
            this.btnPagarFactura.Text = "button1";
            this.btnPagarFactura.UseVisualStyleBackColor = true;
            // 
            // ControlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFacturas);
            this.Controls.Add(this.gbxBusquedaSocio);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlFacturas";
            this.Size = new System.Drawing.Size(310, 345);
            this.gbxBusquedaSocio.ResumeLayout(false);
            this.gbxBusquedaSocio.PerformLayout();
            this.gbxFacturas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBusquedaSocio;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.TextBox txtCedulaSocio;
        private System.Windows.Forms.Label lblCedulaSocio;
        private System.Windows.Forms.GroupBox gbxFacturas;
        private System.Windows.Forms.Button btnPagarFactura;
        private System.Windows.Forms.ListBox lstFacturas;
    }
}
