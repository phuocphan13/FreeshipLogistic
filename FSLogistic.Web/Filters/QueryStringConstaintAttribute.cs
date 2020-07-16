using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Routing;
using System;

namespace FSLogistic.Web.Filters
{
    public class QueryStringConstaintAttribute : ActionMethodSelectorAttribute
    {
        public string ValueName { get; set; }
        public bool IsValuePresent { get; set; }
        public QueryStringConstaintAttribute(string valueName, bool isValuePresent)
        {
            ValueName = valueName;
            IsValuePresent = isValuePresent;
        }
        public override bool IsValidForRequest(RouteContext routeContext, ActionDescriptor action)
        {
            var value = routeContext.HttpContext.Request.Query[this.ValueName];
            if (this.IsValuePresent)
            {
                return !String.IsNullOrEmpty(value);
            }
            return String.IsNullOrEmpty(value);
        }
    }
}
