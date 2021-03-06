﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityEpidemicManagementSystem
{
    public partial class EmergencyAddResident : Form
    {
        public Emergency emergency { get; set; }
        public EmergencyAddResident()
        {
            InitializeComponent();
        }

        public EmergencyAddResident(Emergency emergency) : this()
        {
            this.emergency = emergency;
            this.EmergencyBindingSource.DataSource = emergency;
        }
    }
}
