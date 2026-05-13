using System.Text;

Console.WriteLine("--- Section 1: Basic string operations ---");
string s = "Hello, World!";
Console.WriteLine($"Length: {s.Length}");
Console.WriteLine($"Char at 7: {s[7]}");
Console.WriteLine($"IndexOf 'o': {s.IndexOf('o')}");
Console.WriteLine($"LastIndexOf 'o': {s.LastIndexOf('o')}");
Console.WriteLine($"Contains \"World\": {s.Contains("World")}");
Console.WriteLine($"Upper: {s.ToUpper()}");
Console.WriteLine($"Lower: {s.ToLower()}");
Console.WriteLine($"Replace World->C#: {s.Replace("World", "C#")}");
Console.WriteLine($"Substring(7, 5): {s.Substring(7, 5)}");

string s1 = "   spaced   ";
Console.WriteLine($"Trim: {s1.Trim()}");






Console.WriteLine();
Console.WriteLine("--- Section 2: Split + Join ---");

string csv = "apple,banana,cherry,date,elderberry";

Console.WriteLine($"Split: {string.Join(" ", csv.Split(","))}");
Console.WriteLine($"Joined with ' | ': {string.Join(" | ", csv.Split(","))}");

string sentence = "the quick brown fox jumps";

Console.WriteLine($"Word count: {sentence.Split(" ").Length}");
Console.WriteLine($"Joined with '-': {string.Join("-", sentence.Split(" "))}");






Console.WriteLine();
Console.WriteLine("--- Section 3: Character operations ---");

string mixed = "a1B2c3D4";
foreach(char c in mixed){
    if(char.IsLetter(c)){
        if(char.IsUpper(c))
            Console.WriteLine($"{c}: letter, uppercase");
        else
            Console.WriteLine($"{c}: letter, lowercase");
    }
    else{
        Console.WriteLine($"{c}: digit");
    } 
}

foreach(char c in mixed){
    if(char.IsDigit(c)){
            Console.WriteLine($"{c} -> {c - '0'}");
    }
}





Console.WriteLine();
Console.WriteLine("--- Section 4: StringBuilder ---");

StringBuilder sb = new();
for(int i =0; i< 10; i++){
    if(i> 0) sb.Append(",");
    sb.Append(i);
}

Console.WriteLine($"StringBuilder result: {sb}");
Console.WriteLine($"string.Join result: {string.Join(",", Enumerable.Range(0,10))}");




Console.WriteLine();
Console.WriteLine("--- Section 5: Reverse string ---");
s = "hello";

Console.WriteLine($"LINQ reverse: {new string(s.Reverse().ToArray())}");
char[] charArray = s.ToCharArray();
for(int i = 0, j= charArray.Length - 1; i<j; i++, j--){
    (charArray[i], charArray[j]) = (charArray[j], charArray[i]);
}
Console.WriteLine($"Manual reverse: {new string(charArray)}");



Console.WriteLine();
Console.WriteLine("--- Section 6: Parse + ToString ---");

string numStr = "42";
int num = 99;

Console.WriteLine($"Parsed \"42\": {int.Parse(numStr)}");
Console.WriteLine($"TryParse \"abc\": success={int.TryParse("abc", out int val)}, value={val}");
Console.WriteLine($"ToString 99: {num.ToString()}");



