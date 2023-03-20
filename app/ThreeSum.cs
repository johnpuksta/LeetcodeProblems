namespace app
{
    public class ThreeSum {
    public IList<IList<int>> ThreeSumFunction(int[] nums) {
            IList<IList<int>> initialList = new List<IList<int>>();
            var checkVal = 1;
            IList<int> tempList = new List<int>();
            for(int k = 0; k < nums.Length; k++){
                for(int i = 1; i <nums.Length; i++){
                    for(int j = 2; j < nums.Length; j++){
                        checkVal = nums[k] + nums[i] + nums[j];
                        if(checkVal == 0 && k != i && k != j && i != j){
                            tempList = new List<int>(){nums[k],nums[j],nums[i]};
                            initialList.Add(tempList);
                        }
                    }
                }
            }
            var returnList = ListTrim(initialList);
            var t =  returnList.Distinct().ToList();
            return t;
        }
        public IList<IList<int>> ListTrim(IList<IList<int>> lists) {
            IList<IList<int>> _l = new List<IList<int>>();
            IList<IList<int>> _lReturn = new List<IList<int>>();
            foreach(var l in lists){
                List<int> t = l.OrderBy(s => s).ToList();
                _l.Add(t);
            }
            var sorted = _l.OrderBy(s => s[0]).ThenByDescending(s =>s[1]).ThenByDescending(s => s[2]).ToList();
            IList<int> prev = new List<int>(){-1, -1, -1};
            foreach(var _list in sorted){
                if(_list[0] != prev[0] || _list[1] != prev[1] || _list[2] != prev[2] ){
                    _lReturn.Add(_list);
                }
                prev = _list;
            }
            return _lReturn;
        }
    }
}
