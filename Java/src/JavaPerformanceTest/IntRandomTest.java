package JavaPerformanceTest;

import java.util.Random;

public class IntRandomTest extends SomeTest
{
    public IntRandomTest()
    {
        _name = "Генерация случайных чисел int";
    }

    private Random rnd = new Random();

    @Override    
    public void Do()
    {
        StartTiming();
        for (int i = 0; i < 100000000; ++i)
        {
            @SuppressWarnings("unused")
			int x = rnd.nextInt();
        }
        StopTiming();            
    }
}