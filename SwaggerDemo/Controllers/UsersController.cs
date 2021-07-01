using Newtonsoft.Json;
using SwaggerDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SwaggerDemo.Controllers
{
    /// <summary>
    /// 用户信息处理
    /// </summary>
    public class UsersController : ApiController
    {
        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public HttpResponseMessage GetAllUser()
        {
            var userList = new List<UserModel>
            {
                new UserModel
                {
                    UserName = "kris",
                    UserAge = 22,
                    UserSex = "M"
                },
                new UserModel
                {
                    UserName = "gina",
                    UserAge = 22,
                    UserSex = "W"
                },
            };
            var response = new ResponseMessage { Message = "hello", Code = "xxx" };
            var json = JsonConvert.SerializeObject(response);
            return Request.CreateResponse(HttpStatusCode.OK, userList);
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="user">用户信息</param>
        /// <param name="flag">标志位</param>
        /// <typeparamref name="UserModel"/>
        /// <returns>返回处理结果</returns>
        /// <response code="201">返回操作成功信息</response>
        /// <response code="404">
        /// 没有有效的用户
        /// <example>{"errorCode":404,"message":"没有有效的用户"}</example>
        /// </response>
        public HttpResponseMessage PostAddUser([FromBody]UserModel user,string flag)
        {
            if(user != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK,"操作成功");
            }

            return Request.CreateErrorResponse(HttpStatusCode.NotFound,"参数不能为空");
        }
    }
}
