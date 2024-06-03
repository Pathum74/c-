using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {   
        int n1,n2,ans;
        char op;
       
        
        Console.WriteLine ("n1");
        n1=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine ("n2");
        n2=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter given letter for calcuation\n+ = A\n- = B\n/ = C \n* = D ");
        op=Convert.ToChar(Console.ReadLine());
        
        switch (op) 
        {
            case 'A' :
            ans=n1+n2;
            Console.WriteLine("Answer is "+ans);
            
            break;
            
            case 'B' :
            ans=n1-n2;
            Console.WriteLine("Answer is "+ans);
            
            break;
            
            case 'C' :
            
             if(n2 !=0)
             {
                 ans=n1/ n2;
            Console.WriteLine("Answer is "+ans);
             }
             else {
                 Console.WriteLine("Cannot divide by zero");
             }
            
            break;
            
            case 'D' :
            ans=n1*n2;
            Console.WriteLine("Answer is "+ans);
            
            break;
            
            default :
            Console.WriteLine("Wrong input");
            
            break;
            
        }
        Console.ReadLine();
    }
}
