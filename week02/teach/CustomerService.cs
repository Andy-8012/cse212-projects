/*
 * CSE212 
 * (c) BYU-Idaho
 * 04-Teach - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */

/// <summary>
/// Maintain a Customer Service Queue.  Allows new customers to be 
/// added and allows customers to be serviced.
/// </summary>
public class CustomerService {
    public static void Run() {
        // Example code to see what's in the customer service queue:
        // var cs = new CustomerService(10);
        // Console.WriteLine(cs);

        // Test Cases
        var customerService = new CustomerService(0);
        // Test 1
        // Scenario: If the max size of the queue is less than or equal to 0 
        //           Default the max size to 10
        // Expected Result: 10
        Console.WriteLine("Test 1");
        Console.WriteLine(customerService._maxSize);
        // Defect(s) Found: No defects found

        Console.WriteLine("=================");

        // Test 2
        // Scenario: Using the AddNewCutsomer function should place a new
        //           customer into the queue
        // Expected Result: [size=3 max_size=3 => (Name, Account ID : Problem)]
        //                  This should be equal to what you inputed in the console
        Console.WriteLine("Test 2");
        customerService = new CustomerService(3);

        for (int i = 0; i < customerService._maxSize; i++){
            // in the console 
            customerService.AddNewCustomer();
        }

        Console.WriteLine(customerService.ToString());
        // Defect(s) Found: No defects found Add them to the queue properly

        Console.WriteLine("=================");

        // Add more Test Cases As Needed Below

        // Test 3
        // Scenario: Add one more customer over the max size to get an error message
        // Expected Result: An error message is displayed.

        Console.WriteLine("Test 3");
        customerService = new CustomerService(3);

        //This for loop will run AddNewCustomer function One more time over
        //the max size limit
        for (int i = 0; i <= customerService._maxSize; i++){
            // in the console answer the prompts
            customerService.AddNewCustomer();
        }

        // Defect(s) Found: Doesn't print an error message adds them to the queue
        // over the max size

        Console.WriteLine("=================");

        // Test 4
        // Scenario: Dequeue the next customer from the que and display the details
        // Expected Result: (Name 1 (ID): Problem), (Name 2 (ID): Problem), (Name 3 (ID): Problem)

        Console.WriteLine("Test 4");
        // We will be using the queue created in test 3

        //Create a for loop that uses the size of the que to serve each customer
        int customerQueueSize = customerService._queue.Count;
        for (int i = 0; i < customerQueueSize; i++){
            customerService.ServeCustomer();
        }

        // Defect(s) Found: Doesn't print out the first name in the list because it
        // removes it from the queue then prints out the next name.

        Console.WriteLine("=================");

        // Test 5
        // Scenario: Displays an error message when trying to serve a customer
        //           When the queue is empty
        // Expected Result: Error message is displayed saying no customer in queue.

        Console.WriteLine("Test 5");
        customerService = new CustomerService(1);

        //Create a for loop that uses the size of the que to serve each customer
        //Add one to test what happens when serving an empty queue
        customerQueueSize = customerService._queue.Count + 1;
        for (int i = 0; i < customerQueueSize; i++){ 
            customerService.ServeCustomer();
        }

        // Defect(s) Found: Donesn't print an error message states there is
        //                  an unhandled exception.
    }

    private readonly List<Customer> _queue = new();
    private readonly int _maxSize;

    public CustomerService(int maxSize) {
        if (maxSize <= 0)
            _maxSize = 10;
        else
            _maxSize = maxSize;
    }

    /// <summary>
    /// Defines a Customer record for the service queue.
    /// This is an inner class.  Its real name is CustomerService.Customer
    /// </summary>
    private class Customer {
        public Customer(string name, string accountId, string problem) {
            Name = name;
            AccountId = accountId;
            Problem = problem;
        }

        private string Name { get; }
        private string AccountId { get; }
        private string Problem { get; }

        public override string ToString() {
            return $"{Name} ({AccountId})  : {Problem}";
        }
    }

    /// <summary>
    /// Prompt the user for the customer and problem information.  Put the 
    /// new record into the queue.
    /// </summary>
    private void AddNewCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count >= _maxSize) {
            Console.WriteLine("Maximum Number of Customers in Queue.");
            return;
        }

        Console.Write("Customer Name: ");
        var name = Console.ReadLine()!.Trim();
        Console.Write("Account Id: ");
        var accountId = Console.ReadLine()!.Trim();
        Console.Write("Problem: ");
        var problem = Console.ReadLine()!.Trim();

        // Create the customer object and add it to the queue
        var customer = new Customer(name, accountId, problem);
        _queue.Add(customer);
    }

    /// <summary>
    /// Dequeue the next customer and display the information.
    /// </summary>
    private void ServeCustomer() {
        // Verify there is room in the service queue
        if (_queue.Count <= 0) {
            Console.WriteLine("There are no Customers in the queue");
            return;
        }

        var customer = _queue[0];
        Console.WriteLine(customer);
        _queue.RemoveAt(0);
    }

    /// <summary>
    /// Support the WriteLine function to provide a string representation of the
    /// customer service queue object. This is useful for debugging. If you have a 
    /// CustomerService object called cs, then you run Console.WriteLine(cs) to
    /// see the contents.
    /// </summary>
    /// <returns>A string representation of the queue</returns>
    public override string ToString() {
        return $"[size={_queue.Count} max_size={_maxSize} => " + String.Join(", ", _queue) + "]";
    }
}