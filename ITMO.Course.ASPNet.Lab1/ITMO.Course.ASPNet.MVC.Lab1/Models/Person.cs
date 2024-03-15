namespace ITMO.Course.ASPNet.MVC.Lab1.Models
{
    public class Person
    {
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public override string ToString()
        {
            string s = FirstName + " " + LastName;
            return s;
        }        
    }
}
