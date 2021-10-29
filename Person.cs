using System;

class Person{
    private Person(){}
    public string name { get; set; }

    public Person(string name){
        this.name = name;
    }
    private event EventHandler<Tweet> tweetEvent;

    public void SendTweet(string message)
    {
        Tweet tweet = new Tweet(message);
        if(tweetEvent != null){
            tweetEvent(this, tweet);
        }
    }
    public void Subscribe(Person person)
    {        
        person.tweetEvent += ShowTweet;
    }
    public void Unsubscribe(Person person)
    {        
        person.tweetEvent -= ShowTweet;
    }
    public void ShowTweet(object sender, Tweet tweet)
    {        
        Person tweeter = (Person) sender;
        Console.WriteLine(this.name + " : Tweet Sent by " + tweeter.name + " message: " + tweet.message + " at: " + tweet.time.ToLongTimeString());
    }
}