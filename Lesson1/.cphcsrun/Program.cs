Console.OutputEncoding = System.Text.Encoding.UTF8;

// Console.Write("Nhap ten cua ban: ");
// string s = Console.ReadLine();
// Console.WriteLine("Ten cua ban la: " + s);


// Console.Write("Nhap so thu nhat: ");
// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Nhap so thu hai: ");
// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"{a} + {b} = {a + b}");


// Console.Write("Nhap vao ban phim: ");
// double r = Convert.ToDouble(Console.ReadLine());

// //double area = 2 * 3.14 * r;
// double area = 2 * Math.PI * r;
// //double perimeter = 3.14 * r * r;
// double perimeter = Math.PI * r * r;

// Console.WriteLine($"Dien tich: {area}, chu vi: {perimeter}");


// Console.Write("Nhap so thang: ");
// int month = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Thang {month} thuoc quy {(month - 1) / 3 + 1}");


// Console.Write("Nhap so dong: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Nhap so dong tren 1 trang: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int pages = (row + size - 1) / size;
// Console.WriteLine($"So trang la {pages}");


// int n = Convert.ToInt32(Console.ReadLine());
// n %= 360;
// int result = n / 90 + 1;

// Console.WriteLine(result);


// int n = Convert.ToInt32(Console.ReadLine());
// int totals = 0;
// totals += n / 50;
// n %= 50;
// totals += n / 20;
// n %= 20;
// totals += n / 10;
// n %= 10;
// totals += n / 5;
// n %= 5;
// totals += n / 2;
// n %= 2;
// totals += n;
// Console.WriteLine(totals);


// int d = Convert.ToInt32(Console.ReadLine());
// int k = Convert.ToInt32(Console.ReadLine());
// Dictionary<int, string> p = new();
// p[1] = "Sun";
// p[2] = "Mon";
// p[3] = "Tus";
// p[4] = "Wed";
// p[5] = "Thur";
// p[6] = "Fri";
// p[7] = "Sat";

// d = ((d - 1 + k) % 7 + 1);
// Console.WriteLine($"Sau {k} ngay la thu {p[d]}");


// // Excercise 1:
// int r = Convert.ToInt32(Console.ReadLine());

// double area = Math.PI * r * r;
// double perimeter = 2 * Math.PI * r;

// System.Console.WriteLine($"area is: {area}\nperimeter is: {perimeter}");


// // Excercise 2
// int r = Convert.ToInt32(Console.ReadLine());
// r = (r % 360 + 360) % 360;

// System.Console.WriteLine($"{r / 90 + 1}");


// // Excercise 3
// int totals = Convert.ToInt32(Console.ReadLine());

// int num50 = totals / 50;
// totals %= 50;
// int num20 = totals / 20;
// totals %= 20;
// int num10 = totals / 10;
// totals %= 10;
// int num5 = totals / 5;
// totals %= 5;
// int num2 = totals / 2;
// totals %= 2;
// int num1 = totals;
// System.Console.WriteLine($"50đ: {num50}\n20đ: {num20}\n10đ: {num10}\n5đ: {num5}\n2đ: {num2}\n1đ: {num1}");


// // Excercise 4
// int h = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// int s = Convert.ToInt32(Console.ReadLine());

// s += 1;
// m += s / 60;
// h += m / 60;

// s %= 60;
// m %= 60;
// h %= 24;

// System.Console.WriteLine($"{h} : {m} : {s}");


// // Excercise 5
// int n = Convert.ToInt32(Console.ReadLine());
// int k = Convert.ToInt16(Console.ReadLine());

// int ans = (n + k - 1) % 7 + 1;

// System.Console.WriteLine(ans);


// // Excercise 6
// double n = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine((int)(n + 0.5));


// // Excercise 7
// double n = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine((int)(n * 2 + 0.5) / 2.0);


// // Excercise 8
// int n = Convert.ToInt32(Console.ReadLine());
// int k = Convert.ToInt32(Console.ReadLine());
// int x = (n + k - 1) / k;
// System.Console.WriteLine(x * k - n);


// double a = Convert.ToDouble(Console.ReadLine());
// a = a + 0.25;
// a = a - a % 0.5;

// System.Console.WriteLine(a);


