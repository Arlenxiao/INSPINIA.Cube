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
    
    #line 1 "..\..\Views\Shared\List.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 2 "..\..\Views\Shared\List.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\List.cshtml"
    using XCode;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/List.cshtml")]
    public partial class _Views_Shared_List_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared_List_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 4 "..\..\Views\Shared\List.cshtml"
  
    Layout = NewLife.Cube.Setting.Current.Layout;

    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"col-lg-12\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ibox float-e-margins\"");

WriteLiteral(">\r\n\r\n            <div");

WriteLiteral(" class=\"ibox-content\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(" style=\"padding:0 15px 10px 15px;\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 16 "..\..\Views\Shared\List.cshtml"
               Write(Html.Partial("_List_Toolbar"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"table-responsive\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 19 "..\..\Views\Shared\List.cshtml"
               Write(Html.Partial("_List_Data"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n                <!--分页-->\r\n                <div");

WriteLiteral(" class=\"panel-footer\"");

WriteLiteral(" style=\"background-color:transparent;border-top:0px solid #ffffff;\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 23 "..\..\Views\Shared\List.cshtml"
               Write(Html.Partial("_List_Pager"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r" +
"\n");

DefineSection("css", () => {

WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 902), Tuple.Create("\"", 957)
, Tuple.Create(Tuple.Create("", 909), Tuple.Create<System.Object, System.Int32>(Href("~/Template/css/plugins/sweetalert/sweetalert.css")
, 909), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n");

});

DefineSection("scripts", () => {

WriteLiteral("\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1013), Tuple.Create("\"", 1069)
, Tuple.Create(Tuple.Create("", 1019), Tuple.Create<System.Object, System.Int32>(Href("~/Template/js/plugins/sweetalert/sweetalert.min.js")
, 1019), false)
);

WriteLiteral("></script>\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">

        function DeleteList(id) {
            swal({
                title: ""确定删除?"",
                type: ""warning"",
                showCancelButton: true,
                confirmButtonColor: ""#DD6B55"",
                confirmButtonText: ""确定"",
                cancelButtonText: ""取消"",
                closeOnConfirm: false,
                closeOnCancel: true
            },
                function (isConfirm) {
                    if (isConfirm) {
                        swal({ title: ""删除成功!"", type: ""success"", timer: 1500});
                        setTimeout(function () { location = $(""#delete_"" + id).val(); }, 1000);
                    } 
                });
        }

    </script>
");

});

        }
    }
}
#pragma warning restore 1591