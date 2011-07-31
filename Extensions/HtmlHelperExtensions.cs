using System;
using System.Text;
using System.Web;
using System.Web.Mvc;
using NGM.TwitterFollowButton.Models;

namespace NGM.TwitterFollowButton.Extensions {
    public static class HtmlHelperExtensions {
        public static IHtmlString BuildTwitterScriptFor(this HtmlHelper htmlHelper, TwitterFollowPart part) {
            const string startTag = "<a";
            const string endTag = ">Follow @{0}</a>";

            var builder = new StringBuilder();
            builder.Append(startTag);

            builder.AppendFormat(" href=\"http://twitter.com/{0}\"", part.Username);
            builder.Append(" class=\"twitter-follow-button\"");

            if (!part.ShowFollowerCount)
                builder.Append(" data-show-count=\"false\"");

            if (part.BackgroundColour == Colour.Dark.ToString())
                builder.Append(" data-text-color=\"#FFFFFF\" data-link-color=\"#00AEFF\"");

            builder.AppendFormat(" data-lang=\"{0}\"", GetLanguage());

            if (part.Width != 300)
                builder.AppendFormat(" data-width=\"{0}\"px", part.Width);

            if (part.Align != Align.Left.ToString())
                builder.AppendFormat(" data-width=\"{0}\"px", part.Width);

            builder.AppendFormat(endTag, part.Username);

            return MvcHtmlString.Create(builder.ToString());
        }

        private static object[] GetLanguage() {
            return null;
        }
    }
}