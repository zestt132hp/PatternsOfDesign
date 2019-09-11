using System;
using System.Collections.Generic;
using PatternsOfDesign.Behavior_patterns.Iterator.Iterators;

namespace PatternsOfDesign.Behavior_patterns.Iterator.SocialNetworks
{
    class Facebook : ISocialNetwork
    {
        public IIterator CreateFriendsIterator(Guid profileId)
        {
            return new FacebookIterator(this, profileId, "friends");
        }

        public IIterator CreateCoworkerIterator(Guid profileId)
        {
            return new FacebookIterator(this, profileId, "coworkers");
        }

        public Profile[] SendSophisticatedSocialGraphRequest(Guid profileId, string type)
        {
            var friendsList = new List<Profile>() { new Profile("vasia@mail.ru", new Guid()), new Profile("petya@google.com", new Guid())};
            var coworkerList = new List<Profile>(){new Profile("Ivanovic@gmail.com", new Guid()), new Profile("Petrovic@gmail.com", new Guid())};
            return type == "friends" ? friendsList.ToArray() : coworkerList.ToArray();
        }
    }
}
