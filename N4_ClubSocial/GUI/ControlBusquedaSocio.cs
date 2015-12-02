﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N4_ClubSocial.GUI
{
    public partial class ControlBusquedaSocio: UserControl
    {
        #region Atributos interfaz
        private Principal principal;
        private Operaciones operacion;
        #endregion

        public ControlBusquedaSocio(Principal principal, Operaciones operacion)
        {
            InitializeComponent();
            ConfiguracionComponentes();
            this.principal = principal;
            this.operacion = operacion;
        }

        private void ConfiguracionComponentes()
        {
            gbxBusquedaSocio.Text = Properties.Resources.BusquedaDeSocio;
            lblCedulaSocio.Text = Properties.Resources.CedulaSocio;
            btnBuscarSocio.Text = Properties.Resources.Buscar;
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            principal.BuscarSocio(txtCedulaSocio.Text, operacion);
        }
    }
}
