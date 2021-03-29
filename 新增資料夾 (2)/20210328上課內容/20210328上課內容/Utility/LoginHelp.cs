using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _20210328上課內容.Utility
{
    public class LoginHelp
    {
        private const string _sessionKey = "IsLogined";

        private const string _sessionKey_Account = "Account";

        private string _gotToUrl = "";
        /// <summary>
        /// 檢查是否登入
        /// </summary>
        /// <returns></returns>
        public static bool HasLogined()
        {
            bool? val = HttpContext.Current.Session[_sessionKey] as bool?;
            if (val.HasValue && val.Value)
            {
                return true;
            }
            else { return false; }

        }
        public static bool TryLogin(string account, string password)
        {

            if (LoginHelp.HasLogined())
            {
                return true;
            }

            DataTable dt = DBAccountManager.GetUserAccount(account);

            if(dt ==null || dt.Rows.Count == 0)
            {
                return false;
            }

            // bool isAccountRight = string.Compare("admin", account.Trim(), true) == 0;

            string DBpwd = dt.Rows[0].Field<string>("Pwd");
            string DBName = dt.Rows[0].Field<string>("Name");
            bool isPasswordRight = string.Compare(DBpwd, password.Trim()) == 0;

            if (isPasswordRight)
            {
                HttpContext.Current.Session["Account"] = DBName;
                HttpContext.Current.Session[_sessionKey] = true;
                return true;
            }
            else return false;
            
        }
        public static void Logout()
        {
            if (!LoginHelp.HasLogined())
            {
                return;
            }
            HttpContext.Current.Session.Remove(_sessionKey);
            HttpContext.Current.Session.Remove(_sessionKey_Account);
        }

        /// <summary>
        /// 取得登入者資訊，如果沒登入回傳空字串
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentUserInfo()
        {
            if (!LoginHelp.HasLogined())
            {
                return string.Empty;
            }
            else
            {
                return HttpContext.Current.Session[_sessionKey_Account] as string;
            }
            
        }
    }

}