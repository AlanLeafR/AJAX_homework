#pragma checksum "C:\Users\Student\Desktop\project\AJAX_homework\AJAX_homework\Views\Home\Homewrok3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58c02e1fc72ba267831de6e735fb564a6d012367"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Homewrok3), @"mvc.1.0.view", @"/Views/Home/Homewrok3.cshtml")]
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
#line 1 "C:\Users\Student\Desktop\project\AJAX_homework\AJAX_homework\Views\_ViewImports.cshtml"
using AJAX_homework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Student\Desktop\project\AJAX_homework\AJAX_homework\Views\_ViewImports.cshtml"
using AJAX_homework.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58c02e1fc72ba267831de6e735fb564a6d012367", @"/Views/Home/Homewrok3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef558cc849372a7ad479d306dbe57573772fd4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Homewrok3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Student\Desktop\project\AJAX_homework\AJAX_homework\Views\Home\Homewrok3.cshtml"
  
    ViewData["Title"] = "Homewrok3";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>用async await完成下拉式選單</h1>\r\n\r\n<select id=\"select1\"></select>\r\n<select id=\"select2\"></select>\r\n<select id=\"select3\"></select>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
    const selcity = document.querySelector(""#select1"");
    const selsite = document.querySelector(""#select2"");
    const selroad = document.querySelector(""#select3"");

      async function LoadCities() {
            let response = await fetch(""");
#nullable restore
#line 19 "C:\Users\Student\Desktop\project\AJAX_homework\AJAX_homework\Views\Home\Homewrok3.cshtml"
                                   Write(Url.Content("~/api/city"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""")
            let datas = await response.json();
            datas.forEach(city => {
                const opt = new Option(city, city)
                selcity.options.add(opt)
            })
            let defaultCity = selcity.options[0].value;
            LoadSites(defaultCity);
        }

        async function LoadSites(cityParams) {
            const url = """);
#nullable restore
#line 30 "C:\Users\Student\Desktop\project\AJAX_homework\AJAX_homework\Views\Home\Homewrok3.cshtml"
                    Write(Url.Content("~/api/Site"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?city="";
            let response = await fetch(url + cityParams)
            let datas = await response.json();
            selsite.options.length = 0;
            datas.forEach(site => {
                const opt = new Option(site, site)
                selsite.options.add(opt);
            })
            let defaultSite = selsite.options[0].value;
            LoadRoad(defaultSite);
        }

           async function LoadRoad(siteParams) {
            const url = """);
#nullable restore
#line 43 "C:\Users\Student\Desktop\project\AJAX_homework\AJAX_homework\Views\Home\Homewrok3.cshtml"
                    Write(Url.Content("~/api/Road"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"?site="";
            let response = await fetch(url + siteParams)
            let datas = await response.json();
               selroad.options.length = 0;
            datas.forEach(site => {
                const opt = new Option(site, site)
                selroad.options.add(opt);
            })
        }

        //綁定城市下拉式選單change事件、預載鄉鎮區下拉式選單
        selcity.addEventListener(""change"", () => {
            selectedCity = selcity.options[selcity.selectedIndex].value;
            LoadSites(selectedCity);
        })

        //綁定鄉鎮區下拉式選單change事件、預載道路下拉式選單
        selsite.addEventListener(""change"", () => {
            selectedsite = selsite.options[selsite.selectedIndex].value;
            LoadRoad(selectedsite);
        })

        LoadCities(); //讀取城市

    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
