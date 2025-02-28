//https://dotnettutorials.net/lesson/groupby-multiple-keys-in-linq/
using Linq.Model;
using Linq.Helper;
using System.Collections;
using System.Diagnostics;
using System.Reflection.Emit;




int num = 34555;
//char[] strval= (num.ToString()).ToCharArray();
//string rev="";
//for (int i = str.Length-1; i >=0; i--)
//{
//    rev += strval[i];
//    Console.WriteLine(i.ToString());
//}
var val = num.ToString().ToCharArray().Select(ch => ch.ToString()).Aggregate<string>((xs, x) => x + xs);
var val2 = num.ToString().ToCharArray().Select(ch => ch.ToString()).GroupBy(ch => ch.ToString()).ToList().ToDictionary(x=>x.Key.ToString(),x=>x.Count()).ToList();


string str = "pooja";
var reversedValue = str.ToCharArray()
                         .Select(ch => ch.ToString())
                         .Aggregate<string>((xs, x) => x + xs);
var lst=str.ToArray().GroupBy(x=>x).Where(y=>y.Key=='o' || y.Key=='a').ToDictionary(x=>x.Key.ToString(),x=>x.Count()).ToList();

Joins obj =new Joins();














