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
    
    #line 1 "..\..\Views\Shared\_Form_Group.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Views\Shared\_Form_Group.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_Form_Group.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Form_Group.cshtml")]
    public partial class _Views_Shared__Form_Group_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Form_Group_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\_Form_Group.cshtml"
  
    var pair = Model as Pair;
    var entity = pair.First as IEntity;
    var item = pair.Second as FieldItem;

    var set = NewLife.Cube.Setting.Current;
    var cls = set.FormGroupClass;
    if (cls.IsNullOrEmpty()) { cls = "form-group col-xs-12 col-sm-6 col-lg-4"; }

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 14 "..\..\Views\Shared\_Form_Group.cshtml"
Write(Html.Partial("_Form_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591