using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RoutePrefix("api/scenicSpot")]
    public class BookController : ApiController
    {
        /// <summary>
        ///     获取书本详情
        /// </summary>
        /// <param name="id">书本编号.</param>
        /// <response code="200">成功.</response>
        /// <response code="404">找不到数据.</response>
        [Route("{id:int}")]
        //[ResponseType(typeof(ScenicSpotViewModel))]
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }
    }
}
