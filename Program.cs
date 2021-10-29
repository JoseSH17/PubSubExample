namespace PubSubExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person trump = new Person("Donald Trump");
            Person joe = new Person("Joe Biden");

            Person jose = new Person("Jose Salazar");
            Person pedro = new Person("Pedro Rodriguez");
            Person carlos = new Person("Carlos Vargas");

            jose.Subscribe(joe);
            pedro.Subscribe(joe);            

            jose.Subscribe(trump);
            pedro.Subscribe(trump);
            carlos.Subscribe(trump);

            trump.SendTweet("I'm the best president ever and that's a fact");
            joe.SendTweet("No you're not");
            
            pedro.Unsubscribe(trump);

            joe.Subscribe(trump);
            trump.SendTweet("If I don't win this election RIOT!");
        }
    }
}
