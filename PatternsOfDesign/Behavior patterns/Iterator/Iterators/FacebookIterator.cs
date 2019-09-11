using System;
using PatternsOfDesign.Behavior_patterns.Iterator.SocialNetworks;

namespace PatternsOfDesign.Behavior_patterns.Iterator.Iterators
{
    class FacebookIterator:IIterator
    {
        private readonly Facebook _facebook;
        private readonly Guid _profileId;
        private Profile[] _cache;
        private readonly string _type;
        private int _currentPosition;

        public FacebookIterator(Facebook social, Guid profileId, string type)
        {
            _facebook = social;
            _profileId = profileId;
            _type = type;
        }

        public Profile GetNext()
        {
            if (HasMore())
            {
                _currentPosition++;
            }

            return _cache[_currentPosition];
        }

        public bool HasMore()
        {
            LazyInit();
            return _cache.Length < _currentPosition;
        }

        private void LazyInit()
        {
            if (_cache == null)
            {
                _cache = _facebook.SendSophisticatedSocialGraphRequest(_profileId, _type);
            }
        }
    }
}
