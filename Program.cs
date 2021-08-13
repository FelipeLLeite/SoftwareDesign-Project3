using Assi3.Classes;
using Assi3.States;
using Assi3.Validators;

namespace Assi3
{
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();

            // Create classes that let you execute the following code:

            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Username"), 6
                )
            );
            form.AddComponent(
                new CharacterValidator(
                    new CharacterValidator(
                        new TextBox("Email"), "@"
                    ), "."
                )
            );
            form.AddComponent(
                new MinLengthValidator(
                    new TextBox("Real Name"), 2
                )
            );

            FormComponent password = new CharacterValidator(
                new MinLengthValidator(
                    new TextBox("Password"), 8
                ), "!"
            );
            form.AddComponent(password);

            form.AddComponent(
                new ValueMatchValidator(
                    new TextBox("Confirm Password"), password
                )
            );
            form.AddComponent(
                new NumberValidator(
                    new TextBox("Age")
                )
            );


            // Anonymous call
            new StateContext().Run(form);
        }
    }
}
