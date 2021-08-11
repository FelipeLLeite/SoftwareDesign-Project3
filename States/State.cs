namespace proj3
{
    public class State : IState
    {
        protected Form form;

        public State(Form form)
        {
            this.form = form;
        }

        public void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}