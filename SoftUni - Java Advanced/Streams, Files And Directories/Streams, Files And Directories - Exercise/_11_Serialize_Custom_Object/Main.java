package exercise._11_Serialize_Custom_Object;

import java.io.*;

public class Main
{
    public static void main(String[] args)
    {
        String path = "C:\\Users\\krisi\\OneDrive\\Desktop\\Informatik\\SoftUni\\Java - Advanced2\\Streams, Files and Directories\\Streams Files and Directories\\src\\Resources-Exercises\\course.ser";

        // with new keyword we allocate little memory in the heap
        Course course = new Course("S", 300);
        // When read -> deserialization | write -> serialization
        try(ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream(path));
            ObjectInputStream ois = new ObjectInputStream(new FileInputStream(path)))
        {
            // serialization:
            oos.writeObject(course);
            course.setStudents(350);
            // deserialization:
            Object obj = ois.readObject();
            // If I'm not sure what kind of object it is:
            if(obj instanceof Course)
            {
                Course deserialization = (Course) obj;
                System.out.println(deserialization.getStudents()); // answer: 300 (we save the behavior of the object when is created)
            }

        }
        catch (IOException | ClassNotFoundException e)
        {
            e.printStackTrace();
        }

    }
}
