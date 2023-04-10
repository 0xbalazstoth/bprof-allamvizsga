namespace DesignPatterns
{
    public class OnTheFlyProperty
    {
        List<string> _list = new List<string>()
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"
        };

        public List<string> GetEverySecondLetter => _list.Where((x, i) => i % 2 == 0).ToList();
    }

    public class SharedObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsLearning // This is the shared object
        {
            get
            {
                return Learning; // Calling a static property
            }
        }
        static bool Learning => true; // ONLY READABLE
    }

    public class ReusableObject
    {
        public class AdditionalData
        {
            public int Age { get; set; }
        }

        public void Reuse(AdditionalData data)
        {
            data.Age = 25;
        }
    }
}