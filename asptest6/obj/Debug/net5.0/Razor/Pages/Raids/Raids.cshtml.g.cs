#pragma checksum "C:\Users\Labra\source\repos\asptest6\asptest6\Pages\Raids\Raids.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9ef3acc49ab309a5125dbf1b967f8e072a2a72b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(asptest6.Pages.Raids.Pages_Raids_Raids), @"mvc.1.0.razor-page", @"/Pages/Raids/Raids.cshtml")]
namespace asptest6.Pages.Raids
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
#line 1 "C:\Users\Labra\source\repos\asptest6\asptest6\Pages\_ViewImports.cshtml"
using asptest6;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/raids/{MembershipType}/{MembershipId}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9ef3acc49ab309a5125dbf1b967f8e072a2a72b", @"/Pages/Raids/Raids.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32c30ccee86fbc3f1dd284aaf8a9b3df551106fd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Raids_Raids : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<script src=""https://cdn.jsdelivr.net/npm/vue@2/dist/vue.js""></script>
<div id=""app"">
    <div v-for=""profile in profiles"" v-on:click=""activeProfile=profile.membershipId"">
        {{ profile.username }}
    </div>
    {{ getActivityPagesResults.count }}
<div v-for=""raid in raids[activeProfile]"">
    <h1>{{ raid.raid.displayName }}</h1>
    <h3>{{ raid.threeMans }} Threemans</h3>
    <h3>{{ raid.twoMans }} Twomans</h3>
    <h3>{{ raid.oneMans }} Solos</h3>
</div>
</div>
<I></I>
<script>
    var app = new Vue({
        el: '#app',
        mounted() {
            fetch('");
#nullable restore
#line 24 "C:\Users\Labra\source\repos\asptest6\asptest6\Pages\Raids\Raids.cshtml"
              Write(Url.RouteUrl("ProfileController"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/CharacterPages', {
                method: ""POST"",
                body: JSON.stringify(
                    this.profiles
                ),
                headers: {
                    'Content-Type': 'application/json',
                    Accept: 'application/json',
                }
            })
            .then(response => response.json())
            .then((data) => {
                this.getActivityPagesResults = data;
                console.log(data);
                this.InitRequestPCGRsForCharacters();
            });

            this.FetchRaids();
            this.activeProfile = this.profiles[0].membershipId;
        },
        data: {
            user: ");
#nullable restore
#line 45 "C:\Users\Labra\source\repos\asptest6\asptest6\Pages\Raids\Raids.cshtml"
             Write(Json.Serialize(Model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            profiles: ");
#nullable restore
#line 46 "C:\Users\Labra\source\repos\asptest6\asptest6\Pages\Raids\Raids.cshtml"
                 Write(Json.Serialize(Model.Profiles));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            getActivityPagesResults: {
                characters: [],
                count: 0,
                pages: 0
            },
            raids: {},
            activeProfile: null
        },
        methods: {
            InitRequestPCGRsForCharacters() {
                let self = this;
                this.getActivityPagesResults.characters.forEach((character) => {
                    let amountOfPages = character.pages;
                    for (var i = 0; i < amountOfPages; i++) {
                        self.RequestPCGRsForCharacters(character);
                        character.pages--;
                    }
                });
            },
            RequestPCGRsForCharacters(character) {
                fetch('");
#nullable restore
#line 67 "C:\Users\Labra\source\repos\asptest6\asptest6\Pages\Raids\Raids.cshtml"
                  Write(Url.RouteUrl("ProfileController"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/PcgrsPage', {
                    method: ""POST"",
                    body: JSON.stringify(character),
                    headers: {
                        'Content-Type': 'application/json',
                        Accept: 'application/json',
                    }
                })
                .then(response => response.json())
                .then((data) => {
                    console.log(data);
                });
            },
            FetchRaids() {
                let self = this;
                this.profiles.forEach((profile) => {
                    fetch('");
#nullable restore
#line 83 "C:\Users\Labra\source\repos\asptest6\asptest6\Pages\Raids\Raids.cshtml"
                      Write(Url.RouteUrl("ProfileController"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"/ProfileRaids', {
                        method: ""POST"",
                        body: JSON.stringify(profile),
                        headers: {
                            'Content-Type': 'application/json',
                            Accept: 'application/json',
                        }
                    })
                        .then(response => response.json())
                        .then((data) => {
                            self.raids[data.profile.membershipId] = data.raidCompletions;
                        });
                });
            }
        }
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<asptest6.Pages.Forms.RaidsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<asptest6.Pages.Forms.RaidsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<asptest6.Pages.Forms.RaidsModel>)PageContext?.ViewData;
        public asptest6.Pages.Forms.RaidsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
