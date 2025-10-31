class Solution:
    def uncommonFromSentences(self, s1: str, s2: str) -> List[str]:
        c = Counter((s1 + " " + s2).split())
        ret = []
        for x in c:
            if c[x] == 1:
                ret.append(x)
        
        return ret
