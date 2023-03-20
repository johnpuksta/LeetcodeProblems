namespace app
{
    public class ThreeSumClosest {
        public int ThreeSumClosestFunction(int[] nums, int target) {
        int prevVal = 10000;
        if(target < 0){
            for(int k = 0; k < nums.Length; k++){
                for(int i = 1; i <nums.Length; i++){
                    for(int j = 2; j < nums.Length; j++){
                        if(k != i && i != j && k != j){
                            int checkVal = nums[k] + nums[i] + nums[j];
                            if(checkVal == target){
                                return checkVal;
                            }
                            else if((checkVal + target) < prevVal){
                                prevVal = checkVal;
                            }                            
                            }
                        }

                    }
                }
        }
        else{      
            for(int k = 0; k < nums.Length; k++){
                for(int i = 1; i <nums.Length; i++){
                    for(int j = 2; j < nums.Length; j++){
                        if(k != i && i != j && k != j){
                            int checkVal = nums[k] + nums[i] + nums[j];
                            if(checkVal == target){
                                return checkVal;
                            }
                            else if((Math.Abs(checkVal - target)) < prevVal && checkVal > prevVal){
                                prevVal = checkVal;
                            }                            
                            }
                        }

                    }
                }

        }
        return prevVal;   
        }  
    }
}