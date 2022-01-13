package types;

import java.io.Serializable;

public class Tovar  implements Serializable {

    private int id;
    private String name;

    private int count;

    private int price;

    public Tovar() {

        this.id=0;
        this.name = "";

        this.count = 0;

        this.price = 0;

    }

    public Tovar(int id, String name, int count, int price) {
        this.id=id;
        this.name = name;
        this.count = count;
        this.price = price;

    }
    public Tovar(String name, int count,int price)
    {
        this.count=count;
        this.name=name;
        this.price=price;
    }
    public int getId(){
        return id;
    }

    public int getCount() {

        return count;

    }

    public void setCount(int kol) {

        this.count = kol;

    }

    public String getName() {

        return name;

    }

    public void setName(String name) {

        this.name = name;

    }

    public int getPrice() {

        return price;

    }

    public void setPrice(int price) {

        this.price = price;

    }
    public  double getSumm()
    {
        return count*price;
    }

}
