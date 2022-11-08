namespace Logging;

public class TestProgram
{
    public static void Main()
    {
        Employee emp1 = new Employee("H", "1");
        
        emp1.StartShift();
        emp1.DoAction();
        emp1.DoSomething();
        emp1.EndShift();
    }
}

public class Employee
{
    public string Name { get; set; }
    public string ID { get; set; }
    private EmployeeLogger logger;

    public Employee(string name, string id)
    {
        this.Name = name ?? throw new ArgumentNullException(nameof(name));
        this.ID = id ?? throw new ArgumentNullException(nameof(id));

        logger = new EmployeeLogger(this);
    }

    public void StartShift()
    {
        logger.StartShift();
    }
    
    public void EndShift()
    {
        logger.EndShift();
    }

    public void DoAction()
    {
        logger.LogAction("An action");
    }
    
    public void DoSomething()
    {
        logger.LogAction("A thing", "some");
    }
}