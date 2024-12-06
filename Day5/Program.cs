﻿string example = @"47|53
97|13
97|61
97|47
75|29
61|13
75|53
29|13
97|29
53|29
61|53
97|53
61|29
47|13
75|47
97|75
47|61
75|61
47|29
75|13
53|13

75,47,61,53,29
97,61,53,29,13
75,29,13
75,97,47,61,53
61,13,29
97,13,75,29,47";
string input = @"69|26
93|46
93|43
46|53
46|74
46|67
91|11
91|78
91|34
91|43
43|66
43|26
43|44
43|84
43|89
18|69
18|74
18|34
18|36
18|48
18|11
86|89
86|48
86|53
86|56
86|42
86|66
86|26
73|56
73|32
73|81
73|63
73|69
73|43
73|74
73|53
32|18
32|81
32|93
32|53
32|71
32|86
32|66
32|46
32|34
74|19
74|68
74|76
74|38
74|48
74|53
74|89
74|57
74|22
74|44
52|78
52|38
52|76
52|93
52|46
52|69
52|43
52|82
52|84
52|73
52|42
19|29
19|59
19|69
19|43
19|84
19|73
19|12
19|46
19|78
19|32
19|71
19|81
66|47
66|92
66|42
66|64
66|22
66|89
66|41
66|15
66|91
66|73
66|38
66|19
66|48
57|69
57|93
57|38
57|73
57|22
57|42
57|19
57|64
57|91
57|46
57|97
57|43
57|59
57|47
37|81
37|66
37|47
37|89
37|15
37|71
37|26
37|36
37|63
37|68
37|95
37|24
37|52
37|86
37|67
29|73
29|86
29|78
29|93
29|96
29|11
29|59
29|82
29|63
29|18
29|71
29|37
29|84
29|95
29|98
29|81
82|59
82|34
82|93
82|46
82|37
82|74
82|86
82|73
82|18
82|69
82|11
82|32
82|67
82|84
82|53
82|96
82|43
71|81
71|74
71|24
71|56
71|89
71|15
71|42
71|66
71|95
71|92
71|68
71|64
71|48
71|67
71|38
71|97
71|22
71|52
53|66
53|91
53|47
53|64
53|19
53|56
53|22
53|29
53|48
53|44
53|92
53|52
53|57
53|26
53|24
53|41
53|78
53|97
53|42
89|18
89|29
89|69
89|42
89|93
89|97
89|38
89|64
89|52
89|41
89|68
89|46
89|73
89|57
89|82
89|92
89|47
89|19
89|24
89|78
97|46
97|84
97|18
97|19
97|29
97|11
97|12
97|76
97|86
97|37
97|69
97|43
97|82
97|91
97|98
97|73
97|78
97|32
97|93
97|38
97|22
47|11
47|43
47|41
47|38
47|46
47|73
47|59
47|76
47|82
47|97
47|98
47|32
47|93
47|29
47|42
47|64
47|91
47|84
47|12
47|69
47|22
47|78
41|12
41|78
41|32
41|37
41|96
41|34
41|59
41|19
41|43
41|82
41|36
41|69
41|71
41|11
41|18
41|46
41|86
41|29
41|91
41|76
41|93
41|73
41|98
98|66
98|63
98|15
98|74
98|11
98|71
98|96
98|95
98|89
98|36
98|86
98|53
98|12
98|44
98|67
98|84
98|59
98|81
98|92
98|34
98|56
98|26
98|37
98|48
59|15
59|71
59|95
59|96
59|92
59|67
59|11
59|66
59|86
59|81
59|89
59|74
59|44
59|36
59|63
59|37
59|52
59|53
59|34
59|26
59|56
59|12
59|48
59|24
76|12
76|37
76|59
76|81
76|78
76|19
76|82
76|43
76|84
76|71
76|36
76|73
76|46
76|98
76|86
76|96
76|29
76|34
76|11
76|69
76|93
76|18
76|32
76|91
26|22
26|57
26|52
26|38
26|29
26|42
26|24
26|32
26|91
26|64
26|92
26|73
26|76
26|47
26|44
26|68
26|82
26|78
26|97
26|18
26|41
26|15
26|89
26|19
95|26
95|89
95|15
95|64
95|76
95|68
95|66
95|74
95|24
95|42
95|38
95|57
95|44
95|22
95|92
95|19
95|97
95|48
95|52
95|56
95|41
95|53
95|67
95|47
24|41
24|38
24|93
24|19
24|68
24|98
24|47
24|64
24|32
24|69
24|43
24|52
24|78
24|73
24|91
24|82
24|22
24|18
24|57
24|76
24|42
24|46
24|29
24|97
36|57
36|34
36|63
36|47
36|81
36|64
36|52
36|53
36|74
36|92
36|44
36|96
36|48
36|67
36|56
36|26
36|42
36|66
36|89
36|95
36|15
36|24
36|68
36|71
11|37
11|52
11|26
11|36
11|95
11|66
11|81
11|92
11|67
11|89
11|57
11|56
11|63
11|53
11|71
11|34
11|68
11|74
11|48
11|44
11|86
11|15
11|24
11|96
15|64
15|92
15|52
15|32
15|89
15|78
15|82
15|24
15|41
15|68
15|29
15|57
15|47
15|22
15|19
15|44
15|76
15|42
15|73
15|93
15|97
15|18
15|91
15|38
42|32
42|46
42|43
42|11
42|93
42|64
42|84
42|22
42|12
42|41
42|98
42|19
42|76
42|73
42|29
42|91
42|78
42|37
42|18
42|97
42|69
42|59
42|38
42|82
64|11
64|37
64|78
64|98
64|22
64|93
64|76
64|38
64|82
64|97
64|46
64|59
64|19
64|84
64|69
64|41
64|86
64|91
64|32
64|29
64|12
64|43
64|73
64|18
48|82
48|76
48|24
48|44
48|64
48|15
48|41
48|97
48|38
48|57
48|26
48|89
48|73
48|91
48|19
48|47
48|32
48|78
48|42
48|22
48|92
48|68
48|29
48|52
84|11
84|12
84|71
84|63
84|95
84|89
84|92
84|53
84|74
84|67
84|56
84|44
84|96
84|37
84|24
84|48
84|86
84|26
84|66
84|34
84|81
84|36
84|59
84|15
68|32
68|38
68|93
68|97
68|59
68|41
68|64
68|91
68|19
68|98
68|22
68|43
68|76
68|78
68|18
68|12
68|82
68|29
68|69
68|84
68|46
68|47
68|42
68|73
44|89
44|29
44|82
44|47
44|32
44|73
44|46
44|97
44|64
44|42
44|24
44|78
44|38
44|18
44|19
44|68
44|57
44|52
44|91
44|76
44|92
44|41
44|93
44|22
78|34
78|36
78|82
78|84
78|43
78|93
78|86
78|69
78|95
78|74
78|32
78|37
78|81
78|96
78|71
78|67
78|12
78|63
78|98
78|11
78|59
78|73
78|18
78|46
22|12
22|38
22|43
22|76
22|36
22|19
22|69
22|29
22|82
22|84
22|93
22|73
22|11
22|96
22|37
22|86
22|46
22|32
22|41
22|18
22|91
22|98
22|78
22|59
12|34
12|92
12|44
12|86
12|37
12|95
12|26
12|63
12|71
12|52
12|36
12|67
12|96
12|66
12|74
12|89
12|15
12|57
12|11
12|81
12|53
12|24
12|48
12|56
38|18
38|59
38|78
38|98
38|43
38|41
38|29
38|86
38|96
38|11
38|84
38|37
38|93
38|69
38|73
38|91
38|76
38|34
38|19
38|46
38|32
38|82
38|12
38|36
56|78
56|82
56|29
56|26
56|91
56|19
56|38
56|41
56|42
56|47
56|24
56|68
56|66
56|64
56|57
56|92
56|97
56|76
56|44
56|52
56|22
56|48
56|15
56|89
67|53
67|52
67|15
67|29
67|26
67|56
67|19
67|76
67|89
67|66
67|44
67|57
67|24
67|41
67|64
67|48
67|68
67|42
67|97
67|91
67|92
67|47
67|38
67|22
63|47
63|48
63|26
63|53
63|66
63|57
63|89
63|15
63|97
63|68
63|38
63|92
63|95
63|42
63|64
63|44
63|22
63|76
63|74
63|56
63|67
63|41
63|52
63|24
81|92
81|42
81|22
81|74
81|15
81|97
81|57
81|52
81|95
81|66
81|53
81|26
81|67
81|89
81|48
81|64
81|56
81|68
81|38
81|44
81|24
81|41
81|63
81|47
34|97
34|24
34|95
34|63
34|53
34|44
34|66
34|48
34|52
34|81
34|74
34|68
34|89
34|71
34|15
34|67
34|56
34|57
34|64
34|42
34|22
34|26
34|92
34|47
96|67
96|48
96|26
96|44
96|52
96|15
96|63
96|71
96|81
96|66
96|47
96|74
96|64
96|89
96|57
96|56
96|92
96|34
96|42
96|95
96|68
96|24
96|53
96|97
92|73
92|47
92|69
92|78
92|82
92|91
92|32
92|42
92|64
92|97
92|22
92|46
92|19
92|57
92|41
92|18
92|24
92|43
92|52
92|29
92|68
92|76
92|93
92|38
69|81
69|48
69|67
69|63
69|95
69|44
69|34
69|12
69|56
69|53
69|98
69|11
69|84
69|15
69|36
69|66
69|86
69|37
69|71
69|43
69|74
69|96
69|59
93|67
93|53
93|74
93|59
93|37
93|26
93|63
93|34
93|98
93|66
93|11
93|84
93|71
93|96
93|95
93|48
93|69
93|12
93|36
93|56
93|86
93|81
46|15
46|36
46|69
46|63
46|84
46|59
46|98
46|26
46|48
46|34
46|96
46|11
46|81
46|71
46|95
46|56
46|43
46|66
46|12
46|86
46|37
91|86
91|95
91|98
91|63
91|93
91|29
91|81
91|59
91|46
91|18
91|32
91|37
91|96
91|82
91|69
91|71
91|84
91|36
91|73
91|12
43|95
43|15
43|37
43|86
43|59
43|74
43|81
43|67
43|98
43|96
43|11
43|12
43|56
43|53
43|34
43|36
43|63
43|71
43|48
18|81
18|86
18|71
18|59
18|56
18|93
18|96
18|43
18|46
18|67
18|66
18|95
18|53
18|63
18|12
18|98
18|84
18|37
86|95
86|74
86|52
86|68
86|44
86|96
86|92
86|15
86|57
86|24
86|34
86|63
86|67
86|71
86|81
86|47
86|36
73|59
73|46
73|84
73|11
73|86
73|12
73|98
73|71
73|93
73|95
73|37
73|96
73|36
73|18
73|34
73|67
32|11
32|12
32|36
32|96
32|59
32|95
32|37
32|74
32|63
32|43
32|69
32|98
32|84
32|56
32|67
74|67
74|91
74|26
74|15
74|97
74|56
74|66
74|64
74|52
74|24
74|92
74|42
74|47
74|41
52|32
52|68
52|98
52|29
52|41
52|47
52|91
52|19
52|57
52|97
52|64
52|18
52|22
19|82
19|36
19|18
19|34
19|11
19|37
19|96
19|86
19|91
19|93
19|63
19|98
66|76
66|24
66|29
66|26
66|78
66|44
66|97
66|82
66|57
66|68
66|52
57|29
57|32
57|82
57|84
57|41
57|76
57|18
57|98
57|78
57|68
37|48
37|34
37|44
37|92
37|53
37|96
37|57
37|56
37|74
29|46
29|74
29|12
29|34
29|32
29|43
29|36
29|69
82|98
82|95
82|12
82|81
82|71
82|63
82|36
71|57
71|44
71|63
71|47
71|26
71|53
53|15
53|38
53|76
53|68
53|89
89|32
89|22
89|76
89|91
97|59
97|41
97|36
47|18
47|19
41|84

