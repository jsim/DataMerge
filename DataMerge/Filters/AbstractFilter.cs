using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jas.DataMerge.Filters {
    abstract class AbstractFilter : IFilter {

        protected DataGridView dgv1;
        protected DataGridView dgv2;
        protected DataGridView result;
        protected int[] key1;
        protected int[] key2;

        protected int rightHalf = 0;

        public void Init( DataGridView g1, DataGridView g2, DataGridView resultGrid, int[] key1, int[] key2 ) {
            this.dgv1 = g1;
            this.dgv2 = g2;
            this.result = resultGrid;
            this.key1 = key1;
            this.key2 = key2;
        }

        protected void createColumns() {
            result.Columns.Clear();

            int i = 0;

            foreach ( DataGridViewColumn col in dgv1.Columns ) {
                result.Columns.Add( "col" + i, "A." + col.HeaderText );

                result.Columns[i].DefaultCellStyle.BackColor = dgv1.BackgroundColor;

                i++;
            }

            rightHalf = i;

            foreach ( DataGridViewColumn col in dgv2.Columns ) {
                result.Columns.Add( "col" + i, "B." + col.HeaderText );

                result.Columns[i].DefaultCellStyle.BackColor = dgv2.BackgroundColor;

                i++;
            }
        }

        protected Dictionary<string, int> buildRowsLookup( int[] key, DataGridView dgv ) {

            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach ( DataGridViewRow row in dgv.Rows ) {

                if ( !validKey( row, key ) ) {
                    continue;
                }

                string k = getKey( row, key );

                try {
                    map.Add( k, row.Index );
                } catch { }

            }

            return map;
        }

        protected bool validKey( DataGridViewRow row, int[] key ) {
            StringBuilder sb = new StringBuilder();

            foreach ( int i in key ) {

                object obj = row.Cells[i].Value;

                if ( obj == null ) {
                    obj = "";
                }

                sb.Append( obj.ToString() );
            }

            return !string.IsNullOrEmpty( sb.ToString().Trim() );
        }

        protected string getKey( DataGridViewRow row, int[] key ) {
            StringBuilder sb = new StringBuilder();

            foreach ( int i in key ) {

                object obj = row.Cells[i].Value;

                if ( obj == null ) {
                    obj = "";
                }

                sb.Append( obj.ToString() );
                sb.Append( "." );
            }

            return sb.ToString();
        }

        protected void addRows( DataGridView grid, DataGridViewRow rowA, DataGridViewRow rowB, int rightHalf ) {

            int newRowIndex = grid.Rows.Add();
            DataGridViewRow row = grid.Rows[newRowIndex];

            int i = 0;

            if ( rowA != null ) {
                foreach ( DataGridViewCell cell in rowA.Cells ) {

                    row.Cells[i].Value = cell.Value;

                    i++;
                }
            }

            if ( rowB != null ) {

                i = rightHalf;

                foreach ( DataGridViewCell cell in rowB.Cells ) {

                    row.Cells[i].Value = cell.Value;

                    i++;
                }
            }
        }

        public abstract void Run();
    }
}
