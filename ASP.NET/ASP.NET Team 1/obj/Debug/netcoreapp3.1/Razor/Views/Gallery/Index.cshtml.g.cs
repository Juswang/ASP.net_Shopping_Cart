#pragma checksum "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c415f2f624cf952ed4097bec5a7aa940ac4462"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
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
#line 1 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\_ViewImports.cshtml"
using ASP.NET_Team_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\_ViewImports.cshtml"
using ASP.NET_Team_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66c415f2f624cf952ed4097bec5a7aa940ac4462", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18e37aacfd35dc807419fd66fbdd7ab3e24ee5c8", @"/Views/_ViewImports.cshtml")]
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Gallery/GalleryPage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
  
    ViewData["Title"] = "Index";
    string sessionId = (string)ViewData["sessionId"];
    string userId = (string)ViewData["UserId"];

    var popularProducts = (List<Product>)ViewData["popularProducts"];
    var highRatedProducts = (List<Product>)ViewData["highRatedProducts"];
    var recommendedProducts = (List<Product>)ViewData["recommendedProducts"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66c415f2f624cf952ed4097bec5a7aa940ac44624346", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<!--To display recommended products only if the user is logged in-->\r\n\r\n");
#nullable restore
#line 19 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
 if (userId != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Recommended Products</h1>\r\n    <table>\r\n\r\n");
#nullable restore
#line 24 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
         for (int i = 0; i < recommendedProducts.Count; i += 3)
        {
            int j;


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n");
#nullable restore
#line 29 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                 for (j = 0; j < 3 && i + j < recommendedProducts.Count; j++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\r\n                        <table class=\"inner-table\">\r\n                            <tr>\r\n                                <td>\r\n");
#nullable restore
#line 35 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                      
                                        string url = "/Images/" + recommendedProducts[i + j].ProductLogo;
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"card-img-top\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=", 1265, "", 1274, 1);
#nullable restore
#line 39 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 1270, url, 1270, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"175\" />\r\n                                    </div>\r\n                                </td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"card-title\">");
#nullable restore
#line 44 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                  Write(recommendedProducts[i + j].ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"card-text\"><small>");
#nullable restore
#line 47 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                        Write(recommendedProducts[i + j].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></td>\r\n                            </tr>\r\n                            <tr>\r\n                                <td class=\"card-title\">$ ");
#nullable restore
#line 50 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                    Write(recommendedProducts[i + j].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n                            <tr>\r\n");
#nullable restore
#line 53 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                 if (recommendedProducts[i + j].NumReviews != 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <!--Code for star rating-->\r\n                                    <td>\r\n");
#nullable restore
#line 57 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                          int k = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        Rating:");
#nullable restore
#line 58 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                for (; k <= Math.Floor(recommendedProducts[i + j].Rating); k++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            WriteLiteral(" &#10022;\r\n");
#nullable restore
#line 61 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                         for (; k <= 5; k++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            WriteLiteral(" &#10023;\r\n");
#nullable restore
#line 66 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
#nullable restore
#line 67 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                   Write(recommendedProducts[i + j].Rating.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" out of 5\r\n                                        <br />");
#nullable restore
#line 68 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                         Write(recommendedProducts[i + j].NumReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Customer Reviews\r\n                                    </td>\r\n");
#nullable restore
#line 70 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>No customer reviews</td>\r\n");
#nullable restore
#line 74 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tr>\r\n");
#nullable restore
#line 76 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                              
                                string recId = recommendedProducts[i + j].ProductID + "rec";
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <tr height=\"20px\">\r\n                                <td>\r\n                                    <input type=\"Button\" value=\"Add to Cart\" class=\"cartButton\"");
            BeginWriteAttribute("id", " id=", 3537, "", 3547, 1);
