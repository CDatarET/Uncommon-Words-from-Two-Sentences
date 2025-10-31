public class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        Dictionary<string, int> d = new Dictionary<string, int>();
        string[] arr = (s1 + " " + s2).Split(" ");
        for(int i = 0; i < arr.Length; i++){
            if(d.ContainsKey(arr[i])){
                d[arr[i]]++;
            }
            else{
                d[arr[i]] = 1;
            }
        }

        List<string> list = new List<String>();
        foreach(string x in d.Keys){
            if(d[x] == 1){
                list.Add(x);
            }
        }

        return(list.ToArray());
    }
}
