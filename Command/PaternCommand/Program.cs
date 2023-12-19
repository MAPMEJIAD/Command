using PaternCommand;

var figure = new Figure(5);

var crCommand = new CreateCommand(figure);
var DelCommand = new DeleteCommand(figure);
var FillCommand = new FillCommand(figure);

Stack<ICommand> historyCommands = new Stack<ICommand>();

//Create
crCommand.Execute();
historyCommands.Push(crCommand);

//Delete
DelCommand.Execute();
historyCommands.Push(DelCommand);

//Change fill of figure
FillCommand.Execute();
historyCommands.Push(FillCommand);

//Create
crCommand.Execute();
historyCommands.Push(crCommand);

//Undo
var com = historyCommands.Pop();
com.Undo();

//Create again
crCommand.Execute();
historyCommands.Push(crCommand);

