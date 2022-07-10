namespace Facebook
{
    class Facebook
    {
        public static void Main()
        {
            var name = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter Your Name(or Press Enter to Exit): ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    break;
                name.Add(input);
            }
            if (name.Count > 2)
                Console.WriteLine("{0}, {1} and {2} others liked your post", name[0], name[1], name.Count - 2);
            else if (name.Count == 2)
                Console.WriteLine("{0} and {1} liked your post", name[0], name[1]);
            else if (name.Count == 1)
                Console.WriteLine("{0} liked your post.", name[0]);
            else
                Console.WriteLine("no one liked your posts");

        }
    }
}