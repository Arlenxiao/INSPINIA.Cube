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
    
    #line 1 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using NewLife.Reflection;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Views\Shared\_ListTree_Data.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_ListTree_Data.cshtml")]
    public partial class _Views_Shared__ListTree_Data_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__ListTree_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 8 "..\..\Views\Shared\_ListTree_Data.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as List<FieldItem>;
    var fk = fact.Unique;
    var enableSelect = this.EnableSelect();

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<table");

WriteLiteral(" class=\"table table-striped\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n            ");

WriteLiteral("\r\n");

            
            #line 24 "..\..\Views\Shared\_ListTree_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\_ListTree_Data.cshtml"
             foreach (var item in fields)
            {
                var sortUrl = item.OriField != null ? page.GetSortUrl(item.OriField.Name) : page.GetSortUrl(item.Name);
                var cls = item.IsIdentity ? "text-center hidden-md hidden-sm hidden-xs" : "text-center";

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteAttribute("class", Tuple.Create(" class=\"", 1008), Tuple.Create("\"", 1020)
            
            #line 28 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1016), Tuple.Create<System.Object, System.Int32>(cls
            
            #line default
            #line hidden
, 1016), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 1021), Tuple.Create("\"", 1046)
            
            #line 28 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1029), Tuple.Create<System.Object, System.Int32>(item.Description
            
            #line default
            #line hidden
, 1029), false)
);

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1050), Tuple.Create("\"", 1075)
            
            #line 28 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1057), Tuple.Create<System.Object, System.Int32>(Html.Raw(sortUrl)
            
            #line default
            #line hidden
, 1057), false)
);

WriteLiteral(">");

            
            #line 28 "..\..\Views\Shared\_ListTree_Data.cshtml"
                                                                                   Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></th>\r\n");

            
            #line 29 "..\..\Views\Shared\_ListTree_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">升</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">降</th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 36 "..\..\Views\Shared\_ListTree_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 36 "..\..\Views\Shared\_ListTree_Data.cshtml"
         foreach (IEntityTree entity in Model)
        {
            var FirstFlag = 0;
            var p = entity.Parent as IEntityTree;
            if (p == null)
            {
                p = fact.EntityType.GetValue("Root") as IEntityTree;
            }
            var id = entity["ID"];

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                ");

WriteLiteral("\r\n");

            
            #line 50 "..\..\Views\Shared\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 50 "..\..\Views\Shared\_ListTree_Data.cshtml"
                 foreach (var item in fields)
                {
                    if (FirstFlag == 0)
                    {
                    
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Shared\_ListTree_Data.cshtml"
               Write(Html.Partial("_List_Data_Item_First", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Shared\_ListTree_Data.cshtml"
                                                                                  
                    }
                    else
                    {
                    
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Shared\_ListTree_Data.cshtml"
               Write(Html.Partial("_List_Data_Item", new Pair(entity, item)));

            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Shared\_ListTree_Data.cshtml"
                                                                            
                    }

                    FirstFlag++;
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 64 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Views\Shared\_ListTree_Data.cshtml"
                     if (p != null && p.Childs != null && p.Childs.Count > 0 && entity != p.Childs[0])
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2459), Tuple.Create("\"", 2495)
            
            #line 66 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2466), Tuple.Create<System.Object, System.Int32>(Url.Action("Up", new { id })
            
            #line default
            #line hidden
, 2466), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-up\"");

WriteLiteral(" style=\"color: green;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 67 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

            
            #line 70 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Shared\_ListTree_Data.cshtml"
                     if (p != null && entity != p.Childs[p.Childs.Count - 1])
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 2791), Tuple.Create("\"", 2829)
            
            #line 72 "..\..\Views\Shared\_ListTree_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2798), Tuple.Create<System.Object, System.Int32>(Url.Action("Down", new { id })
            
            #line default
            #line hidden
, 2798), false)
);

WriteLiteral("><span");

WriteLiteral(" class=\"glyphicon glyphicon-arrow-down\"");

WriteLiteral(" style=\"color: red;\"");

WriteLiteral("></span></a>\r\n");

            
            #line 73 "..\..\Views\Shared\_ListTree_Data.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n");

            
            #line 75 "..\..\Views\Shared\_ListTree_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 75 "..\..\Views\Shared\_ListTree_Data.cshtml"
                 if (user.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 78 "..\..\Views\Shared\_ListTree_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 80 "..\..\Views\Shared\_ListTree_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 82 "..\..\Views\Shared\_ListTree_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591