#pragma checksum "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee5b04d672d0aaf736f06e2735b7a4c9767be88e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MB.Presentation.MVCCore.Pages.Pages_ArticleDetails), @"mvc.1.0.razor-page", @"/Pages/ArticleDetails.cshtml")]
namespace MB.Presentation.MVCCore.Pages
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
#line 1 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\_ViewImports.cshtml"
using MB.Presentation.MVCCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:long}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee5b04d672d0aaf736f06e2735b7a4c9767be88e", @"/Pages/ArticleDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"538c48893e259ab600c4b09750c881ad8909dde0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ArticleDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<main class=\"post blog-post col-lg-12\">\r\n    <div class=\"container\">\r\n        <div ");
            WriteLiteral(">\r\n            <div class=\"post-thumbnail\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 257, "\"", 283, 1);
#nullable restore
#line 10 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 263, Model.Article.Image, 263, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 284, "\"", 310, 1);
#nullable restore
#line 10 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 290, Model.Article.Title, 290, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 311, "\"", 339, 1);
#nullable restore
#line 10 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
WriteAttributeValue("", 319, Model.Article.Title, 319, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n            </div>\r\n            <div ");
            WriteLiteral(">\r\n                <div class=\"post-meta d-flex justify-content-between\">\r\n                    <div class=\"category\">\r\n                        <a href=\"#\">");
#nullable restore
#line 15 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                               Write(Model.Article.ArticleCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                </div>\r\n                <h1>\r\n                    ");
#nullable restore
#line 19 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <a href=""#"">
                        <i class=""fa fa-bookmark-o""></i>
                    </a>
                </h1>
                <div class=""post-footer d-flex align-items-center flex-column flex-sm-row"">
                    <div class=""d-flex align-items-center flex-wrap"">
                        <div class=""date"">
                            <i class=""icon-clock""></i> ");
#nullable restore
#line 27 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                                                  Write(Model.Article.CreationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <div class=""comments meta-last""><i class=""icon-comment""></i>12</div>
                    </div>
                </div>
                <div class=""post-body"">
                    <p>
                        ");
#nullable restore
#line 34 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
                   Write(Model.Article.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    ");
#nullable restore
#line 36 "D:\PROGRAMING\C#\Core\Master Blogger\MasterBlogger\MB.Presentation.MVCCore\Pages\ArticleDetails.cshtml"
               Write(Model.Article.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.MVCCore.Pages.ArticleDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Pages.ArticleDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MB.Presentation.MVCCore.Pages.ArticleDetailsModel>)PageContext?.ViewData;
        public MB.Presentation.MVCCore.Pages.ArticleDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
