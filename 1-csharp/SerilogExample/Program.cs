using System;
using Serilog;
// using Serilog.Formatting.Compact;
// using Serilog.Sinks.Json;
// using Serilog.Core;
// using Serilog.Events;
// using Serilog.Debugging;


namespace SerilogExample
{
    class Program
    {
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Verbose()
                .WriteTo.File("logs/Logs.json")
                .CreateLogger();

            Log.Verbose("Verbose log message");
            Log.Debug("Debug log message");
            Log.Information("Information log message");
            Log.Warning("Warning log message");
            Log.Error("Error log message");
            Log.Fatal("Fatal log message");

            int a = 10, b = 0;
            try
            {
                Log.Debug("Dividing {A} by {B}", a, b);
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Something went wrong");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        
        //My Code:
        // static void Main()
        // {
        //     var levelSwitch = new LoggingLevelSwitch();

        //     Log.Logger = new LoggerConfiguration()
        //         .MinimumLevel.ControlledBy(levelSwitch)
        //         .WriteTo.File(new CompactJsonFormatter(), "./logs/myapp.json")
        //         .CreateLogger();

        //     levelSwitch.MinimumLevel = LogEventLevel.Verbose;

        //     Log.Information("Hello, world!");
        //     Log.Verbose("This is a verbose call");
        //     //Log.Error("This is an error.");
        //     Log.Warning("Dont go there!");
        //     Log.Verbose("Second rebose");

        //     int a = 10, b = 0;
        //     try
        //     {
        //         Log.Debug("Dividing {A} by {B}", a, b);
        //         Console.WriteLine(a / b);
        //     }
        //     catch (Exception ex)
        //     {
        //         Log.Error(ex, "Something went wrong");
        //     }
        //     finally
        //     {
        //         Log.CloseAndFlush();
        //     }
        // }
    }
}