// string[] str = { "hello", "hi", "goodbye" };

// System.Console.WriteLine(str.Length);
// System.Console.WriteLine(str[2]);
// System.Console.WriteLine(string.Join(", ", str));


// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 1)
// {
//     System.Console.WriteLine("so le");
// }
// else
// {
//     System.Console.WriteLine("so chan");
// }


// string[] arr = { "Chan", "Le" };
// System.Console.WriteLine(string.Join(", ", arr));


// int[] arr = { 1, 3, 7, 8, 9, 15, 24 };
// double median = (arr[arr.Length / 2] + arr[(arr.Length - 1) / 2]) / 2.0;
// System.Console.WriteLine($"Median: {median}");


// Random rand = new Random();

// System.Console.WriteLine(rand.NextDouble());
// System.Console.WriteLine(rand.Next(1, 10));
// System.Console.WriteLine(rand.Next(1, 10));
// System.Console.WriteLine(rand.Next(1, 10));
// System.Console.WriteLine(rand.Next(1, 10));


// Random rand = new Random();
// System.Console.WriteLine("1. Keo");
// System.Console.WriteLine("2. Bua");
// System.Console.WriteLine("3. Bao");
// string[] choices = { "Keo", "Bua", "Bao" };
// string[] result = { "Hoa", "Thang", "Thua" };

// int x = Convert.ToInt16(Console.ReadLine());

// int y = rand.Next(1, 4);
// System.Console.WriteLine($"Nguoi chon: {choices[x - 1]}");
// System.Console.WriteLine($"May chon: {choices[y - 1]}");

// System.Console.WriteLine($"Ket qua: {result[(x - y) % 3]}");

// string[,] matrix = {{"Hoa", "Thua", "Thang"},
//                     {"Thang", "Hoa", "Thua"},
//                     {"Thua", "Thang", "Hoa"} };
// System.Console.WriteLine($"Ket qua: {matrix[x - 1, y - 1]}");


