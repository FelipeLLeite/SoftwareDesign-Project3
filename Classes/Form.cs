using System;
using System.Collections.Generic;

namespace proj3
{
    public class Form
    {
        private State _state;
        private ValidatorDecorator _validator;

        public Form()
        {
            ChangeState(new FormInput(this));
        } // end ctor


        public void ChangeState(State newState)
        {
            _state = newState;
        } // end ChangeState method

    } // end Form class
} // end namespace
