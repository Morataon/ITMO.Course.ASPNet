namespace ITMO.Course.ASPNet.MVC.Lab1.Models
{
    public class PersonRepository
    {
        private List<Person> persons = new List<Person>(); // создаём коллекцию - список персон
        public int NumberOfPerson // возвращает количество персон
        {
            get
            { 
                return persons.Count();
            }
        }
        public IEnumerable<Person> GetAllResponses // возвращает коллекцию (список) персон
        {
            get
            {
                return persons;
            }
        }

        public void AddResponse(Person pers)
        { 
            persons.Add(pers);
        }
    }
}
