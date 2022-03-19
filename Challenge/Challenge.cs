using System;
    public class Challenge {
        public static List<string> ProcessCollection(string searchCriteria, IEnumerable<string> collection) {
            var answer = new List<string>();
            foreach(var str in collection) {
                if(str.IndexOfAny(searchCriteria.ToCharArray()) > -1) {
                    answer.Add(str);
                }
            }
            return answer;
        }
    }

