using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Delete{

        static void Main(string[] args){
            string text = "Строка Админ удалил привет Инструменты новый инструментарий про Строка котиков привет";
            string[] words = new string[]{"Строка","привет","Инструменты"};
            foreach (var word in words)
            {
                text = text.Replace(word,"");
            }
           
           
            Nums sum = new Nums ();
            Medians res = new Medians ();
            Reversing rev = new Reversing ();
            rev.ReverseString();
            res.Median();
            sum.NumsRes();
        
        }
       
    }

     class Reversing{
         public void ReverseString() {
            string[] res = {"h","e","l","l","o"};
            Array.Reverse(res);
           
         }

    }   

    

    class Medians{
        
        public double Median(){

            int[] nums1 = {1,3};
            int[] nums2 = {2};
            int[] concat = nums1.Concat(nums2).ToArray();
            Array.Sort(concat);
            if(concat.Length%2!=0){
                return concat[concat.Length/2];
            }else{
                return (concat[concat.Length/2] + concat[concat.Length/2 - 1])/2d  ;
            }

            
        }
        

    }


    class Nums {

        public int NumsRes(){
            string[] nums = {"777","7","77","77"};
            string target = "7777";
            int res = 0;

            for(int i = 0; i < nums.Length;i++){
                for(int j = 0;j < nums.Length; j++){
                    if(j == i) continue;
                    if(target == (nums[i] + nums[j])){
                        res++;
                    } 
                }
            }
            Console.WriteLine(string.Join("",res));
            return res;
        }
    }
    
}