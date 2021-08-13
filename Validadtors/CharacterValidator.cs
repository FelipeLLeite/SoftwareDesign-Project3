using Assi3.Classes;

namespace Assi3.Validators
{
    public class CharacterValidator : FormComponent
    {
        private string _character;

        public CharacterValidator(FormComponent component, string character) : base(component.GetName())
        {
            _character = character.ToLower();
            _component = component;
        }

        public override bool IsValid()
        {
            if (!GetValue().ToLower().Contains(_character))
                return false;
            return _component.IsValid();
        } // end IsValid override method
    } // end CharacterValidator class
} // end namespace Assi3.Validators