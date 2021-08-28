# Prime Numbers

An application that takes numeric input (N) from a user and outputs a multiplication table of (N) prime numbers.

The requirements:

- This exercise must be written in C# using the .NET Core v2 or higher framework
- Write your application with high unit test coverage
- For the input and output you can use the console, a web page, or something else
- Please write an algorithm to solve the prime number generation - do not use a library method to generate your primes
- The user should input a whole number N, where is N is at least 1
- The application should output an N+1 x N+1 grid of numbers

Implementation:

- This program generates the prime numbers for a input number N.
- It prints the multiplication table of (N) prime numbers similar to matrix format.
- Sample output for N=5:

 -| 2 | 3 | 5 | 7 | 11
--|---|---|---|---|----
2 | 4 | 6 | 10| 14| 22
3 | 6 | 9 | 15| 21| 33
5 | 10| 15| 25| 35| 55
7 | 14| 21| 35| 49| 77
11| 22|33 | 55| 77| 121

- Console output for N = 5:

![image](https://user-images.githubusercontent.com/13997274/131222094-961746f1-1ceb-4439-bb29-45776c0f9037.png)

 - NUnit is used for unit testing.
 - Multiplication table generated in a HelperFunctions so it can be used for unit testing as well.
 - HashSet used to store prime numbers because the list of primes always going to be unique and it is also faster than List.
