using Newtonsoft.Json;
using System;
using System.IO;

namespace ContactsApp
{
    public static class ProjectManager
    {
        public static string _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ContactsApp";
        public static string _fileName = @"Contacts.json";

        /// <summary>
        /// Метод записи объекта <see cref="Project"> в файл.
        /// </summary>
        /// <param name="fileName">Имя файла для записи.</param>
        /// <param name="filePath">Значение пути к директории расположения файла.</param>
        /// <param name="project">Записываемый экземпляр <see cref="Project">.
        /// </param>
        public static void SaveToFile(string filePath, string fileName, Project project)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            var stringJSON = JsonConvert.SerializeObject(project, Formatting.Indented);

            using (StreamWriter streamWriter = new StreamWriter(filePath + fileName, false))
            {
                streamWriter.Write(stringJSON);
            }
        }

        /// <summary>
        /// Метод чтения объекта <see cref="Project"> из файла.
        /// </summary>
        /// <param name="fileName">Имя файла для чтения.</param>
        /// <param name="filePath">Значение пути к директории расположения файла.</param>
        /// <returns>Объект <see cref="Project">.
        /// </returns>
        public static Project LoadFromFile(string filePath, string fileName)
        {
            if (!Directory.Exists(filePath))
            {
                return new Project();
            }

            if (!File.Exists(filePath + fileName))
            {
                return new Project();
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
    }
}
