// See https://aka.ms/new-console-template for more information
using cohort_csharp;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Threading.Channels;
//linq methodsg

//filtering
//projecting 
//    ordering
//    joining
//    grouping
//    set operators
//    element operators
//    aggreegate operators
//    quantifiers
    //conversion methods
IList<String> wordlist = new List<string>()
{
    "c# course",
    "c++ Tutorial",
    "java course",
    "python course",
    "swift course",
    "Flutter Tutorial",
    "kotlin Tutorial"
};
//query synthax
var result = from s in wordlist
             where s.Contains("Tutorial")
             select s;
foreach (var word in result)
    Console.WriteLine(word);


filtering Filtering = new filtering();
Filtering.WhereValue();
Projection.SelectValue();
////Projection.SelectSetOpaerator();
//ElementOperator.ElementMethod();