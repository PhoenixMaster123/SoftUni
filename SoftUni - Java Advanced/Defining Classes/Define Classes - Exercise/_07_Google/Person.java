package exercise._07_Google;

import java.util.ArrayList;
import java.util.List;

public class Person {
    private String personName;
    private List<Parent> parentList;
    private List<Child> childList;
    private Company company;
    private List<Pokemon> pokemonList;
    private Car car;

    public Person(String personName) {
        this.personName = personName;
        pokemonList = new ArrayList<>();
        parentList = new ArrayList<>();
        childList = new ArrayList<>();
    }

    public String toString() {
        StringBuilder builder = new StringBuilder();
        builder.append(personName).append("\n");

        builder.append("Company:\n");
        if(this.company != null)
        {
            builder.append(company.getCompanyName()).append(" ")
                    .append(company.getCompanyDepartment()).append(" ")
                    .append(String.format("%.2f", company.getSalary())).append("\n");
        }
        builder.append("Car:\n");
        if(this.car != null)
        {
            builder.append(car.getCarModel()).append(" ")
                    .append(car.getCarSpeed()).append("\n");
        }
        builder.append("Pokemon:\n");
        if(this.pokemonList != null)
        {
            for (Pokemon pokemon : this.pokemonList) {
                builder.append(pokemon).append("\n");
            }
        }
        builder.append("Parents:\n");

        if(this.parentList != null)
        {
            for (Parent parent : parentList) {
                builder.append(parent).append("\n");
            }
        }
        builder.append("Children:\n");

        if(this.childList != null)
        {
            for (Child child : childList) {
                builder.append(child).append("\n");
            }
        }
        return builder.toString();
    }
    public void addPokemon(Pokemon pokemon) {
        pokemonList.add(pokemon);
    }
    public void addParent(Parent parent) {
        parentList.add(parent);
    }
    public void addChild(Child child) {
        childList.add(child);
    }
    public void setCompany(Company company) {
        this.company = company;
    }


    public Car getCar() {
        return car;
    }

    public void setCar(Car car) {
        this.car = car;
    }
}
