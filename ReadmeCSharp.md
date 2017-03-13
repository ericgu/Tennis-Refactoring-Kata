
In this iteration, I was playing around with two things.

First of all, I found in previous interations that I wasn't happy with the Player abstraction that I came up with; it seemed
that I was doing a lot of operations where I had to reach into both player abstractions, and it left me without a good place
to put abstractions such as "PlayersHaveEqualNumberOfPoints". I suspected that a better abstraction would put the two players
together in a single type, named ScoringData here. That was quite successful; it ended up being a nice immutable type, and it
was a natural center of gravity for scoring words and a number of helper properties. I pushed some of the rule testing (IsDeuce())
into it. 

Second, I wanted to play around with a different way of coupling the rules together. Instead of coupling through interface, 
in this implementation the rules are coupled by shape; the delegate type of the ScoreReady event matches the Score function,
and the individual rule implementations are just chained together. The resulting implementation is a message-passing approach;
while it executes synchronously in this implementation - because that's how events work - it would work exactly the same in a
pure asynch approach. Basically, it passes the ScoringData and the score from one method to the next, and if there is something
for that method to do and it knows how to do it, it does it. This is a different example of chain of responsibility.

The creation is hand-written because I wanted to show the pattern without interfaces, but it would be simple to use an interface
and then write a small method that just takes an array of all the scorers, hooks them together, and gets them started. 




