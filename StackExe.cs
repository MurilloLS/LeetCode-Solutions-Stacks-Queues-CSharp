//1614. Maximum Nesting Depth of the Parentheses

namespace DaySix
{
  public class StackExe
  {
    int MaxDepth(string s)
    {
      Stack<char> stack = new();
      int maxDepth = 0;

      foreach (char item in s)
      {
        if (item == '(')
        {
          stack.Push(item);
          maxDepth = Math.Max(maxDepth, stack.Count);
        }
        if (item == ')')
        {
          stack.Pop();
        }
      }
      return maxDepth;
    }
  }
}