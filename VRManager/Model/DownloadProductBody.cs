using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class DownloadProductBody
    {
        private string productId;

        /// <summary>
        /// 产品 ID
        /// </summary>
        public string ProductId
        {
            set { productId = value; }
            get { return productId; }
        }

    }
}
