package rpg_lab;

import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

class AxeTest {
    @Test
    void whenTheDurabilityPointsAreTenAndAttack_thenPointsWillBeReducedWithOne() {
        Axe axe = new Axe(2, 10);

        axe.attack(new Dummy(5,5));

        assertEquals(9, axe.getDurabilityPoints());
    }
    @Test
    void whenTheDurabilityPointsAreZeroAndAttack_thenItWillThrowAnIllegalStateException() {
        Axe axe = new Axe(2, 0);


        assertThrows(IllegalStateException.class, () -> axe.attack(new Dummy(5,5)));
    }
}