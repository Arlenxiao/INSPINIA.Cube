﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    
    #line 3 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 1 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Ace_Layout_Nav.cshtml")]
    public partial class _Views_Shared__Ace_Layout_Nav_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Ace_Layout_Nav_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
  
    var menu = ManageProvider.Menu.Current;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
 if (menu != null)
{

            
            #line default
            #line hidden
WriteLiteral("    <ol");

WriteLiteral(" class=\"breadcrumb\"");

WriteLiteral(">\r\n        <li> <strong><a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" onclick=\"history.go(-1);\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-reply\"");

WriteLiteral(" style=\"font-size:16px;color:#ed5565;\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral("></i>");

WriteLiteral("</a></strong></li>\r\n        <li>\r\n");

            
            #line 12 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
            
            
            #line default
            #line hidden
            
            #line 12 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
             if (menu != null)
            {
                foreach (IMenu item in (menu as IEntityTree).AllParents)
                {
                    if (item.ID != 0)
                    {

            
            #line default
            #line hidden
WriteLiteral("                            <i>\r\n                                ");

WriteLiteral("\r\n                                <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(">");

            
            #line 20 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
                                       Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                            </i>\r\n");

            
            #line 22 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
                    }
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </li>\r\n        <li");

WriteLiteral(" class=\"active\"");

WriteLiteral(">\r\n            <i>\r\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 948), Tuple.Create("\"", 977)
            
            #line 28 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
, Tuple.Create(Tuple.Create("", 955), Tuple.Create<System.Object, System.Int32>(Url.Content(menu.Url)
            
            #line default
            #line hidden
, 955), false)
);

WriteLiteral(">");

            
            #line 28 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
                                             Write(menu != null ? menu.DisplayName : ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </i>\r\n        </li>\r\n    </ol>\r\n");

            
            #line 32 "..\..\Views\Shared\_Ace_Layout_Nav.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
