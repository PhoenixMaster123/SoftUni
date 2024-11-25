package Structural_Pattern.Composite_Pattern;

// Composite design pattern
// When we need to implement tree structure like a file system.
public class Main {
    public static void main(String[] args) {
        File fileA = new File();
        File fileB = new File();
        File fileC = new File();

        Folder root = new Folder();
        Folder folderB = new Folder();

        folderB.addComponent(fileB);
        folderB.addComponent(fileC);

        root.addComponent(fileA);
        root.addComponent(folderB);

        System.out.println(root.getSize());
    }
}
