using DummyDB_Task1.WorkWithSchema;

namespace DummyDB_Task1
{
    class CsvDataParser
    {
        public static void AppendDataToCsv(string path, string data)
        {
            File.AppendAllText(path, "\n" + data);
        }

        public static void CreateCsvFile(string path, string columns)
        {
            File.WriteAllText(path, columns);
        }

        public static string[] GetDataFromCsv(string filePath, string schemaPath)
        {
            var lines = File.ReadAllLines(filePath);
            var schema = JSONSchemaValidator.GetSchema(schemaPath);

            if (JSONSchemaValidator.IsValidToSchema(lines, schema))
            {
                lines = lines.Skip(1).ToArray();
                return lines;
            }
            return null;
        }
    }
}
