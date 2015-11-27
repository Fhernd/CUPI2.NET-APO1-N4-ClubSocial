namespace N4_ClubSocial.GUI
{
    partial class ControlAutorizados
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
            this.lblCedulaSocio = new System.Windows.Forms.Label();
            this.txtCedulaSocio = new System.Windows.Forms.TextBox();
            this.btnBuscarSocio = new System.Windows.Forms.Button();
            this.gbxAutorizados = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbxAutorizados = new System.Windows.Forms.ListBox();
            this.btnAgregarAutorizado = new System.Windows.Forms.Button();
            this.gbxBusquedaSocio.SuspendLayout();
            this.gbxAutorizados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBusquedaSocio
            // 
            this.gbxBusquedaSocio.Controls.Add(this.btnBuscarSocio);
            this.gbxBusquedaSocio.Controls.Add(this.txtCedulaSocio);
            this.gbxBusquedaSocio.Controls.Add(this.lblCedulaSocio);
            this.gbxBusquedaSocio.Location = new System.Drawing.Point(4, 4);
            this.gbxBusquedaSocio.Name = "gbxBusquedaSocio";
            this.gbxBusquedaSocio.Size = new System.Drawing.Size(306, 90);
            this.gbxBusquedaSocio.TabIndex = 0;
            this.gbxBusquedaSocio.TabStop = false;
            this.gbxBusquedaSocio.Text = "groupBox1";
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
            // txtCedulaSocio
            // 
            this.txtCedulaSocio.Location = new System.Drawing.Point(154, 30);
            this.txtCedulaSocio.Name = "txtCedulaSocio";
            this.txtCedulaSocio.Size = new System.Drawing.Size(146, 20);
            this.txtCedulaSocio.TabIndex = 1;
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
            // gbxAutorizados
            // 
            this.gbxAutorizados.Controls.Add(this.lbxAutorizados);
            this.gbxAutorizados.Controls.Add(this.txtNombre);
            this.gbxAutorizados.Controls.Add(this.lblNombre);
            this.gbxAutorizados.Location = new System.Drawing.Point(4, 98);
            this.gbxAutorizados.Name = "gbxAutorizados";
            this.gbxAutorizados.Size = new System.Drawing.Size(306, 207);
            this.gbxAutorizados.TabIndex = 1;
            this.gbxAutorizados.TabStop = false;
            this.gbxAutorizados.Text = "groupBox2";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(36, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label2";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lbxAutorizados
            // 
            this.lbxAutorizados.FormattingEnabled = true;
            this.lbxAutorizados.ItemHeight = 16;
            this.lbxAutorizados.Location = new System.Drawing.Point(12, 68);
            this.lbxAutorizados.Name = "lbxAutorizados";
            this.lbxAutorizados.Size = new System.Drawing.Size(288, 132);
            this.lbxAutorizados.TabIndex = 2;
            // 
            // btnAgregarAutorizado
            // 
            this.btnAgregarAutorizado.Location = new System.Drawing.Point(74, 311);
            this.btnAgregarAutorizado.Name = "btnAgregarAutorizado";
            this.btnAgregarAutorizado.Size = new System.Drawing.Size(152, 23);
            this.btnAgregarAutorizado.TabIndex = 2;
            this.btnAgregarAutorizado.Text = "button1";
            this.btnAgregarAutorizado.UseVisualStyleBackColor = true;
            // 
            // ControlAutorizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregarAutorizado);
            this.Controls.Add(this.gbxAutorizados);
            this.Controls.Add(this.gbxBusquedaSocio);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlAutorizados";
            this.Size = new System.Drawing.Size(310, 345);
            this.gbxBusquedaSocio.ResumeLayout(false);
            this.gbxBusquedaSocio.PerformLayout();
            this.gbxAutorizados.ResumeLayout(false);
            this.gbxAutorizados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBusquedaSocio;
        private System.Windows.Forms.Button btnBuscarSocio;
        private System.Windows.Forms.TextBox txtCedulaSocio;
        private System.Windows.Forms.Label lblCedulaSocio;
        private System.Windows.Forms.GroupBox gbxAutorizados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lbxAutorizados;
        private System.Windows.Forms.Button btnAgregarAutorizado;
    }
}
