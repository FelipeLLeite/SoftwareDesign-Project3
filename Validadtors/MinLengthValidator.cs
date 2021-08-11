namespace proj3
{
    public class MinLengthValidator : ValidatorDecorator
    {
        private int _length;
        public MinLengthValidator(IDecorator decorator, int length) : base(decorator)
        {
            _length = length;
        }

        public override void ErrorMessage()
        {
            throw new System.NotImplementedException();
        }

        public override bool HandleInput()
        {
            throw new System.NotImplementedException();
        }
    }
}