#nullable restore
#line 82 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 3541, recId, 3541, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                </td>\r\n                            </tr>\r\n                        </table>\r\n                    </td>\r\n");
#nullable restore
#line 87 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 89 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 91 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n\r\n<!--To display highly rated products-->\r\n<h1>Highly Rated Products</h1>\r\n<hr />\r\n<table>\r\n");
#nullable restore
#line 99 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
     for (int i = 0; i < highRatedProducts.Count; i += 3)
    {
        int j;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 104 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
             for (j = 0; j < 3 && i + j < highRatedProducts.Count; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <table class=\"inner-table\">\r\n                        <tr>\r\n                            <td>\r\n");
#nullable restore
#line 110 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                  
                                    string url = "/Images/" + highRatedProducts[i + j].ProductLogo;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-img-top\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=", 4454, "", 4463, 1);
#nullable restore
#line 114 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 4459, url, 4459, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"175\" />\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-title\">");
#nullable restore
#line 119 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                              Write(highRatedProducts[i + j].ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-text\"><small>");
#nullable restore
#line 122 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                    Write(highRatedProducts[i + j].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-title\">$ ");
#nullable restore
#line 125 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                Write(highRatedProducts[i + j].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n");
#nullable restore
#line 128 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                             if (highRatedProducts[i + j].NumReviews != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <!--Code for star rating-->\r\n");
#nullable restore
#line 132 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                      int k = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    Rating:");
#nullable restore
#line 133 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                            for (; k <= Math.Floor(highRatedProducts[i + j].Rating); k++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral(" &#10022;\r\n");
#nullable restore
#line 136 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 138 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                     for (; k <= 5; k++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral(" &#10023;\r\n");
#nullable restore
#line 141 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 142 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                               Write(highRatedProducts[i + j].Rating.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" out of 5\r\n                                    <br />");
#nullable restore
#line 143 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                     Write(highRatedProducts[i + j].NumReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Customer Reviews\r\n                                </td>\r\n");
#nullable restore
#line 145 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>No customer reviews</td>\r\n");
#nullable restore
#line 149 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 151 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                          
                            string hrId = highRatedProducts[i + j].ProductID + "hig";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <tr height=\"20px\">\r\n                            <td>\r\n                                <input type=\"Button\" value=\"Add to Cart\" class=\"cartButton\"");
            BeginWriteAttribute("id", " id=", 6549, "", 6558, 1);
#nullable restore
#line 157 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 6553, hrId, 6553, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n                    </table>\r\n                </td>\r\n");
#nullable restore
#line 162 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 164 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<br />\r\n<h1>Best Selling Products</h1>\r\n<hr />\r\n<table>\r\n");
#nullable restore
#line 171 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
     for (int i = 0; i < popularProducts.Count; i += 3)
    {
        int j;


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
#nullable restore
#line 176 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
             for (j = 0; j < 3 && i + j < popularProducts.Count; j++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <table class=\"inner-table\">\r\n                        <tr>\r\n                            <td>\r\n");
#nullable restore
#line 182 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                  
                                    string url = "/Images/" + popularProducts[i + j].ProductLogo;
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card-img-top\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=", 7381, "", 7390, 1);
#nullable restore
#line 186 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 7386, url, 7386, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"175\" />\r\n                                </div>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-title\">");
#nullable restore
#line 191 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                              Write(popularProducts[i + j].ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-text\"><small>");
#nullable restore
#line 194 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                    Write(popularProducts[i + j].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td class=\"card-title\">$ ");
#nullable restore
#line 197 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                                Write(popularProducts[i + j].Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        </tr>\r\n                        <tr>\r\n");
#nullable restore
#line 200 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                             if (popularProducts[i + j].NumReviews != 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <!--Code for star rating-->\r\n");
#nullable restore
#line 204 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                      int k = 1; 

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    Rating:");
#nullable restore
#line 205 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                            for (; k <= Math.Floor(popularProducts[i + j].Rating); k++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral(" &#10022;\r\n");
#nullable restore
#line 208 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 210 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                     for (; k <= 5; k++)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            WriteLiteral(" &#10023;\r\n");
#nullable restore
#line 213 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    ");
#nullable restore
#line 214 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                               Write(popularProducts[i + j].Rating.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" out of 5\r\n                                    <br />");
#nullable restore
#line 215 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                                     Write(popularProducts[i + j].NumReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Customer Reviews\r\n                                </td>\r\n");
#nullable restore
#line 217 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>No customer reviews</td>\r\n");
#nullable restore
#line 221 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 223 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
                          
                            string popId = popularProducts[i + j].ProductID + "pop";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <tr height=\"20px\">\r\n                            <td>\r\n                                <input type=\"Button\" value=\"Add to Cart\" class=\"cartButton\"");
            BeginWriteAttribute("id", " id=", 9462, "", 9472, 1);
#nullable restore
#line 229 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 9466, popId, 9466, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n                    </table>\r\n                </td>\r\n");
#nullable restore
#line 234 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 236 "C:\Users\LM\Desktop\ASP.NET-team-1-final (1)\ASP.NET-team-1-final\ASP.NET Team 1 - LM - v2\ASP.NET Team 1\Views\Gallery\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
