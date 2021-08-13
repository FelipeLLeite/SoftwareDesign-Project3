using System;
using proj3.Interfaces;

namespace proj3.States
{
    public class FormDoneState : IState
    {
        private StateContext _context;
        private string _stateOption;

        public FormDoneState(StateContext context)
        {
            _context = context;
            _stateOption = "";
        }

        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}Type print to print the form, or exit to leave.{Environment.NewLine}");
            // reset the state option
            _stateOption = "";
            while (_stateOption.ToLower().Equals("exit"))
            {
                Console.Write("> ");
                _stateOption = Console.ReadLine();
                // case 
                if (_stateOption.ToLower().Equals("print"))
                    Console.WriteLine(_context.GetForm().Print());
            }
        }
    } // end class
} // end namespace