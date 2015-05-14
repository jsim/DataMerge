using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jas.DataMerge.Filters {
    class PairFilter : AbstractFilter {
        public override void Run() {
            createColumns();

            Dictionary<string, int> rowLookup = buildRowsLookup( key2, dgv2 );

            foreach ( DataGridViewRow rowA in dgv1.Rows ) {

                if ( !validKey( rowA, key1 ) ) {
                    continue;
                }

                string k1 = getKey( rowA, key1 );

                DataGridViewRow rowB = null;

                if ( rowLookup.ContainsKey( k1 ) ) {

                    int rowIndex = rowLookup[k1];
                    rowB = dgv2.Rows[rowIndex];

                    rowLookup.Remove( k1 );
                }

                addRows( result, rowA, rowB, rightHalf );

            }

            foreach ( int rowIndex in rowLookup.Values ) {
                DataGridViewRow rowB = dgv2.Rows[rowIndex];

                addRows( result, null, rowB, rightHalf );
            }
        }
    }
}
