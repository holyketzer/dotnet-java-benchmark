package JavaPerformance.CollectionsTests;

import java.util.Stack;

import JavaPerformance.SomeTest;

public class StackInsertRemoveTest extends SomeTest 
{
    public StackInsertRemoveTest()
    {
        _name = "Stack<int> вставка и удаление элементов";
        _iterationCount = CollectionTestParams.ListInsertRemoveSize * 20;
    }
    
	@Override
	public void Do() 
	{
		 Stack<Integer> stack = new Stack<Integer>();
         StartTiming();
         try
         {
	         for (int i = 0; i < _iterationCount; ++i)
	         {
	             stack.push(i);
	         }
         }
         catch (OutOfMemoryError e)
         {
        	 System.out.println("!! Недостаточно памяти для полного теста");
        	 _iterationCount = stack.size();
         }
         
         for (int i = 0; i < stack.size(); ++i)
         {
             @SuppressWarnings("unused")
             int x = stack.pop();
         }
         StopTiming();
         
         stack.clear();
	}
}
