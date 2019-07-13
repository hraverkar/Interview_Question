Container with Most Water
Given n non-negative integers a_1, a_2, ..., a_n  where each represents a point at coordinate  (i, a_i) . ‘ n ‘ 
vertical lines are drawn such that the two endpoints of line i is at  (i, a_i)  and (i, 0).
Find two lines, which together with x-axis forms a container, such that the container contains the most water.

The program should return an integer which corresponds to the maximum area of water that can be contained
( maximum area instead of maximum volume sounds weird but this is 2D plane we are working with for simplicity ).



Example - 
Input [1,5,4,3]
Output - 6

5 and 3 are distance apart 4;
size of the base is 4 ;
height of Container = 4*3=12;

input - { 3, 1, 2, 4,5,9 }
3 and 9  are distance apart 5
size of the base is 5 ;
height of Constaineer is 5*3 = 15;

