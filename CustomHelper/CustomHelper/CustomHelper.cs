using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomHelper.Models;

namespace CustomHelper
{
    public static class CustomHelper
    {
        public static IHtmlString Mytag(List<String> items)
        {
            //string ans = "<img src ='"+txt+"' alt ='no data'>";
            //return new MvcHtmlString(ans);

            if (items == null)
            {
                return MvcHtmlString.Empty;
            }

            var ul = new TagBuilder("ul");
            foreach (var item in items)
            {
                var li = new TagBuilder("li");
                li.SetInnerText(item);
                ul.InnerHtml += li.ToString();
            }

            return MvcHtmlString.Create(ul.ToString());
        }
    }
}

