
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add one item, then remove it.
    // Expected Result: Dequeue returns that item.
    // Defect(s) Found: None
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        Assert.AreEqual("A", priorityQueue.Dequeue());
       
    }

    [TestMethod]
    // Scenario: Add multiple items with different priorities.
    // Expected Result: Dequeue returns item with highest priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);
        Assert.AreEqual("High", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Add multiple items with same priority.
    // Expected Result: Dequeue returns first inserted of the highest priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_FIFOWithEqualPriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 10);
        Assert.AreEqual("First", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue.
    // Expected Result: InvalidOperationException thrown.
    // Defect(s) Found: None
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue(); // Should throw
    }

    [TestMethod]
    // Scenario: Add mixed priorities and multiple items.
    // Expected Result: Dequeues in priority order, FIFO within priority.
    // Defect(s) Found: None
    public void TestPriorityQueue_MixedOrderCorrectness()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);  // Low
        priorityQueue.Enqueue("B", 5);  // High
        priorityQueue.Enqueue("C", 5);  // High (same as B, comes after)
        priorityQueue.Enqueue("D", 3);  // Medium

        Assert.AreEqual("B", priorityQueue.Dequeue()); // First highest priority
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Next highest priority (same as B)
        Assert.AreEqual("D", priorityQueue.Dequeue()); // Next: priority 3
        Assert.AreEqual("A", priorityQueue.Dequeue()); // Finally: priority 2
    }
}
