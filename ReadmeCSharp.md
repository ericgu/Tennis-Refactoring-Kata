This iteration was triggered by the message-passing implementation in EricGu3. 

I liked the design for a true message-passing architecture, but for a synchronous implementation it had a lot of overhead; 
each of the rule classes needed to expose an event, which is extra overhead. I also passed the score as a separate item, which 
I did to make ScoringData immutable, but it was a bit weird.

Solve the second issue first; I added a ScoringData constructor that took a ScoringData and a new score, thereby giving us a way
to add a score while keeping it immutable. I then pulled out the event-based infrastructure, and changed the rules so they took a
ScoringData and they returned a ScoringData, either a new one with a new score or the one passed in.

And finally, I modified them to use the LINQ techniques; the scoring methods are chained together the way that we would in LINQ.
This gets rid of the Scorer abstraction and makes everything simpler. 




