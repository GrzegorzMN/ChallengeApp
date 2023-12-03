var number = 48885999920;
var numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

var count0 = 0;
var count1 = 0;
var count2 = 0;
var count3 = 0;
var count4 = 0;
var count5 = 0;
var count6 = 0;
var count7 = 0;
var count8 = 0;
var count9 = 0;


foreach (char c in letters)
{
    if (c == '0') count0 = count0 + 1;
    else if (c == '1') count1 = count1 + 1;
    else if (c == '2') count2 = count2 + 1;
    else if (c == '3') count3 = count3 + 1;
    else if (c == '4') count4 = count4 + 1;
    else if (c == '5') count5 = count5 + 1;
    else if (c == '6') count6 = count6 + 1;
    else if (c == '7') count7 = count7 + 1;
    else if (c == '8') count8 = count8 + 1;
    else if (c == '9') count9 = count9 + 1;
}

Console.WriteLine("Wyniki dla liczby: " + number);
Console.WriteLine("0 => " + count0);
Console.WriteLine("1 => " + count1);
Console.WriteLine("2 => " + count2);
Console.WriteLine("3 => " + count3);
Console.WriteLine("4 => " + count4);
Console.WriteLine("5 => " + count5);
Console.WriteLine("6 => " + count6);
Console.WriteLine("7 => " + count7);
Console.WriteLine("8 => " + count8);
Console.WriteLine("9 => " + count9);