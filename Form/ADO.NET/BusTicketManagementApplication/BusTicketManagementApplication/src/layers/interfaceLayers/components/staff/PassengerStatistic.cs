﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.components.staff
{
    public partial class PassengerStatistic : Form
    {
        public PassengerStatistic()
        {
            InitializeComponent();
        }

        private void PassengerStatistic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookedTicketPassengerDataSet.BOOKEDTICKETPASSENGER' table. You can move, or remove it, as needed.
            this.bOOKEDTICKETPASSENGERTableAdapter.Fill(this.bookedTicketPassengerDataSet.BOOKEDTICKETPASSENGER);

            this.RvPassengerStatistic.RefreshReport();
        }
    }
}
