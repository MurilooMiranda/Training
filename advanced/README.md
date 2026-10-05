# Advanced

The **Advanced** level focuses on solving more complex programming problems that require deeper algorithmic reasoning and a stronger understanding of data structures and algorithms.

The exercises in this stage are designed to be challenging without being excessively theoretical or competitive-programming oriented. They aim to develop skills that are useful for more demanding technical interviews and live coding sessions.

The main topics covered are:

* Trees
* Graphs
* Recursion
* Backtracking
* Dynamic Programming
* Binary Search
* Heaps and Priority Queues
* Hashing
* Greedy Algorithms
* Algorithm Optimization
* Time and Space Complexity

## Exercises

### 1. Binary Search Tree

Implement a Binary Search Tree with operations for insertion, searching, and deletion.

**Main concepts:**

* Binary Search Trees
* Recursion
* Tree traversal
* Searching

### 2. Tree Traversals

Given a binary tree, implement the three main depth-first traversals:

* In-order
* Pre-order
* Post-order

Then implement a breadth-first traversal using a queue.

**Main concepts:**

* Binary Trees
* Recursion
* Stack
* Queue
* DFS
* BFS

### 3. Graph Traversal

Represent a graph using an adjacency list and implement both **Breadth-First Search (BFS)** and **Depth-First Search (DFS)**.

The program should allow searching for a path between two vertices.

**Main concepts:**

* Graphs
* Adjacency lists
* BFS
* DFS
* Stack
* Queue

### 4. Shortest Path

Given a weighted graph, find the shortest path between two vertices.

The program should return both the shortest distance and the path taken.

**Recommended algorithm:** Dijkstra's Algorithm

**Main concepts:**

* Weighted graphs
* Dijkstra
* Priority Queue
* Graph traversal
* Algorithm complexity

### 5. Maze Solver

Given a two-dimensional grid representing a maze, find a path from a starting position to a destination.

For example:

```text
S . . #
# . . #
# # . .
# # # E
```

The program should determine whether a path exists and, if possible, return the path.

**Main concepts:**

* BFS
* DFS
* Graph representation
* Matrix traversal
* Path finding

### 6. Backtracking - N Queens

Given an `N × N` chessboard, place `N` queens so that no two queens can attack each other.

Return at least one valid configuration.

**Main concepts:**

* Backtracking
* Recursion
* Constraint solving
* State management

### 7. Coin Change

Given a set of coin denominations and a target amount, determine the minimum number of coins required to reach that amount.

Example:

```text
Coins: 1 5 10 25
Amount: 36

Output:
4
```

**Main concepts:**

* Dynamic Programming
* Memoization
* Recursion
* Optimization

### 8. Longest Increasing Subsequence

Given an array of integers, find the length of the longest subsequence in which the values are strictly increasing.

Example:

```text
Input:
10 9 2 5 3 7 101 18

Output:
4
```

One possible subsequence is:

```text
2 3 7 101
```

**Main concepts:**

* Dynamic Programming
* Arrays
* Optimization
* Time complexity

### 9. Top K Frequent Elements

Given an array of integers, return the `K` most frequently occurring elements.

Example:

```text
Input:
1 1 1 2 2 3
K = 2

Output:
1 2
```

The solution should be more efficient than repeatedly sorting the entire collection when possible.

**Main concepts:**

* Dictionary
* Hashing
* Heap
* Priority Queue
* Complexity analysis

### 10. LRU Cache

Implement a simplified **Least Recently Used (LRU) Cache**.

The cache should have a fixed capacity and support:

```text
GET key
PUT key value
```

When the cache reaches its capacity, the least recently used item must be removed.

Example:

```text
Capacity: 2

PUT 1 A
PUT 2 B
GET 1
PUT 3 C
```

Since key `2` was the least recently used item, it should be removed.

**Recommended data structures:**

* Dictionary
* Doubly Linked List

**Main concepts:**

* Hashing
* Linked Lists
* Data structure design
* O(1) operations
* State management
* Complexity analysis

## Goal

The goal of this stage is to develop the ability to break down complex problems, select appropriate algorithms and data structures, analyze their efficiency, and implement solutions under the time constraints of technical interviews and live coding sessions.

The exercises should not only be solved, but also revisited to identify opportunities for improving **time complexity, space complexity, readability, and overall design**.
