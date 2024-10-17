//this code takes a string number as a argument and 
//outputs the largest number that can be made with it's integers
using System;
public class Program{
    public static int maxIndex(string s){
        int len=s.Length;
        int maxindex=0;
        for(int i=1;i<len;i++){
            if(s[i]>s[maxindex]){maxindex=i;}
        }
    return maxindex;}
    //up is good
    
    public static string maxString(string s){
        int len=s.Length;
        int count=0;
        string result=String.Empty;
        while(count<len){
            int maxindex=maxIndex(s);
            result+=s[maxindex];
            string newS=String.Empty;
            for(int i=0;i<maxindex;i++){newS+=s[i].ToString();}
            for(int i=maxindex+1;i<len-count;i++){newS+=s[i].ToString();}
            s=newS;
            count+=1;
        }
    return result;}
    public static void Main(string[] args){
        
        string number="13791234";
        maxnumber=maxString(number);
        Console.Write(maxnumber);
    }
}
