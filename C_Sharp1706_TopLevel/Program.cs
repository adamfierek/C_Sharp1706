Console.WriteLine("Hello, World!");


var x = 11;

if (x % 2 == 2)
{

}
else
{

}

var y = x % 2 == 2 ? "Yes" : "No";

string str = null;

var z = str ?? "str is null";

void WriteText(string txt)
{
    Console.WriteLine(txt);
}

for (var p = 0; p <= 120; p++)
{
    switch (p)
    {
        case 0: Console.WriteLine("Zero"); break;
        case < 10:
            {

                WriteText("Less than 10"); 
                break;
            }
        case > 100 when p % 2 == 0: Console.WriteLine("More than 100 and dividable by 2"); break;
        default: Console.WriteLine("Another value"); break;
    }
}

var j = 0;

while (j <= 10)
{
    Console.WriteLine($"While: {j}");
    j++;

}

var k = 0;

do
{
    Console.WriteLine($"Do-While: {k}");
    k++;
}
while (k <= 10);


var fruits = new List<string>
{
    "Apple", "Orange", "Banana"
};

foreach (var fr in fruits)
{
    Console.WriteLine($"Foreach: {fr}");
}

var number = 100;


var result = number switch
{
    > 100 => "More than 100",
    < 100 => "Less than 100",
    _ => "Equals 100"
};

var queue = new Queue<int>();

queue.Enqueue(8);
queue.Enqueue(5);

//...

var nextItem = queue.Dequeue();
var peek = queue.Peek();


var dict = new Dictionary<int, string>();

dict.Add(0, "Zero");
dict.Add(1, "One");
dict.Add(2, "Two");
dict.Add(3, "Three");

var fruit = fruits[0];

var two = dict[2];

var allResult = fruits.All(f => f.Length < 20);
var anyResult = fruits.Any(f => f.Length > 5);

var maxResult = fruits.Max(f => f.Length);
var maxByResult = fruits.MaxBy(f => f.Length);


int i = 5;
float f = 5.5f;
double d = 10.5;
string s1 = "1100";
string s2 = "True";
bool b = false;

var s2i = Convert.ToInt32(s1);

var s2i2 = int.Parse(s1);

var parseResult = int.TryParse(s1, out var s2i3);

var d2i = (int)d;

var i2d = (double)i;

var a = 5;
var c = 10;

double divResult = (double)a / c;

fruits.ForEach(ProcessFruit);

void ProcessFruit(string f)
{
    Console.WriteLine($"Fruit from List.ForEach: {f}");
}