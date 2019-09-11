namespace PatternsOfDesign.Behavior_patterns.State
{
    abstract class State
    {
        protected Player _player;
        public State(Player player)
        {
            _player = player;
        }
        public abstract void OnLock();
        public abstract void OnPlay();
        public abstract void OnNext();
        public abstract void OnPrevious();
    }
}
