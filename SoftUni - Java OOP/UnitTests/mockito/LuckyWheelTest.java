package mockito;

import org.junit.jupiter.api.Test;
import org.mockito.Mockito;

import java.util.Random;

import static org.junit.jupiter.api.Assertions.*;

class LuckyWheelTest {

    @Test
    public void whenRisk5MoneyAndLuckyNumberIs100_thenWin500Money() {

        // mock objects are easy to manipulate
        Random random = Mockito.mock(Random.class);
        LuckyWheel luckyWheel = new LuckyWheel(random);

        Mockito.when(random.nextInt()).thenReturn(100);

        int win = luckyWheel.riskAndWin(5);
        assertEquals(500, win);
    }
    @Test
    public void whenRisk5MoneyAndLuckyNumberIs2_thenWin10Money() {

        // mock objects are easy to manipulate
        Random random = Mockito.mock(Random.class);
        LuckyWheel luckyWheel = new LuckyWheel(random);

        Mockito.when(random.nextInt()).thenReturn(2);

        int win = luckyWheel.riskAndWin(5);
        assertEquals(10, win);
    }
    @Test
    public void whenRisk5MoneyAndLuckyNumberIsThen2And100_thenLose1Money() {

        // mock objects are easy to manipulate
        Random random = Mockito.mock(Random.class);
        LuckyWheel luckyWheel = new LuckyWheel(random);

        Mockito.when(random.nextInt()).thenReturn(33);

        int win = luckyWheel.riskAndWin(5);
        assertEquals(4, win);
    }

}