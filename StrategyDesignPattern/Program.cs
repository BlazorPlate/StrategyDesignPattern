using System;

namespace StrategyDesignPattern
{


    abstract class Strategy

    {
        public abstract void SendNotification();
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class NotifyByEmailStrategy : Strategy

    {
        public override void SendNotification()
        {
            Console.WriteLine(
              "Called NotifyByEmailStrategy.SendNotification()");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class NotifyBySmsStrategy : Strategy

    {
        public override void SendNotification()
        {
            Console.WriteLine(
              "Called NotifyBySmsStrategy.SendNotification()");
        }
    }

    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class NotifyByAlertStrategy : Strategy

    {
        public override void SendNotification()
        {
            Console.WriteLine(
              "Called NotifyByAlertStrategy.SendNotification()");
        }
    }

    /// <summary>

    /// The 'Context' class

    /// </summary>

    class Context

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
    /// <summary>

    /// MainApp startup class for Structural

    /// Strategy Design Pattern.

    /// </summary>

    class Program

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

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

    /// <summary>

    /// The 'Strategy' abstract class

    /// </summary>
}
