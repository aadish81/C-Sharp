using System ;

namespace JaggedArray{

    class Program{

        static void Main(){
            
            int[][] array = {
                new int[]{2,3,4,5,6},
                new int[]{1,2,3,4,6,7,8},
                new int[]{1,9,6,4}
            };
            for(int i=0; i<array.Length; i++){
                Console.Write("{ ");
                for(int j=0;j<array[i].Length; j++){
                    Console.Write(array[i][j]+" ");
                    
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }
    }
}