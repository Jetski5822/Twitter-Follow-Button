using Orchard.ContentManagement.Records;

namespace NGM.TwitterFollowButton.Models {
    public class TwitterFollowPartRecord : ContentPartRecord {
        public virtual bool ShowFollowerCount { get; set; }
        public virtual string Username { get; set; }
        public virtual string BackgroundColour { get; set; }
        public virtual int Width { get; set; }
        public virtual string Align { get; set; }
        public virtual string Language { get; set; }
    }
}