using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRManager.Model
{
    public class AuthenticationBody
    {
        #region ========= 用 户 鉴 权 接 口 请 求 信 息 ================

        private string username;
        /// <summary>
        /// 用户名称
        /// </summary>
        public String UserName
        {
            set { username = value; }
            get { return username; }
        }

        private string password;
        /// <summary>
        /// 用户密码
        /// </summary>
        public String PassWord
        {
            set { password = value; }
            get { return password; }
        }

        private string consoleName;
        /// <summary>
        /// 头显名称或编号
        /// </summary>
        public string ConsoleName
        {
            set { consoleName = value; }
            get { return consoleName; }
        }

        #endregion

        #region ===================用 户 鉴 权 响 应 参 数==============
        private Object urls;
        /// <summary>
        /// 加载 url 地址
        /// </summary>
        public Object URLS
        {
            set { urls = value; }
            get { return urls; }
        }

        private Object userInfo;
        /// <summary>
        /// 
        /// </summary>
        public Object UserInfo
        {
            set { userInfo = value; }
            get { return userInfo; }
        }
        #endregion
    }

    #region ============= URLS 的 结 构 体 信 息 ==========================
    public struct Urls
    {
        private int menuID;
        /// <summary>
        /// 菜单顺序
        /// </summary>
        public int MenuID
        {
            set { menuID = value; }
            get { return menuID; }
        }

        private string menuName;
        /// <summary>
        /// MenuName string 菜单名称
        /// </summary>
        public string MenuName
        {
            set { menuName = value; }
            get { return menuName; }
        }

        private int menuType;
        /// <summary>
        ///MenuType int 菜单类型
        ///0: 页面控制菜单， url 参数有效
        ///1: 控制台控制菜单
        /// </summary>
        public int MenuType
        {
            set { menuType = value; }
            get { return menuType; }
        }

        private string url;

        /// <summary>
        /// url string 页面菜单的 url
        /// </summary>
        public string URL
        {
            set { url = value; }
            get { return url; }
        }
    }
    #endregion


    #region =================== UserInfo 数 据 结 构 ======================
    public struct UserInfo
    {
        private string id;
        /// <summary>
        /// id String 用户唯一主键
        /// </summary>
        public String ID
        {
            set { id = value; }
            get { return id; }
        }

        private string userType;
        /// <summary>
        /// userType string 用户 类型 0:个人用户，1:企业用户
        /// </summary>
        public string UserType
        {
            set { userType = value; }
            get { return userType; }
        }

        private string username;
        /// <summary>
        /// userName int 用户名称
        /// </summary>
        public string UserName
        {
            set { username = value; }
            get { return username; }
        }
    }
    #endregion

}