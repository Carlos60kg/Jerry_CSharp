using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayFab;
using PlayFab.AdminModels;

namespace JerryUploader
{
    class ListCatalogItemData
    {
        public List<CatalogItem> CataLogItems { get; set; }
         public ListCatalogItemData()
        {
            CataLogItems = new List<CatalogItem>();
        }
    }
}
