using System;
bool isSuccess = true;

while(isSuccess){


Console.WriteLine("Welcome IELTS Band Score Calculator\nPlease enter your score");
Console.Write("Listening Score: ");
double listening = Convert.ToDouble(Console.ReadLine());
Console.Write("Writing Score: ");
double writing = Convert.ToDouble(Console.ReadLine());
Console.Write("Reading Score: ");
double reading = Convert.ToDouble(Console.ReadLine());
Console.Write("Speaking Score: ");
double speaking = Convert.ToDouble(Console.ReadLine());

double overall = (listening+writing+reading+speaking)/4;
double butun = Math.Floor(overall);
double qoldiq = overall-butun;


if(qoldiq < 0.25){
    overall = butun;
}
else if((qoldiq >=0.25 && qoldiq < 0.75) || qoldiq >= 0.75){
    overall = butun + 0.5;
}
Console.WriteLine($"Your Overall Band Score {overall}");
Console.WriteLine("Do you want to continue? Yes (y) / No (n)");
string text = Console.ReadLine().ToLower();
if(text == "yes" || text == "y"){
    isSuccess = true;
}
else
{
    isSuccess = false;
}
}
