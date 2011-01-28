package JavaPerformance.RandomTests;

import java.util.Random;

import JavaPerformance.SomeTest;

public class DoubleRandomTest extends SomeTest
{
    public DoubleRandomTest()
    {
        _name = "Генерация случайных чисел double";
        _iterationCount = RandomTestParams.count;
    }

    private Random rnd = new Random();
    
    @Override
    public  void Do()
    {
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			double x = rnd.nextDouble();
        }
        StopTiming();
    }
}
