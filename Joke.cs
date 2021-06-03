namespace ConsoleAppJoke
{
    public class Joke
    {
        public Joke()
        {
        }

        public Joke(string statement, string punchline)
        {
            Statement = statement;
            Punchline = punchline;
        }

        public string Statement { get; set; }
        public string Punchline { get; set; }

        public override string ToString()
        {
            return "\n Statement: " + Statement + "\n Punchline: " + Punchline;
        }
    }
}