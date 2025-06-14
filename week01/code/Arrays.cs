public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step-by-step plan:
        // 1. Create an array of size `length` to store the multiples.
        // 2. Use a loop from 0 to length - 1.
        // 3. In each loop iteration, calculate the multiple: number * (i + 1)
        //    and store it in the array.
        // 4. Return the array after the loop completes.
          double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // I replaced this return statement with my own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // Step-by-step plan:
        // 1. Understand that rotating to the right means shifting the last `amount` elements to the front.
        // 2. Use List slicing:
        //    a. Get the last `amount` items using GetRange.
        //    b. Get the remaining items at the beginning.
        // 3. Clear the original list and then:
        //    a. Add the last `amount` items.
        //    b. Add the beginning part of the list.
        // 4. Since lists are dynamic, we modify the original list in-place.

        // Get the last `amount` elements
        List<int> endSlice = data.GetRange(data.Count - amount, amount);

        // Get the beginning elements (everything except the last `amount`)
        List<int> startSlice = data.GetRange(0, data.Count - amount);

        // Clear and rebuild the list
        data.Clear();
        data.AddRange(endSlice);
        data.AddRange(startSlice);
    }
}
