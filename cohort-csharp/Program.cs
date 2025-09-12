// See https://aka.ms/new-console-template for more information
using cohort_csharp;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Threading.Channels;

//What i learnt in freecodecamp
 //Console.Write
 //literal values
 //escape sequences
 //camel case  pascal case  snake case
 //@directive
 //string interpolation
 //pemdas
 //casting
// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

Console.WriteLine("           Total sum of scores of each student      ");
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);

decimal sophiaScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahScore = (decimal)zahirahSum / currentAssignments;
decimal jeongScore = (decimal)jeongSum / currentAssignments;

Console.WriteLine("\t\tStudent\tAverage\tScore and Grade\n\t\t");
Console.WriteLine($"Sophia:\t {sophiaScore}; Grade : \tA");
Console.WriteLine($"nicolas: {nicolasScore}; Grade : \tB");
Console.WriteLine($"Zahirah: {zahirahScore}; Grade : \tB");
Console.WriteLine($"jeong:\t {jeongScore}; Grade : \tA");





































////icollection
////ilist
////list

//List<string> WordList = new List<string>();
//WordList.Add("Cup");
//WordList.Add("Jotter");
//WordList.Add("Bag");
//WordList.Add("KeyHolder");
//WordList.Add("Mirror");

////foreach(var data in WordList)
////{
////    Console.WriteLine(data);
////}
//static void CollectionMethod(ICollection model)
//{

//}
//static void IListMethod(IList model)
//{

//}

//static void ListMethod(IList model)
//{

//}

//static void IenumerableMethod(IEnumerable model)
//{

//}
