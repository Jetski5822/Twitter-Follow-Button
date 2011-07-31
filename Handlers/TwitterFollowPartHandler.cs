using JetBrains.Annotations;
using NGM.TwitterFollowButton.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;

namespace NGM.TwitterFollowButton.Handlers {
    [UsedImplicitly]
    public class TwitterFollowPartHandler : ContentHandler {
        public TwitterFollowPartHandler(IRepository<TwitterFollowPartRecord> repository) {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}