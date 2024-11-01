package _05_Border_Control;

public class Robot implements Identifiable{
    private String id;
    private String model;

    public Robot(String model, String id) {
        this.setModel(model);
        this.setId(id);
    }
    @Override
    public String getId() {
        return this.id;
    }

    public String getModel() {
        return model;
    }

    private void setModel(String model) {
        this.model = model;
    }
    private void setId(String id) {
        this.id = id;
    }
}
