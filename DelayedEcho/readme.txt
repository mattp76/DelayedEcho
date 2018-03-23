DelayedEcho Library.

Description.

This is a class library project which contains a concrete class (called concreteClass for the purpose of this task) that provides the following key features .....

1) non blocking method call EchoDelayed(string message, int delaySeconds)
2) An event handler that can be subscribed to, for receiving the delayed echo messages


EchoDelayed
I am using the 'async' key word on this method because it will make use of the await / task key words in order to help it run asynchronously from the calling application (console app). Therefore becoming 'non-blocking'.


EchoEvent
This is the EventHandler which can be subscribed to. The event is fired each time the delayed operation reaches its interval in seconds. Datetime (now) and message passed from the user make up the event args.


This library has been added to the Nuget public repo under my own account.

URL: https://www.nuget.org/packages/DelayedEcho.MP.AP/1.0.0

This will be used for any application (console app) which needs it.




