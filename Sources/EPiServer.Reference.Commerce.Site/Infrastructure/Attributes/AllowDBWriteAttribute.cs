using EPiServer.Data;
using EPiServer.ServiceLocation;
using System.Web.Mvc;

namespace EPiServer.Reference.Commerce.Site.Infrastructure.Attributes
{
    public class AllowDBWriteAttribute : ActionMethodSelectorAttribute
    {
        protected Injected<IDatabaseMode> DBMode;

        public override bool IsValidForRequest(ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo)
        {
            //DEMO: allows UI to allow adding to cart and placing orders
            return true;
            //return DBMode.Service != null && DBMode.Service.DatabaseMode != DatabaseMode.ReadOnly;
        }
    }
}