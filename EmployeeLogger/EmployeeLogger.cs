namespace Logging;

/// <summary>
/// Logging object for employees.
/// Each employee has their own logger.
/// The logger writes to a log file in CSV format.
/// The log includes timestamps, the actions of the employee, and extra details if needed.
/// </summary>
public class EmployeeLogger
{
    private string _id = null!;

    public string ID
    {
        get => _id;
        set => _id = value ?? throw new ArgumentNullException(nameof(value));
    }

    private readonly string _name = null!;

    public string Name
    {
        get => _name;
        init => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    private readonly string _path = null!;

    public string Path
    {
        get => _path;
        init => _path = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Create an EmployeeLogger object for a specific Employee.
    /// </summary>
    /// <param name="employee">The employee to log</param>
    public EmployeeLogger(Employee employee)
    {
        ID = employee.ID;
        Name = employee.Name;
        Path = $".\\logs\\{ID}\\{DateTime.Today:yyyy-MM-dd}.log";
        StartLog();
    }

    /// <summary>
    /// Create an EmployeeLogger object for an employee with the entered properties.
    /// </summary>
    /// <param name="id">ID of the employee to log</param>
    /// <param name="name">name of the employee to log</param>
    public EmployeeLogger(string id, string name)
    {
        ID = id;
        Name = name;
        Path = $".\\logs\\{ID}\\{DateTime.Today:yyyy-MM-dd}.log";
        StartLog();
    }

    /// <summary>
    /// Log an action made by the employee.
    /// The action will be logged with the current time.
    /// </summary>
    /// <param name="actionType">The type of action made.</param>
    /// <param name="details">Details about the specific action.</param>
    public void LogAction(string actionType, string details = "")
    {
        var fileStream = new FileStream(Path, FileMode.Append, FileAccess.Write);
        var streamWriter = new StreamWriter(fileStream);
        streamWriter.WriteLine($"\"{DateTime.UtcNow}\",\"{actionType}\",\"{details}\"");
        
        streamWriter.Close();
    }
    
    private void StartLog()
    {
        FileInfo file = new FileInfo(Path);
        file.Directory.Create(); // If the directory already exists, does nothing
        var fileStream = new FileStream(Path, FileMode.Append, FileAccess.Write);
        var streamWriter = new StreamWriter(fileStream);
        streamWriter.WriteLine($"Timestamp (UTC), Action, Details");
        streamWriter.Close();
        
        LogAction("Log Start", $"Employee: {ID} {Name}");
    }

    /// <summary>
    /// Log shift start.
    /// </summary>
    public void StartShift()
    {
        LogAction("Shift Start");
    }
    
    /// <summary>
    /// Log shift end.
    /// </summary>
    public void EndShift()
    {
        LogAction("Shift End");
    }

    public override string ToString()
    {
        return $"Employee Logger for: {Name}, {ID}.";
    }
}
