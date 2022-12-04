namespace HackernEwsClone.Helpers 
{
    public static class HashHelper 
    {
        public static string GetMD5(string input, string salt)
        {
            string payload = input + salt;
            return payload; // TODO : make a hashing!!
        } 
    }
}