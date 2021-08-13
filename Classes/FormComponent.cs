namespace proj3.Classes
{
    public class FormComponent
    {
        private string _name;
        private string _value;
        protected FormComponent _component;
        public FormComponent(string name)
        {
            _name = name;
            _value = "";
        }

        public string GetName()
        {
            return _name;
        }

        public string GetValue()
        {
            if (_component != null)
                return _component.GetValue();
            return _value;
        }

        public void SetValue(string value)
        {
            if (_component != null)
                _component.SetValue(value);
            else
                _value = value;
        }

        public virtual bool IsValid()
        {
            return true;
        }
    } // end FormComponent class
} // end namespace proj3.Classes