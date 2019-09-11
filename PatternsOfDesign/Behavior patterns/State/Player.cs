using System;

namespace PatternsOfDesign.Behavior_patterns.State
{
    abstract class Player
    {
        private State _state;

        public Player()
        {
            _state = new ReadyState(this);
            var ui = new Ui(new Button());
            ui.Button.OnClick(ClickLock);
            ui.Button.OnClick(ClickPlay);
            ui.Button.OnClick(ClickNext);
            ui.Button.OnClick(ClickPrevious);
        }

        private void ClickPlay()
        {
            _state.OnPlay();
        }

        private void ClickLock()
        {
            _state.OnLock();
        }

        private void ClickNext()
        {
            _state.OnNext();
        }

        private void ClickPrevious()
        {
            _state.OnPrevious();
        }

        public void ChangeState(State state)
        {
            _state = state;
        }

        public void NextSong()
        {
            Console.WriteLine("Playing next song");
        }

        public void StartPlaying() => Console.WriteLine("Playing song");

        public void PreviosSong() => Console.WriteLine("Playing previous song");
    }

    internal class Ui
    {
        private Button _button;

        public Ui(Button button)
        {
            _button = button;
        }

        public Button Button => _button;

    }

    internal class Button
    {
        public void OnClick(Action action)
        {
            action.Invoke();
        }
    }
}
