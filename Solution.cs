namespace _9.CyclicRotation
{
    /*Se da una matriz A que consta de N enteros. La rotación de la matriz significa que cada elemento se 
    desplaza hacia la derecha en un índice, y el último elemento de la matriz se mueve al primer lugar. 
    Por ejemplo, la rotación de la matriz A = [3, 8, 9, 7, 6] es [6, 3, 8, 9, 7] (los elementos se desplazan 
    hacia la derecha un índice y 6 se mueven al primer lugar).
    El objetivo es rotar la matriz AK veces; es decir, cada elemento de A se desplazará a los K tiempos correctos. */
    public class Solution
    {
        public int[] solution(int[] A, int K){

            int vueltas = K;
            int[] array1 = A;
            int[] result;

            for(int i=0; i<vueltas; i++){

                result = new int[5]; 
                result[0]=array1[array1.Length-1];

                for(int i1=1; i1<result.Length; i1++){
                    result[i1]=array1[i1-1];
                }
                               

                if(i==vueltas-1){
                    return result;
                }else{
                    array1 = result; 
                }
            }
             return A;   
        }
    }
}