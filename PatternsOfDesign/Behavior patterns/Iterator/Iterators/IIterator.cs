

namespace PatternsOfDesign.Behavior_patterns.Iterator.Iterators
{
    interface IIterator
    {
        Profile GetNext();
        bool HasMore();
    }
}
