class AddingReversedNumbers
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        Console.WriteLine("Enter the numbers for the first list separating with comma");
        List<int> list1 = Console.ReadLine().Split(',').Select(int.Parse).ToList();

        Console.WriteLine("Enter the numbers for the second list separating with comma");
        List<int> list2 = Console.ReadLine().Split(',').Select(int.Parse).ToList();

        solution.SumOfRevercedNumbers(list1, list2);
        Console.WriteLine("Up to date");

    }
}

public class Solution
{
    public void SumOfRevercedNumbers(List<int> list1, List<int> list2)
    {
        list1.Reverse();
        list2.Reverse();
        int resList1 = list1.Aggregate((nums, list1) => nums * 10 + list1);
        int resList2 = list2.Aggregate((nums, list2) => nums * 10 + list2);
        int res = resList1 + resList2;
        Console.WriteLine(resList1);
        Console.WriteLine(resList2);
        Console.WriteLine($"Sum before reversing:{res}");
        int result = int.Parse(new string(res.ToString().Reverse().ToArray()));
        Console.WriteLine($"Numbers from first list: {resList1} + numbers from second list: {resList2} reversed result = {result}");
    }

    
}

