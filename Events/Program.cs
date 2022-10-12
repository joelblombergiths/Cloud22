using Events;

Publisher publisher = new();


Subscriber s1 = new("A");
Subscriber s2 = new("B");
Subscriber s3 = new("C");

publisher.MessageSent += s1.OnMessageRecieved;
publisher.MessageSent += s2.OnMessageRecieved;
publisher.MessageSent += s3.OnMessageRecieved;

publisher.SendMessage("Test");