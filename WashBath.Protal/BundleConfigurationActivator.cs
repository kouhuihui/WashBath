using System.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(typeof(WashBath.Protal.BundleConfigurationActivator), "Activate")]
namespace WashBath.Protal
{
    public static class BundleConfigurationActivator
    {
        public static void Activate()
        {
            BundleTable.Bundles.RegisterConfigurationBundles();
        }
    }
}