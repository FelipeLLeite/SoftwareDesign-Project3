using System;
using Assi3.Interfaces;

namespace Assi3.States
{
    public class FormInputState : IState
    {
        private StateContext _context;
        private string _stateOption;
        private string _input;

        public FormInputState(StateContext context)
        {
            _context = context;
            _stateOption = "";
            _input = "";
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Form.");
            for (int i = 0; i < _context.GetForm().GetComponents().Count; i++)
            {
                Console.WriteLine($"{_context.GetForm().GetComponents()[i].GetName()}:");
                do
                {
                    Console.Write("> ");
                    _input = Console.ReadLine();
                    _context.GetForm().GetComponents()[i].SetValue(_input);
                    if (!_context.GetForm().GetComponents()[i].IsValid())
                        Console.WriteLine("Invalid entry, try again:");
                } while (!_context.GetForm().GetComponents()[i].IsValid()); // end do-while loop
            } // end for-loop block
            Console.WriteLine($"{Environment.NewLine}You're done! To confirm, here's what you wrote:{Environment.NewLine}");
            Console.WriteLine(_context.GetForm().Print());
            Console.WriteLine("Type \"reset\" to reset, or \"ok\" to proceed");
            while (!_stateOption.ToLower().Equals("ok") && !_stateOption.ToLower().Equals("reset"))
            {
                Console.Write("> ");
                _stateOption = Console.ReadLine();
            }
            if (_stateOption.ToLower().Equals("reset"))
                Run();
            else
                _context.SetState(new FormDoneState(_context));
        } // end run method
    } // end FormInputState class
} // end namespace Assi3.States
