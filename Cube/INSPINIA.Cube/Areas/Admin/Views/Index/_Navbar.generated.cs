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
    using INSPINIA.Cube;
    using NewLife;
    
    #line 1 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    
    #line 2 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Index/_Navbar.cshtml")]
    public partial class _Areas_Admin_Views_Index__Navbar_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Index__Navbar_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var uid = 0;
    if (user != null) { uid = user.ID; }
    var cfg = ViewBag.Config as SysConfig;
    var name = cfg == null ? "" : cfg.DisplayName;

            
            #line default
            #line hidden
WriteLiteral("\r\n<nav");

WriteLiteral(" class=\"navbar navbar-static-top  \"");

WriteLiteral(" role=\"navigation\"");

WriteLiteral(" style=\"margin-bottom: 0\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\r\n        <a");

WriteLiteral(" class=\"navbar-minimalize minimalize-styl-2 \"");

WriteLiteral(" style=\"color:white;\"");

WriteLiteral(" href=\"#\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-bars\"");

WriteLiteral("></i> </a>\r\n        ");

WriteLiteral("\r\n    </div>\r\n    <ul");

WriteLiteral(" class=\"nav navbar-top-links navbar-right\"");

WriteLiteral(">\r\n\r\n        <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"dropdown-toggle count-info\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-envelope\"");

WriteLiteral("></i> <span");

WriteLiteral(" class=\"label label-warning\"");

WriteLiteral("></span>\r\n            </a>\r\n            ");

WriteLiteral("\r\n        </li>\r\n        <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"dropdown-toggle count-info\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-bell\"");

WriteLiteral("></i> <span");

WriteLiteral(" class=\"label label-primary\"");

WriteLiteral("></span>\r\n            </a>\r\n            ");

WriteLiteral("\r\n        </li>\r\n\r\n        <li");

WriteLiteral(" class=\"dropdown\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"dropdown-toggle count-info\"");

WriteLiteral(" data-toggle=\"dropdown\"");

WriteLiteral(" href=\"empty_page.html#\"");

WriteLiteral(">\r\n                <i");

WriteLiteral(" class=\"fa fa-sign-out\"");

WriteLiteral(">");

            
            #line 76 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                                     Write(user);

            
            #line default
            #line hidden
WriteLiteral("</i> <span");

WriteLiteral(" class=\"label label-primary\"");

WriteLiteral("></span>\r\n            </a>\r\n            <ul");

WriteLiteral(" class=\"dropdown-menu \"");

WriteLiteral(">\r\n                <li>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 3758), Tuple.Create("\"", 3767)
, Tuple.Create(Tuple.Create("", 3765), Tuple.Create<System.Object, System.Int32>(Href("~/")
, 3765), false)
);

WriteLiteral(">\r\n                        <i");

WriteLiteral(" class=\"fa fa-home\"");

WriteLiteral("></i> 网站首页\r\n                    </a>\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

            
            #line 85 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                
            
            #line default
            #line hidden
            
            #line 85 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                 if (user.Has("Admin/Sys", PermissionFlags.Detail))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4060), Tuple.Create("\"", 4078)
, Tuple.Create(Tuple.Create("", 4067), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/Sys")
, 4067), false)
);

WriteLiteral(">\r\n                                <i");

WriteLiteral(" class=\"fa fa-cog\"");

WriteLiteral("></i> 设置\r\n                        </a>\r\n                    </li>\r\n");

WriteLiteral("                    <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

            
            #line 93 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("              \r\n                <li>\r\n                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4327), Tuple.Create("\"", 4356)
, Tuple.Create(Tuple.Create("", 4334), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/User/Info/")
, 4334), false)
            
            #line 96 "..\..\Areas\Admin\Views\Index\_Navbar.cshtml"
, Tuple.Create(Tuple.Create("", 4352), Tuple.Create<System.Object, System.Int32>(uid
            
            #line default
            #line hidden
, 4352), false)
);

WriteLiteral(">\r\n                            <i");

WriteLiteral(" class=\"fa fa-user\"");

WriteLiteral("></i>个人信息\r\n                    </a>\r\n                </li>\r\n                <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n                <li>\r\n                    <div");

WriteLiteral(" class=\"text-center link-block\"");

WriteLiteral(">\r\n                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 4618), Tuple.Create("\"", 4644)
, Tuple.Create(Tuple.Create("", 4625), Tuple.Create<System.Object, System.Int32>(Href("~/Admin/User/Logout")
, 4625), false)
);

WriteLiteral(">\r\n                            注销\r\n                            <i");

WriteLiteral(" class=\"fa fa-power-off\"");

WriteLiteral("></i>\r\n                        </a>\r\n                    </div>\r\n                " +
"</li>\r\n            </ul>\r\n        </li>\r\n\r\n        ");

WriteLiteral("\r\n    </ul>\r\n\r\n</nav>");

        }
    }
}
#pragma warning restore 1591
