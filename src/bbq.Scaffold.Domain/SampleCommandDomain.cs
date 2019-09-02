namespace bbq.Scaffold.Domain
{
    public class SampleCommandDomain
    {
        public string DoAction(string input)
        {
            return $"{input} hexa => {input.GetHashCode()}";
        }
    }
}
