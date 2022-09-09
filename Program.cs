// See https://aka.ms/new-console-template for more information
//Validation algorithm

    static Boolean IsUppercase(string s){

        return s.All(char.IsUpper);
    }
    Console.WriteLine(IsUppercase("y"));

