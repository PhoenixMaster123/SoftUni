package _02_Generic_Array_Creator;

import java.lang.reflect.Array;

public class ArrayCreator {

    // When is our methods are static:
    // {access_modifier} static {generic_parameter} {return_type} {name}() {}
    public static<T> T[] create (int length, T item) {

        //T[] array = new T[length]; // wrong, the compiler doesn't know if there is a (default constructor?)
       // newInstance → creates a new array from a given class
        T[] array = (T[]) Array.newInstance(item.getClass(), length); // if we don't know the type
        // int[] numbers = (int[]) Array.newInstance(Integer.class, length);

        for (int i = 0; i < length; i++) {
            array[i] = item;
        }
        return array;
    }

    public static<T> T[] create (Class<T> _class, int length, T item) {
        T[] array = (T[]) Array.newInstance(_class, length);

        for (int i = 0; i < length; i++) {
            array[i] = item;
        }
        return array;
    }
}
