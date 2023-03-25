// Ввести строку из которой выдернуть в отдельный массив элементы строки меньше или равных 3 символам
Console.WriteLine("Please enter line: ");
string Line = (Console.ReadLine());
string[] words = Line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int LengthString = words.Length;
int i=0;
string[] NewArray = new string[LengthString];
for (i=0; i<LengthString; i++)
 {
if (words[i].Length <=3)
    {
        NewArray[i]=words[i];
        

    }
 }
