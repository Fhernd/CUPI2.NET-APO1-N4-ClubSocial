namespace N4_ClubSocial.GUI
{
    partial class ControlAfiliacion
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
            this.gbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.btnAfiliar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbxDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosPersonales
            // 
            this.gbxDatosPersonales.Controls.Add(this.btnAfiliar);
            this.gbxDatosPersonales.Controls.Add(this.txtCedula);
            this.gbxDatosPersonales.Controls.Add(this.lblCedula);
            this.gbxDatosPersonales.Controls.Add(this.txtNombre);
            this.gbxDatosPersonales.Controls.Add(this.lblNombre);
            this.gbxDatosPersonales.Location = new System.Drawing.Point(4, 5);
            this.gbxDatosPersonales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatosPersonales.Name = "gbxDatosPersonales";
            this.gbxDatosPersonales.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxDatosPersonales.Size = new System.Drawing.Size(310, 176);
            this.gbxDatosPersonales.TabIndex = 0;
            this.gbxDatosPersonales.TabStop = false;
            // 
            // btnAfiliar
            // 
            this.btnAfiliar.Location = new System.Drawing.Point(10, 125);
            this.btnAfiliar.Name = "btnAfiliar";
            this.btnAfiliar.Size = new System.Drawing.Size(294, 23);
            this.btnAfiliar.TabIndex = 4;
            this.btnAfiliar.Text = "button1";
            this.btnAfiliar.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(10, 87);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(294, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(10, 68);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(36, 16);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "label2";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(294, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 21);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(36, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label1";
            // 
            // ControlAfiliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxDatosPersonales);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlAfiliacion";
            this.Size = new System.Drawing.Size(317, 185);
            this.gbxDatosPersonales.ResumeLayout(false);
            this.gbxDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosPersonales;
        private System.Windows.Forms.Button btnAfiliar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}