57,47,82,32,18
74,56,86,81,84,44,53,92,12,36,15,66,95,26,71
26,68,47,42,73,41,52,44,78,64,24,76,29,82,38
98,78,59,22,91
98,84,12,11,37,86,36,96,34,71,81,63,95,74,67,53,56,66,48,26,15,44,89
78,73,32,93,46,69,43,98,84,59,12,37,86,34,71,81,63,95,74
32,64,38,97,82,68,47,26,22,29,24,19,92,76,52,73,44,41,78,89,91
41,78,82,59,98,29,34,91,93,76,73,11,46,96,37
59,12,37,86,34,71,81,95,67,53,56,66,48,15,44,92,24
26,66,56,95,11,44,81
52,66,15,48,63,38,64
19,91,82,73,18,93,46,69,43,98,84,59,36,34,81
59,12,11,37,86,36,96,34,71,81,63,95,74,53,56,66,26,44,89,92,24
59,12,11,36,34,71,74,67,53,56,66,48,26,15,44,89,24
48,26,15,44,89,92,24,52,68,64,97,22,38,41,76,19,91,29,78,82,73
92,24,52,68,47,42,22,76,19,91,29,78,82,93,69
86,36,96,34,63,56,66,44,89,92,24,68,47
26,44,92,52,68,42,64,76,91,29,82,73,32
67,56,48,26,15,44,89,92,24,52,57,47,42,22,38,41,19
71,53,36,92,15,84,89,66,67
38,11,18,84,19,78,93,86,12,59,32,43,96,76,29,98,36,73,82,41,69
63,81,74,96,98
67,66,44,15,42,24,91
78,59,34,32,82,91,36,98,12,18,93,11,46,86,37,76,69,73,19
19,93,98,52,78,97,41,68,64,18,73,43,46,91,22,29,82,57,69,32,38,76,47
52,57,68,42,64,19,29,78,82,93,46,43,98
95,67,53,66,15,24,52,68,47,97,22,38,76
71,56,36,81,44,15,67,48,57,86,96,89,92,26,95,53,24,11,52,34,37
73,19,64,52,29,15,42,68,24,32,82,41,91,47,22,97,78,38,76,89,26
98,84,69,74,86,93,12,18,71,56,96,36,34,37,95,67,63,32,81
84,59,12,11,37,86,96,34,71,81,63,74,67,53,56,66,48,15,44,89,92
68,78,15,22,42,56,41,44,26
86,11,41,91,69,97,18
93,46,69,98,84,37,86,36,96,34,71,81,74,53,56,66,48
92,29,78,42,44,19,82,66,76
46,69,43,34,71,81,95,74,67,56,66,48,26
92,18,78,42,32,46,24,64,47,29,97,82,91,68,76,73,93,38,41,57,22
11,32,93,19,84,71,36,34,43,29,59,46,73,82,81
48,26,15,44,89,92,52,57,68,47,42,64,97,22,38,41,76,19,91,29,78,82,73
15,44,66,67,63,86,26,92,74,71,53,24,48,52,96,12,36,11,34,89,56
57,68,47,42,64,97,22,38,41,19,91,29,78,82,73,32,18,93,46,69,43,98,84
48,97,57,81,26,68,47,24,53,52,64,95,67,74,44
96,48,44,15,56,74,53,84,81,63,11,98,12,59,86,89,71
22,92,52,64,67,57,24,63,66,15,95,53,41,44,48,26,42
69,73,24,38,82,29,41,42,57,47,43
53,71,66,44,56,37,74,12,24,96,52,89,63,81,15,67,26,48,86
56,66,48,26,44,89,92,24,57,68,47,42,64,97,22,38,41,76,19,29,78
96,34,71,63,95,74,53,56,48,26,15,44,89,92,24,52,57,68,47,42,64
73,78,32,93,97,44,24,29,22,19,57
81,42,71,63,36,74,67,92,24,48,15,44,68,34,66,96,53
53,56,66,48,26,15,44,92,57,68,47,42,97,22,38,41,76,91,29
76,47,68,82,15,18,29,38,52,97,73
84,69,37,98,29,19,82,59,18,46,36,11,93,12,71,43,73,86,81
18,93,43,98,84,59,12,11,36,96,34,71,81,53,66
37,46,69,11,59,41,73,36,96,82,43,38,76,18,29,78,91,86,98,32,19
53,59,67,95,56,24,96
53,56,66,15,44,92,57,47,42,64,97,22,76,19,29
38,64,22,91,41,82,46,84,98,37,19,43,59,12,76
56,24,97,67,42,68,48,38,52,74,92,64,53
44,42,24,57,89,22,53,26,95,68,52,81,63,56,64,67,48,66,97,47,38,92,15
66,44,24,52,57,47,82
36,96,34,81,63,95,53,56,48,26,15,44,92,52,57,47,42
81,71,37,73,96,19,78,98,11,82,29,36,43,84,18,91,32,59,12,93,46,86,69
11,59,96,84,29,91,69,43,36,82,37,12,73,32,81,93,98,71,46,86,34
26,15,89,92,24,52,68,47,64,97,22,38,41,76,19,91,29,78,82,73,32
63,81,56,71,64,92,68
59,32,82,38,64,73,69,84,41,42,76,93,18,12,97,11,29
81,15,56,53,96,26,36,89,71,95,52,92,67,12,24,66,11,34,37
41,19,91,78,82,73,32,18,46,69,98,84,59,12,11,37,86,36,34
48,24,38,64,52,68,41,97,89,22,15,26,29,56,91,44,19,76,57,47,53
24,68,91,57,82,92,41,93,42,19,29
15,44,89,24,42,38,41,82,18
68,42,64,97,41,19,91,29,78,73,32,18,93,46,69,84,59
56,11,48,15,12,44,37,24,52
11,93,78,41,73,69,38,46,59
64,91,46,43,98,84,12
69,84,11,36,96
22,38,41,76,19,91,29,78,82,73,32,18,93,46,69,43,98,84,59,12,11,86,36
47,97,56,74,92,41,67,44,19
81,78,43,59,71,69,32,82,98,11,34,96,29,36,12,84,93,86,73,63,91,18,37
37,86,36,96,34,71,81,63,95,74,53,66,48,26,44,89,92,24,52,57,68
53,36,81,86,96,46,98,71,84,95,37,32,12,63,56
89,57,22,38,41,76,82,32,18
64,95,41,44,76,74,52
32,93,59,86,71,81,63,95,53
73,64,38,42,22,76,24,29,93,52,46,97,19,91,57,32,92
64,97,22,41,76,19,91,29,78,82,73,32,93,43,98,84,59,12,37
89,92,24,57,47,42,64,97,38,41,91,82,73,32,18,93,46
44,52,96,64,42,66,71,24,63,68,26
26,91,52,89,41,48,47
76,84,91,73,93,29,18,59,69,82,37,96,12,86,32
46,56,18,95,93,66,59,86,74
24,97,47,18,91,68,42,29,44,57,92,19,89,93,76,52,78
34,71,81,63,95,67,53,56,66,48,26,15,44,89,92,24,52,57,68,47,42,64,97
38,64,78,91,89,29,93,97,22,57,52,18,47,32,73,19,41
18,53,12,95,84,73,81
43,98,84,59,86,36,34,71,63,95,74,67,53,56,66,48,26,15,44
74,56,98,96,86,95,53,89,34
38,42,74,15,53,52,48,22,47,44,97,41,26,57,24,64,67,76,95
52,97,38,93,69,43,98
91,82,78,59,37,34,41,19,84
74,34,53,37,56,96,68
97,57,22,78,29,92,44
63,74,67,53,56,66,48,44,89,24,52,57,68,97,22,38,41
41,76,19,91,29,78,82,73,32,18,93,46,69,43,98,84,59,12,11,37,36,96,34
63,95,56,66,26,15,89,92,24,52,47,42,64,38,41
81,96,36,71,12,74,32,43,63,86,73,69,84,59,93,11,95,37,18,78,34
38,41,76,19,29,93,46,69,43,59,12,11,86,36,96
47,97,38,78,82,73,46,98,12
12,53,11,98,66,15,69,48,96
42,52,68,89,24,63,41,26,48
38,15,19,74,48,22,47,67,42,76,56,52,26
67,56,48,26,15,44,89,92,24,52,57,68,47,42,64,97,22,38,41,19,91
95,67,53,56,15,92,52,68,47,42,76
78,18,46,69,43,98,84,86,96,34,71,63,74
43,98,84,59,96,95,74,67,53,56,66,48,26,15,44
18,43,84,59,12,11,86,36,34,71,63,95,66
91,29,78,82,73,32,18,93,69,43,59,12,86,36,71,81,63
56,66,48,89,42,22,38,41,76,19,78
11,37,86,96,34,71,81,63,95,67,56,66,48,26,15,44,89,92,24,52,57
68,64,66,41,82,26,52
63,59,73,71,74,95,36,86,11
57,97,44,92,67,19,38,56,91
93,69,43,59,11,71,56
12,93,32,19,78,18,46,64,76,43,38,47,98,73,29,69,84,42,97
11,48,34,53,93,96,67
26,89,52,57,76,19,78,82,32
44,89,92,24,52,57,68,47,64,97,38,41,76,19,91,29,78,82,32,18,93
57,81,44,26,71,34,68,86,36,74,24,66,56,52,95,96,47,89,15,53,67
97,41,91,15,92,52,38,42,53,89,24,64,47,68,76,48,44,56,26,67,19,57,66
92,63,71,89,81,34,96,52,67,44,24,11,15,56,53
86,96,56,92,68
12,34,74,53,24
46,19,22,91,86,84,18,73,41,97,76
93,18,34,82,12,32,73,37,63,74,36
42,48,66,26,89,38,53,52,22,64,76,67,68,19,24
19,97,64,47,22,15,38,76,57,68,92,52,32,44,42,78,89,24,29,41,18,82,91
73,34,37,96,98,11,95,74,63,84,67,46,81,36,18,32,59,93,69,82,43
98,12,11,37,86,36,71,81,63,95,74,67,66,48,26,15,89
15,89,92,52,68,47,42,64,22,38,41,76,19,91,29,78,73,32,18
92,24,68,47,42,97,22,38,41,76,19,91,29,78,82,73,32,18,93,46,69
71,96,74,43,53,81,56,67,63,37,59,98,84,95,12,66,86,48,11,36,46,34,93
68,47,42,64,97,22,38,41,76,91,29,78,82,73,32,18,46,69,43,98,84
43,18,93,84,74,37,32,34,67,95,46,59,53,56,12
59,11,76,82,64,42,97,43,84
57,26,74,48,66,89,42,63,22,81,24,68,92,38,97,44,15,56,52,47,95,53,64
92,74,24,22,42,38,97,63,48,57,64,68,26,44,15,56,89,53,47,81,95,52,67
95,11,56,86,84,44,15,92,34,67,26,66,63,96,81
92,66,59,56,36,11,12,24,71
69,43,98,59,12,11,37,86,36,96,34,71,81,63,95,74,67,53,56,66,48
96,71,63,95,74,53,56,48,15,57,68
53,56,66,26,15,44,89,92,42,64,22,41,19
81,37,46,71,36,63,93,82,95,18,12,96,74,32,69,43,59
92,24,52,57,68,47,42,64,97,22,38,41,76,19,91,78,82,73,32,18,69
59,37,96,34,71,74,53,26,44,89,24
37,53,86,96,36,63,74,84,18,93,69,73,95,43,46
18,19,29,97,78,15,52,82,92
66,44,15,34,12,56,37,52,92
74,67,53,66,48,26,24,47,42,64,97,41,19
82,78,76,86,91,12,29,18,37,38,43,97,22,84,59,93,73,19,32,11,46,98,41
19,82,47,43,57,73,41,93,91,38,18,32,64,29,76,84,68,98,78
42,32,43,64,46,29,76,24,78,73,47,18,22,82,41,93,57,38,97,91,69
29,59,43,81,36,95,86,78,12
42,56,74,48,67,81,63,89,57,26,53
92,26,52,15,19,48,78,57,76
67,82,84,93,43,71,98,46,73,95,69,18,63,11,59
81,69,95,36,86,84,18,37,73,59,82,34,32,71,46,96,12
29,59,95,34,46,69,71,86,93
53,56,66,48,26,44,89,92,24,52,57,68,47,42,97,22,38,76,29
59,95,86,96,67,12,37,63,46,26,56,36,84,66,11,34,53,74,69
93,81,34,86,53,96,84,11,37,63,73
89,26,48,47,15,24,38,53,57,52,64,67,63,81,56,74,68,95,22,66,92,44,97
97,22,38,76,19,78,82,32,18,93,43,59,12,37,86
34,86,84,11,73,78,95
44,89,92,24,52,57,68,47,42,64,97,38,41,76,19,91,29,78,82,73,32,18,93
19,92,41,97,91,47,24,56,15,26,78,52,44,66,29,76,22
69,84,36,34,74
19,91,82,73,69,98,84,59,37,86,36
96,59,95,67,11,74,48,26,81,36,43,69,12,63,56,37,15,34,86,71,53,98,66
38,84,46,82,93,37,41,59,19,78,36
15,44,64,97,29
63,95,74,67,48,15,44,89,92,42,64,97,22,38,41
29,82,32,12,96
73,29,86,41,96,82,98,38,91,18,69,12,84,78,76,59,46,37,93,36,32,43,19
42,64,97,22,38,41,19,73,18,46,84,12,11
93,46,69,43,84,59,12,11,37,86,36,96,34,71,81,95,74,67,56,66,48
66,48,26,15,44,92,24,57,47,42,97,22,38,41,76,91,82
29,68,82,43,64,19,69,32,97,78,76,47,41,93,38,59,46,98,73,18,22
66,15,44,89,24,52,47,22,41,76,19,29,82
73,69,12,91,59
73,32,18,93,46,69,43,98,84,59,12,11,37,86,36,96,34,71,81,63,95,67,53
71,56,24,52,57,47,64,97,22
46,43,84,59,37,86,63,53,66,48,26";

