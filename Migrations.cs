using NGM.TwitterFollowButton.Models;
using Orchard.ContentManagement.MetaData;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace NGM.TwitterFollowButton {
    public class Migrations : DataMigrationImpl {
        public int Create() {
            SchemaBuilder.CreateTable("TwitterFollowPartRecord",
                                      table => table
                                                   .ContentPartRecord()
                                                   .Column<bool>("ShowFollowerCount")
                                                   .Column<string>("Username")
                                                   .Column<string>("BackgroundColour")
                                                   .Column<int>("Width")
                                                   .Column<string>("Align")
                                                   .Column<string>("Language")
                );

            ContentDefinitionManager.AlterPartDefinition(typeof(TwitterFollowPart).Name, cfg => cfg.Attachable());

            ContentDefinitionManager.AlterTypeDefinition("TwitterFollowWidget", cfg => cfg
                                                                                           .WithPart("TwitterFollowPart")
                                                                                           .WithPart("WidgetPart")
                                                                                           .WithPart("CommonPart")
                                                                                           .WithSetting("Stereotype", "Widget"));
            return 1;
        }
    }
}