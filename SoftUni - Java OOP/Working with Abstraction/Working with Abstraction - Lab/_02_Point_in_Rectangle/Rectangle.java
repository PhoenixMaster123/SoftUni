package _02_Point_in_Rectangle;

public class Rectangle {
    private Point bottomLeft;
    private Point topRight;

    public Rectangle(Point bottomLeft, Point topRight) {
        this.bottomLeft = bottomLeft;
        this.topRight = topRight;
    }
    public boolean contains(Point point) {
        return this.bottomLeft.getX() <= point.getX() &&
                this.topRight.getX() >= point.getX() &&
                this.bottomLeft.getY() <= point.getY() &&
                this.topRight.getY() >= point.getY();
    }
}
