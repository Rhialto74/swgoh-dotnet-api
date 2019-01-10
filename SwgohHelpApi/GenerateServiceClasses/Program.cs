using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamasoft.JsonClassGenerator;
using Xamasoft.JsonClassGenerator.CodeWriters;
using SwgohHelpApi;
using SwgohHelpApi.Model;
using CommandLine;
using CommandLine.Text;
using System.Dynamic;

namespace GenerateServiceClasses
{
    class Program
    {
        private static string testUsername = ConfigurationManager.AppSettings["username"];
        private static string testPassword = ConfigurationManager.AppSettings["password"];
        private static SwgohHelper helper;

        public class Options
        {
            [Option('p', "player", Required = false, HelpText = "Generate Player Classes.")]
            public bool Player { get; set; }

            [Option('g', "guild", Required = false, HelpText = "Generate Guild Classes.")]
            public bool Guild { get; set; }

            [Option('t', "punit", Required = false, HelpText = "Generate Player Unit Classes.")]
            public bool PUnit { get; set; }

            [Option('u', "unit", Required = false, HelpText = "Generate Localized Unit Classes.")]
            public bool Unit { get; set; }

            [Option('f', "filename", Default = "", Required = false, HelpText = "Parses JSON from a file. Other options are ignored when using this option.")]
            public string FileName { get; set; }

        }

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       if (!string.IsNullOrEmpty(o.FileName))
                       {
                           Console.WriteLine($"Generating Classes From File");
                           GenerateFromFile(o.FileName);
                       }
                       else
                       {
                           if (o.Player)
                           {
                               Console.WriteLine($"Generating Player Classes");
                               GeneratePlayer();

                           }
                           if (o.Guild)
                           {
                               Console.WriteLine($"Generating Guild Classes");
                               GenerateGuild();
                           }
                           if (o.PUnit)
                           {
                               Console.WriteLine($"Generating Player Unit Classes");
                               GeneratePlayerUnit();
                           }
                           if (o.Unit)
                           {
                               Console.WriteLine($"Generating Localized Unit Classes");
                               GenerateUnit();
                           }
                       }
                   });

            
        }
        
        private static void LogIn()
        {
            helper = new SwgohHelper(new UserSettings() { Username = testUsername, Password = testPassword, Debug = "true" });
            helper.Login();
        }

        private static void GenerateFromFile(string filename)
        {
            using (StreamReader reader = File.OpenText(filename))
            {
                var classgen = Prepare(reader.ReadToEnd());
                classgen.GenerateClasses();
            }
        }
        
        private static void GeneratePlayer()
        {
            LogIn();
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                language = "eng_us",
                enums = true
            };
            var data = helper.fetchPlayersJsonString(options);
            Prepare(data, "Player").GenerateClasses();
        }
        private static void GenerateGuild()
        {
            LogIn();
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                language = "eng_us",
                enums = true
            };
            var data = helper.fetchGuildJsonString(options);
            Prepare(data, "Guild").GenerateClasses();
        }

        private static void GeneratePlayerUnit()
        {
            LogIn();
            var options = new RequestOptions
            {
                allycodes = new List<int>() { 999531726 },
                enums = true
            };
            var data = helper.fetchUnitJsonString(options);
            Prepare(data, "Unit").GenerateClasses();
        }

        private static void GenerateUnit()
        {
            LogIn();

            dynamic match = new ExpandoObject();
            match.rarity = 7;

            dynamic project = new ExpandoObject();
            project.baseId = 7;
            project.nameKey = 1;
            project.descKey = 1;
            project.forceAlignment = 1;
            project.categoryIdList = 1;
            project.combatType = 1;

            var options = new RequestOptions
            {
                collection = DataEndpointConstants.unitsList,
                language = "eng_us",
                enums = true,
                match = match,
                project = project
            };
            var data = helper.fetchLocalizedUnitJsonString(options);
            Prepare(data, "Unit").GenerateClasses();
        }

        private static JsonClassGenerator Prepare(string jsonToParse)
        {
            return Prepare(jsonToParse, ConfigurationManager.AppSettings["MainClass"]);
        }

        private static JsonClassGenerator Prepare(string jsonToParse, string outputfile)
        {
            var gen = new JsonClassGenerator();
            gen.Example = jsonToParse;
            gen.InternalVisibility = bool.Parse(ConfigurationManager.AppSettings["InternalVisibility"]);
            gen.CodeWriter = new CSharpCodeWriter();
            gen.ExplicitDeserialization = bool.Parse(ConfigurationManager.AppSettings["ExplicitDeserialization"]);
            gen.Namespace = ConfigurationManager.AppSettings["Namespace"];
            gen.NoHelperClass = bool.Parse(ConfigurationManager.AppSettings["NoHelperClass"]);
            gen.SecondaryNamespace = !string.IsNullOrEmpty(ConfigurationManager.AppSettings["SecondaryNamespace"]) ? ConfigurationManager.AppSettings["SecondaryNamespace"] : null;
            gen.TargetFolder = ConfigurationManager.AppSettings["TargetFolder"];
            gen.UseProperties = bool.Parse(ConfigurationManager.AppSettings["UseProperties"]);
            gen.MainClass = outputfile;
            gen.UsePascalCase = bool.Parse(ConfigurationManager.AppSettings["UsePascalCase"]);
            gen.UseNestedClasses = bool.Parse(ConfigurationManager.AppSettings["UseNestedClasses"]);
            gen.ApplyObfuscationAttributes = bool.Parse(ConfigurationManager.AppSettings["ApplyObfuscationAttributes"]);
            gen.SingleFile = bool.Parse(ConfigurationManager.AppSettings["SingleFile"]);
            gen.ExamplesInDocumentation = bool.Parse(ConfigurationManager.AppSettings["ExamplesInDocumentation"]);
            
            return gen;
        }
    }
}
