package JavaPerformance.StringConversionsTests;

import JavaPerformance.SomeTestRunner;

public class StringConversionsTestRunner extends SomeTestRunner 
{
	@Override
	protected void InitTests() 
	{
		_name = "Строковые преобразования";

        _tests.add(new IntParseTest());
        _tests.add(new FloatParseTest());
        _tests.add(new DoubleParseTest());
        _tests.add(new IntToStringTest());
        _tests.add(new FloatToStringTest());
        _tests.add(new DoubleToStringTest());
        _tests.add(new StringConcatTest());
        _tests.add(new StringBuilderConcatTest());
        _tests.add(new StringSubstringTest());
        _tests.add(new StringBuilderRemoveTest());
        _tests.add(new StringReplaceTest());
        //_tests.add(new StringBuilderReplaceTest());
	}
}
