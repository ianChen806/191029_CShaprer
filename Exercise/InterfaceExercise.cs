using FluentAssertions;

namespace Exercise;

public class InterfaceExercise
{
    /*
      實做一個 工廠
      依照傳入 類型 返回不同的 Exporter
      目前支援 CSV 和 Excel
      呼叫 Exporter 的方法 "Export" 會返回 "Export CSV" 或 "Export Excel"
     */
    [Fact]
    public void try_Factory()
    {
        var factory = new ExporterFactory();

        // var csv = factory.Create("csv");
        // csv.Should().BeOfType<CsvExporter>();
        // csv.Export().Should().Be("Export CSV");
        //
        // var excel = factory.Create("excel");
        // excel.Should().BeOfType<ExcelExporter>();
        // excel.Export().Should().Be("Export Excel");
    }
}

public class ExporterFactory
{
    // public IExcelExporter Create(string csv)
    // {
    //     throw new NotImplementedException();
    // }
}
