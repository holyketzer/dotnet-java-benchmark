package Test;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Random;

class random_test {

	/**
	 * @param args
	 */
	public static void main(String[] args) 
	{
		Random rnd = new Random();
        int totalLoop = 10;        
        int randomTime = 0;
        int listAddTime = 0;
        
		for (int total = 0; total < totalLoop; ++total)
        {			
			long start = System.currentTimeMillis();
			/*
			for (int i = 0; i < 100000000; ++i)
	        {
				double x = rnd.nextDouble();
	        }
			start = System.currentTimeMillis() - start;
			randomTime += start;
			*/
			
			start = System.currentTimeMillis();
			LinkedList<Integer> list = new LinkedList<Integer>(); 
			//ArrayList<Integer> list = new ArrayList<Integer>();
            for (int i = 0; i < 100000; ++i)
            {
                list.add(i);
            }
            while (list.size() > 0)
            {
                list.remove(0);
            }
            start = System.currentTimeMillis() - start;
            listAddTime += start;       			
        }
		System.out.println("random test = " + randomTime / totalLoop + " ms.");
		System.out.println("list<int> add test = " + listAddTime / totalLoop + " ms.");
	}

}
