namespace Dictionary1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Mary";
            cookies["email"] = "mary@gmail.com";
            cookies["phone"] = "999999";
            cookies["phone"] = "898989";

            foreach (var cookie in cookies)
            {
                Console.WriteLine(cookie.Key + ": " + cookie.Value);
            }

            cookies.Remove("user");

            if (cookies.ContainsKey("user"))
            {
                Console.WriteLine("\nUser: ");
                Console.Write(cookies["user"]);
            }

            Console.WriteLine("\nAll cookies:");
            foreach (KeyValuePair<string, string> cookie in cookies)
            {
                Console.WriteLine(cookie.Key + ": " + cookie.Value);
            }
        }
    }
}
