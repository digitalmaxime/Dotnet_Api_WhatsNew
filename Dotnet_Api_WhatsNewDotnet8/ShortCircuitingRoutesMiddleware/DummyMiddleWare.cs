namespace ShortCircuitingRoutesMiddleware;

public class DummyMiddleWare
{
    private readonly RequestDelegate _next;

    public DummyMiddleWare(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}