Console.WriteLine($"Komp: {Environment.MachineName}");
Console.WriteLine($"user: {Environment.UserName}");
Console.WriteLine($"data i vrema: {DateTime.Now:dd.MM.yyyy HH:mm}");

Console.WriteLine($"OC: {Environment.OSVersion}");
Console.WriteLine($"64? {Environment.Is64BitOperatingSystem}");

Console.WriteLine($"logic processors: {Environment.ProcessorCount}");

Console.WriteLine($"PID: {Environment.ProcessId}");
long mem = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"memory: {mem}");
Console.ReadLine();