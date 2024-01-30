
string original = "abcde FGHIJ ABC abc DEFG   ";

string s1 = original.ToUpper();
string s2 = original.ToLower();
string s3 = original.Trim();

int n1 = original.IndexOf("bc");
int n2 = original.LastIndexOf("bc");

string s4 = original.Substring(3);
string s5 = original.Substring(3, 5);

string s6 = original.Replace('a', 'x');
string s7 = original.Replace("abc", "xy");

bool b1 = String.IsNullOrEmpty(original);
bool b2 = String.IsNullOrWhiteSpace(original);
Console.WriteLine("Original: " + original);
Console.WriteLine("ToUpper: " + s1);

Console.WriteLine("Original: " + original);
Console.WriteLine("ToLower: " + s2);

Console.WriteLine("Original: " + original);
Console.WriteLine("Trim: " + s3);

Console.WriteLine("IndexOf('bc'): " + n1);
Console.WriteLine("IndexLastOf('bc'): " + n2);

Console.WriteLine("SubString: " + s4);
Console.WriteLine("SubString: " + s5);
Console.WriteLine("Replace: " + s6);
Console.WriteLine("Replace: " + s7);

Console.WriteLine("String Is null or Empty: " + b1);
Console.WriteLine("String Is null or Empty: " + b2);