public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value == Data){
            return;
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        //Console.WriteLine($"Current Data Value: {Data}");
        if (value < Data){
            //Console.WriteLine($"{value} is less than {Data}.");
            //Console.WriteLine($"Checking left brach from {Data}");
            if (Left is null){
                //Console.WriteLine("No left branch return false");
                return false;
            }
            else {
                //Console.WriteLine($"Left Branch filled Running Contains funciton again with {Left.Data}");
                return Left.Contains(value);
            }
        }
        else if (value > Data){
            //Console.WriteLine($"{value} is greater than {Data}.");
            //Console.WriteLine($"Checking right brach from {Data}");
            if (Right is null){
                //Console.WriteLine("No right branch return false");
                return false;
            }
            else {
                //Console.WriteLine($"Right Branch filled Running Contains funciton again with {Right.Data}");
                return Right.Contains(value);
            }
        }
        else if (value == Data){
            //Console.WriteLine($"Yay value {value} was found return true");
            return true;
        }
        else{
            //Console.WriteLine($"Value: {value}");
            //Console.WriteLine($"Data: {Data}");
            //Console.WriteLine($"Value {value} is not contained in tree return false");
            return false;
        }
        
    }

    public int GetHeight() {
        // TODO Start Problem 4
        int height = 1;
        if (Right is null && Left is not null){
            return height + Left.GetHeight();
        }
        else if (Left is null && Right is not null){
            return height + Right.GetHeight();
        }
        else if (Left is not null && Right is not null){
            if (Left.GetHeight() < Right.GetHeight()){
                return height + Right.GetHeight();
            }
            else {
                return height + Left.GetHeight();
            }
        }
        else {
            return 1;
        }
    }
}