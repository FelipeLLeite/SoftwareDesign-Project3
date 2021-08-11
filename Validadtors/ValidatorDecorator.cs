namespace proj3
{
    public abstract class ValidatorDecorator
    {
        protected IDecorator decorator;
        public ValidatorDecorator(IDecorator decorator)
        {
            this.decorator = decorator;
        }

        public abstract bool HandleInput();
        public abstract void ErrorMessage();
    }
}