RunPart1(input);
RunPart2(input);

static void RunPart1(string input)
{
    int result = 0;
    input = input.Replace("\r\n", "\n");
    var lines = input.Split("\n\n")
                     .ToArray();

    var (ruleBlock, updateBlock) = (lines[0].Split("\r\n")[0], lines[1].Split("\r\n")[0]);

    var rules = ruleBlock.Split("\n");
    var updates = updateBlock.Split("\n");

    foreach (var update in updates)
    {
        string[] pages = update.Split(',');
        if (IsCorrectlyOrdered(pages, rules))
        {
            var middlePageIndex = pages.Length / 2;
            result += int.Parse(pages[middlePageIndex]);
        }
    }

    Console.WriteLine($"Part 1 result: {result}");
}

static void RunPart2(string input)
{
    int result = 0;
    input = input.Replace("\r\n", "\n");
    var lines = input.Split("\n\n")
                     .ToArray();

    var (ruleBlock, updateBlock) = (lines[0].Split("\r\n")[0], lines[1].Split("\r\n")[0]);

    var rules = ruleBlock.Split("\n");
    var updates = updateBlock.Split("\n");

    List<string> updatesToOrder = new();
    foreach (var update in updates)
    {
        string[] pages = update.Split(',');
        if (!IsCorrectlyOrdered(pages, rules))
        {
            updatesToOrder.Add(update);
        }
    }

    foreach (var update in updatesToOrder)
    {
        string[] pages = update.Split(',');
        Console.WriteLine("Before:" + string.Join(',', pages));
        pages = Order(pages, rules);
        var middlePageIndex = pages.Length / 2;
        Console.WriteLine("After:" + string.Join(',', pages));
        Console.WriteLine("Middle:" + int.Parse(pages[middlePageIndex]));
        result += int.Parse(pages[middlePageIndex]);
    }

    Console.WriteLine($"Part 2 result: {result}");
}

static bool IsCorrectlyOrdered(string[] pages, string[] rules)
{
    for (int i = 0; i < pages.Length - 1; i++)
    {
        if (!rules.Contains($"{pages[i]}|{pages[i + 1]}"))
        {
            return false;
        }
    }

    return true;
}

static string[] Order(string[] pages, string[] rules)
{
    while (!IsCorrectlyOrdered(pages, rules)) 
    {
        for (int i = 0; i < pages.Length - 1; i++)
        {
            if (rules.Contains($"{pages[i + 1]}|{pages[i]}"))
            {
                (pages[i], pages[i + 1]) = (pages[i + 1], pages[i]);
                Console.WriteLine("-------" + string.Join(',', pages));
            }
        }
    }

    return pages;
}
