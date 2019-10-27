using System;

namespace StrategyDesignPattern
{


    public interface Strategy

    {
        void SendNotification();
    }

    public class NotifyByEmailStrategy : Strategy

    {
        public void SendNotification()
        {
            Console.WriteLine(
              "Called NotifyByEmailStrategy.SendNotification()");
        }
    }


    public class NotifyBySmsStrategy : Strategy

    {
        public void SendNotification()
        {
            Console.WriteLine(
              "Called NotifyBySmsStrategy.SendNotification()");
        }
    }

    public class NotifyByAlertStrategy : Strategy

    {
        public void SendNotification()
        {
            Console.WriteLine(
              "Called NotifyByAlertStrategy.SendNotification()");
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

            context = new Context(new NotifyByEmailStrategy());
            context.Execute();

            context = new Context(new NotifyBySmsStrategy());
            context.Execute();

            context = new Context(new NotifyByAlertStrategy());
            context.Execute();

            // Wait for user

            Console.ReadKey();
        }
    }

}
