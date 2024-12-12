string example = @"125 17";
string input = @"70949 6183 4 3825336 613971 0 15 182";

Console.Write("Part 1 result: ");
Run(input, 25);
Console.Write("Part 2 result: ");
Run(input, 75);

static void Run(string input, int blinks)
{
    List<string> stones = input.Split(' ').ToList();

    Dictionary<string, long> valueAndCount = new();

    foreach (var stone in stones)
        valueAndCount = AddOrIncrement(stone, 1, valueAndCount);

    for (int i = 0; i < blinks; i++)
        valueAndCount = Blink(valueAndCount);

    long result = 0;
    foreach (var stone in valueAndCount)
        result += valueAndCount[stone.Key];

    Console.WriteLine($"{result}");
}


static Dictionary<string, long> Blink(Dictionary<string, long> stones)
{
    Dictionary<string, long> newStones = new();

    foreach (var stone in stones)
    {
        Rules rule = GetFirstApplicableRule(stone.Key);

        newStones = ApplyRule(stone.Key, stone.Value, rule, newStones);
    }

    return newStones;
}

static Rules GetFirstApplicableRule(string stone)
{
    if (stone == "0")
        return Rules.ZeroToOne;
    else if (long.IsEvenInteger(stone.Length))
        return Rules.Split;
    else
        return Rules.MultiplyBy2024;
}

static Dictionary<string, long> ApplyRule(string stone, long count, Rules rule, Dictionary<string, long> newStones)
{
    if (rule == Rules.ZeroToOne)
    {
        newStones = AddOrIncrement("1", count, newStones);
    }
    else if (rule == Rules.Split)
    {
        int midpoint = stone.Length / 2;

        newStones = AddOrIncrement(long.Parse(stone[midpoint..]).ToString(), count, newStones);
        newStones = AddOrIncrement(long.Parse(stone[..midpoint]).ToString(), count, newStones);
    }
    else
    {
        newStones = AddOrIncrement((long.Parse(stone) * 2024).ToString(), count, newStones);
    }

    return newStones;
}

static Dictionary<string, long> AddOrIncrement(string stone, long count, Dictionary<string, long> valueAndCount)
{
    if (valueAndCount.ContainsKey(stone))
        valueAndCount[stone] += count;
    else
        valueAndCount.Add(stone, count);

    return valueAndCount;
}

enum Rules
{
    ZeroToOne,
    Split,
    MultiplyBy2024
}