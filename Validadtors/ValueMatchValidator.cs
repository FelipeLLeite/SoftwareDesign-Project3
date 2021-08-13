using Assi3.Classes;

namespace Assi3.Validators
{
    class ValueMatchValidator : FormComponent
    {
        private FormComponent _other;

        public ValueMatchValidator(FormComponent component, FormComponent other) : base(component.GetName())
        {
            _component = component;
            _other = other;
        }

        public override bool IsValid()
        {
            if (GetValue() != _other.GetValue())
                return false;
            return _component.IsValid();
        }
    }
}
