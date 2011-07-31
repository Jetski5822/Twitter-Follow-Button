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

            builder.AppendFormat(" href=\"http://twitter.com/{0}\"", part.Username.TrimStart('@'));
            builder.Append(" class=\"twitter-follow-button\"");

            if (!part.ShowFollowerCount)
                builder.Append(" data-show-count=\"false\"");

            if (part.BackgroundColour == Colour.Dark.ToString())
                builder.Append(" data-text-color=\"#FFFFFF\" data-link-color=\"#00AEFF\"");

            if (!string.IsNullOrEmpty(part.Language) && !string.IsNullOrEmpty(GetTwoLanguageCharacter(part.Language)))
                builder.AppendFormat(" data-lang=\"{0}\"", GetTwoLanguageCharacter(part.Language));

            if (part.Width != 300)
                builder.AppendFormat(" data-width=\"{0}\"px", part.Width);

            if (part.Align != Align.Left.ToString())
                builder.AppendFormat(" data-width=\"{0}\"px", part.Width);

            builder.AppendFormat(endTag, part.Username.TrimStart('@'));

            return MvcHtmlString.Create(builder.ToString());
        }

        private static string GetTwoLanguageCharacter(string language) {
            Language supportedLanguage = (Language)Enum.Parse(typeof(Language), language, true);

            switch (supportedLanguage) {
                case Language.English:
                    return string.Empty;
                case Language.French:
                    return "fr";
                case Language.German:
                    return "de";
                case Language.Italian:
                    return "it";
                case Language.Japanese:
                    return "ia";
                case Language.Korean:
                    return "ko";
                case Language.Portuguese:
                    return "pt";
                case Language.Russian:
                    return "ru";
                case Language.Spanish:
                    return "es";
                case Language.Turkish:
                    return "tr";
            }

            return string.Empty;
        }
    }

    
}