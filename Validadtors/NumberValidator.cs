using Assi3.Classes;

namespace Assi3.Validators
{
    class NumberValidator : FormComponent
    {
        public NumberValidator(FormComponent component) : base(component.GetName())
        {
            _component = component;
        }

        public override bool IsValid()
        {
            int result;
            if (!int.TryParse(GetValue(), out result))
                return false;
            if (result < 0)
                return false;
            return _component.IsValid();
        }
    }
}