package _02_Library;
import java.util.ArrayList;
import java.util.List;

public class Book {
    private String title;
    private int year;
    private List<String> authors;

    //private List<String> authors2 = new ArrayList<>(); → That's equal like in the constructor

    public Book(String title, int year, String... authors) {
        setTitle(title);
        setYear(year);
        setAuthors(authors);
    }

    public String getTitle() {
        return this.title;
    }
    public int getYear() {
        return this.year;
    }
    public List<String> getAuthors() {
        return this.authors;
    }

    private void setTitle(String title) {
        this.title = title;
    }
    private void setYear(int year) {
        this.year = year;
    }
    private void setAuthors(String... authors) {
        this.authors = new ArrayList<>();
        for (String author : authors) {
            this.authors.add(author);
        }
    }
}
