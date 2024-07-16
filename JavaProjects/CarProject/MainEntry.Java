

public class MainEntry {

    
    public static void main(String[] args) {
        Car myObj = new Car("Lambo", 1990, "Zentro");
        myObj.DisplayInformation();
        String myObjName = myObj.getName();
        System.out.println(myObjName);
        System.out.println(myObj.getYear());
        for (int i = 0; i < 5; i++) {
            System.out.println(myObj.getName());
        }
        myObj.setName("Car");
        System.out.println(myObj.getName());
        System.out.println("Hello World!");
    
    }

}



public class Car {

    private String name;
    private int year;
    private String model;


    public String getName() {
        return name;
    }

    public void setName(String newname) {
        this.name = newname;
    }

    public int getYear() {
        return year;
    }

    public void setYear(int year) {
        this.year = year;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String newmodel) {
        this.model = newmodel;
    }


    public Car(String Name, int Year, String Model) {
        name = Name;
        year = Year;
        model = Model;
    }

    public void DisplayInformation(){
        System.out.println("This car name is " + name + " and the year is " + year + " and the model is " + model);
    }

    
}

