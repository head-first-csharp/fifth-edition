string[] myArray = new string[] {
    "first in line",
    "second in line",
    "third in line",
    "last in line",
};

Queue<string> myQueue = new Queue<string>(myArray);
List<string> myList = new List<string>(myQueue);
Stack<string> anotherStack = new Stack<string>(myList);

Console.WriteLine($@"myQueue has {myQueue.Count} items
myList has {myList.Count} items
anotherStack has {anotherStack.Count} items");