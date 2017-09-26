using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WKFramework.Controllers
{
    public static class Htmlhelper
    {
        public static MvcHtmlString Img(this HtmlHelper helper, string id, string url, string alternateText, object htmlAttributes)
        {

            // 创建IMG标签
            var builder = new TagBuilder("img");

            // 增加ID属性
            builder.GenerateId(id);

            // 增加属性
            builder.MergeAttribute("src", url);
            builder.MergeAttribute("alt", alternateText);
            builder.MergeAttributes(new RouteValueDictionary(htmlAttributes));

            // 输出完整的img标签
            return new MvcHtmlString(builder.ToString(TagRenderMode.SelfClosing));
        }
    }
}