// double[,] zMatrix ={    {0.50000, 0.50399, 0.50798, 0.51197, 0.51595, 0.51994, 0.52392, 0.52790, 0.53188, 0.53586},
//                         {0.53983, 0.54380, 0.54776, 0.55172, 0.55567, 0.55962, 0.56360, 0.56749, 0.57142, 0.57535},
//                         {0.57926, 0.58317, 0.58706, 0.59095, 0.59483, 0.59871, 0.60257, 0.60642, 0.61026, 0.61409},
//                         {0.61791, 0.62172, 0.62552, 0.62930, 0.63307, 0.63683, 0.64058, 0.64431, 0.64803, 0.65173},
//                         {0.65542, 0.65910, 0.66276, 0.66640, 0.67003, 0.67364, 0.67724, 0.68082, 0.68439, 0.68793},
//                         {0.69146, 0.69497, 0.69847, 0.70194, 0.70540, 0.70884, 0.71226, 0.71566, 0.71904, 0.72240},
//                         {0.72575, 0.72907, 0.73237, 0.73565, 0.73891, 0.74215, 0.74537, 0.74857, 0.75175, 0.75490},
//                         {0.75804, 0.76115, 0.76424, 0.76730, 0.77035, 0.77337, 0.77637, 0.77935, 0.78230, 0.78524},
//                         {0.78814, 0.79103, 0.79389, 0.79673, 0.79955, 0.80234, 0.80511, 0.80785, 0.81057, 0.81327},
//                         {0.81594, 0.81859, 0.82121, 0.82381, 0.82639, 0.82894, 0.83147, 0.83398, 0.83646, 0.83891},
//                         {0.84134, 0.84375, 0.84614, 0.84849, 0.85083, 0.85314, 0.85543, 0.85769, 0.85993, 0.86214},
//                         {0.86433, 0.86650, 0.86864, 0.87076, 0.87286, 0.87493, 0.87698, 0.87900, 0.88100, 0.88298},
//                         {0.88493, 0.88686, 0.88877, 0.89065, 0.89251, 0.89435, 0.89617, 0.89796, 0.89973, 0.90147},
//                         {0.90320, 0.90490, 0.90658, 0.90824, 0.90988, 0.91149, 0.91308, 0.91466, 0.91621, 0.91774},
//                         {0.91924, 0.92073, 0.92220, 0.92364, 0.92507, 0.92647, 0.92785, 0.92922, 0.93056, 0.93189},
//                         {0.93319, 0.93448, 0.93574, 0.93699, 0.93822, 0.93943, 0.94062, 0.94179, 0.94295, 0.94408},
//                         {0.94520, 0.94630, 0.94738, 0.94845, 0.94950, 0.95053, 0.95154, 0.95254, 0.95352, 0.95449},
//                         {0.95543, 0.95637, 0.95728, 0.95818, 0.95907, 0.95994, 0.96080, 0.96164, 0.96246, 0.96327},
//                         {0.96407, 0.96485, 0.96562, 0.96638, 0.96712, 0.96784, 0.96856, 0.96926, 0.96995, 0.97062},
//                         {0.97128, 0.97193, 0.97257, 0.97320, 0.97381, 0.97441, 0.97500, 0.97558, 0.97615, 0.97670},
//                         {0.97725, 0.97778, 0.97831, 0.97882, 0.97932, 0.97982, 0.98030, 0.98077, 0.98124, 0.98169},
//                         {0.98214, 0.98257, 0.98300, 0.98341, 0.98382, 0.98422, 0.98461, 0.98500, 0.98537, 0.98574},
//                         {0.98610, 0.98645, 0.98679, 0.98713, 0.98745, 0.98778, 0.98809, 0.98840, 0.98870, 0.98899},
//                         {0.98928, 0.98956, 0.98983, 0.99010, 0.99036, 0.99061, 0.99086, 0.99111, 0.99134, 0.99158},
//                         {0.99180, 0.99202, 0.99224, 0.99245, 0.99266, 0.99286, 0.99305, 0.99324, 0.99343, 0.99361},
//                         {0.99379, 0.99396, 0.99413, 0.99430, 0.99446, 0.99461, 0.99477, 0.99492, 0.99506, 0.99520},
//                         {0.99534, 0.99547, 0.99560, 0.99573, 0.99585, 0.99598, 0.99609, 0.99621, 0.99632, 0.99643},
//                         {0.99653, 0.99664, 0.99674, 0.99683, 0.99693, 0.99702, 0.99711, 0.99720, 0.99728, 0.99736},
//                         {0.99744, 0.99752, 0.99760, 0.99767, 0.99774, 0.99781, 0.99788, 0.99795, 0.99801, 0.99807},
//                         {0.99813, 0.99819, 0.99825, 0.99831, 0.99836, 0.99841, 0.99846, 0.99851, 0.99856, 0.99861},
//                         {0.99865, 0.99869, 0.99874, 0.99878, 0.99882, 0.99886, 0.99889, 0.99893, 0.99896, 0.99900},
//                         {0.99903, 0.99906, 0.99910, 0.99913, 0.99916, 0.99918, 0.99921, 0.99924, 0.99926, 0.99929},
//                         {0.99931, 0.99934, 0.99936, 0.99938, 0.99940, 0.99942, 0.99944, 0.99946, 0.99948, 0.99950},
//                         {0.99952, 0.99953, 0.99955, 0.99957, 0.99958, 0.99960, 0.99961, 0.99962, 0.99964, 0.99965},
//                         {0.99966, 0.99968, 0.99969, 0.99970, 0.99971, 0.99972, 0.99973, 0.99974, 0.99975, 0.99976},
//                         {0.99977, 0.99978, 0.99978, 0.99979, 0.99980, 0.99981, 0.99981, 0.99982, 0.99983, 0.99983},
//                         {0.99984, 0.99985, 0.99985, 0.99986, 0.99986, 0.99987, 0.99987, 0.99988, 0.99988, 0.99989},
//                         {0.99989, 0.99990, 0.99990, 0.99990, 0.99991, 0.99991, 0.99992, 0.99992, 0.99992, 0.99992},
//                         {0.99993, 0.99993, 0.99993, 0.99994, 0.99994, 0.99994, 0.99994, 0.99995, 0.99995, 0.99995},
//                         {0.99995, 0.99995, 0.99996, 0.99996, 0.99996, 0.99996, 0.99996, 0.99996, 0.99997, 0.99997},
//                         {0.99997, 0.99997, 0.99997, 0.99997, 0.99997, 0.99997, 0.99998, 0.99998, 0.99998, 0.99998}  };

