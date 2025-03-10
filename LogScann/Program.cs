using CSoftt.Contract;
using CSoftt.Contracts;
using CSoftt.Services;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "logs.csv";

        DateTime startDate = new DateTime(2025, 3, 1);
        DateTime endDate = new DateTime(2025, 3, 7);


        ILogReader logReader = new LogReader();
        ILogProcessor logProcessor = new LogProcessor();


        var logs = logReader.ReadLogFile(filePath);


        var usersWithMultiplePages = logProcessor.GetUsersWithMultiplePages(logs, startDate, endDate);


        Console.WriteLine("Users who have visited at least two different pages:");

        using (StreamWriter writer = new StreamWriter("output.csv"))
        {
            writer.WriteLine("Users who have visited at least two different pages:");


            foreach (var user in usersWithMultiplePages)
            {
                var userDate = logProcessor.GetUsersDateLogin(logs, user);
                string formattedDate = userDate.ToString("dd-MM-yyyy, HH:mm") ?? "N/A";

                string result = $"User: {user}, First Login: {formattedDate}";

                Console.WriteLine(result);
                writer.WriteLine(result);
            }
        }

        Console.WriteLine($"Results saved in: output.csv");
    }






}
