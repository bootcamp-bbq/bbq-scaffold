namespace bbq.Scaffold.Domain
{
    public class SampleQueryDomain
    {
        public string DoQuery(string input)
        {
            switch (input)
            {
                case "input":
                    return "output";
                default:
                    return "default";
            }
        }
    }
}
