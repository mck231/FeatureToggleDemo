using System.Web.Mvc;

namespace FeatureToggleDemo.Attribute
{
    
    public class FeatureToggleAttribute : ActionFilterAttribute
    {
        public string FeatureName { get; set; }
        public string[] AllowedRoles { get; set; }

        public FeatureToggleAttribute(string featureName, params string[] allowedRoles)
        {
            FeatureName = featureName;
            AllowedRoles = allowedRoles;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Here you can implement your logic to check if the feature is enabled and if the user has one of the allowed roles
            // If not, you can redirect the user to a different view
        }
    }
}