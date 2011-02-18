package JavaPerformance.CollectionsTests;

import java.util.concurrent.LinkedBlockingQueue;

import JavaPerformance.SomeTest;

public class QueueInsertRemoveTest extends SomeTest 
{
	 public QueueInsertRemoveTest()
	 {
	     _name = "Queue<int> вставка и удаление элементов";
	     _iterationCount = CollectionTestParams.ListInsertRemoveSize * 2;
	 }
	 
	 @Override
	 public void Do() 
	 {
		 LinkedBlockingQueue<Integer> stack = new LinkedBlockingQueue<Integer>();
         StartTiming();
         try 
         {
        	for (int i = 0; i < _iterationCount; ++i)
        	{
        		stack.put(i);
            } 
         }
         catch (InterruptedException e) 
         {
        	 e.printStackTrace();
         }
         catch (OutOfMemoryError e)
         {
        	 System.out.println("!! Недостаточно памяти для полного теста");
        	 _iterationCount = stack.size();
         }
         
         for (int i = 0; i < stack.size(); ++i)
         {
             @SuppressWarnings("unused")
             int x = stack.poll();             
         }
         StopTiming();
         
         stack.clear();
	 }

}
