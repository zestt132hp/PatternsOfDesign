using System;
using PatternsOfDesign.Behavior_patterns.Mediator.Components;
using Button = PatternsOfDesign.Behavior_patterns.Mediator.Components.Button;

namespace PatternsOfDesign.Behavior_patterns.Mediator
{
    class AuthenticationDialog:IMediator
    {
        private string _title;
        private TextBox _loginUserName, _loginUserPassword, _registeredMail;
        private CheckBox _checkBox;
        private Button _okButton, _cancelBiButton;

        public AuthenticationDialog(string title)
        {
            _loginUserName = new TextBox(this);
            _loginUserPassword = new TextBox(this);
            _registeredMail = new TextBox(this);
            _checkBox = new CheckBox(this);
            _okButton = new Button(this);
            _cancelBiButton = new Button(this);
            _title = title;
        }
        public void Notify(object sender, EventArgs e)
        {
            if (sender == _okButton)
            {
                _okButton.Click();
            }

            if (sender == _checkBox)
            {
                _checkBox.Check();
            }

            if (_cancelBiButton == sender)
            {
                _cancelBiButton.Click();
            }
        }
    }
}
