
In this iteration, I was playing around with two things.

First of all, I found in previous interations that I wasn't happy with the Player abstraction that I came up with; it seemed
that I was doing a lot of operations where I had to reach into both player abstractions, and it left me without a good place
to put abstractions such as "PlayersHaveEqualNumberOfPoints". I suspected that a better abstraction would put the two players
together in a single type, named ScoringData here. That was quite successful; it ended up being a nice immutable type, and it
was a natural center of gravity for scoring words and a number of helper properties. I pushed some of the rule testing (IsDeuce())
into it. 

Second, I wanted to play around with a different way of coupling the rules together. 