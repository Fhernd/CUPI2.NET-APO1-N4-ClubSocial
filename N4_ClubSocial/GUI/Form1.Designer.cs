﻿namespace N4_ClubSocial
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
            this.ctlAfiliacion = new N4_ClubSocial.GUI.ControlAfiliacion();
            this.tpgAutorizados = new System.Windows.Forms.TabPage();
            this.ctlAutorizados = new N4_ClubSocial.GUI.ControlAutorizados();
            this.tpgConsumos = new System.Windows.Forms.TabPage();
            this.ctlConsumos = new N4_ClubSocial.GUI.ControlConsumos();
            this.tpgFacturas = new System.Windows.Forms.TabPage();
            this.ctlFacturas = new N4_ClubSocial.GUI.ControlFacturas();
            this.tpgContabilidad = new System.Windows.Forms.TabPage();
            this.ctlContabilidad = new N4_ClubSocial.GUI.ControlContabilidad();
            this.tabOperaciones.SuspendLayout();
            this.tpgAfiliar.SuspendLayout();
            this.tpgAutorizados.SuspendLayout();
            this.tpgConsumos.SuspendLayout();
            this.tpgFacturas.SuspendLayout();
            this.tpgContabilidad.SuspendLayout();
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
            this.tpgAfiliar.Controls.Add(this.ctlAfiliacion);
            resources.ApplyResources(this.tpgAfiliar, "tpgAfiliar");
            this.tpgAfiliar.Name = "tpgAfiliar";
            this.tpgAfiliar.UseVisualStyleBackColor = true;
            // 
            // ctlAfiliacion
            // 
            resources.ApplyResources(this.ctlAfiliacion, "ctlAfiliacion");
            this.ctlAfiliacion.Name = "ctlAfiliacion";
            // 
            // tpgAutorizados
            // 
            this.tpgAutorizados.Controls.Add(this.ctlAutorizados);
            resources.ApplyResources(this.tpgAutorizados, "tpgAutorizados");
            this.tpgAutorizados.Name = "tpgAutorizados";
            this.tpgAutorizados.UseVisualStyleBackColor = true;
            // 
            // ctlAutorizados
            // 
            resources.ApplyResources(this.ctlAutorizados, "ctlAutorizados");
            this.ctlAutorizados.Name = "ctlAutorizados";
            // 
            // tpgConsumos
            // 
            this.tpgConsumos.Controls.Add(this.ctlConsumos);
            resources.ApplyResources(this.tpgConsumos, "tpgConsumos");
            this.tpgConsumos.Name = "tpgConsumos";
            this.tpgConsumos.UseVisualStyleBackColor = true;
            // 
            // ctlConsumos
            // 
            resources.ApplyResources(this.ctlConsumos, "ctlConsumos");
            this.ctlConsumos.Name = "ctlConsumos";
            // 
            // tpgFacturas
            // 
            this.tpgFacturas.Controls.Add(this.ctlFacturas);
            resources.ApplyResources(this.tpgFacturas, "tpgFacturas");
            this.tpgFacturas.Name = "tpgFacturas";
            this.tpgFacturas.UseVisualStyleBackColor = true;
            // 
            // ctlFacturas
            // 
            resources.ApplyResources(this.ctlFacturas, "ctlFacturas");
            this.ctlFacturas.Name = "ctlFacturas";
            // 
            // tpgContabilidad
            // 
            this.tpgContabilidad.Controls.Add(this.ctlContabilidad);
            resources.ApplyResources(this.tpgContabilidad, "tpgContabilidad");
            this.tpgContabilidad.Name = "tpgContabilidad";
            this.tpgContabilidad.UseVisualStyleBackColor = true;
            // 
            // ctlContabilidad
            // 
            resources.ApplyResources(this.ctlContabilidad, "ctlContabilidad");
            this.ctlContabilidad.Name = "ctlContabilidad";
            // 
            // Principal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabOperaciones);
            this.Name = "Principal";
            this.tabOperaciones.ResumeLayout(false);
            this.tpgAfiliar.ResumeLayout(false);
            this.tpgAutorizados.ResumeLayout(false);
            this.tpgConsumos.ResumeLayout(false);
            this.tpgFacturas.ResumeLayout(false);
            this.tpgContabilidad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOperaciones;
        private System.Windows.Forms.TabPage tpgAfiliar;
        private System.Windows.Forms.TabPage tpgAutorizados;
        private System.Windows.Forms.TabPage tpgConsumos;
        private System.Windows.Forms.TabPage tpgFacturas;
        private System.Windows.Forms.TabPage tpgContabilidad;
        private GUI.ControlAfiliacion ctlAfiliacion;
        private GUI.ControlAutorizados ctlAutorizados;
        private GUI.ControlConsumos ctlConsumos;
        private GUI.ControlFacturas ctlFacturas;
        private GUI.ControlContabilidad ctlContabilidad;
    }
}

