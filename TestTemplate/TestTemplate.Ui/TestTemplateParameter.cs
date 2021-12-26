namespace TestTemplate.Ui
{
    public class TestTemplateParameter
    {
        public void TestParameter()
        {
            Console.WriteLine("what is your best friend name? : {bestFriend}");
            Console.WriteLine("what is your favorite food? : {foodName}");

#if likeJob
        Console.WriteLine("do you like your job? : Yes");
#else
            Console.WriteLine("do you like your job? : No");
#endif


        }
    }
}
