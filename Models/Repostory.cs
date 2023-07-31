namespace HRApplication.Models
{
    public class Repostory
    {
        private static List<Employee> employeelist = new List<Employee>();
        public static IEnumerable<Employee> GetEmployee()
        {
            return employeelist;
        }
        public static void Addemb (Employee em)
        {
            employeelist.Add(em);
        }
        

        
           
        





    }
}
