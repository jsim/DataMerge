using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jas.DataMerge.Filters {
   public interface IFilter {

        void Init( DataGridView g1, DataGridView g2, DataGridView resultGrid, int[] key1, int[] key2 );

        void Run();

        void BackFill(DataGridView g1, DataGridView g2);
    }
}
