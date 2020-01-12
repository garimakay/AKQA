using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TESTAPI.Models;

namespace TESTAPI.Controllers
{
    public class HomeController : ApiController
    {
        public IHttpActionResult GET(string Data)
        {
            JObject RequestPayload = new JObject();
            try
            {
                ResponseMdl<object> returnVal = new ResponseMdl<object>();
                returnVal.MessageId = 1;
                returnVal.Message = "Success";
                returnVal.Data = NumberToWords.ConvertAmount(Convert.ToDouble(Data))?.ToUpper();
                return Ok<ResponseMdl<object>>(returnVal);
            }
            catch (ApplicationException Ex)
            {
                ResponseMdl<object> returnVal = new ResponseMdl<object>();
                returnVal.MessageId = -1;
                returnVal.Message = Ex.Message;
                return Ok<ResponseMdl<object>>(returnVal);
            }
            catch (Exception Ex)    
            {
                ResponseMdl<object> returnVal = new ResponseMdl<object>();
                returnVal = returnVal ?? new ResponseMdl<object>();
                returnVal.MessageId = 0;
                returnVal.Message = Ex.Message;
                return Ok<ResponseMdl<object>>(returnVal);
            }
        }
    }
}
