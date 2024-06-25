namespace DesignPatterns.ChainOfResponsibility.Repositories
{
    internal class AuthenticationManager
    {
        private bool isAuthenticated = false;
        public AuthenticationManager()
        {

        }

        public void Login()
        {
            isAuthenticated = true;
        }
        public bool IsAuthenticated
        {
            get => isAuthenticated;
        }
    }
}
