namespace Huy_Phuong
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using Huy_Phuong.Contracts;

    public class Theater
    {
        public static IPerformanceDatabase Universal = new ShowDatabase();
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("vi-VN");

            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == null)
                {
                    return;
                }

                if (commandLine != string.Empty)
                {
                    string[] commanParts = commandLine.Split('(');
                    string command = commanParts[0];
                    string commandResult;

                    try
                    {
                        switch (command)
                        {
                            case "AddTheatre":
                                commanParts = commandLine.Split('(');
                                command = commanParts[0];
                                string[] chiHuyParts1 = commandLine.Split(
                                    new[] { '(', ',', ')' },
                                    StringSplitOptions.RemoveEmptyEntries);
                                string[] commandParams1 = chiHuyParts1.Skip(1).Select(p => p.Trim()).ToArray();
                                string[] commandParams = commandParams1;
                                commandResult = Engine.ExecuteAddTheatreCommand(commandParams);
                                break;

                            case "PrintAllTheatres":
                                commandResult = Engine.ExecutePrintAllTheatresCommand();
                                break;

                            case "AddPerformance":
                                commanParts = commandLine.Split('(');
                                command = commanParts[0];
                                chiHuyParts1 = commandLine.Split(
                                    new[] { '(', ',', ')' },
                                    StringSplitOptions.RemoveEmptyEntries);
                                commandParams1 = chiHuyParts1.Skip(1).Select(p => p.Trim()).ToArray();
                                commandParams = commandParams1;
                                string theatreName = commandParams[0];
                                string performanceTitle = commandParams[1];
                                DateTime result = DateTime.ParseExact(
                                    commandParams[2],
                                    "dd.MM.yyyy HH:mm",
                                    CultureInfo.InvariantCulture);
                                DateTime startDateTime = result;
                                TimeSpan result2 = TimeSpan.Parse(commandParams[3]);
                                TimeSpan duration = result2;
                                decimal result3 = decimal.Parse(commandParams[4], NumberStyles.Any);
                                decimal price = result3;
                                Theater.Universal.AddPerformance(
                                    theatreName,
                                    performanceTitle,
                                    startDateTime,
                                    duration,
                                    price);
                                commandResult = "Performance added";
                                break;

                            case "PrintAllPerformances":
                                commandResult = ExecutePrintAllPerformancesCommand();
                                break;

                            case "PrintPerformances":
                                commanParts = commandLine.Split('(');
                                command = commanParts[0];
                                chiHuyParts1 = commandLine.Split(
                                    new[] { '(', ',', ')' },
                                    StringSplitOptions.RemoveEmptyEntries);
                                commandParams1 = chiHuyParts1.Skip(1).Select(p => p.Trim()).ToArray();
                                commandParams = commandParams1;
                                string theatre = commandParams[0];
                                var performances = Universal.ListPerformances(theatre).Select(
                                    p =>
                                    {
                                        string result1 = p.S2.ToString("dd.MM.yyyy HH:mm");
                                        return string.Format("({0}, {1})", p.Tr32, result1);
                                    }).ToList();
                                if (performances.Any())
                                {
                                    commandResult = string.Join(", ", performances);
                                }
                                else
                                {
                                    commandResult = "No performances";
                                }

                                break;

                            default:
                                commandResult = "Invalid command!";
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        commandResult = "Error: " + ex.Message;
                    }

                    Console.WriteLine(commandResult);
                }
            }
        }

        

        protected internal static string ExecutePrintAllPerformancesCommand()
        {
            var performances = Theater.Universal.ListAllPerformances().ToList();
            var result = string.Empty;

            if (performances.Any())
            {
                for (int i = 0; i < performances.Count; i++)
                {
                    var output = new StringBuilder();
                    output.Append(result);
                    if (i > 0)
                    {
                        output.Append(", ");
                    }
                    string result1 = performances[i].S2.ToString("dd.MM.yyyy HH:mm");
                    output.AppendFormat(
                        "({0}, {1}, {2})", performances[i].Tr32, performances[i].Tr23, result1);
                    result = output.ToString();
                }

                return result;
            }

            return "No performances";
        }
    }
}
