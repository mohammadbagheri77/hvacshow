#pragma checksum "E:\Pro_TSHP\hvac_show\hvacshow\Areas\Company\Views\Company\buyHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22a9a609073604fe7267e0f38cf13bde7b461dad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Company_Views_Company_buyHistory), @"mvc.1.0.view", @"/Areas/Company/Views/Company/buyHistory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a9a609073604fe7267e0f38cf13bde7b461dad", @"/Areas/Company/Views/Company/buyHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e5ddbc70e4b6c320bc05114b2ab04fa2be8071f", @"/Areas/Company/Views/_ViewImports.cshtml")]
    public class Areas_Company_Views_Company_buyHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Pro_TSHP\hvac_show\hvacshow\Areas\Company\Views\Company\buyHistory.cshtml"
  
    ViewData["Title"] = "buyHistory";
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
                                پلن
                            </span>
                        </a>
                    </li>
                    <li class=""m-nav__separator"">
                        -
                    </li>
                    <li class=""m-nav__item"">
                        <a");
            BeginWriteAttribute("href", " href=\"", 1099, "\"", 1106, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""m-nav__link"">
                            <span class=""m-nav__link-text"">
                                تاریخچه خرید
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
            WriteLiteral(@"  <ul class=""nav nav-tabs m-tabs m-tabs-line   m-tabs-line--left m-tabs-line--primary"" role=""tablist"">
                                <li class=""nav-item m-tabs__item"">
                                    <a class=""nav-link m-tabs__link active"" data-toggle=""tab"" href=""#m_user_profile_tab_1"" role=""tab"">
                                        <i class=""flaticon-share m--hide""></i>
                                        <cust_title>
                                            تاریخچه خرید
                                        </cust_title>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""tab-content"">
                        <div class=""tab-pane active"" id=""m_user_profile_tab_1"">
                            <div class=""m-portlet__body"">
                                <table class=""nres-table table table-striped table-hover m-table--head-sep");
            WriteLiteral(@"arator-primary"">
                                    <thead>
                                        <tr>
                                            <th>#</th>
                                            <th>پلن</th>
                                            <th>شماره فاکتور</th>
                                            <th>تاریخ خرید</th>
                                            <th>مبلع پرداختی</th>
                                            <th>وضعیت</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <th scope=""row"">1</th>
                                            <td>نام پلن</td>
                                            <td>1399051910001</td>
                                            <td>1399/05/19</td>
                                            <td class=""price-format"">450,000,000</td>
        ");
            WriteLiteral(@"                                    <td>
                                                <button class=""btn btn-success btn-padding"">موفق</button>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                                <table style=""display: none;"" class=""res-table table table-striped table-hover m-table m-table--head-separator-primary"">
                                    <tr>
                                        <th>#</th>
                                        <td>1</td>
                                    </tr>
                                    <tr>
                                        <th>نوع صفحه</th>
                                        <td>صفحه شرکت</td>
                                    </tr>
                                    <tr>
                                        <th>مشاهده صفحه</th>
                                      ");
            WriteLiteral("  <td>\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 5257, "\"", 5264, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <button class=""btn btn-success tshpcustom btn-padding""><i class=""fa fa-eye tshfa""></i></button>
                                            </a>
                                        </td>
                                    </tr>
                                    <tr>
                                        <th>بازدید امروز</th>
                                        <td>12</td>
                                    </tr>
                                    <tr>
                                        <th>نرخ پیشرفت</th>
                                        <td class=""dir-ltr"">+10</td>
                                    </tr>
                                    <tr>
                                        <th>بادید کل</th>
                                        <td>300</td>
                                    </tr>
                                    <tr>
                                        <th>تیتر صفحه</th>
                   ");
            WriteLiteral(@"                     <td>شرکت A</td>
                                    </tr>
                                </table>
                                <div class=""col-lg-12 mt-4 mb-4 col-xs-12 pag-par"">
                                    <span class=""col-xs-12"">
                                        صفحه
                                        <span>50</span>
                                        از
                                        <span>170</span>
                                    </span>
                                    <ul class=""tshpaglist col-xs-12"">
                                        <li class=""btn btn-brand disabled"">قبلی</li>
                                        <li class=""btn btn-brand active-pag"">1</li>
                                        <li class=""btn btn-brand"">2</li>
                                        <li class=""btn btn-brand"">3</li>
                                        <li class=""btn btn-brand"">4</li>
                                        ");
            WriteLiteral(@"<li class=""btn btn-brand"">5</li>
                                        <li class=""btn btn-brand"">6</li>
                                        <li class=""btn btn-brand"">7</li>
                                        <li class=""btn btn-brand"">8</li>
                                        <li class=""btn btn-brand"">9</li>
                                        <li class=""btn btn-brand"">10</li>
                                        <li class=""btn btn-brand"">بعدی</li>
                                    </ul>
                                </div>
                            </div>
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
