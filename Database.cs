using System.Collections.Generic;

namespace ConsoleAppJoke
{
    public class Database
    {
        public List<Joke> Jokes = CreateJokes();

        private static List<Joke> CreateJokes()
        {
            return new List<Joke>()
            {
                new Joke() {Statement = "Dad, did you get a haircut?",
                            Punchline = "No, I got them all cut!"},
                new Joke() {Statement = "How do you get a squirrel to like you?",
                            Punchline = "Act like a nut."},
                new Joke() {Statement = "Why don't eggs tell jokes?",
                            Punchline = "They'd crack each other up."},
                new Joke() {Statement = "What do you call someone with no body and no nose ?",
                            Punchline = "Nobody knows."},
                new Joke() {Statement = "Why couldn't the bicycle stand up by itself",
                            Punchline = "It was two tired."},
                new Joke() {Statement = "What kind of shoes do ninjas wear?",
                            Punchline = "Sneakers!"},
                new Joke() {Statement = "How does a penguin build its house?",
                            Punchline = "Igloos it together"},
                new Joke() {Statement = "Why did the math book look so sad?",
                            Punchline = "Because of all of its problems!"},
                new Joke() {Statement = "How many tickles does it take to make an octopus laugh ? ",
                            Punchline = "Ten tickles."},
                new Joke() {Statement = "Did you hear about the guy who invented the knock - knock joke ? ",
                             Punchline = "He won the 'no-bell' prize."}

            };
        }


    }
}
