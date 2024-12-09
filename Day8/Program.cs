using System.Collections;
using System.ComponentModel;

string example = @"............
........0...
.....0......
.......0....
....0.......
......A.....
............
............
........A...
.........A..
............
............";
string input = @"...............e.........................i........
...............................1.......i.0........
..............................s.0......d..........
........................i....B.I............d.....
.............................s....................
................J.................................
.....................L.....0i.......4...d.........
.N...e...........................s..R.....4.....I.
........e.........v................1......R....I..
.............G..............0.....1...............
..2...N.............B......................4...R..
..............2...................N..........4s...
..p...................................1..b..I.....
..................p...........B........b...R......
....................................b.............
........W.......C.....w...........................
............7....u.............B..................
...W.................u......................bw....
.......p.2...........v......................9.....
.E.....C....u................................9....
E....Y................u.D........9...........J....
.......2..........................................
............................J.................c...
.............7...K..D..............J..............
.....C.Wq........t.................T..............
............Yt......v.............................
..W......................3...............w........
..7.....j................T...D.....n......8.....c.
.........E...............nTD......................
...r....E..........Y............n.......P........c
......K........G......L...........................
......................G.....L....v................
..............G...t......q.............l.8........
......................q............l..............
...6........r.............................w..c....
..6.........3.......Qk........T...................
......Y...............j.................n.........
..K.....S.....r......j.....U......9.l......8......
........................U......................P..
.....................q............................
.......K......5..N.....j.7.Q......................
...................p..k...U..........L.Q..........
.r......3...S.......k........y....8U....Q.......P.
.......S....g..3..................................
.....S..........gk................................
................5...................yP............
.......................g......yV..l...............
.........6.5...............V......................
..................6..5..V.........................
.............g.......................y..........V.";

RunPart1(input);
RunPart2(input);

static void RunPart1(string input)
{
    int result = 0;
    var lines = input.Split('\n').ToArray();

    char[][] puzzle = new char[lines.Length][];

    for (int i = 0; i < lines.Length; i++)
        puzzle[i] = lines[i].ToCharArray();

    int puzzleLenght = puzzle.Length;

    List<int[]> antinodes = new();

    for (int i = 0; i < puzzleLenght; i++)
    {
        for (int j = 0; j < puzzleLenght; j++)
        {
            char currentChar = puzzle[i][j];

            for (int k = 0; k < puzzleLenght; k++)
            {
                for (int l = 0; l < puzzleLenght; l++)
                {
                    if (puzzle[k][l] == currentChar && puzzle[k][l] != '.' && puzzle[k][l] != '#' && (k != i && l != j))
                    {
                        var newX = k + k - i;
                        var newY = l + l - j;

                        if (newX >= 0 && newX < puzzleLenght && newY >= 0 && newY < puzzleLenght)
                        {
                            antinodes.Add(new[] { newX, newY });

                            if (puzzle[newX][newY] == '.')
                                puzzle[newX][newY] = '#';
                        }
                    }
                }
            }
        }
    }

    result = CalculateAntinodes(result, puzzle, puzzleLenght, antinodes);

    Console.WriteLine($"Part 1 result: {result}");
}

static void RunPart2(string input)
{
    int result = 0;
    var lines = input.Split('\n').ToArray();

    char[][] puzzle = new char[lines.Length][];

    for (int i = 0; i < lines.Length; i++)
        puzzle[i] = lines[i].ToCharArray();

    int puzzleLenght = puzzle.Length;

    List<int[]> antinodes = new();

    for (int i = 0; i < puzzleLenght; i++)
    {
        for (int j = 0; j < puzzleLenght; j++)
        {
            char currentChar = puzzle[i][j];

            for (int k = 0; k < puzzleLenght; k++)
            {
                for (int l = 0; l < puzzleLenght; l++)
                {
                    if (puzzle[k][l] == currentChar && puzzle[k][l] != '.' && puzzle[k][l] != '#' && (k != i && l != j))
                    {
                        antinodes.Add(new[] { k, l });

                        var distanceX = k - i;
                        var distanceY = l - j;

                        GetAntinodes(puzzle, puzzleLenght, distanceX, distanceY, k, l, ref antinodes);
                    }
                }
            }
        }
    }

    result = CalculateAntinodes(result, puzzle, puzzleLenght, antinodes);

    Console.WriteLine($"Part 2 result: {result}");
}

static bool IsWithinBounds(int puzzleLenght, int newX, int newY)
{
    return newX >= 0 && newX < puzzleLenght && newY >= 0 && newY < puzzleLenght;
}

static int CalculateAntinodes(int result, char[][] puzzle, int puzzleLenght, List<int[]> antinodes)
{
    for (int i = 0; i < puzzleLenght; i++)
    {
        for (int j = 0; j < puzzleLenght; j++)
        {
            if (antinodes.Any(arr => arr.SequenceEqual(new[] { i, j })))
            {
                result++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(string.Format("{0} ", puzzle[i][j]));
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(string.Format("{0} ", puzzle[i][j]));
            }
        }
        Console.Write(Environment.NewLine);

    }

    return result;
}

static void GetAntinodes(char[][] puzzle, int puzzleLenght, int distanceX, int distanceY, int k, int l, ref List<int[]> antinodes)
{
    var newX = k + distanceX;
    var newY = l + distanceY;
    if (IsWithinBounds(puzzleLenght, newX, newY))
    {
        antinodes.Add(new[] { newX, newY });

        if (puzzle[newX][newY] == '.')
            puzzle[newX][newY] = '#';

        GetAntinodes(puzzle, puzzleLenght, distanceX, distanceY, newX, newY, ref antinodes);
    }
}