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
    
    #line 1 "..\..\Views\Shared\_List_Data_Menu.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Menu.cshtml")]
    public partial class _Views_Shared__List_Data_Menu_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Menu_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_List_Data_Menu.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;

            
            #line default
            #line hidden
WriteLiteral("\r\n<ul");

WriteLiteral(" class=\"dropdown-menu pull-right\"");

WriteLiteral(">\r\n    <li>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 155), Tuple.Create("\"", 188)
            
            #line 7 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 162), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportExcel")
            
            #line default
            #line hidden
, 162), false)
);

WriteLiteral(">导出Excel</a>\r\n    </li>\r\n    <li>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 234), Tuple.Create("\"", 265)
            
            #line 10 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 241), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportXml")
            
            #line default
            #line hidden
, 241), false)
);

WriteLiteral(">导出Xml</a>\r\n    </li>\r\n    <li>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 309), Tuple.Create("\"", 341)
            
            #line 13 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 316), Tuple.Create<System.Object, System.Int32>(Url.Action("ExportJson")
            
            #line default
            #line hidden
, 316), false)
);

WriteLiteral(">导出Json</a>\r\n    </li>\r\n");

            
            #line 15 "..\..\Views\Shared\_List_Data_Menu.cshtml"
    
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\_List_Data_Menu.cshtml"
     if (SysConfig.Current.Develop && User.IsInRole("管理员"))
    {

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 497), Tuple.Create("\"", 524)
            
            #line 19 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 504), Tuple.Create<System.Object, System.Int32>(Url.Action("Clear")
            
            #line default
            #line hidden
, 504), false)
);

WriteLiteral(" onclick=\"return confirm(\'该操作将删除数据表所有数据并不可恢复！\\n确认清空？\');\"");

WriteLiteral(">清空数据表</a>\r\n        </li>\r\n");

            
            #line 21 "..\..\Views\Shared\_List_Data_Menu.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 22 "..\..\Views\Shared\_List_Data_Menu.cshtml"
     if (user.Has(PermissionFlags.Delete))
    {

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 729), Tuple.Create("\"", 763)
            
            #line 26 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 736), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteSelect")
            
            #line default
            #line hidden
, 736), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" data-confirm=\"该操作将删除选中数据并不可恢复！确认删除？\"");

WriteLiteral(" title=\"删除选中数据\"");

WriteLiteral(">删除选中</a>\r\n        </li>\r\n");

WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 910), Tuple.Create("\"", 941)
            
            #line 29 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 917), Tuple.Create<System.Object, System.Int32>(Url.Action("DeleteAll")
            
            #line default
            #line hidden
, 917), false)
);

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-confirm=\"该操作将删除当前查询的所有数据并不可恢复！确认删除？\"");

WriteLiteral(" title=\"删除当前查询的所有数据\"");

WriteLiteral(">删除全部</a>\r\n        </li>\r\n");

            
            #line 31 "..\..\Views\Shared\_List_Data_Menu.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 32 "..\..\Views\Shared\_List_Data_Menu.cshtml"
     if (SysConfig.Current.Develop)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"divider\"");

WriteLiteral("></li>\r\n");

WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1165), Tuple.Create("\"", 1195)
            
            #line 36 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 1172), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeList")
            
            #line default
            #line hidden
, 1172), false)
);

WriteLiteral(">生成列表</a>\r\n        </li>\r\n");

WriteLiteral("        <li>\r\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1250), Tuple.Create("\"", 1280)
            
            #line 39 "..\..\Views\Shared\_List_Data_Menu.cshtml"
, Tuple.Create(Tuple.Create("", 1257), Tuple.Create<System.Object, System.Int32>(Url.Action("MakeForm")
            
            #line default
            #line hidden
, 1257), false)
);

WriteLiteral(">生成表单</a>\r\n        </li>\r\n");

            
            #line 41 "..\..\Views\Shared\_List_Data_Menu.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>\r\n");

        }
    }
}
#pragma warning restore 1591