// double z = Convert.ToDouble(Console.ReadLine());

// int row = (int)(z * 100) / 10;
// int column = (int)(z * 100) % 10;

// System.Console.WriteLine($"p(Z = {z}) = {zMatrix[row, column]}");


// // Excercise 3:
// int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
// int month = Convert.ToInt16(Console.ReadLine());
// System.Console.WriteLine($"Month {month} have {months[month]} days");


// // Excercise 4:
// System.Console.Write("Cho biết hôm nay là thứ mấy: today = ");
// int currentDay = Convert.ToInt16(Console.ReadLine());
// System.Console.Write("Nhập k: ");
// int k = Convert.ToInt16(Console.ReadLine());
// int nextDay = (currentDay - 1 + k) % 7 + 1;
// System.Console.WriteLine($"Sau {k} ngày là thứ {nextDay}");


// // Excercise 6:
// string[] can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
// string[] chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };

// Console.Write("Nhập năm dương lịch: ");
// int year = Convert.ToInt32(Console.ReadLine());

// string namAmLich = can[year % 10] + " " + chi[year % 12];
// Console.WriteLine($"Năm {year} là năm {namAmLich}");


// // Excercise 7:
// char[] Base = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
// char[] encrypt = { 'X', 'N', 'Y', 'A', 'H', 'P', 'O', 'G', 'Z', 'Q', 'W', 'B', 'T', 'S', 'F', 'L', 'R', 'C', 'V', 'M', 'U', 'E', 'K', 'J', 'D', 'I' };
// char[] decrypt = { 'D', 'L', 'R', 'Y', 'V', 'O', 'H', 'E', 'Z', 'X', 'W', 'P', 'T', 'B', 'G', 'F', 'J', 'Q', 'N', 'M', 'U', 'S', 'K', 'A', 'C', 'I' };

// char c = Convert.ToChar(Console.ReadLine());
// char EncryptChar = '0', DecryptChar = '0';
// for (int i = 0; i < Base.Length; i++)
// {
//     if (Base[i] == c)
//     {
//         EncryptChar = encrypt[i];
//         break;
//     }
// }

// for (int i = 0; i < Base.Length; i++)
// {
//     if (Base[i] == EncryptChar)
//     {
//         DecryptChar = decrypt[i];
//         break;
//     }
// }

// System.Console.WriteLine($"Encrypt: {EncryptChar}\nDecrypt: {DecryptChar}");


// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// int maxNum1 = (a > b ? a : b);
// int maxNum2;
// if (a > b)
// {
//     maxNum2 = a;
// }
// else
// {
//     maxNum2 = b;
// }
// int maxNum3 = Math.Max(a, b);


// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

// int maxNum1 = Math.Max(a, Math.Max(b, c));
// int maxNum2 = ((a > b && a > c) ? a : (b > c ? b : c));

// int[] arr = { a, b, c };
// int maxNum4 = arr.Max();
// System.Console.WriteLine(maxNum4);

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());

// if ((double)a / b > (double)c / d)
// {
//     System.Console.WriteLine($"{a}/{b} > {c}/{d}");
// }
// else if ((double)a / b < (double)c / d)
// {
//     System.Console.WriteLine($"{a}/{b} < {c}/{d}");
// }
// else
// {
//     System.Console.WriteLine($"{a}/{b} = {c}/{d}");
// }


// var brackets = new List<(int limit, double baseTax, double rate)>
// {
//     (80, 18.15, 0.35),
//     (52, 9.75, 0.30),
//     (32, 4.75, 0.25),
//     (18, 1.95, 0.20),
//     (10, 0.75, 0.15),
//     (5, 0.25, 0.10),
//     (0, 0.00, 0.05),
// };

// int income = Convert.ToInt32(Console.ReadLine());

// double totalTaxes = 0;
// foreach (var bracket in brackets)
// {
//     if (income > bracket.limit)
//     {
//         totalTaxes = bracket.baseTax + (income - bracket.limit) * bracket.rate;
//         break;
//     }
// }

// System.Console.WriteLine(totalTaxes);

