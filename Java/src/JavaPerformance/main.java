package JavaPerformance;

class main {

	/**
	 * @param args
	 */
	public static void main(String[] args) 
	{
        int iterationCount = 5;
        if (args.length > 0)
        {
        	if (isNumeric(args[0]))
        	{
        		iterationCount = Integer.parseInt(args[0]);
        	}
        }
        System.out.println("iterationCount = " + iterationCount);
		
		Tester testRunner = new Tester(iterationCount);
        testRunner.Do();
        testRunner.WriteResult();
	}
	
	public static boolean isNumeric(String input) 
	{
		  try 
		  {
		    Integer.parseInt(input);
		    return true;
		  }
		  catch (NumberFormatException e) 
		  {
		    // s is not numeric
		    return false;
		  }
	}
}
