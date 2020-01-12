using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TESTAPI.Models
{
    /// <summary>
    /// Purpose:ResponseMdl for Response message -Wrapper class for all json Response object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ResponseMdl<T>
    {
        T _Data;
        /// <summary>
        /// 0 for Fail, 1 for success
        /// </summary>
        public int MessageId { get; set; } = 1;
        public string Message { get; set; } = "SUCCESS";
        public T Data
        {
            get
            {
                _Data = MessageId == 1 && _Data == null ? Activator.CreateInstance<T>() : _Data;
                return _Data;
            }
            set { _Data = value; }
        }
    }
}