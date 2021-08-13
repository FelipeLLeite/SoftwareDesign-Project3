using System;
using System.Collections.Generic;

namespace Assi3.Classes
{
    public class Form
    {
        private List<FormComponent> _components;
        public Form()
        {
            _components = new List<FormComponent>();
        }
        public void AddComponent(FormComponent component)
        {
            _components.Add(component);
        }

        public List<FormComponent> GetComponents()
        {
            return _components;
        }

        public string Print()
        {
            string result = "";
            for (int i = 0; i < _components.Count; i++)
                result += $"{ _components[i].GetName()}: {_components[i].GetValue()}{Environment.NewLine}";
            return result;
        } // end Print method
    } // end Form class
} // end namespace
