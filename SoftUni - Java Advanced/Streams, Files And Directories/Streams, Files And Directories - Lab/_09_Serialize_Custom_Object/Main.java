package lab._09_Serialize_Custom_Object;

import java.io.FileInputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Main
{
    public static void main(String[] args) throws IOException, ClassNotFoundException {

        //Person person = new Person("Ivan", 24);

      //  FileInputStream fos = new FileInputStream("C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\demo");
      //  ObjectOutputStream oos = new ObjectOutputStream(fos);

        //oos.writeObject(person);

        FileInputStream fis = new FileInputStream("C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\resources\\demo");
        ObjectInputStream ois = new ObjectInputStream(fis);

        Person person1 = (Person) ois.readObject();
    }
}
