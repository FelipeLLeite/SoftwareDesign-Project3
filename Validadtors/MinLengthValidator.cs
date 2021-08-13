using proj3.Classes;

namespace proj3.Validators
{
    class MinLengthValidator : FormComponent
    {
        private int _minLength;

        public MinLengthValidator(FormComponent component, int minLength) : base(component.GetName())
        {
            _minLength = minLength;
            _component = component;
        }

        public override bool IsValid()
        {
            if (GetValue().Length < _minLength)
                return false;
            return _component.IsValid();
        }
    }
}
