

namespace PatternsOfDesign.Behavior_patterns.State
{
    class LockedState:State
    {
        public override void OnLock()
        {
            _player.ChangeState(new PlayingState(_player));
        }

        public override void OnPlay()
        {
        }

        public override void OnNext()
        {
        }

        public override void OnPrevious()
        {
        }

        public LockedState(Player player) : base(player)
        {
        }
    }
}
