package JavaPerformanceTest;

import java.util.Random;

public class DoubleRandomTest extends SomeTest
{
    public DoubleRandomTest()
    {
        _name = "Генерация случайных чисел double";
    }

    private Random rnd = new Random();
    
    @Override
    public  void Do()
    {
        StartTiming();
        for (int i = 0; i < 100000000; ++i)
        {
            @SuppressWarnings("unused")
			double x = rnd.nextDouble();
        }
        StopTiming();
    }
}
