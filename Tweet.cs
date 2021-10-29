using System;

class Tweet: EventArgs{
    private Tweet(){}
    public string message { get; set; }
    public DateTime time { get; set; }

    public Tweet(string message)
    {
        this.message = message;
        this.time = DateTime.Now;
    }
}
