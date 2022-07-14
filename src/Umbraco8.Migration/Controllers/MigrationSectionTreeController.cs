using System.Net.Http.Formatting;
using System.Web.Http.ModelBinding;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Mvc;
using Umbraco.Web.Trees;
using Umbraco.Web.WebApi.Filters;

namespace Umbraco.Migration
{
    [Tree("umbracoMigrationSection", "UmbracoMigrationSectionTree", IsSingleNodeTree = true, SortOrder = 0)]
    [PluginController("umbracoMigrationSection")]
    public class MigrationSectionTreeController : TreeController
    {        
        protected override TreeNode CreateRootNode(FormDataCollection queryStrings)
        {
            var root = base.CreateRootNode(queryStrings);

            root.RoutePath = "umbracoMigrationSection/UmbracoMigrationSectionTree/dashboard";
            root.Icon = "icon-users-alt";
            root.HasChildren = false;

            return root;
        }

        protected override MenuItemCollection GetMenuForNode(string id, [ModelBinder(typeof(HttpQueryStringModelBinder))] FormDataCollection queryStrings)
        {
            return MenuItemCollection.Empty;
        }

        protected override TreeNodeCollection GetTreeNodes(string id, [ModelBinder(typeof(HttpQueryStringModelBinder))] FormDataCollection queryStrings)
        {
            return TreeNodeCollection.Empty;
        }
    }
}
