using Microsoft.AspNetCore.Mvc;

namespace MoMaWeb.Controllers
{
    /// <summary>
    /// 路由方式2：特性路哟
    /// 只能选择一种路由方式
    /// </summary>
    [Route("xxx/[controller]/[action]")]
    public class TestController : Controller
    {
       // [Route("[action]")]
        public void GetResult()
        {
            //Todo
        }
    }
}