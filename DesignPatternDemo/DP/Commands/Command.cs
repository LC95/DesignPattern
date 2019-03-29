using System;
using System.Threading;

namespace DP.Commands
{
    public abstract class Command
    {
        public abstract void Execute();
    }

    public abstract class Receiver
    {
        public abstract void Do();
    }

    public class Invoker
    {
        private Command _command;

        public void SetCommand(Command command)
        {
            _command = command;
        }

        public void SendCommand()
        {
            _command.Execute();
        }
    }

    public class ConcreteCommand : Command //could be many
    {
        private readonly Receiver _receiver;

        public ConcreteCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public override void Execute()
        {
            _receiver.Do();
        }
    }

    public class ConcreteReceiver : Receiver //could be many
    {
        public override void Do()
        {
            //DO
        }
    }

    public class Example
    {
        public Example()
        {
            var invoker = new Invoker();
            var command = new ConcreteCommand(new ConcreteReceiver());
            invoker.SetCommand(command);
            invoker.SendCommand();
        }
    }
}