using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class GetProductInfoBody
    {
        #region =======================下 载 /更 新 接 口 请 求 参 数 ===============
        private String productId;
        /// <summary>
        /// 产品 ID
        /// </summary>
        public String ProductId
        {
            set { productId = value; }
            get { return productId; }
        }
        #endregion 

        #region====================下 载 /更 新 接 口 响 应 参 数 ==================
        private String productName;
        /// <summary>
        /// 产品名称
        /// </summary>
        public String ProductName
        {
            set { productName = value; }
            get { return productName; }
        }

        private String version;
        /// <summary>
        /// 产品版本
        /// </summary>
        public String Version
        {
            set { version = value; }
            get { return version; }
        }

        private int productType;
        /// <summary>
        /// 产品类型
        /// </summary>
        public int ProductType
        {
            set { productType = value; }
            get { return productType; }
        }

        private string preview;
        /// <summary>
        /// 产品预览图， 用逗号分隔多图的 URL
        /// </summary>
        public string Preview
        {
            set { preview = value; }
            get { return preview; }
        }

        private String cover;
        /// <summary>
        /// 产品封面下载 url
        /// </summary>
        public String Cover
        {
            set { cover = value; }
            get { return cover; }
        }

        private String productUrl;
        /// <summary>
        /// 产品下载 url
        /// </summary>
        public String ProductUrl
        {
            set { productUrl = value; }
            get { return productUrl; }
        }

        private string productScript;
        /// <summary>
        /// 产品描述
        /// </summary>
        public String ProductScript
        {
            set { productScript = value; }
            get { return productScript; }
        }
        #endregion
    }
}
