#pragma checksum "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23d80911ff57ecd453a38e59b460059a62529ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Cizge), @"mvc.1.0.view", @"/Views/Search/Cizge.cshtml")]
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
#line 1 "C:\Users\90545\Desktop\akademikArama\demo\Views\_ViewImports.cshtml"
using demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\90545\Desktop\akademikArama\demo\Views\_ViewImports.cshtml"
using demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23d80911ff57ecd453a38e59b460059a62529ca7", @"/Views/Search/Cizge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eae16e985384ed2ccc0dcb10dbe2dab2d21b6a3b", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Cizge : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Layers.Arastirmaci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("draw()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
  
    ViewData["Title"] = "Cizge";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23d80911ff57ecd453a38e59b460059a62529ca73762", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <!-- CSS only -->
<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css""
 rel=""stylesheet"" integrity=""sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.6.0.js"" integrity=""sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="" crossorigin=""anonymous""></script>

    <style type=""text/css"">
        #viz{
              position: fixed; 
  top: -50%; 
  left: -50%; 
  width: 200%; 
  height: 200%;
        }
    </style>
    <script src=""https://cdn.neo4jlabs.com/neovis.js/v1.5.0/neovis.js""></script>
    <script src=""https://rawgit.com/neo4j-contrib/neovis.js/master/dist/neovis.js""></script>
<script>
    var viz;

        function draw() {
            var config = {
    ");
                WriteLiteral(@"              encrypted:""ENCRYPTION_ON"",
        trust: ""TRUST_SYSTEM_CA_SIGNED_CERTIFICATES"",
                container_id:""viz"",
            server_url:""neo4j://cffecb40.databases.neo4j.io:7687"",
            server_user:""neo4j"",
            server_password:""BTiC1EmclRs3sYMUQ3LXEnmihiunqKrmuuOqoa379ds"",
                labels: {
                    ""Person"":{
                        ""caption"": ""name"",
                        
                        
                    },
                    ""Yayinlar"":{
                         ""caption"": ""name"",
                          ""font"": {
        ""size"":13,
        ""color"":""#000000""
    },
                    },
                    ""Tur"":{
                        ""caption"":""name"",
                        
                    }
                },
                relationships: {
                    ""yayinYazari"": {
                        ""thickness"": ""weight""
                        
                    },
                    ""ortakCa");
                WriteLiteral(@"lisir"":{
                        ""thickness"": ""weight""
                    },
                    ""Turu"":{
                        ""thickness"": ""weight""
                    }
                },
               // initial_cypher: ""MATCH (n:Person{name:'Ömer'})-[FRIEND]-(m:Yayinlar)-[ATE]-(a) RETURN *"",
                 //initial_cypher: ""MATCH (p)-[j:yayinYazari]-(n)-[s:ortakCalisir]-(m)-[e:yayinYazari]-(a) WHERE ID(n)=");
#nullable restore
#line 72 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                                                                                                                  Write(Model.ArastirmaciId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" RETURN *\",\r\n                 //initial_cypher:\"MATCH (x)-[t:Turu]-(p)-[j:yayinYazari]-(n)-[s:ortakCalisir]-(m)-[e:yayinYazari]-(a)-[g:Turu]-(v) WHERE ID(n)=");
#nullable restore
#line 73 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                                                                                                                                           Write(Model.ArastirmaciId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" RETURN *\",\r\n              \r\n               // initial_cypher:\"match(n:Person)-[t]-(m)-[u:yayinYazari]-(i) match(n)-[s:yayinYazari]-(y) where ID(n)=");
#nullable restore
#line 75 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                                                                                                                  Write(Model.ArastirmaciId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" return *\",\r\n                //initial_cypher:\"match(n:Person)-[t]-(m)-[u]-(i) match(n)-[s:yayinYazari]-(y)  where ID(n)=");
#nullable restore
#line 76 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                                                                                                       Write(Model.ArastirmaciId);

#line default
#line hidden
#nullable disable
                WriteLiteral(" return *\",\r\n                initial_cypher:\"match(n:Person)-[t]-(m) match(m)-[s:yayinYazari]-(y)  where ID(n)=");
#nullable restore
#line 77 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                                                                                             Write(Model.ArastirmaciId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" return *"",  // mükemmel sonuç 
                    
      
       
            };

            viz = new NeoVis.default(config);
            viz.render();
            viz.registerOnEvent(""completed"", (e)=>{ 
        viz[""_network""].on(""selectNode"", (event)=>{ 
            console.log(event.nodes[0]);
           if(event.nodes[0]!=null)
           {
               var url = '");
#nullable restore
#line 90 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                     Write(Url.Action("Profil"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\' + \'/\' +event.nodes[0];\r\n           }\r\n    document.location = url;\r\n        });\r\n    });\r\n        }\r\n\r\n        \r\n        \r\n</script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23d80911ff57ecd453a38e59b460059a62529ca710339", async() => {
                WriteLiteral("\r\n\r\n    <div class=\"row\">\r\n            <h1 class=\"text-center\">");
#nullable restore
#line 104 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                               Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 104 "C:\Users\90545\Desktop\akademikArama\demo\Views\Search\Cizge.cshtml"
                                           Write(Model.Soyad);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Kullanıcısının Çizge Yapısı</h1>\r\n        <div class=\"col\">\r\n            <div id=\"viz\"></div>\r\n        </div>\r\n        \r\n    </div>\r\n    \r\n");
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
            WriteLiteral("\r\n\r\n\r\n</html>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Layers.Arastirmaci> Html { get; private set; }
    }
}
#pragma warning restore 1591