using NGM.TwitterFollowButton.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;

namespace NGM.TwitterFollowButton.Drivers {
    public class TwitterFollowPartDriver : ContentPartDriver<TwitterFollowPart> {
        protected override DriverResult Display(TwitterFollowPart part, string displayType, dynamic shapeHelper) {
            return ContentShape("Parts_Twitter_Follow", () => shapeHelper.Parts_Twitter_Follow(ContentPart: part));
        }

        protected override DriverResult Editor(TwitterFollowPart part, dynamic shapeHelper) {
            if (part.Width == 0)
                part.Width = 300;

            return ContentShape("Parts_Twitter_FollowButton_Fields",
                                () => shapeHelper.EditorTemplate(TemplateName: "Parts.Twitter.FollowButton.Fields", Model: part, Prefix: Prefix));
        }

        protected override DriverResult Editor(TwitterFollowPart part, IUpdateModel updater, dynamic shapeHelper) {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}