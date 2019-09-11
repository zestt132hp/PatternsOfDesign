
using System;
using PatternsOfDesign.Behavior_patterns.Iterator.Iterators;

namespace PatternsOfDesign.Behavior_patterns.Iterator.SocialNetworks
{
    class SocialSpammer
    {
        private Profile _profile;

        public SocialSpammer(Profile profile)
        {
            _profile = profile;
        }
        public void Send(IIterator iterator, string message)
        {
            while (iterator.HasMore())
            {
                _profile = iterator.GetNext();
                SendMail(_profile.GetEmail, "Hello World");
            }
        }

        private void SendMail(string email, string message)
        {
            Console.WriteLine($"send to address: {email} \n Message: {message}");
        }
    }
}
