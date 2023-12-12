namespace NET_022_Test2_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher("This should be passed to the event");
            var subscriber = new Subscriber();

            publisher.someEvent += subscriber.SubscriberOnEvent;

            publisher.DoSmth();
           
        }
    }
}