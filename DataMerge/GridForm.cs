using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jas.Utils.AnalyticalGrid;
using Jas.DataMerge.Filters;

namespace Jas.DataMerge {
    public partial class GridForm : Form {

        private IFilter filter;

        public AnalyticalGrid Grid {
            get {
                return dgv;
            }
        }

        public GridForm(IFilter filter) {
            InitializeComponent();

            this.filter = filter;
        }

        private void bBackFill_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            filter.BackFill(fr.Grid1, fr.Grid2);
            fr.Show();
        }
    }
}
