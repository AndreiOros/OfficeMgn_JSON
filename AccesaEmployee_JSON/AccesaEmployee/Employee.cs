using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AccesaEmployee
{
	public class Employee
	{
		private string _name;
		private EmployeePosition _position;
		private float _capacity;//max number of hours per day
		private List<string> h1=new List<string>();


        public string Name => _name;
		public EmployeePosition Position => _position;
		public float Capacity => _capacity;
		public List<string> Hobbies => h1;


		protected Employee(string name, EmployeePosition position, float capacity)
		{
			_name = name;
			_position = position;
			_capacity = capacity;
		}


		public virtual void DisplayInfo()
		{
			var sb= new StringBuilder();
			h1.ForEach(x=>sb.Append(x+" "));
			Console.WriteLine($"{_name} ocupa pozitia {_position} si e angajat cu {_capacity} ore pe zi. Lui ii place {sb.ToString()}");
		}


        public virtual void Jason()
        {
            JObject emp = new JObject();
            new JProperty("Name", Name);
            new JProperty("Capacity", Capacity);
            new JProperty("Position", Position);
            foreach (string s in Hobbies)
                new JProperty("Hobby", s);
        }

        
    }
}
