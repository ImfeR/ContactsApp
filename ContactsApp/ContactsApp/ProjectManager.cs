using Newtonsoft.Json;
using System;
using System.IO;

namespace ContactsApp
{
    public class ProjectManager
    {
        public static string _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Denisov\ContactsApp";
        public static string _fileName = @"project.json";

        public static void WriteFile(string fileName, string filePath, Project project)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(_path + _fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        public static Project ReadFile(string fileName, string filePath)
        {
            if (!File.Exists(_path + _fileName))
            {
                return null;
            }

            Project project = new Project();

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(_path + _fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project)serializer.Deserialize<Project>(reader);
            }

            return project;
        }

        public static void WriteFile(Project project)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(@"project.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        public static Project ReadFile()
        {
            if (!File.Exists(@"project.json"))
            {
                return null;
            }
            Project project = null;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(@"project.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}
