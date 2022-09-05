namespace MyClassLibrary1
{

    public class Emp
    {
        //data declared inside class are known as "fields"
        int id;
        string name;
        string dept;
        double sal;

        public DateTime doj { get; set; }

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Emp(int id, string name, DateTime doj)
        {
            this.id = id; this.name = name; this.doj = doj;
        }
        public Emp()
        {
            id = -1; name = "no name";
        }
        public Emp(int id, string name)
        {
            this.id = id; this.name = name;
        }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public string Print()   //only virtual method can be overridden
        {
            return $"Emp Id={id}, Name={name}, Experience={GetYearsofExp()} Years";
        }


    }
}
internal interface ICar
    {
        int GetPrice(string name);
    }
    class BMW : ICar
    {
        public int GetPrice(string name)
        {
            if (name == "m3")
                return 1300000;
            else if (name == "X7")
                return 7500000;
            else
                return 500000;

        }
    }

