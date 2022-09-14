namespace App.Middlewares
{
  public class BasicMiddleware
  {
    private readonly RequestDelegate _next;
    public BasicMiddleware(RequestDelegate next)
    {
      _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
      // Sur l'aller
      Console.WriteLine("... MW1 ===>");
      await _next(context);
      // Sur le retour : Intercepte la réponse
      Console.WriteLine("<=== MW1 ...");
    }
  }
}