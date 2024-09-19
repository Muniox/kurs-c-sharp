namespace _05._04_Słowa_kluczowe_const___readonly
{
    internal class Program
    {
        class ApiClient
        {
            // w readonly zmienną możemy zmienić jedynie w konstruktorze
            private readonly string baseUrl = "https://our-api-dev.com";
            private const string getUsersEndpoint = "/api/users";
            private readonly HttpClient httpClient = new HttpClient();
            private int defaultPort = 80;


            //wartości referencyjne mogą być tylko readonly
            //const List<string> users = new List<string>(); // bad
            //readonly List<string> users = new List<string>(); // good :)

            public ApiClient(string _baseUrl)
            {
                baseUrl = _baseUrl;
            }

            public void GetUsers()
            {
                //httpClient = new HttpClient(); //proba nadpisania spowoduje blad

                var getUsersUri = $"{baseUrl}{getUsersEndpoint}";

                //getUsersEndpoint = "/api/user"; // może być nadpisane jeśli nie mamy readonly albo const

                // HTTP GET Request @getUsersUri
                httpClient.GetAsync(getUsersUri);
                // return users
            }

            public void PostUser()
            {

            }

            public void GetResources()
            {

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
