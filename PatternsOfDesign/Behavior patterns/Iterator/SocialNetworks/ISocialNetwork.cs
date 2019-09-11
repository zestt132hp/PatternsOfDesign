using System;
using PatternsOfDesign.Behavior_patterns.Iterator.Iterators;

namespace PatternsOfDesign.Behavior_patterns.Iterator.SocialNetworks
{
    interface ISocialNetwork
    {
        IIterator CreateFriendsIterator(Guid profileId);
        IIterator CreateCoworkerIterator(Guid profileId);
    } 
}
