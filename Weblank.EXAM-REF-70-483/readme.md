# Chapter 1: Manage program flow
## Objective 1.1: Implement multithreading and asynchronus Processing

1. You have a lot of items that need to be processed. For each item, you need to perform a complex calculation. Which technique should you use?
A. You create a Task for each item and then wait until all tasks are finished.
B. You use Parallel.For to process all items concurrently.
C. You use async/await to process all items concurrently.
D. You add all items to a BlockingCollection and process them on a thread created by the Thread class.

2. You are creating a complex query that doesn’t require any particular order and you want to run it in parallel. Which method should you use?
A. AsParallel
B. AsSequential
C. AsOrdered
D. WithDegreeOfParallelism

3. You are working on an ASP.NET application that retrieves some data from another web    
server and then writes the response to the database. Should you use async/await?
A. No, both operations depend on external factors. You need to wait before they are finished.
B. No, in a server application you don’t have to use async/await. It’s only for responsiveness on the client.
C. Yes, this will free your thread to serve other requests while waiting for the I/O to complete.
D. Yes, this put your thread to sleep while waiting for I/O so that it doesn’t use any CPU.