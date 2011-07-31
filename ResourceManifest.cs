using System.Globalization;
using Orchard;
using Orchard.UI.Resources;

namespace NGM.TwitterFollowButton {
    public class ResourceManifest : IResourceManifestProvider {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript("TwitterFollow").SetUrl("http://platform.twitter.com/widgets.js").SetVersion("1.0");
        }
    }
}