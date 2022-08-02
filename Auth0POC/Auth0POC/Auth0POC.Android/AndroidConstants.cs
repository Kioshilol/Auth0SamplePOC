namespace Auth0POC.Droid
{
    public static class AndroidConstants
    {
        public const string PackageName = "com.companyname.auth0poc";

        public const string Domain = "dev-7xpcooft.eu.auth0.com";

        public static string CallbackUrl = $"{PackageName}://{Domain}/android/{PackageName}/callback";
    }
}