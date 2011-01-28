package JavaPerformance.RandomTests;

import java.util.Random;

import JavaPerformance.SomeTest;

public class IntRandomTest extends SomeTest
{
    public IntRandomTest()
    {
        _name = "Генерация случайных чисел int";
        _iterationCount = RandomTestParams.count;
    }

    private Random rnd = new Random();

    @Override    
    public void Do()
    {
        StartTiming();
        for (int i = 0; i < _iterationCount; ++i)
        {
            @SuppressWarnings("unused")
			int x = rnd.nextInt();
        }
        StopTiming();            
    }
}