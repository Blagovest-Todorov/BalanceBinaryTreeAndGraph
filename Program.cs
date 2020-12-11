using System;
using System.Collections.Generic;
using System.Collections.Generic;

namespace _23.BalancedBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
           // the balanced Binary Tree is sorted 
           // balanced binary tree are hard to implemetn, hard to write algorithm to search them effectively
           //  AVL -Trees -> perfectly balanced! , very complex ,slow operatons--insert, find, delete take 2 log(n)-fast the speed of operations
           // Red -black tree -> roughly balancerd, more simple --twice faster than AVL  Tree; / black  search, find, insert, delete -lon(n)
           // AA -Tree -relatively simple to implement, not well balances, simpletin implement
           // most used are reb-balck tree 
           // B-trees are binary tree with additional properties--are optimised with memory and hardware--work faster than other trees;
           //trees-each child has only one parent !
           //Graphs-- each child have more than one parent !
           // in a tree form one node to another node there is exactly one rout, 
           // in a graph from one node to anoher You have many roads 
           //in graphs --predecessors - parents, 
           // in graphs successors = chiildren 
           // directed graph --there is a direction of movement of node to node, as one way street
           // non-directed, no-directed, underected =graph --no direction form movement is determinde, --as two way-street/

            //weighted graph--the values of elements movements have a priority 
            //in a graph the node is called- > vertex !
            //edge ->  is the connection between two nodes ; A -----B 
            // directed --one way movement, undercted--two way movement -in both directions! // wighted/ unweighted 
            // Example of graphs -> road network in a Country, 
            // internet network, - > 
        }
       
    }
    public class Graph
    {
        int[][] childNodes;
        public Graph(int[][] nodes)   // Jagged Array , array of arrays , each row has a diffeen number of elmements,  this is not recatangle matrix
        {
            this.childNodes = nodes;
        }
        Graph g = new Graph(new int[][]
        {
         new int[]{3,6 },  // successor of vertice 0
         new int[]{2, 3, 4, 5, 6 },  // successor of vertice 1
         new int[]{1, 4 , 5 }, // successor of vertice 2
         new int[]{0, 1, 5}, // successor of vertice 3
         new int[]{1, 2 , 6 }, // successor  of vertive  4
         new int[]{1, 2 , 3 },  // successor of vertice 5
         new int[]{0, 1, 4} // successor of vertice 6;
        });

    }
}
