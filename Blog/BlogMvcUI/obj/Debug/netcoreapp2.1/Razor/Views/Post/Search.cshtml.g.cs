#pragma checksum "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6ba4ad209107aa5b3acb2d662884200b1c390fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Search), @"mvc.1.0.view", @"/Views/Post/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Search.cshtml", typeof(AspNetCore.Views_Post_Search))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6ba4ad209107aa5b3acb2d662884200b1c390fe", @"/Views/Post/Search.cshtml")]
    public class Views_Post_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogMvcUI.Models.PostSearchViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(100, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(191, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
 if (Model.Posts.Count == 0)
{

#line default
#line hidden
            BeginContext(258, 121, true);
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        Aradığınız kelimeyi içeren bir post bulunamadı !\r\n    </div>\r\n");
            EndContext();
#line 15 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
}


#line default
#line hidden
#line 17 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
                          
else
{
    

#line default
#line hidden
#line 20 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
     foreach (var post in Model.Posts)
    {
        var text = Html.Raw(post.PostContent);

        

#line default
#line hidden
#line 24 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
         if (post.PostContent.Length > 300)
        {
            text = Html.Raw(post.PostContent.Substring(0, 297) + "...");
        }

#line default
#line hidden
            BeginContext(661, 109, true);
            WriteLiteral("        <div class=\"card mb-4\">\r\n            <div class=\"card-body\">\r\n                <h2 class=\"card-title\">");
            EndContext();
            BeginContext(771, 10, false);
#line 31 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
                                  Write(post.Title);

#line default
#line hidden
            EndContext();
            BeginContext(781, 44, true);
            WriteLiteral("</h2>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(826, 4, false);
#line 32 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
                                Write(text);

#line default
#line hidden
            EndContext();
            BeginContext(830, 22, true);
            WriteLiteral("</p>\r\n                ");
            EndContext();
            BeginContext(852, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d591fdd45c4494b8a847a3f298731f6", async() => {
                BeginContext(949, 11, true);
                WriteLiteral("Read More →");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
                                                                   WriteLiteral(post.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(964, 100, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"card-footer text-muted\">\r\n                Posted on : ");
            EndContext();
            BeginContext(1065, 38, false);
#line 36 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
                       Write(post.UploadDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 39 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
    }

#line default
#line hidden
#line 39 "C:\Users\yiba_\Desktop\Yazılım Notlarım\Önemli Projeler\Blog\BlogMvcUI\Views\Post\Search.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogMvcUI.Models.PostSearchViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
