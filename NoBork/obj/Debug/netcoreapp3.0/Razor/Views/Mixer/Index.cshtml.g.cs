#pragma checksum "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5065da6cf120c63e131dd383c87b24f088bdebbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mixer_Index), @"mvc.1.0.view", @"/Views/Mixer/Index.cshtml")]
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
#line 1 "C:\Users\polin\Desktop\NoBork\NoBork\Views\_ViewImports.cshtml"
using NoBork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\polin\Desktop\NoBork\NoBork\Views\_ViewImports.cshtml"
using NoBork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5065da6cf120c63e131dd383c87b24f088bdebbc", @"/Views/Mixer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12cbf42fbd250e7ddafb1c5482c4ef57bf40208d", @"/Views/_ViewImports.cshtml")]
    public class Views_Mixer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mixer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Mixer/Filter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5065da6cf120c63e131dd383c87b24f088bdebbc5855", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>NoBork - Mixer</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"" integrity=""sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"" crossorigin=""anonymous"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5065da6cf120c63e131dd383c87b24f088bdebbc6406", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5065da6cf120c63e131dd383c87b24f088bdebbc8288", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-light"">
        <div class=""nav-container"">
            <a class=""navbar-brand"">NoBork</a>
            <div class=""btn-group"" role=""group"" aria-label=""Basic example"">
                <button type=""button"" class=""btn btn-outline-light"" onclick=""document.location.href = 'http://localhost:5000/Mixer/Sort?sort=1'"">По названию</button>
                <button type=""button"" class=""btn btn-outline-light"" onclick=""document.location.href = 'http://localhost:5000/Mixer/Sort?sort=2'"">По цене</button>
            </div>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5065da6cf120c63e131dd383c87b24f088bdebbc9132", async() => {
                    WriteLiteral("\r\n                <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\" name=\"Value\"");
                    BeginWriteAttribute("value", " value=\"", 1183, "\"", 1191, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                <button class=\"btn btn-outline-light my-2 my-sm-0\" type=\"submit\">Search</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </nav>\r\n    <div class=\"main row\">\r\n        <div id=\"filter\" class=\"col-4\">\r\n            <div class=\"accordion\" id=\"accordionExample\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5065da6cf120c63e131dd383c87b24f088bdebbc11417", async() => {
                    WriteLiteral(@"
                    <div class=""card"">
                        <div class=""card-header"" id=""heading1"">
                            <h2 class=""mb-0"">
                                <button class=""btn"" type=""button"" data-toggle=""collapse"" data-target=""#collapse1"" aria-expanded=""true"" aria-controls=""collapseOne"">
                                    Цена
                                </button>
                            </h2>
                        </div>

                        <div id=""collapse1"" class=""collapse show"" aria-labelledby=""heading1"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <div class=""form-container"">
                                    <div class=""form-group row"">
                                        <input type=""text"" class=""form-control"" id=""minPrice"" name=""MinPrice"" value=""0"" aria-describedby=""emailHelp"">
                                    </div>
                                    <div class=""");
                    WriteLiteral(@"form-group row"">
                                        <input type=""text"" class=""form-control"" id=""maxPrice"" name=""MaxPrice"" value=""100000"" aria-describedby=""emailHelp"">
                                    </div>
                                    <div class=""input-submit"">
                                        <input class=""btn btn-dark"" type=""submit"" value=""Применить"">
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""heading2"">
                            <h2 class=""mb-0"">
                                <button class=""btn collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapse2"" aria-expanded=""false"" aria-controls=""collapseTwo"">
                                    Мощность
                                </button>
                            </h2>
        ");
                    WriteLiteral(@"                </div>
                        <div id=""collapse2"" class=""collapse"" aria-labelledby=""heading2"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""Power"" value=""0"" id=""Power1"">
                                    <label class=""form-check-label"" for=""Power1"">
                                        Меньше 1000 Вт
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""Power"" value=""1000"" id=""Power2"">
                                    <label class=""form-check-label"" for=""Power2"">
                                        От 1000 до 2000 Вт
                                    </label>
                                </div>
          ");
                    WriteLiteral(@"                      <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""Power"" value=""2000"" id=""Power3"">
                                    <label class=""form-check-label"" for=""Power3"">
                                        От 2000 до 3000 Вт
                                    </label>
                                </div>

                                <div class=""input-submit"">
                                    <input class=""btn btn-dark"" type=""submit"" value=""Применить"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""heading3"">
                            <h2 class=""mb-0"">
                                <button class=""btn collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapse3"" aria-expanded=""false"" aria-controls=""collapseThree""");
                    WriteLiteral(@">
                                    Количество программ
                                </button>
                            </h2>
                        </div>
                        <div id=""collapse3"" class=""collapse"" aria-labelledby=""heading3"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""ProgramsNumber"" value=""1"" id=""Modes1"">
                                    <label class=""form-check-label"" for=""Modes1"">
                                        1
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""ProgramsNumber"" value=""2"" id=""Modes2"">
                                    <label class=""form-check-label"" for=""Modes2"">
        ");
                    WriteLiteral(@"                                2
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""ProgramsNumber"" value=""3"" id=""Modes3"">
                                    <label class=""form-check-label"" for=""Modes3"">
                                        3
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""ProgramsNumber"" value=""4"" id=""Modes4"">
                                    <label class=""form-check-label"" for=""Modes3"">
                                        4
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input cl");
                    WriteLiteral(@"ass=""form-check-input"" type=""checkbox"" name=""ProgramsNumber"" value=""5"" id=""Modes5"">
                                    <label class=""form-check-label"" for=""Modes3"">
                                        5
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""ProgramsNumber"" value=""2000"" id=""Modes6"">
                                    <label class=""form-check-label"" for=""Modes3"">
                                        6
                                    </label>
                                </div>
                                <div class=""input-submit"">
                                    <input class=""btn btn-dark"" type=""submit"" value=""Применить"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class");
                    WriteLiteral(@"=""card"">
                        <div class=""card-header"" id=""heading3"">
                            <h2 class=""mb-0"">
                                <button class=""btn collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapse5"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                    Количество скоростей
                                </button>
                            </h2>
                        </div>
                        <div id=""collapse5"" class=""collapse"" aria-labelledby=""heading3"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""SpeedsNumber"" value=""1"" id=""Modes1"">
                                    <label class=""form-check-label"" for=""Modes1"">
                                        1
                                    </label>
                       ");
                    WriteLiteral(@"         </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""SpeedsNumber"" value=""2"" id=""Modes2"">
                                    <label class=""form-check-label"" for=""Modes2"">
                                        2
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""SpeedsNumber"" value=""3"" id=""Modes3"">
                                    <label class=""form-check-label"" for=""Modes3"">
                                        3
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""SpeedsNumber"" value=""4"" id=""Modes4"">
                         ");
                    WriteLiteral(@"           <label class=""form-check-label"" for=""Modes3"">
                                        4
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""SpeedsNumber"" value=""5"" id=""Modes5"">
                                    <label class=""form-check-label"" for=""Modes3"">
                                        5
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""SpeedsNumber"" value=""2000"" id=""Modes6"">
                                    <label class=""form-check-label"" for=""Modes3"">
                                        6
                                    </label>
                                </div>
                                <div c");
                    WriteLiteral(@"lass=""input-submit"">
                                    <input class=""btn btn-dark"" type=""submit"" value=""Применить"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""card-header"" id=""heading4"">
                            <h2 class=""mb-0"">
                                <button class=""btn collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapse4"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                    Объем
                                </button>
                            </h2>
                        </div>
                        <div id=""collapse4"" class=""collapse"" aria-labelledby=""heading4"" data-parent=""#accordionExample"">
                            <div class=""card-body"">
                                <div class=""form-check"">
                                    <input class=""fo");
                    WriteLiteral(@"rm-check-input"" type=""checkbox"" name=""Volume"" value=""0"" id=""Volume1"">
                                    <label class=""form-check-label"" for=""Volume1"">
                                        Меньше 1л.
                                    </label>
                                </div>
                                <div class=""form-check"">
                                    <input class=""form-check-input"" type=""checkbox"" name=""Volume"" value=""1"" id=""Volume2"">
                                    <label class=""form-check-label"" for=""Volume2"">
                                        от 1 до 2 л.
                                    </label>
                                </div>
                                <div class=""input-submit"">
                                    <input class=""btn btn-dark"" type=""submit"" value=""Применить"">
                                </div>
                            </div>
                        </div>
                    </div>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"content col-8\">\r\n");
#nullable restore
#line 229 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
             foreach (Mixer b in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"product\">\r\n                    <div class=\"product-photo\">\r\n                        <img src=\"http://st.bork.ru/photos_resized/common/220_220/9201/1_9201.png\"");
                BeginWriteAttribute("alt", " alt=\"", 14127, "\"", 14133, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                    </div>\r\n                    <!--\r\n                    -->\r\n                    <div class=\"product-info\">\r\n                        <div class=\"product-info-point product-info-point-first\">\r\n                            <h3>");
#nullable restore
#line 240 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                           Write(b.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                        </div>\r\n                        <div class=\"product-info-point\">\r\n                            <h6>Размер: <b>");
#nullable restore
#line 243 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                                      Write(b.Width);

#line default
#line hidden
#nullable disable
                WriteLiteral(" x ");
#nullable restore
#line 243 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                                                 Write(b.Length);

#line default
#line hidden
#nullable disable
                WriteLiteral(" x ");
#nullable restore
#line 243 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                                                             Write(b.Height);

#line default
#line hidden
#nullable disable
                WriteLiteral(" см</b></h6>\r\n                        </div>\r\n                        <div class=\"product-info-point\">\r\n                            <h6>Вес: <b>");
#nullable restore
#line 246 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                                   Write(b.Weight);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></h6>\r\n                        </div>\r\n                        <div class=\"product-info-point\">\r\n                            <h6>Мощность: <b>");
#nullable restore
#line 249 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                                        Write(b.Power);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Вт</b></h6>\r\n                        </div>\r\n                        <div class=\"product-info-point\">\r\n                            <h6>Страна: <b>");
#nullable restore
#line 252 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                                      Write(b.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></h6>\r\n                        </div>\r\n                        <div class=\"product-info-point product-info-point-last\">\r\n                            <h3>");
#nullable restore
#line 255 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
                           Write(b.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Руб.</h3>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 259 "C:\Users\polin\Desktop\NoBork\NoBork\Views\Mixer\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>

    </div>


    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mixer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
