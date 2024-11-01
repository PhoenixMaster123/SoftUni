package _03_Random_Array_List;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class RandomArrayList<Т> extends ArrayList<Т> {

    List<Т> objectList = new ArrayList<>();
    Random random;
    public Object getRandomElement() {
        int index = this.random.nextInt(super.size());
        Object element = super.get(index);
        super.remove(element);
        return element;
        //return super.get(random.nextInt(objectList.size() - 1) + 1);
    }
}
