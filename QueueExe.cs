//1700. Number of Students Unable to Eat Lunch - Leetcode

namespace DaySix
{
  public class QueueExe {
    public int CountStudents(int[] students, int[] sandwiches) {
        Queue<int> studentQueue = new Queue<int>(students);
        int sandwichIndex = 0;
        int attempts = 0; 

        while (studentQueue.Count > 0 && attempts < studentQueue.Count)
        {
            if (studentQueue.Peek() == sandwiches[sandwichIndex])
            {
                studentQueue.Dequeue();
                sandwichIndex++;
                attempts = 0;
            }
            else
            {
                int student = studentQueue.Dequeue();
                studentQueue.Enqueue(student);
                attempts++;
            }
        }
        return studentQueue.Count;
    }
}
}