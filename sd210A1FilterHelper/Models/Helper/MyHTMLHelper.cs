using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sd210A1FilterHelper.Models.Helper
{
    public static class MyHTMLHelper
    {

        public static MvcHtmlString BootstrapModal(this HtmlHelper html, string id, string title, string message)
        {
            return MvcHtmlString
                .Create($@"
                        <button type='button' class='btn btn-primary' data-toggle='modal' data-target='#{id}' style='margin: 10px 5px;'>
                          Launch demo modal
                        </button>
                            <div class='modal' id='{id}' tabindex='-1' role='dialog'>
                             < div class='modal-dialog' role='document'>
                               <div class='modal-content'>
                                 <div class='modal-header'>
                                   <h5 class='modal-title'>{title}</h5>
                                   <button type='button' class='close' data-dismiss='modal' aria-label='Close'>
                                     <span aria-hidden='true'>&times;</span>
                                   </button>
                                 </div>
                                 <div class='modal-body'>
                                   <p>{message}</p>
                                 </div>
                                 <div class='modal-footer'>
                                   <button type='button' class='btn btn-secondary' data-dismiss='modal'>Close</button>
                                   <button type='button' class='btn btn-primary'>Save changes</button>
                                 </div>
                               </div>
                             </div>
                            </div>"
                       );
        }


    }

    public static class BooleanTeller
    {
        public static string ToYesOrNo(this bool input)
        {
            if (input)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
