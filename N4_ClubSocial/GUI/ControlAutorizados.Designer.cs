using System;
using System.Collections;

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
            this.gbxAutorizados = new System.Windows.Forms.GroupBox();
            this.lbxAutorizados = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregarAutorizado = new System.Windows.Forms.Button();
            this.gbxAutorizados.SuspendLayout();
            this.SuspendLayout();
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
            // lbxAutorizados
            // 
            this.lbxAutorizados.FormattingEnabled = true;
            this.lbxAutorizados.ItemHeight = 16;
            this.lbxAutorizados.Location = new System.Drawing.Point(12, 68);
            this.lbxAutorizados.Name = "lbxAutorizados";
            this.lbxAutorizados.Size = new System.Drawing.Size(288, 132);
            this.lbxAutorizados.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(288, 20);
            this.txtNombre.TabIndex = 1;
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
            // btnAgregarAutorizado
            // 
            this.btnAgregarAutorizado.Location = new System.Drawing.Point(74, 311);
            this.btnAgregarAutorizado.Name = "btnAgregarAutorizado";
            this.btnAgregarAutorizado.Size = new System.Drawing.Size(152, 23);
            this.btnAgregarAutorizado.TabIndex = 2;
            this.btnAgregarAutorizado.Text = "button1";
            this.btnAgregarAutorizado.UseVisualStyleBackColor = true;
            this.btnAgregarAutorizado.Click += new System.EventHandler(this.btnAgregarAutorizado_Click);
            // 
            // ControlAutorizados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregarAutorizado);
            this.Controls.Add(this.gbxAutorizados);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlAutorizados";
            this.Size = new System.Drawing.Size(310, 345);
            this.gbxAutorizados.ResumeLayout(false);
            this.gbxAutorizados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAutorizados;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lbxAutorizados;
        private System.Windows.Forms.Button btnAgregarAutorizado;
    }
}
