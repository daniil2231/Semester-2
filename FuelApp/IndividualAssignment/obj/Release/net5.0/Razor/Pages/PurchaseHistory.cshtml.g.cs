#pragma checksum "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b975cc5be789f53bf1189a9eb3bcbd2302d99804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(IndividualAssignment.Pages.Pages_PurchaseHistory), @"mvc.1.0.razor-page", @"/Pages/PurchaseHistory.cshtml")]
namespace IndividualAssignment.Pages
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
#line 1 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\_ViewImports.cshtml"
using IndividualAssignment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b975cc5be789f53bf1189a9eb3bcbd2302d99804", @"/Pages/PurchaseHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c78617ad6765b341c7795ce2f4457c8d56affb5a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_PurchaseHistory : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("purchases-history"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b975cc5be789f53bf1189a9eb3bcbd2302d998043313", async() => {
                WriteLiteral(@"
    <div id=""purchases-history-form-wrap"">
        <h2>Purchases history</h2>
        <table class=""purchases-history-table"">
            <tr>
                <th>Username</th>
                <th>ZIP code</th>
                <th>Fuel type</th>
                <th>Liters purchased</th>
                <th>Cost</th>
            </tr>
");
#nullable restore
#line 16 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml"
             foreach (var purchase in Model.fuelManager.GetSalesHistory())
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<tr>\n    <th>");
#nullable restore
#line 19 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml"
   Write(purchase.Username);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n    <th>");
#nullable restore
#line 20 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml"
   Write(purchase.ZipCode);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n    <th>");
#nullable restore
#line 21 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml"
   Write(purchase.FuelName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n    <th>");
#nullable restore
#line 22 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml"
   Write(purchase.LitersPurchased);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n    <th>");
#nullable restore
#line 23 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml"
   Write(purchase.Cost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\n</tr>\n");
#nullable restore
#line 25 "C:\Users\35988\Desktop\wad_fitness-main\IndividualAssignment\Pages\PurchaseHistory.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </table>
    </div>
    <div class=""side-menu"">
        <a href=""/AdminAddFuel"" class=""side-menu-buy"">Edit fuels</a>
        <hr class=""solid"">
        <a href=""/PurchaseHistory"" class=""side-menu-profile"">Purchases history</a>
        <hr class=""solid"">
        <a href=""/Logout"" class=""side-menu-profile"">Logout</a>
        <hr class=""solid"">
    </div>
    <footer>
        <p>Got any questions? Contact:<br>Email: daniilblagoev@gmail.com</p>
    </footer>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndividualAssignment.Pages.PurchaseHistoryModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndividualAssignment.Pages.PurchaseHistoryModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndividualAssignment.Pages.PurchaseHistoryModel>)PageContext?.ViewData;
        public IndividualAssignment.Pages.PurchaseHistoryModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
