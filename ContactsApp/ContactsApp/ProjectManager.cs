using Newtonsoft.Json;
using System;
using System.IO;

namespace ContactsApp
{
    public static class ProjectManager
    {
        public static string _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Denisov\ContactsApp";
        public static string _fileName = @"project.json";

        

        /// <summary>
        /// Метод записи объекта <see cref="Project"> в файл.
        /// </summary>
        /// <param name="fileName">Имя файла для записи.</param>
        /// <param name="filePath">Значение пути к директории расположения файла.</param>
        /// <param name="project">Записываемый экземпляр <see cref="Project">.</param>
        public static void SaveToFile(string fileName, string filePath, Project project)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(_path + _fileName))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод чтения объекта <see cref="Project"> из файла.
        /// </summary>
        /// <param name="fileName">Имя файла для чтения.</param>
        /// <param name="filePath">Значение пути к директории расположения файла.</param>
        /// <returns>Объект <see cref="Project">.</returns>
        public static Project LoadFromFile(string fileName, string filePath)
        {
            if (!File.Exists(filePath + fileName))
            {
                return null;
            }

            Project project = new Project();

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(filePath + fileName))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project)serializer.Deserialize<Project>(reader);
            }

            return project;
        }

        public static void SaveToFile(Project project)
        {
            //JsonSerializer serializer = new JsonSerializer();

            var proj= JsonConvert.SerializeObject(project, Formatting.Indented);
            File.WriteAllText("project.json",proj);

            /*using (StreamWriter sw = new StreamWriter("project.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, project);
            }*/
        }

        public static Project LoadFromFile()
        {
            if (!File.Exists("project.json"))
            {
                return null;
            }
            Project project = null;

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader("project.json"))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = (Project) serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}
