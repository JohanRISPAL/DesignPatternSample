// See https://aka.ms/new-console-template for more information
using Composite;
using Composite.Manager;

var consoleManager = new ConsoleManager();

consoleManager.PrintApplicationTitle();

bool userContinue = true;

do
{
    string userAction = consoleManager.PrintMenu();

    userContinue = consoleManager.ManageUserAction(userAction);
    
} while (userContinue);