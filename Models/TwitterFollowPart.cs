using Orchard.ContentManagement;

namespace NGM.TwitterFollowButton.Models {
    public class TwitterFollowPart : ContentPart<TwitterFollowPartRecord> {
        public bool ShowFollowerCount {
            get { return Record.ShowFollowerCount; }
            set { Record.ShowFollowerCount = value; }
        }

        public string Username {
            get { return Record.Username; }
            set { Record.Username = value; }
        }

        public string BackgroundColour {
            get { return Record.BackgroundColour; }
            set { Record.BackgroundColour = value; }
        }

        public int Width {
            get { return Record.Width; }
            set { Record.Width = value; }
        }

        public string Align {
            get { return Record.Align; }
            set { Record.Align = value; }
        }
    }
}