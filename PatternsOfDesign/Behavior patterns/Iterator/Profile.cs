using System;

namespace PatternsOfDesign.Behavior_patterns.Iterator
{
    class Profile
    {
        private string _email;
        private Guid _id;

        public Profile(string email, Guid id)
        {
            _email = email;
            _id = id;
        }

        public Guid GetId => _id;
        public string GetEmail => _email;
    }
}
