using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Jas.DataMerge.Filters;
using Jas.Utils.AnalyticalGrid;
using Jas.Utils.CSVTools;

namespace Jas.DataMerge {
    public partial class Form1 : Form {

        private AnalyticalGrid workGrid;

        private ParserConfig parserConfig = ParserConfig.GetDefault();

        public Form1() {
            InitializeComponent();

            parserConfig.Delimiter = ',';
        }

        private void bLoad1_Click( object sender, EventArgs e ) {
            doLoad( dgv1 );
        }

        private void bLoad2_Click( object sender, EventArgs e ) {
            doLoad( dgv2 );
        }

        private void doLoad( AnalyticalGrid useGrid ) {

            if ( od1.ShowDialog() == System.Windows.Forms.DialogResult.OK ) {

                workGrid = useGrid;

                workGrid.Rows.Clear();
                workGrid.Columns.Clear();

                this.Enabled = false;
                Application.DoEvents();

                CSVParser parser = new CSVParser();
                parser.OnRowComplete += new CSVParser.IRowComplete( parser_OnRowComplete );

                try {

                    parserConfig.FileName = od1.FileName;

                    parser.Parse( parserConfig );

                } finally {
                    parser.OnRowComplete -= parser_OnRowComplete;
                    this.Enabled = true;
                }


            }

        }

        void parser_OnRowComplete( string[] row ) {

            assertColumns( workGrid, row );

            workGrid.Rows.Add( row );
        }

        private void assertColumns( AnalyticalGrid dgv, string[] row ) {
            if ( dgv.Columns.Count == 0 ) {
                int i = 0;
                foreach ( string s in row ) {
                    dgv.Columns.Add( "col" + i, s );

                    dgv.Columns[i].DefaultCellStyle.BackColor = dgv.BackgroundColor;

                    i++;
                }
            }
        }

        private void Form1_Resize( object sender, EventArgs e ) {
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
        }

        private void bFilterSame_Click( object sender, EventArgs e ) {
            doFilter(1);
        }

        private void bPair_Click( object sender, EventArgs e ) {
            doFilter( 2 );
        }

        private void doFilter( int mode ) {
            if ( dgv1.CurrentCell == null ) {
                MessageBox.Show( "Grid1 has no KEY columns selected!" );
                return;
            }

            if ( dgv2.CurrentCell == null ) {
                MessageBox.Show( "Grid2 has no KEY columns selected!" );
                return;
            }

            int[] key1 = getSelectedColumnIndexes( dgv1 );
            int[] key2 = getSelectedColumnIndexes( dgv2 );


            IFilter f = null;

            if ( mode == 2 ) {
                f = new PairFilter();
            }
            else {
                f = new SameFilter();
            }

            var fr = new GridForm();

            f.Init( dgv1, dgv2, fr.Grid, key1, key2 );

            f.Run();

            fr.Show();
        }

        private int[] getSelectedColumnIndexes( AnalyticalGrid dgv ) {
            List<int> cols = new List<int>();

            foreach ( DataGridViewCell cell in dgv.SelectedCells ) {
                cols.Add( cell.ColumnIndex );
            }

            cols.Sort();

            return cols.ToArray();
        }

        private void dgv_KeyDown( object sender, KeyEventArgs e ) {

            AnalyticalGrid dgv = (AnalyticalGrid)sender;

            if ( e.KeyCode == Keys.D ) {
                deleteColumns( dgv );
            }
            else if ( e.KeyCode == Keys.I) {
                createColumn( dgv );
            }
            else if ( e.KeyCode == Keys.E ) {
                excludeValue( dgv );
            }
            else if ( e.Alt && e.KeyCode == Keys.Left ) {
                spill( dgv, -1 );
            }
            else if ( e.Alt && e.KeyCode == Keys.Right ) {
                spill( dgv, 1 );
            }
        }

        private void excludeValue( AnalyticalGrid dgv ) {
            var toDel = new List<DataGridViewRow>();

            int index = dgv.CurrentCell.ColumnIndex;

            object obj = dgv.CurrentCell.Value;
            string txt = obj != null ? obj.ToString() : "";

            foreach ( DataGridViewRow row in dgv.Rows ) {
                obj = row.Cells[index].Value;
                
                string current = obj != null ? obj.ToString() : "";

                if ( txt.Equals( current ) ) {
                    toDel.Add( row );
                }
            }

            toDel.ForEach( en => dgv.Rows.Remove( en ) );
        }

        private void spill( AnalyticalGrid dgv, int side ) {
            
            object obj = dgv.CurrentCell.Value;
            string txt = obj != null ? obj.ToString() : "";

            bool reset = false;

            int src = dgv.CurrentCell.ColumnIndex;
            int dst = src + side;

            for ( int i = dgv.CurrentCell.RowIndex; i < dgv.Rows.Count; i++ ) {

                obj = dgv.Rows[i].Cells[src].Value;
                string stopper = obj != null ? obj.ToString().Trim() : "";

                if ( string.IsNullOrEmpty( stopper ) ) {
                    reset = true;
                    txt = string.Empty;
                }
                else {

                    if ( reset ) {
                        reset = false;
                        txt = stopper;
                    }

                }

                dgv.Rows[i].Cells[dst].Value = txt;

            }
        }

        private void createColumn( AnalyticalGrid dgv ) {

            if ( dgv.CurrentCell == null ) {
                return;
            }

            DataGridViewColumn newColumn = new DataGridViewTextBoxColumn();
            dgv.Columns.Insert( dgv.CurrentCell.ColumnIndex, newColumn );
            
        }

        private void deleteColumns( AnalyticalGrid dgv ) {
            List<DataGridViewColumn> cols = new List<DataGridViewColumn>();

            foreach ( DataGridViewCell cell in dgv.SelectedCells ) {
                cols.Add(dgv.Columns[cell.ColumnIndex]);
            }

            foreach ( var col in cols ) {
                dgv.Columns.Remove( col );
            }
        }

        private void bCsvConfig_Click( object sender, EventArgs e ) {
            var newConfig = Jas.Utils.CSVTools.Forms.SettingsForm.GetConfig( parserConfig );

            if ( newConfig != null ) {
                parserConfig = newConfig;
            }
        }

        
    }
}
