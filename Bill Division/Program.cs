int b = 7;
int k = 1;
var bill = new List<int> { 3, 10, 2, 9 };

var billTotal = bill.Sum();

if ((billTotal / 2) == bill[k])
    Console.WriteLine("Bon Appetit");
else if (((billTotal - bill[k]) / 2) == b)
    Console.WriteLine("Bon Appetit");
else
    Console.WriteLine(bill[k] / 2);
