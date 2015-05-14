using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jas.Utils.AnalyticalGrid;

namespace Jas.DataMerge {
    public partial class GridForm : Form {

        public AnalyticalGrid Grid {
            get {
                return dgv;
            }
        }

        public GridForm() {
            InitializeComponent();
        }
    }
}
