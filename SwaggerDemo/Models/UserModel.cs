using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerDemo.Models
{
    /// <summary>
    /// 用户模型
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// 用户名
        /// </summary>
        /// <example>kris</example>
        public string UserName { get; set; }

        /// <summary>
        /// 用户年龄
        /// </summary>
        /// <example>22</example>
        public int UserAge { get; set; }

        /// <summary>
        /// 用户性别
        /// </summary>
        /// <example>男</example>
        public string UserSex { get; set; }
    }
}