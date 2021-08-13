using proj3.Classes;
using proj3.Interfaces;

namespace proj3.States
{
    public class StateContext
    {
        private Form _form;
        private IState _state;

        public void Run(Form form)
        {
            this._form = form;
            this.SetState(new FormInputState(this));
        }

        public void SetState(IState state)
        {
            _state = state;
            _state.Run();
        }

        public Form GetForm()
        {
            return _form;
        }
    }

}