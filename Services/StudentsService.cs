using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using lab.Models;

namespace lab.Services;

public class StudentsService
{
  public static async Task<List<Student>> GetStudents()
  {
    var csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/students.csv");

    var config = new CsvConfiguration(CultureInfo.InvariantCulture)
    {
      PrepareHeaderForMatch = args => args.Header.ToLower(),
    };

    var data = new List<Student>().AsEnumerable();
    using (var reader = new StreamReader(csvFilePath))
    {
      using (var csv = new CsvReader(reader, config))
      {
        data = (csv.GetRecords<Student>()).ToList();
      }
    }

    return (List<Student>)data;
  }
}