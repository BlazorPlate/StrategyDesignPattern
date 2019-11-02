using System;

namespace StrategyDesignPattern
{
    public interface Strategy

    {
        void SendNotification();
    }

    public class EmailStrategy : Strategy

    {
        public void SendNotification()
        {
            Console.WriteLine("Called EmailStrategy.SendNotification()");
        }
    }


    public class SmsStrategy : Strategy

    {
        public void SendNotification()
        {
            Console.WriteLine("Called SmsStrategy.SendNotification()");
        }
    }

    public class AlertStrategy : Strategy

    {
        public void SendNotification()
        {
            Console.WriteLine("Called AlertStrategy.SendNotification()");
        }
    }

    public class Context

    {
        private Strategy _strategy;

        // Constructor

        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }

        public void Execute()
        {
            _strategy.SendNotification();
        }
    }

    public class Program
    {
        static void Main()
        {
            Context context;

            // Three contexts following different strategies

            context = new Context(new EmailStrategy());
            context.Execute();

            context = new Context(new SmsStrategy());
            context.Execute();

            context = new Context(new AlertStrategy());
            context.Execute();

            Console.ReadKey();
        }
    }

}
