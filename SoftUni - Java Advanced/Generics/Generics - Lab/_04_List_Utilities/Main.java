package _04_List_Utilities;

import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<Integer> listNumbers = Arrays.asList(20,10,30,60,2,40);
        System.out.println(ListUtils.getMin(listNumbers));
        System.out.println(ListUtils.getMax(listNumbers));
    }
}
