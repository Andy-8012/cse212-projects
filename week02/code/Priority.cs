/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Use the Enqueue function to make sure item and priority are added
        // Expected Result: [apple (Pri:2), Pinapple (Pri:5), Banana (Pri:1)]
        Console.WriteLine("Test 1");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Pinapple", 5);
        priorityQueue.Enqueue("Banana", 1);

        Console.WriteLine(priorityQueue);

        // Defect(s) Found: No defects found works properly

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Use the Dequeue function to remove the item with the highest priority
        // Expected Result: Pinapple
        //                  [Apple (Pri:2), Banana (Pri:1)]
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Pinapple", 5);
        priorityQueue.Enqueue("Banana", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Didn't remove the item from the list.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Two items with the same priority. Remove the Item that came in first
        // Expected Result: Orange
        //                  [Apple (Pri:2), Pinapple (Pri:5), Banana (Pri:1)]
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Apple", 2);
        priorityQueue.Enqueue("Orange", 5);
        priorityQueue.Enqueue("Pinapple", 5);
        priorityQueue.Enqueue("Banana", 1);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue);
        // Defect(s) Found: Removed the last item that was added to the queue instead of the first.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: No items in the queue
        // Expected Result: prints "The queue is empty.
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();

        priorityQueue.Dequeue();
        // Defect(s) Found: Works properly no defects found.
    }
}