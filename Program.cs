namespace employeewageoop
{
    class Program
    {
        public static void Main(string[] args)
        {


            // Compute Employee wages for multiple Company

            Console.WriteLine("Enter the name of the company Dmart or Relince:");
            string company = Console.ReadLine();

            calmulcomapny obj = new calmulcomapny();
            if (company == "Dmart")
            {
                obj.ComputeEmpWage(company, 20, 10, 90);
            }
            else if (company == "Relince") { obj.ComputeEmpWage(company, 20, 10, 90); }
            else { Console.WriteLine("Please enter correct company!!"); }

            //CheckEmployeeFullTime obj = new CheckEmployeeFullTime();
            //obj.EmployeeAttendence();
            //EmployeeWageCode obj2 = new EmployeeWageCode();
            //obj2.CheckTime();
            //switchcase obj3 = new switchcase();
            //obj3.CheckCase();
            //wagemonth obj4 = new wagemonth();
            //obj4.WageCalculate();
            //calculatehrsnddayemp obj5 = new calculatehrsnddayemp();
            //obj5.CheckEmpHrAndDays();
            //calcompany obj6 = new calcompany();
            //obj6.ComputeEmpWage();
        }
    }
}
