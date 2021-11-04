#pragma checksum "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbb56893e3f1f8c27a0b53bac1668862512dceb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rockets__List), @"mvc.1.0.view", @"/Views/Rockets/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rockets/_List.cshtml", typeof(AspNetCore.Views_Rockets__List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\_ViewImports.cshtml"
using miltron.com.ui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\_ViewImports.cshtml"
using miltron.com.ui.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb56893e3f1f8c27a0b53bac1668862512dceb3", @"/Views/Rockets/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca6f0747671c6fe75fbbecffa731d35f0411b278", @"/Views/_ViewImports.cshtml")]
    public class Views_Rockets__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<miltron.com.ui.Models.generate_response<int>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
  
    var list = new List<miltron.com.ui.Models.Rocket.RocketResponse>();
    var headers = new Dictionary<string, string>();
    headers.Add("x-api-key", "API_KEY_1");
    try
    {
        list = miltron.com.ui.utils.service.helper<List<miltron.com.ui.Models.Rocket.RocketResponse>>.get_api_client(miltron.com.ui.utils.enums.http_protocol.get, "/rockets", null, false, null, headers).Result;
    }
    catch (Exception)
    {
        

#line default
#line hidden
#nullable disable
            BeginContext(506, 130, true);
            WriteLiteral("\r\n                <script>\r\n                     window.location.href = \'/Rockets/_List\';\r\n                </script>\r\n            ");
            EndContext();
#nullable restore
#line 16 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                   
    }


#line default
#line hidden
#nullable disable
            BeginContext(657, 83, true);
            WriteLiteral("<div class=\"wrapper wrapper-content animated fadeInRight\">\r\n    <div class=\"row\">\r\n");
            EndContext();
