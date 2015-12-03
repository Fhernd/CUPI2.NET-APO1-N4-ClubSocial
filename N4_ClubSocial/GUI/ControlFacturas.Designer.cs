using System;
using System.Collections;

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
            this.gbxFacturas = new System.Windows.Forms.GroupBox();
            this.btnPagarFactura = new System.Windows.Forms.Button();
            this.lstFacturas = new System.Windows.Forms.ListBox();
            this.gbxFacturas.SuspendLayout();
            this.SuspendLayout();
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
            // btnPagarFactura
            // 
            this.btnPagarFactura.Location = new System.Drawing.Point(88, 174);
            this.btnPagarFactura.Name = "btnPagarFactura";
            this.btnPagarFactura.Size = new System.Drawing.Size(123, 23);
            this.btnPagarFactura.TabIndex = 1;
            this.btnPagarFactura.Text = "button1";
            this.btnPagarFactura.UseVisualStyleBackColor = true;
            this.btnPagarFactura.Click += new System.EventHandler(this.btnPagarFactura_Click);
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
            // ControlFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxFacturas);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlFacturas";
            this.Size = new System.Drawing.Size(310, 345);
            this.gbxFacturas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxFacturas;
        private System.Windows.Forms.Button btnPagarFactura;
        private System.Windows.Forms.ListBox lstFacturas;
    }
}