// float height = Convert.ToSingle(Console.ReadLine());
// float weight = Convert.ToSingle(Console.ReadLine());

// float bmi = weight / height;

// if (bmi < 18.5)
// {
//     System.Console.WriteLine("Gầy");
// }
// else if (bmi < 25)
// {
//     System.Console.WriteLine("Bình thường");
// }
// else if (bmi < 30)
// {
//     System.Console.WriteLine("Thừa cân");
// }
// else if (bmi < 34.9)
// {
//     System.Console.WriteLine("Béo phì độ I");
// }
// else if (bmi < 40)
// {
//     System.Console.WriteLine("Béo phì độ II");
// }
// else
// {
//     System.Console.WriteLine("Béo phì độ III");
// }


// int r1 = Convert.ToInt32(Console.ReadLine());
// int r2 = Convert.ToInt32(Console.ReadLine());

// int d = Convert.ToInt32(Console.ReadLine());


// if (r1 + r2 < d)
// {
//     System.Console.WriteLine("Ngoai nhau");
// }
// else if (r1 + r2 == d)
// {
//     System.Console.WriteLine("Tiep xuc ngoai");
// }
// else if (Math.Abs(r1 - r2) < d)
// {
//     System.Console.WriteLine("Cat nhau");
// }
// else if (Math.Abs(r1 - r2) == d)
// {
//     System.Console.WriteLine("Tiep xuc trong");
// }
// else if (Math.Abs(r1 - r2) > d)
// {
//     System.Console.WriteLine("Dung nhau");
// }
// else
// {
//     System.Console.WriteLine("Dong tam");
// }


// int n = Convert.ToInt32(Console.ReadLine());
// int s = 0;
// for (int i = 1; i <= n; i++)
// {
//     s += i;
// }
// System.Console.WriteLine(s);


// int n = Convert.ToInt32(Console.ReadLine());
// int s = 0;
// for (int i = 1; i <= n; i++)
// {
//     s += (2 * i);
// }
// System.Console.WriteLine(s);


// int n = Convert.ToInt32(Console.ReadLine());
// int s = 0;
// for (int i = 0; i <= n; i++)
// {
//     s += (2 * i + 1);
// }
// System.Console.WriteLine(s);


// int n = Convert.ToInt32(Console.ReadLine());
// double s = 0;
// for (int i = 1; i <= n; i++)
// {
//     s += 1.0 / i;
// }
// System.Console.WriteLine($"{s:F3}");


// int n = Convert.ToInt32(Console.ReadLine());
// double s = 0;
// for (int i = 1; i <= n; i++)
// {
//     s += 1.0 / 2 * i;
// }
// System.Console.WriteLine($"{s:F3}");


// int n = Convert.ToInt32(Console.ReadLine());
// double s = 0;
// for (int i = 0; i <= n; i++)
// {
//     s += 1.0 / (2 * i + 1);
// }
// System.Console.WriteLine($"{s:F3}");


// int n = Convert.ToInt32(Console.ReadLine());
// long s = 1;
// for (int i = 1; i <= n; i++)
// {
//     s *= i;
// }
// System.Console.WriteLine(s);


// int n = Convert.ToInt32(Console.ReadLine());
// int x = Convert.ToInt16(Console.ReadLine());

// long s = 1;
// for (int i = 1; i <= n; i++)
// {
//     s *= x;
// }
// System.Console.WriteLine(s);

// long Factorial(int n)
// {
//     if (n == 0) return 1;
//     return n * Factorial(n - 1);
// }

// long Sum(int n)
// {
//     if (n == 0)
//     {
//         return 1;
//     }
//     return Factorial(n) + Sum(n - 1);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{Sum(n)}");


// long binPow(int x, int n)
// {
//     if (n == 0) return 1;

//     var tmp = binPow(x, n / 2);
//     tmp *= tmp;
//     if (n % 2 == 0)
//     {
//         return tmp;
//     }
//     return tmp * x;
// }

// long solve(int n, int x)
// {
//     if (n == 1)
//         return x;
//     return binPow(x, n) + solve(n - 1, x);
// }

// int x = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(solve(n, x));


// long Factorial(int n)
// {
//     if (n == 0) return 1;
//     return n * Factorial(n - 1);
// }

