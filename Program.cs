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
Console.Write($"And Your IELTS Category of ");

switch(Math.Round(overall)){
    case 5: Console.WriteLine("Modest");break;
    case 6: Console.WriteLine("Competent");break;
    case 7: Console.WriteLine("Good");break;
    case 8: Console.WriteLine("Very Good");break;
    case 9: Console.WriteLine("Expert");break;

    default: Console.WriteLine("Below or above that range is Invalid");break;
}
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

