#pragma checksum "E:\Pro_TSHP\hvac_show\hvacshow\Areas\Company\Views\Company\profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4fb4f9f0a517c8564b4bc618e1940a85b8258a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Company_Views_Company_profile), @"mvc.1.0.view", @"/Areas/Company/Views/Company/profile.cshtml")]
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
#line 1 "E:\Pro_TSHP\hvac_show\hvacshow\Areas\Company\Views\_ViewImports.cshtml"
using hvacshow.Areas.Company;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4fb4f9f0a517c8564b4bc618e1940a85b8258a", @"/Areas/Company/Views/Company/profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5ddbc70e4b6c320bc05114b2ab04fa2be8071f", @"/Areas/Company/Views/_ViewImports.cshtml")]
    public class Areas_Company_Views_Company_profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Company/assets/app/media/img/users/user4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("m-form m-form--fit m-form--label-align-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("profile-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Pro_TSHP\hvac_show\hvacshow\Areas\Company\Views\Company\profile.cshtml"
  
    ViewData["Title"] = "profile";
    Layout = "~/Areas/Company/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""m-grid__item m-grid__item--fluid m-wrapper"">

    <!-- BEGIN: Subheader -->
    <div class=""m-subheader "">
        <div class=""d-flex align-items-center"">
            <div class=""mr-auto"">
                <h3 class=""m-subheader__title display-inline-block ml-0 pl-0"">داشبورد</h3>
                <ul class=""m-subheader__breadcrumbs m-nav m-nav--inline display-inline-block"">
                    <li class=""m-nav__separator"">
                        -
                    </li>
                    <li class=""m-nav__item"">
                        <a href=""javascript:void(0)"" class=""m-nav__link"">
                            <span class=""m-nav__link-text"">
                                درخواست ها
                            </span>
                        </a>
                    </li>
                    <li class=""m-nav__separator"">
                        -
                    </li>
                    <li class=""m-nav__item"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1103, "\"", 1110, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""m-nav__link"">
                            <span class=""m-nav__link-text"">
                                لیست درخواست ها
                            </span>
                        </a>
                    </li>
                </ul>
            </div>
            <div>
                <span class=""m-subheader__daterange"">
                    &nbsp;
                    17 آذر
                    &nbsp;<a href=""#"" class=""btn btn-sm btn-brand m-btn m-btn--icon m-btn--icon-only m-btn--custom m-btn--pill"">
                        <i class=""la la-calendar""></i>
                    </a>
                </span>
            </div>
        </div>
    </div>
    <!-- END: Subheader -->
    <div class=""m-content"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""m-portlet m-portlet--full-height m-portlet--tabs  "">
                    <div class=""m-portlet__head"">
                        <div class=""m-portlet__head-tools"">
                       ");
            WriteLiteral(@"     <ul class=""nav nav-tabs m-tabs m-tabs-line   m-tabs-line--left m-tabs-line--primary"" role=""tablist"">
                                <li class=""nav-item m-tabs__item"">
                                    <a class=""nav-link m-tabs__link active"" data-toggle=""tab"" href=""#m_user_profile_tab_1"" role=""tab"">
                                        <i class=""flaticon-share m--hide""></i>
                                        پروفایل
                                    </a>
                                </li>
                                <!--<li class=""nav-item m-tabs__item"">
                                    <a class=""nav-link m-tabs__link"" data-toggle=""tab"" href=""#m_user_profile_tab_2"" role=""tab"">
                                        پیام ها
                                    </a>
                                </li>
                                <li class=""nav-item m-tabs__item"">
                                    <a class=""nav-link m-tabs__link"" data-toggle=""tab"" href=""#m_user_pro");
            WriteLiteral(@"file_tab_3"" role=""tab"">
                                        تنظیمات
                                    </a>
                                </li>-->
                            </ul>
                        </div>
                    </div>
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""m_user_profile_tab_1"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be4fb4f9f0a517c8564b4bc618e1940a85b8258a8732", async() => {
                WriteLiteral(@"
                                <div class=""m-portlet__body"">
                                    <div class=""m-card-profile"">
                                        <div class=""m-card-profile__pic"">
                                            <div class=""m-card-profile__pic-wrapper"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "be4fb4f9f0a517c8564b4bc618e1940a85b8258a9336", async() => {
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
                WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""m-section__content container-fluid text-center mb-3"">
                                            <button class=""btn btn-brand btn-sm"" type=""button"" data-target=""#uploader"" data-toggle=""modal"">انتخاب عکس</button>
                                        </div>
                                        <div class=""m-card-profile__details"">
                                            <span class=""m-card-profile__name"">
                                                امیرحسین عرب
                                            </span>
                                            <a class=""m-card-profile__email m-link tshcurpoi"">شماره کاربری : 97776543</a>
                                        </div>
                                    </div>
                                    <div class=""form-group m-form__group row"">
                                     ");
                WriteLiteral(@"   <div class=""col-10 ml-auto"">
                                            <h3 class=""m-form__section"">1. اطلاعات شخصی</h3>
                                        </div>
                                    </div>
                                    <div class=""form-group m-form__group row"">
                                        <label for=""firstname"" class=""col-lg-4 col-xs-12 col-form-label"">نام</label>
                                        <div class=""col-lg-5 col-xs-12"">
                                            <input class=""form-control m-input"" id=""firstname"" name=""firstname"" type=""text"" value=""امیرحسین"">
                                        </div>
                                    </div>
                                    <div class=""form-group m-form__group row"">
                                        <label for=""lastname"" class=""col-lg-4 col-xs-12 col-form-label"">نام خانوادگی</label>
                                        <div class=""col-lg-5 col-xs-12"">
                  ");
                WriteLiteral(@"                          <input class=""form-control m-input"" id=""lastname"" name=""lastname"" type=""text"" value=""عرب"">
                                        </div>
                                    </div>
                                    <div class=""form-group m-form__group row"">
                                        <label for=""email"" class=""col-lg-4 col-xs-12 col-form-label"">ایمیل</label>
                                        <div class=""col-lg-5 col-xs-12"">
                                            <input class=""form-control m-input"" id=""email"" name=""email"" type=""text"" value=""test@test.com"">
                                        </div>
                                    </div>
                                    <div class=""form-group m-form__group row"">
                                        <label for=""phone"" class=""col-lg-4 col-xs-12 col-form-label"">شماره تلفن</label>
                                        <div class=""col-lg-5 col-xs-12"">
                                     ");
                WriteLiteral(@"       <input class=""form-control m-input"" id=""phone"" name=""phone"" type=""text"" value=""09197386684"">
                                        </div>
                                    </div>

                                    <div class=""m-form__seperator m-form__seperator--dashed m-form__seperator--space-2x""></div>

                                    <div class=""form-group m-form__group row"">
                                        <div class=""col-10 ml-auto"">
                                            <h3 class=""m-form__section"">
                                                2. رمز عبور
                                                <small style=""display:block;font-size: 14px;margin-top: 10px;"">برای تغییر رمز عبور فرم زیر را پر کنید.</small>
                                            </h3>
                                        </div>
                                    </div>

                                    <div class=""form-group m-form__group row"">
                            ");
                WriteLiteral(@"            <label for=""password"" class=""col-lg-4 col-xs-12 col-form-label"">رمز عبور</label>
                                        <div class=""col-lg-5 col-xs-12"">
                                            <input class=""form-control m-input"" id=""password"" name=""password"" type=""password""");
                BeginWriteAttribute("value", " value=\"", 8440, "\"", 8448, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>
                                    <div class=""form-group m-form__group row"">
                                        <label for=""repassword"" class=""col-lg-4 col-xs-12 col-form-label"">تکرار رمز عبور</label>
                                        <div class=""col-lg-5 col-xs-12"">
                                            <input class=""form-control m-input"" id=""repassword"" name=""repassword"" type=""password""");
                BeginWriteAttribute("value", " value=\"", 8957, "\"", 8965, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </div>
                                    </div>

                                </div>
                                <div class=""m-portlet__foot m-portlet__foot--fit"">
                                    <div class=""m-form__actions"">
                                        <div class=""row"">
                                            <div class=""col-2"">
                                            </div>
                                            <div class=""col-7 text-left"">
                                                <button type=""submit"" class=""btn btn-accent m-btn m-btn--air m-btn--custom"">ذخیره</button>&nbsp;&nbsp;
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""tab-pane "" id=""m_user_profile_tab_2"">

                        </div>
                        <div class=""tab-pane "" id=""m_user_profile_tab_3"">

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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