#nullable restore
#line 22 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
         if (list.Count() != 0)
        {
            foreach (var item in list.OrderBy(x => x.model).ToList())
            {

#line default
#line hidden
#nullable disable
            BeginContext(870, 280, true);
            WriteLiteral(@"                <div class=""col-lg-3"">
                    <div class=""ibox"">
                        <div class=""ibox-content"">
                            <h2 class=""m-b-md"">
                                <a data-ajax=""true"" data-ajax-begin=""url_rw('/Rockets/_Details/?id=");
            EndContext();
            BeginContext(1151, 7, false);
#nullable restore
#line 30 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                                                                                              Write(item.id);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(1158, 146, true);
            WriteLiteral("\', \'\');loading_start(\'main\');\" data-ajax-complete=\"loading_stop(\'main\')\" data-ajax-method=\"Post\" data-ajax-mode=\"replace\" data-ajax-update=\"#main\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1304, "\"", 1341, 2);
            WriteAttributeValue("", 1311, "/Rockets/_Details/?id=", 1311, 22, true);
#nullable restore
#line 30 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 1333, item.id, 1333, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginContext(1342, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(1345, 10, false);
#nullable restore
#line 30 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                                                                                                                                                                                                                                                                                                Write(item.model);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(1355, 77, true);
            WriteLiteral("  </a>\r\n                           </h2>\r\n                            <small>");
            EndContext();
            BeginContext(1433, 24, false);
#nullable restore
#line 32 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                              Write(item.payload.description);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(1457, 41, true);
            WriteLiteral("</small>\r\n                            <h2");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1498, "\"", 1651, 2);
#nullable restore
#line 33 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 1506, item.status=="waiting"?"text-warning":(item.status=="cancelled"?"text-danger":(item.status=="launched"?"text-navy":"text-success")), 1506, 134, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1640, "text-right", 1641, 11, true);
            EndWriteAttribute();
            BeginContext(1652, 35, true);
            WriteLiteral(">\r\n                                ");
            EndContext();
            BeginContext(1688, 11, false);
#nullable restore
#line 34 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                           Write(item.status);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(1699, 3, true);
            WriteLiteral(" <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1702, "\"", 1865, 3);
            WriteAttributeValue("", 1710, "fa", 1710, 2, true);
#nullable restore
#line 34 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue(" ", 1712, item.status=="waiting"?"fa-yelp":(item.status=="cancelled"?"fa-play fa-rotate-90":(item.status=="launched"?"fa-play fa-rotate-270":"fa-wpexplorer")), 1713, 151, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1864, "", 1865, 1, true);
            EndWriteAttribute();
            BeginContext(1866, 126, true);
            WriteLiteral("></i>\r\n                            </h2>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>");
            EndContext();
#nullable restore
#line 39 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                      }
        }

#line default
#line hidden
#nullable disable
            BeginContext(2006, 41, true);
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row\">\r\n\r\n");
            EndContext();
#nullable restore
#line 45 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
     if (list.Count() == 50)
    {
        foreach (var item in list.OrderBy(x => x.model).ToList())
        {

#line default
#line hidden
#nullable disable
            BeginContext(2162, 56, true);
            WriteLiteral("            <div class=\"col-lg-3\">\r\n                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2218, "\"", 2353, 2);
            WriteAttributeValue("", 2226, "widget", 2226, 6, true);
#nullable restore
#line 50 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue(" ", 2232, item.status=="waiting"?"yellow-bg":(item.status=="cancelled"?"red-bg":(item.status=="launched"?"navy-bg":"lazur-bg")), 2233, 120, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginContext(2354, 114, true);
            WriteLiteral(" style=\"background-color:#3d4244 !important;color:#ffffff;\">\r\n\r\n                    <h2>\r\n                        ");
            EndContext();
            BeginContext(2469, 10, false);
#nullable restore
#line 53 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                   Write(item.model);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(2479, 192, true);
            WriteLiteral("\r\n                    </h2>\r\n                    <ul class=\"list-unstyled m-t-md\">\r\n                        <li>\r\n                            <label>Mass:</label>\r\n                            ");
            EndContext();
            BeginContext(2672, 24, false);
#nullable restore
#line 58 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.mass.ToString("N2"));

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(2696, 145, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <label>Açıklama:</label>\r\n                            ");
            EndContext();
            BeginContext(2842, 24, false);
#nullable restore
#line 62 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.payload.description);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(2866, 142, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <label>Durum:</label>\r\n                            ");
            EndContext();
            BeginContext(3009, 11, false);
#nullable restore
#line 66 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.status);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(3020, 146, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <label>Yükseklik:</label>\r\n                            ");
            EndContext();
            BeginContext(3167, 13, false);
#nullable restore
#line 70 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.altitude);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(3180, 140, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <label>Hız:</label>\r\n                            ");
            EndContext();
            BeginContext(3321, 10, false);
#nullable restore
#line 74 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.speed);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(3331, 145, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <label>Hızlanma:</label>\r\n                            ");
            EndContext();
            BeginContext(3477, 17, false);
#nullable restore
#line 78 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.acceleration);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(3494, 143, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <label>Basınç:</label>\r\n                            ");
            EndContext();
            BeginContext(3638, 26, false);
#nullable restore
#line 82 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.thrust.ToString("N2"));

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(3664, 145, true);
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            <label>Sıcaklık:</label>\r\n                            ");
            EndContext();
            BeginContext(3810, 16, false);
#nullable restore
#line 86 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                       Write(item.temperature);

#line default
#line hidden
#nullable disable
            EndContext();
            BeginContext(3826, 60, true);
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n");
            EndContext();
#nullable restore
#line 89 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                     if (item.status == "waiting")
                    {

#line default
#line hidden
#nullable disable
            BeginContext(3961, 307, true);
            WriteLiteral(@"                        <div class=""text-center"">
                            <a data-ajax=""true"" data-ajax-begin=""url_rw('/Operations/Clients/Rockets/', '');loading_start('rockets');"" data-ajax-complete=""loading_stop('rockets')"" data-ajax-method=""Post"" data-ajax-mode=""replace"" data-ajax-update=""#rockets""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4268, "\"", 4326, 3);
            WriteAttributeValue("", 4275, "/Rockets/_RocketStatus/?id=", 4275, 27, true);
#nullable restore
#line 92 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 4302, item.id, 4302, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4310, "&status=launched", 4310, 16, true);
            EndWriteAttribute();
            BeginContext(4327, 340, true);
            WriteLiteral(@" class=""btn btn-xs btn-primary"">Fırlat <i class=""fa fa-long-arrow-right""></i> </a>
                            <a data-ajax=""true"" data-ajax-begin=""url_rw('/Operations/Clients/Rockets/', '');loading_start('rockets');"" data-ajax-complete=""loading_stop('rockets')"" data-ajax-method=""Post"" data-ajax-mode=""replace"" data-ajax-update=""#rockets""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4667, "\"", 4725, 3);
            WriteAttributeValue("", 4674, "/Rockets/_RocketStatus/?id=", 4674, 27, true);
#nullable restore
#line 93 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 4701, item.id, 4701, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4709, "&status=deployed", 4709, 16, true);
            EndWriteAttribute();
            BeginContext(4726, 89, true);
            WriteLiteral(" class=\"btn btn-xs btn-primary\">Konumlandır <i class=\"fa fa-long-arrow-right\"></i> </a>\r\n");
            EndContext();
            BeginContext(4994, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#nullable restore
#line 97 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                     if (item.status == "deployed")
                    {

#line default
#line hidden
#nullable disable
            BeginContext(5125, 307, true);
            WriteLiteral(@"                        <div class=""text-center"">
                            <a data-ajax=""true"" data-ajax-begin=""url_rw('/Operations/Clients/Rockets/', '');loading_start('rockets');"" data-ajax-complete=""loading_stop('rockets')"" data-ajax-method=""Post"" data-ajax-mode=""replace"" data-ajax-update=""#rockets""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5432, "\"", 5491, 3);
            WriteAttributeValue("", 5439, "/Rockets/_RocketStatus/?id=", 5439, 27, true);
#nullable restore
#line 101 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 5466, item.id, 5466, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5474, "&status=cancelled", 5474, 17, true);
            EndWriteAttribute();
            BeginContext(5492, 85, true);
            WriteLiteral(" class=\"btn btn-xs btn-danger\">Vazgeç <i class=\"fa fa-long-arrow-right\"></i> </a>\r\n\r\n");
            EndContext();
            BeginContext(5663, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#nullable restore
#line 105 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                     if (item.status == "launched")
                    {

#line default
#line hidden
#nullable disable
            BeginContext(5794, 307, true);
            WriteLiteral(@"                        <div class=""text-center"">
                            <a data-ajax=""true"" data-ajax-begin=""url_rw('/Operations/Clients/Rockets/', '');loading_start('rockets');"" data-ajax-complete=""loading_stop('rockets')"" data-ajax-method=""Post"" data-ajax-mode=""replace"" data-ajax-update=""#rockets""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6101, "\"", 6160, 3);
            WriteAttributeValue("", 6108, "/Rockets/_RocketStatus/?id=", 6108, 27, true);
#nullable restore
#line 109 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 6135, item.id, 6135, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6143, "&status=cancelled", 6143, 17, true);
            EndWriteAttribute();
            BeginContext(6161, 85, true);
            WriteLiteral(" class=\"btn btn-xs btn-danger\">Vazgeç <i class=\"fa fa-long-arrow-right\"></i> </a>\r\n\r\n");
            EndContext();
            BeginContext(6332, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#nullable restore
#line 113 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 114 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                     if (item.status == "cancelled")
                    {

#line default
#line hidden
#nullable disable
            BeginContext(6464, 307, true);
            WriteLiteral(@"                        <div class=""text-center"">
                            <a data-ajax=""true"" data-ajax-begin=""url_rw('/Operations/Clients/Rockets/', '');loading_start('rockets');"" data-ajax-complete=""loading_stop('rockets')"" data-ajax-method=""Post"" data-ajax-mode=""replace"" data-ajax-update=""#rockets""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 6771, "\"", 6829, 3);
            WriteAttributeValue("", 6778, "/Rockets/_RocketStatus/?id=", 6778, 27, true);
#nullable restore
#line 117 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 6805, item.id, 6805, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6813, "&status=launched", 6813, 16, true);
            EndWriteAttribute();
            BeginContext(6830, 340, true);
            WriteLiteral(@" class=""btn btn-xs btn-primary"">Fırlat <i class=""fa fa-long-arrow-right""></i> </a>
                            <a data-ajax=""true"" data-ajax-begin=""url_rw('/Operations/Clients/Rockets/', '');loading_start('rockets');"" data-ajax-complete=""loading_stop('rockets')"" data-ajax-method=""Post"" data-ajax-mode=""replace"" data-ajax-update=""#rockets""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7170, "\"", 7228, 3);
            WriteAttributeValue("", 7177, "/Rockets/_RocketStatus/?id=", 7177, 27, true);
#nullable restore
#line 118 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
WriteAttributeValue("", 7204, item.id, 7204, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 7212, "&status=deployed", 7212, 16, true);
            EndWriteAttribute();
            BeginContext(7229, 91, true);
            WriteLiteral(" class=\"btn btn-xs btn-primary\">Konumlandır <i class=\"fa fa-long-arrow-right\"></i> </a>\r\n\r\n");
            EndContext();
            BeginContext(7499, 32, true);
            WriteLiteral("                        </div>\r\n");
            EndContext();
#nullable restore
#line 123 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                    }

#line default
#line hidden
#nullable disable
            BeginContext(7554, 44, true);
            WriteLiteral("                </div>\r\n            </div>\r\n");
            EndContext();
#nullable restore
#line 126 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            BeginContext(7616, 153, true);
            WriteLiteral("</div>\r\n\r\n<script>\r\n    setInterval(function () {\r\n        window.location.href = \'/Rockets/_List\';\r\n    }, 100000); //Every 1000ms = 1sec\r\n\r\n</script>\r\n");
            EndContext();
#nullable restore
#line 136 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
 if (Model != null && Model.notify != null && Model.notify.typ != miltron.com.ui.utils.enums.notify.none)
{
    

#line default
#line hidden
#nullable disable
            BeginContext(7884, 58, false);
#nullable restore
#line 138 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
Write(Html.Partial("/views/Shared/_Notify.cshtml", Model.notify));

#line default
#line hidden
#nullable disable
            EndContext();
#nullable restore
#line 138 "C:\Users\Eser\Desktop\miltron.com\miltron.com.ui\Views\Rockets\_List.cshtml"
                                                               
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<miltron.com.ui.Models.generate_response<int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
