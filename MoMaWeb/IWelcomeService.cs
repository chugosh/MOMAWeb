using Microsoft.Extensions.DependencyInjection;

namespace MoMaWeb
{
    public interface IWelcomeService
    {
        string GetMessage();
    }

    public class WelcomeService : IWelcomeService
    {
        public string GetMessage() => "hello world!!!";
    }

    public static class DapperService
    {
        public static void AddDapper(this IServiceCollection services)
        {
            
        }
    }
}