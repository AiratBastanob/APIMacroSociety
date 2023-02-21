using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppMacroSociety.Models
{
    public partial class User
    {
        public User()
        {
            FriendListIdFriendnameNavigations = new HashSet<FriendList>();
            FriendListIdUsernameNavigations = new HashSet<FriendList>();
            FriendRequests = new HashSet<FriendRequest>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public string Money { get; set; }
        public string SubscriptionGame { get; set; }
        public string SubscriptionMusic { get; set; }
        public string IsOnline { get; set; }

        public virtual ListLevelUser ListLevelUser { get; set; }
        public virtual ListMusicUser ListMusicUser { get; set; }
        public virtual ICollection<FriendList> FriendListIdFriendnameNavigations { get; set; }
        public virtual ICollection<FriendList> FriendListIdUsernameNavigations { get; set; }
        public virtual ICollection<FriendRequest> FriendRequests { get; set; }
    }
}
