

namespace PatternsOfDesign.Behavior_patterns.State
{
    class PlayingState:State
    {
        public PlayingState(Player player) : base(player)
        {
        }

        public override void OnLock()
        {
            _player.ChangeState(new LockedState(_player));
        }

        public override void OnPlay()
        {
            _player.ChangeState(new ReadyState(_player));
        }

        public override void OnNext()
        {
            _player.NextSong();
        }

        public override void OnPrevious()
        {
            _player.PreviosSong();
        }
    }
}
