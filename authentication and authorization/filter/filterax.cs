using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace authentication_and_authorization.filter
{
    public class filterax : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
           if(filterContext.Exception is NotImplementedException)
            {

            }
            else
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "error"
                };
                filterContext.ExceptionHandled = true;
            }
        }
    }
}