// long Sum(int n)
// {
//     if (n == 1)
//     {
//         return 2;
//     }
//     return Factorial(2 * n) + Sum(n - 1);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{Sum(n)}");


// long Factorial(int n)
// {
//     if (n == 0) return 1;
//     return n * Factorial(n - 1);
// }

// long Sum(int n)
// {
//     if (n == 0)
//     {
//         return Factorial(1);
//     }
//     return Factorial(2 * n + 1) + Sum(n - 1);
// }

// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{Sum(n)} {Factorial(1) + Factorial(3) + Factorial(5) + Factorial(7)}");


// double solve(int n)
// {
//     if (n == 1)
//     {
//         return Math.Sqrt(2);
//     }
//     return Math.Sqrt(2 + solve(n - 1));
// }

// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"{solve(n):F3}");
//1 1! + 3!
//2 1! + 3! + 5!


// int n = Convert.ToInt32(Console.ReadLine());

// long sum(int n)
// {
//     long s = 1;
//     long p = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         p *= (2 * i + 1) * 2 * i;
//         s += p;
//     }
//     return s;
// }

// Console.WriteLine(sum(n));


// int n = Convert.ToInt32(Console.ReadLine());

// double solve(int n)
// {
//     double s = Math.Sqrt(n);
//     for (int i = n - 1; i >= 1; i--)
//     {
//         s = Math.Sqrt(s + i);
//     }
//     return s;
// }

// Console.WriteLine(solve(n));


// double TongPhanSo(int n)
// {
//     double s = 1;
//     for (int i = 1; i <= n; i++)
//     {
//         s = 1 + 1 / s;
//     }
//     return s;
// }


// int m = Convert.ToInt32(Console.ReadLine());
// int[] arr = { 50, 20, 10, 5, 2, 1 };
// for (int i = 0; i < arr.Length; i++)
// {
//     int t = m / arr[i];
//     if (t > 0)
//     {
//         Console.WriteLine($"{t} to {arr[i]}");
//     }
//     m %= arr[i];
// }


// double[] arr = [4, 5, 5.5, 6.5, 7, 8, 8.5, 10];
// string[] brr = { "F", "D", "D+", "C", "C+", "B", "B+", "A" };
// string[] rank = { "Kem", "Yeu", "Trung binh yeu", "Trung binh", "Trung binh kha", "Kha", "Kha gioi", "Gioi" };

// double gpa = Convert.ToDouble(Console.ReadLine());

// for (int i = 0; i < arr.Length; i++)
// {
//     if (gpa < arr[i])
//     {
//         Console.WriteLine($"{gpa}, diem: {brr[i]}, Xep hang: {rank[i]}");
//         break;
//     }
// }


// double[] arr = [4, 5, 5.5, 6.5, 7, 8, 8.5, 10];
// string[] brr = { "F", "D", "D+", "C", "C+", "B", "B+", "A" };
// string[] rank = { "Kem", "Yeu", "Trung binh yeu", "Trung binh", "Trung binh kha", "Kha", "Kha gioi", "Gioi" };

// double gpa = Convert.ToDouble(Console.ReadLine());

// int i = 0;
// while (gpa >= arr[i++]) ;

// Console.WriteLine($"{gpa}, diem: {brr[i - 1]}, Xep hang: {rank[i - 1]}");


ulong n = Convert.ToUInt64(Console.ReadLine());

int SumOfDigits(ulong n)
{
    int sum = 0;
    while (n != 0)
    {
        sum += (int)(n % 10);
        n /= 10;
    }
    return sum;
}

ulong InverseDigits(ulong n)
{
    ulong res = 0;
    while (n != 0)
    {
        res = res * 10 + n % 10;
        n /= 10;
    }
    return res;
}

bool isPalindromeNumber(ulong n)
{
    string s = n.ToString();
    int l = 0, r = s.Length - 1;
    while (l < r)
    {
        if (s[l] != s[r])
        {
            return false;
        }
        l++;
        r--;
    }
    return true;
}

// Console.WriteLine($"Sum of Digits: {SumOfDigits(n)}");

// Console.WriteLine($"Inverse Digits: {InverseDigits(n)}");

System.Console.WriteLine($"Is palindrome number: {isPalindromeNumber(n)}");