/*Console.WriteLine($"Komp: {Environment.MachineName}");
Console.WriteLine($"user: {Environment.UserName}");
Console.WriteLine($"data i vrema: {DateTime.Now:dd.MM.yyyy HH:mm}");

Console.WriteLine($"OC: {Environment.OSVersion}");
Console.WriteLine($"64? {Environment.Is64BitOperatingSystem}");

Console.WriteLine($"logic processors: {Environment.ProcessorCount}");

Console.WriteLine($"PID: {Environment.ProcessId}");
long mem = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"memory: {mem}");
Console.ReadLine();*/

using System.Diagnostics;

Console.WriteLine("mini monitor systema\n");
Console.WriteLine($"komp: {Environment.MachineName}");
Console.WriteLine($"user: {Environment.UserName}");
Console.WriteLine($"OC: {Environment.OSVersion}");
Console.WriteLine($"64 bit? {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"logic processors: {Environment.ProcessorCount}");

Process currentProcess = Process.GetCurrentProcess();

Console.WriteLine($"pid: {currentProcess.Id}");
Console.WriteLine($"memory:");
for (int i = 1; i <= 3; i++)
{
    currentProcess.Refresh();
    long mem = currentProcess.WorkingSet64 / 1024 / 1024;
    Console.WriteLine($"{i}: {mem} MB");
    if (i < 3)
    {
        Console.WriteLine("update....");
        Console.ReadLine();
    }
}

Console.WriteLine("done");