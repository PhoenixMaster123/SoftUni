package Demo;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.*;

class CalculatorTest {

    @Test
    public void whenSumTwoAndTwo_thenExpectResultFour() {
        int a = 2;
        int b = 2;

        int resultSum = Calculator.sum(a, b);

        assertEquals(4, resultSum);
    }
    @Test
    public void whenSumEightAndTwo_thenExpectResultTen() {
       assertEquals(10, Calculator.sum(8, 2));
    }

    @ParameterizedTest
    @MethodSource("calculatorParameters")
    public void whenSumTwoNumbers_thenCorrectResult(int a, int b, int expectedResult) {

        int actualResult = Calculator.sum(a, b);

        assertEquals(expectedResult, actualResult);

    }
    public static Stream<Arguments> calculatorParameters() {
        return Stream.of(Arguments.of(2, 2, 4),
                         Arguments.of(4, 4, 8),
                         Arguments.of(10, 20, 30));
    }

}