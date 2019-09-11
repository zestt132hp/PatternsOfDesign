using System.Collections.Generic;

namespace PatternsOfDesign.Behavior_patterns.Observer
{
    class EventManager
    {
        private HashSet<IEventListener> _hashSet;

        public EventManager()
        {
            _hashSet = new HashSet<IEventListener>();
        }

        public void Subscribe( IEventListener listener)
        {
            _hashSet.Add(listener);
        }

        public void Unsubscribe(IEventListener listener)
        {
            if (_hashSet.Count != 0)
            {
                _hashSet.Remove(listener);
            }
        }

        public void Notify(string fileName)
        {
            foreach (var listener in _hashSet)
            {
                listener.Update(fileName);
            }
        }
    }
}
