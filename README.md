# CSharp-Problems

You are designing a compiler for a C++ program and need to check that braces in any given file are balanced.

 

Braces in a string are considered to be balanced if the following criteria are met:

All braces must be closed. Braces come in pairs of the form (), {} and [].  The left brace opens the pair, and the right one closes it. 
In any set of nested braces, the braces between any pair must be closed. 
 

For example, [{}] is a valid grouping of braces but [}]{} is not.

 

Function Description 

Complete the function braces in the editor below. The function must return an array of strings where the string at each index i denotes whether or not the braces were balanced in a valuesi.  The array should consist of strings "YES" or "NO" aligned with their indexes in values.

 

braces has the following parameter(s):

    values[values0,...valuesn-1]:  an array of strings to analyze

 

Constraints

1 ≤ n ≤ 15
1 ≤ length of valuesi ≤ 100
It is guaranteed that each valuesi consists of (, ), {, }, [, and ] only.
Input Format For Custom Testing
Input from stdin will be processed as follows and passed to the function:

 

The first line contains an integer n, the number of elements in values.

Each of the next n lines contains a string describing valuesi where 0 ≤ i < n.

Sample Case 0
 

Sample Input For Custom Testing

2
{}[]()
{[}]}
 

Sample Output

YES
NO
 

Explanation

values0: {}[]() meets the criteria for a balanced string, so index 0 in our return array should contain the string YES.

values1: {[}]} contains unmatched braces between a matched pair in the substrings [}, {[}, and [}], so index 1 in our return array should contain the string NO.
