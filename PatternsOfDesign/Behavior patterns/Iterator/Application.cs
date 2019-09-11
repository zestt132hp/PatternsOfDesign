
using PatternsOfDesign.Behavior_patterns.Iterator.Iterators;
using PatternsOfDesign.Behavior_patterns.Iterator.SocialNetworks;

namespace PatternsOfDesign.Behavior_patterns.Iterator
{
    class Application
    {
        private readonly ISocialNetwork _network;
        private readonly SocialSpammer _spammer;

        public Application(ISocialNetwork network, SocialSpammer spammer)
        {
            _network = network;
            _spammer = spammer;
        }

        public void SendSpam(Profile profile)
        {
            IIterator iteratorCoworker = _network.CreateCoworkerIterator(profile.GetId);
            IIterator iteratorFriends = _network.CreateFriendsIterator(profile.GetId);
            _spammer.Send(iteratorCoworker, "You received the spam message");
            _spammer.Send(iteratorFriends, "You received the spam message");
        }

        public void SendMessage(Profile profile)
        {
            IIterator iteratorCoworker = _network.CreateCoworkerIterator(profile.GetId);
            IIterator iteratorFriends = _network.CreateFriendsIterator(profile.GetId);
            _spammer.Send(iteratorCoworker, "Send very important message");
            _spammer.Send(iteratorFriends, "Send very important message");
        }
    }
}
