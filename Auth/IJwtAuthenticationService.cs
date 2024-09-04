namespace FJCO20240409.Auth
{
    public interface IJwtAuthenticationService
    {
        string Authenticate(string userName);
    }
}
