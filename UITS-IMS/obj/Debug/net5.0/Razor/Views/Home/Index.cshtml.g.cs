#pragma checksum "E:\IMS\UITS-IMS\UITS-IMS\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57569bf855e55e5464f4c6e0ad2881f4b16c7004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\IMS\UITS-IMS\UITS-IMS\Views\_ViewImports.cshtml"
using UITS_IMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\IMS\UITS-IMS\UITS-IMS\Views\_ViewImports.cshtml"
using UITS_IMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\IMS\UITS-IMS\UITS-IMS\Views\_ViewImports.cshtml"
using UITS_IMS.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57569bf855e55e5464f4c6e0ad2881f4b16c7004", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1860ad21bbdbd35b7e6b589113af1bcd53c49987", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\IMS\UITS-IMS\UITS-IMS\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-xl-12"">
        <div class=""card-box"">
            <div class=""dropdown float-right"">
                <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                    <i class=""mdi mdi-dots-horizontal""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"">
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Settings</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Download</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Upload</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Action</a>
                </div>
            </div>
            <h4 class=""header-title mb-4"">Requisitions</h4>


            <div class=""table-responsive"">");
            WriteLiteral(@"
                <table class=""table table-centered table-hover mb-0"" id=""datatable"">
                    <thead>
                        <tr>
                            <th class=""border-top-0"">Name</th>
                            <th class=""border-top-0"">Position</th>
                            <th class=""border-top-0"">Department</th>
                            <th class=""border-top-0"">Mobile No.</th>
                            <th class=""border-top-0"">Options</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-2.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Imelda J. Stanberry</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/visa.png"" alt=""user-card"" height=""");
            WriteLiteral(@"24"" />
                                <span class=""ml-2"">**** 3256</span>
                            </td>
                            <td>27.03.2018</td>
                            <td>$345.98</td>
                            <td><span class=""badge badge-pill badge-danger"">Failed</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-3.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Francisca S. Lobb</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/master.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 8451</span>
                            </td>
                            <td>28.03.2018</td>
                            <td>$1,250</td>
                            <td><sp");
            WriteLiteral(@"an class=""badge badge-pill badge-success"">Paid</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-1.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">James A. Wert</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/amazon.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 2258</span>
                            </td>
                            <td>28.03.2018</td>
                            <td>$145</td>
                            <td><span class=""badge badge-pill badge-success"">Paid</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-4.jpg"" alt=""user-pic"" cla");
            WriteLiteral(@"ss=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Dolores J. Pooley</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/american-express.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 6950</span>
                            </td>
                            <td>29.03.2018</td>
                            <td>$2,005.89</td>
                            <td><span class=""badge badge-pill badge-danger"">Failed</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-5.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Karen I. McCluskey</span>
                            </td>
                            <td>
                                <im");
            WriteLiteral(@"g src=""assets/images/cards/discover.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 0021</span>
                            </td>
                            <td>31.03.2018</td>
                            <td>$24.95</td>
                            <td><span class=""badge badge-pill badge-success"">Paid</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-6.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Kenneth J. Melendez</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/visa.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 2840</span>
                            </td>
                            <td>27.03.2018</td>
                 ");
            WriteLiteral(@"           <td>$345.98</td>
                            <td><span class=""badge badge-pill badge-success"">Paid</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-7.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Sandra M. Nicholas</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/master.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 2015</span>
                            </td>
                            <td>28.03.2018</td>
                            <td>$1,250</td>
                            <td><span class=""badge badge-pill badge-danger"">Failed</span></td>
                        </tr>
                        <tr>
                            <td>
                      ");
            WriteLiteral(@"          <img src=""assets/images/users/avatar-8.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Ronald S. Taylor</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/amazon.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 0325</span>
                            </td>
                            <td>28.03.2018</td>
                            <td>$145</td>
                            <td><span class=""badge badge-pill badge-success"">Paid</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-9.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Beatrice L. Iacovelli</span>
                            </td>
           ");
            WriteLiteral(@"                 <td>
                                <img src=""assets/images/cards/discover.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 9058</span>
                            </td>
                            <td>29.03.2018</td>
                            <td>$6,542.32</td>
                            <td><span class=""badge badge-pill badge-success"">Paid</span></td>
                        </tr>
                        <tr>
                            <td>
                                <img src=""assets/images/users/avatar-10.jpg"" alt=""user-pic"" class=""rounded-circle avatar-sm bx-shadow-lg"" />
                                <span class=""ml-2"">Sylvia H. Parker</span>
                            </td>
                            <td>
                                <img src=""assets/images/cards/discover.png"" alt=""user-card"" height=""24"" />
                                <span class=""ml-2"">**** 2577</span>
                            </td>
   ");
            WriteLiteral(@"                         <td>31.03.2018</td>
                            <td>$24.95</td>
                            <td><span class=""badge badge-pill badge-danger"">Failed</span></td>
                        </tr>
                    </tbody>
                </table>
            </div>

        </div> <!-- end card-box-->
    </div> <!-- end col-->
</div>


<div class=""row"">
    <div class=""col-xl-8"">
        <div class=""card-box"">
            <div class=""dropdown float-right"">
                <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                    <i class=""mdi mdi-dots-horizontal""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"">
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Settings</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Download</a>
                ");
            WriteLiteral(@"    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Upload</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Action</a>
                </div>
            </div>
            <h4 class=""header-title mb-4"">Stock</h4>
            <div class=""row"">
                <div class=""col-md-12"">
                    <h5 class=""mb-1 mt-0"">1,12,540 <small class=""text-muted ml-2"">Lenovo Laptops</small></h5>
                    <div class=""progress-w-percent"">
                        <span class=""progress-value font-weight-bold"">72% </span>
                        <div class=""progress progress-sm"">
                            <div class=""progress-bar"" role=""progressbar"" style=""width: 72%;"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <h5 class=""mb-1 mt-0"">51,480 <small class=""text-muted ml-2"">Black Biometric Devices</s");
            WriteLiteral(@"mall></h5>
                    <div class=""progress-w-percent"">
                        <span class=""progress-value font-weight-bold"">39% </span>
                        <div class=""progress progress-sm"">
                            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 39%;"" aria-valuenow=""39"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <h5 class=""mb-1 mt-0"">45,760 <small class=""text-muted ml-2"">Blue Biometric Devices</small></h5>
                    <div class=""progress-w-percent"">
                        <span class=""progress-value font-weight-bold"">61% </span>
                        <div class=""progress progress-sm"">
                            <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 61%;"" aria-valuenow=""61"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <h5 class=""mb-1 mt-0"">");
            WriteLiteral(@"98,512 <small class=""text-muted ml-2"">Power Reels</small></h5>
                    <div class=""progress-w-percent"">
                        <span class=""progress-value font-weight-bold"">52% </span>
                        <div class=""progress progress-sm"">
                            <div class=""progress-bar bg-warning"" role=""progressbar"" style=""width: 52%;"" aria-valuenow=""52"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <h5 class=""mb-1 mt-0"">2,154 <small class=""text-muted ml-2"">Network Cables</small></h5>
                    <div class=""progress-w-percent"">
                        <span class=""progress-value font-weight-bold"">28% </span>
                        <div class=""progress progress-sm"">
                            <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 28%;"" aria-valuenow=""28"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>");
            WriteLiteral(@"
                </div> <!-- end col -->
            </div> <!-- end row-->
        </div>  <!-- end card-box-->
    </div> <!-- end col -->

    <div class=""col-xl-4"">
        <div class=""card-box"">
            <div class=""dropdown float-right"">
                <a href=""#"" class=""dropdown-toggle arrow-none card-drop"" data-toggle=""dropdown"" aria-expanded=""false"">
                    <i class=""mdi mdi-dots-horizontal""></i>
                </a>
                <div class=""dropdown-menu dropdown-menu-right"">
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Settings</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Download</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Upload</a>
                    <!-- item-->
                    <a href=""javascript:void(0);"" class=""dropdown-item"">Action</a>
                </div>
 ");
            WriteLiteral(@"           </div>
            <h4 class=""header-title mb-3"">Usage</h4>
            <div class=""row text-center"">
                <div class=""col-sm-4 mb-3"">
                    <h3 class=""font-weight-light"">4,335</h3>
                    <p class=""text-muted text-overflow"">Total Sales</p>
                </div>
                <div class=""col-sm-4 mb-3"">
                    <h3 class=""font-weight-light"">874</h3>
                    <p class=""text-muted text-overflow"">Open Compaign</p>
                </div>
                <div class=""col-sm-4 mb-3"">
                    <h3 class=""font-weight-light"">2,548</h3>
                    <p class=""text-muted text-overflow"">Total Sales</p>
                </div>
            </div>
            <div class=""chartjs-chart high-performing-product"">
                <canvas id=""high-performing-product""></canvas>
            </div>
        </div> <!-- end card-box-->
    </div> <!-- end col -->

</div>


");
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
