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
    
    #line 4 "..\..\Views\Shared\_List_Data_Action.cshtml"
    using NewLife.Cube;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    
    #line 2 "..\..\Views\Shared\_List_Data_Action.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_List_Data_Action.cshtml"
    using XCode.Membership;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_List_Data_Action.cshtml")]
    public partial class _Views_Shared__List_Data_Action_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__List_Data_Action_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 5 "..\..\Views\Shared\_List_Data_Action.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var fi = fact.Fields.FirstOrDefault(e => e.Name.EqualIgnoreCase("Deleted", "IsDelete", "IsDeleted"));
    var entity = Model as IEntity;

    var rv = entity.GetRouteKey();

    var user = ViewBag.User as IUser ?? User.Identity as IUser;

    var eid = entity["ID"] + "";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 16 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (user.Has(PermissionFlags.Update))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" title=\"编辑\"");

WriteAttribute("href", Tuple.Create(" href=\"", 467), Tuple.Create("\"", 497)
            
            #line 18 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 474), Tuple.Create<System.Object, System.Int32>(Url.Action("Edit", rv)
            
            #line default
            #line hidden
, 474), false)
);

WriteLiteral(" class=\"editcell\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-pencil\"");

WriteLiteral(" style=\"color:#1c84c6;font-size:16px;padding:0px 5px 0px 0px;\"");

WriteLiteral("></i></a>\r\n");

            
            #line 19 "..\..\Views\Shared\_List_Data_Action.cshtml"
}
else if (user.Has(PermissionFlags.Detail))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" title=\"详细\"");

WriteAttribute("href", Tuple.Create(" href=\"", 679), Tuple.Create("\"", 711)
            
            #line 22 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 686), Tuple.Create<System.Object, System.Int32>(Url.Action("Detail", rv)
            
            #line default
            #line hidden
, 686), false)
);

WriteLiteral(" class=\"editcell\"");

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-bars\"");

WriteLiteral(" style=\"color:#1ab394;font-size:16px;padding:0px 5px 0px 5px;\"");

WriteLiteral("></i></a>\r\n");

            
            #line 23 "..\..\Views\Shared\_List_Data_Action.cshtml"
}

            
            #line default
            #line hidden
            
            #line 24 "..\..\Views\Shared\_List_Data_Action.cshtml"
 if (user.Has(PermissionFlags.Delete))
{

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("id", Tuple.Create(" id=\"", 894), Tuple.Create("\"", 910)
, Tuple.Create(Tuple.Create("", 899), Tuple.Create("delete_", 899), true)
            
            #line 26 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(eid
            
            #line default
            #line hidden
, 906), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 911), Tuple.Create("\"", 944)
            
            #line 26 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 919), Tuple.Create<System.Object, System.Int32>(Url.Action("Delete", rv)
            
            #line default
            #line hidden
, 919), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" title=\"删除\"");

WriteAttribute("onclick", Tuple.Create(" onclick=\"", 976), Tuple.Create("\"", 1004)
, Tuple.Create(Tuple.Create("", 986), Tuple.Create("DeleteList(\'", 986), true)
            
            #line 27 "..\..\Views\Shared\_List_Data_Action.cshtml"
, Tuple.Create(Tuple.Create("", 998), Tuple.Create<System.Object, System.Int32>(eid
            
            #line default
            #line hidden
, 998), false)
, Tuple.Create(Tuple.Create("", 1002), Tuple.Create("\')", 1002), true)
);

WriteLiteral("><i");

WriteLiteral(" class=\"fa fa-trash\"");

WriteLiteral(" style=\"color:red;font-size:16px;padding:0px 0px 0px 5px;\"");

WriteLiteral("></i></a>\r\n");

            
            #line 28 "..\..\Views\Shared\_List_Data_Action.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
