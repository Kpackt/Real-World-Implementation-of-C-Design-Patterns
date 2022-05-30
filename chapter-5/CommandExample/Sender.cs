namespace CommandExample;

public class Sender
{
    private ICommand _command;
    public Sender(ICommand command)
    {
        _command = command;
    }

    public void DoCommand()
    {
        _command.Execute();
    }
}