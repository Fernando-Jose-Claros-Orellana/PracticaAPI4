using FJCO20240409.Auth;

namespace FJCO20240409.Endpoints
{
    public static class AccountEndpoint
    {
        public static void AddAccountEndpoints(this WebApplication app)
        {
            app.MapPost("/account/login", (string login, string password, IJwtAuthenticationService authService) =>
            {
                if (login == "admin" && password == "123")
                {
                    var token = authService.Authenticate(login);

                    return Results.Ok(token);
                }
                else
                {
                    return Results.Unauthorized();
                }
            });
        }
    }
}
