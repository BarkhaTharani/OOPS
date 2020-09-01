using OOPSConcepts.Aggregation;

namespace OOPSConcepts.Aggregation
{
    public class TestAggregation
    {
        public static void Main()
        {

            //Aggregation - there is ownership among entities, ie one owns another.
            // but theie life cycle isn't dependent on each other, if one dies other may servive.
            Worker worker = new Worker("Mark");

            Manager mgr =  new Manager();


        }
    }
}