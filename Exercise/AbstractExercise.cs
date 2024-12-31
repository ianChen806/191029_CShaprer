using System.Text.Json;
using FluentAssertions;

namespace Exercise;

public class AbstractExercise
{
    /*
     * 實做一個 工廠
     * 每個金流有固定的流程, 但是要傳送給三方的內容不同
     * 依照傳入 Enum 返回不同的 Payment
     * 目前支援 LinePay 和 ApplePay
     */
    [Fact]
    public void Method()
    {
        // TODO
        // var factory = new PaymentFactory();
        //
        // var linePay = factory.Create(PayType.LinePay);
        // linePay.Should().BeOfType<LinePay>();
        // linePay.Pay().Should().BeEquivalentTo(new PayResponse
        // {
        //     Name = "LinePay",
        //     Request = "line request",
        //     Response = "body"
        // });
        //
        // var applePay = factory.Create(PayType.ApplePay);
        // applePay.Should().BeOfType<ApplePay>();
        // applePay.Pay().Should().BeEquivalentTo(new PayResponse
        // {
        //     Name = "ApplePay",
        //     Request = "apple request",
        //     Response = "body"
        // });
    }
}

public class PaymentFactory
{
    public PayBase Create(PayType type)
    {
        throw new NotImplementedException();
    }
}

public abstract class PayBase
{
    // TODO
    // public PayResponse Pay()
    // {
    //     var name = GetName();
    //     var request = GetRequestBody();
    //     var response = new FakeHttpClient().Send(name, request);
    //     return response;
    // }
}

public class FakeHttpClient
{
    private string _request;

    public PayResponse Send(string name, string request)
    {
        _request = request;
        var response = new PayResponse
        {
            Name = name,
            Request = request,
            Response = "body"
        };
        return response;
    }
}

public enum PayType
{
    LinePay,
    ApplePay
}

public class PayResponse
{
    public string Name { get; set; }

    public string Request { get; set; }

    public string Response { get; set; }
}
