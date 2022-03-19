// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
var data = new List<SAI>() {
    new SAI() { 
        SearchCriteria = "bh",
        Input = new List<string>() { "abc", "def", "ghi", "jkl", "mno" },
        Answer = new List<string>() { "abc", "ghi" },
        Result = true 
    },
        new SAI() { 
        SearchCriteria = "13579",
        Input = new List<string>() { "a1c", "d2f", "g3i", "j4l", "m5o" },
        Answer = new List<string>() { "a1c", "g3i", "m5x" },
        Result = true 
    }

};
foreach(SAI sai in data) {
    // get answers from user code
    var answer = Challenge.ProcessCollection(sai.SearchCriteria, sai.Input).ToList();
    // if the number of user answers differ from actual; it is an error
    if(answer.Count != sai.Answer.Count) {
        sai.Result &= false;
        continue;
    }
    // sort the user and actual answers so easier to match-up
    sai.Answer.Sort();
    answer.Sort();
    for(var idx = 0; idx < sai.Answer.Count; idx++) {
        if(!sai.Answer[idx].Equals(answer[idx])) {
            sai.Result &= false;
        }
    }
    System.Console.WriteLine($"Test {sai.Id} {(sai.Result ? "Passed" : "Failed")}");
}
// check if all the tests passed
var overallPassFail = true;
foreach(SAI sai in data) {
    overallPassFail &= sai.Result;
}
System.Console.WriteLine($"The Code - {(overallPassFail ? "Passed" : "Failed")}");