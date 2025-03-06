using Spectre.Console;
using System.Diagnostics;
using TarkovDumper.Implementations;
using Microsoft.Extensions.Configuration;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

public class ProcessorConfig
{
    public string AssemblyInputPath { get; set; }
    public string DumpInputPath { get; set; }
    public string SDKOutputPath { get; set; }
}

namespace TarkovDumper
{
    internal class Program
    {
        private static readonly string SettingsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "settings.json");

        static void Main(string[] args)
        {
            // Ask the user which processor to run
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Which processor would you like to run?")
                    .AddChoices(new[] { "Lone Tarkov", "Lone Arena", "Evo" }));

            // Load or create configuration
            var config = LoadOrCreateConfiguration();

            // Get the configuration for the selected processor
            var processorConfig = config.GetSection(choice.Replace(" ", "")).Get<ProcessorConfig>();

            // Check if paths are missing or incomplete
            if (string.IsNullOrEmpty(processorConfig.AssemblyInputPath) ||
                string.IsNullOrEmpty(processorConfig.DumpInputPath) ||
                string.IsNullOrEmpty(processorConfig.SDKOutputPath))
            {
                AnsiConsole.MarkupLine($"[yellow]Configuration for {choice} is missing or incomplete. Please provide paths:[/]");
                processorConfig = PromptForPaths(choice);
                SaveConfiguration(choice.Replace(" ", ""), processorConfig);

                // Reload the configuration after saving
                config = LoadOrCreateConfiguration();
                processorConfig = config.GetSection(choice.Replace(" ", "")).Get<ProcessorConfig>();
            }

            try
            {
                AnsiConsole.Status().Start("Starting...", ctx =>
                {
                    ctx.Spinner(Spinner.Known.Dots);
                    ctx.SpinnerStyle(Style.Parse("green"));

                    Processor processor = choice switch
                    {
                        "Lone Tarkov" => new Tarkov(processorConfig),
                        "Lone Arena" => new Arena(processorConfig),
                        "Evo" => new EVO(processorConfig),
                        _ => throw new InvalidOperationException("Invalid processor selection.")
                    };

                    processor.Run(ctx);
                    GC.Collect();
                });
            }
            catch (Exception ex)
            {
                AnsiConsole.WriteLine();

                AnsiConsole.MarkupLine($"[red]{ex.Message}[/]");
                if (ex.StackTrace != null)
                {
                    AnsiConsole.MarkupLine("[bold yellow]==========================Begin Stack Trace==========================[/]");
                    AnsiConsole.WriteLine(ex.StackTrace);
                    AnsiConsole.MarkupLine("[bold yellow]===========================End Stack Trace===========================[/]");
                }
            }
            finally
            {
                Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.Normal;
                Thread.CurrentThread.Priority = ThreadPriority.Normal;
            }

            Pause();
        }

        private static IConfiguration LoadOrCreateConfiguration()
        {
            if (!File.Exists(SettingsFilePath))
            {
                // Create a new configuration file with default values
                var defaultConfig = new Dictionary<string, ProcessorConfig>
                {
                    ["LoneTarkov"] = new ProcessorConfig(),
                    ["LoneArena"] = new ProcessorConfig(),
                    ["Evo"] = new ProcessorConfig()
                };

                File.WriteAllText(SettingsFilePath, JsonConvert.SerializeObject(defaultConfig, Formatting.Indented));
            }

            // Load the configuration
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("settings.json", optional: true, reloadOnChange: true)
                .Build();

            return config;
        }

        private static ProcessorConfig PromptForPaths(string processorName)
        {
            var config = new ProcessorConfig
            {
                AssemblyInputPath = AnsiConsole.Ask<string>($"Enter Assembly Input Path for {processorName}:"),
                DumpInputPath = AnsiConsole.Ask<string>($"Enter Dump Input Path for {processorName}:"),
                SDKOutputPath = AnsiConsole.Ask<string>($"Enter SDK Output Path for {processorName}:")
            };

            return config;
        }

        private static void SaveConfiguration(string processorName, ProcessorConfig config)
        {
            var settings = File.Exists(SettingsFilePath)
                ? JsonConvert.DeserializeObject<Dictionary<string, ProcessorConfig>>(File.ReadAllText(SettingsFilePath))
                : new Dictionary<string, ProcessorConfig>();

            settings[processorName] = config;
            File.WriteAllText(SettingsFilePath, JsonConvert.SerializeObject(settings, Formatting.Indented));
        }

        private static void Pause()
        {
            AnsiConsole.WriteLine();
            AnsiConsole.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}