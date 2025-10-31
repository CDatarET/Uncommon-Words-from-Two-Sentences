class Solution {
    public String[] uncommonFromSentences(String s1, String s2) {
        HashMap<String, Integer> map = new HashMap<String, Integer>();
        String[] arr = (s1 + " " + s2).split(" ");
        for(int i = 0; i < arr.length; i++){
            map.put(arr[i], map.getOrDefault(arr[i], 0) + 1);
        }

        ArrayList<String> list = new ArrayList<String>();
        for(String x : map.keySet()){
            if(map.get(x) == 1){
                list.add(x);
            }
        }

        return(list.toArray(new String[0]));
    }
}
