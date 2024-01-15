using Swashbuckle.AspNetCore.Filters;
using TimeApi.Models;

namespace TimeApi.Examples;
public static class TestControllerExamples
{
    public class MyGoodExamples : IMultipleExamplesProvider<TestData>
    {
        public IEnumerable<SwaggerExample<TestData>> GetExamples()
        {
            yield return SwaggerExample.Create("Example 1", new TestData
            {
                Getal = 1,
                KommaGetal = 1.234,
                Tekst = "1 komma 234",
                Time = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Local)
            });

            yield return SwaggerExample.Create("Example 2", new TestData
            {
                Getal = 2,
                KommaGetal = 2222,
                Tekst = "22222222222222222",
                Time = new DateTime(2222, 2, 2, 2, 2, 2, DateTimeKind.Local)
            });
        }
    }

    public class MyBadExample : ISwaggerExample<TestData>
    {
        public string Name => "Bad:(";

        public string Summary => "summary";

        public string Description => "Descrrrr";

        public TestData Value => new()
        {
            Getal = 1,
            KommaGetal = 1.234,
            Tekst = "1 komma 234",
            Time = new DateTime(2000, 1, 1, 0, 0, 0, DateTimeKind.Local)
        };
    }
}