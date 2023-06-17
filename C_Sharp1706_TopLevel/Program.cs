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

for (var i = 0; i <= 120; i++)
{
    switch (i)
    {
        case 0: Console.WriteLine("Zero"); break;
        case < 10:
            {

                Console.WriteLine("Less than 10"); 
                break;
            }
        case > 100 when i % 2 == 0: Console.WriteLine("More than 100 and dividable by 2"); break;
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


var fruits = new string[]
{
    "Apple", "Orange", "Banana"
};

foreach (var fruit in fruits)
{
    Console.WriteLine($"Foreach: {fruit}");
}


