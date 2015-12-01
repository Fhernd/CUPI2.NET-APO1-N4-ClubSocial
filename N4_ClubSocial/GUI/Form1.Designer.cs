using System;
using N4_ClubSocial.Modelo;

namespace N4_ClubSocial
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.tabOperaciones = new System.Windows.Forms.TabControl();
            this.tpgAfiliar = new System.Windows.Forms.TabPage();
            this.tpgAutorizados = new System.Windows.Forms.TabPage();
            this.tpgConsumos = new System.Windows.Forms.TabPage();
            this.tpgFacturas = new System.Windows.Forms.TabPage();
            this.tpgContabilidad = new System.Windows.Forms.TabPage();
            this.tabOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOperaciones
            // 
            this.tabOperaciones.Controls.Add(this.tpgAfiliar);
            this.tabOperaciones.Controls.Add(this.tpgAutorizados);
            this.tabOperaciones.Controls.Add(this.tpgConsumos);
            this.tabOperaciones.Controls.Add(this.tpgFacturas);
            this.tabOperaciones.Controls.Add(this.tpgContabilidad);
            resources.ApplyResources(this.tabOperaciones, "tabOperaciones");
            this.tabOperaciones.Multiline = true;
            this.tabOperaciones.Name = "tabOperaciones";
            this.tabOperaciones.SelectedIndex = 0;
            // 
            // tpgAfiliar
            // 
            resources.ApplyResources(this.tpgAfiliar, "tpgAfiliar");
            this.tpgAfiliar.Name = "tpgAfiliar";
            this.tpgAfiliar.UseVisualStyleBackColor = true;
            // 
            // tpgAutorizados
            // 
            resources.ApplyResources(this.tpgAutorizados, "tpgAutorizados");
            this.tpgAutorizados.Name = "tpgAutorizados";
            this.tpgAutorizados.UseVisualStyleBackColor = true;
            // 
            // tpgConsumos
            // 
            resources.ApplyResources(this.tpgConsumos, "tpgConsumos");
            this.tpgConsumos.Name = "tpgConsumos";
            this.tpgConsumos.UseVisualStyleBackColor = true;
            // 
            // tpgFacturas
            // 
            resources.ApplyResources(this.tpgFacturas, "tpgFacturas");
            this.tpgFacturas.Name = "tpgFacturas";
            this.tpgFacturas.UseVisualStyleBackColor = true;
            // 
            // tpgContabilidad
            // 
            resources.ApplyResources(this.tpgContabilidad, "tpgContabilidad");
            this.tpgContabilidad.Name = "tpgContabilidad";
            this.tpgContabilidad.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.tabOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOperaciones;
        private System.Windows.Forms.TabPage tpgAfiliar;
        private System.Windows.Forms.TabPage tpgAutorizados;
        private System.Windows.Forms.TabPage tpgConsumos;
        private System.Windows.Forms.TabPage tpgFacturas;
        private System.Windows.Forms.TabPage tpgContabilidad;
    }
}

