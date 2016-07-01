using SportsStore.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.WebUI.HtmlHelpers
{
    public static class PagingHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, PagingInfo pagingInfo, Func<int, string> pageUrl)
        {
            StringBuilder result = new StringBuilder();
            //int skip = pagingInfo.CurrentPage - pagingInfo.MaxLinks;
            //skip = skip < 0 ? 0 : skip;
            //int startPage = //pagingInfo.CurrentPage<pagingInfo.MaxLinks
            //int startPage = (pagingInfo.MaxLinks / 2 + 1) - pagingInfo.CurrentPage;
            // int middle = 
            int start = pagingInfo.CurrentPage - pagingInfo.MaxLinks / 2;
          

            int end = pagingInfo.CurrentPage + pagingInfo.MaxLinks / 2 + 1;

            if (end > pagingInfo.TotalPages)
                start -=end  - pagingInfo.TotalPages;
            end = end > pagingInfo.TotalPages ? pagingInfo.TotalPages : end;
            if (start < 0)
                end += -start;
                start = start > 0 ? start : 0;
            
            for (int i = start; i <end; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", pageUrl(i));
                tag.InnerHtml = i.ToString();
                if (i == pagingInfo.CurrentPage)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default"); result.Append(tag.ToString());
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}