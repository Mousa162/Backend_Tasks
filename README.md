# Backend_Tasks
Here we are going to provide the tasks for the course 



int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");
1. why the output of this Equation = $30.00?
Because: (:C) is a currency format so {X} -> indicates 10 and {Y} -> indicates 20 so the result will be 30.00$ as a currency format and if we put the (:C) outside the brackets it will consider it as a string 
2. what is its benefit?
It is beneficial if u are building a website that deals with money finance and so on 
3. try another example with a different specifier with a screenshot of the output.
           int X = 1000000;
            int Y = 2500000;
            Console.WriteLine($"Equation: {X} + {Y} = {X + Y:N}");
(:N) it helps to make the number more readable  
