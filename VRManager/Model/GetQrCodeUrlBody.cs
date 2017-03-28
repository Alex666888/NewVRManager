using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class GetQrCodeUrlBody
    {
        #region ====================== 终端二维码消费数据请求接口 请 求 参 数 ===================
        private String productId;
        //String 产品 ID
        public String ProductId
        {
            set { productId = value; }
            get { return productId; }
        }
        #endregion

        #region ===================== 终端二维码消费数据请求接口 响 应 参 数 ====================
        private String qrCodeUrl;
        //付款 url 地址
        public String QrCodeUrl
        {
            set { qrCodeUrl = value; }
            get { return qrCodeUrl; }
        }
        #endregion
    }
}
