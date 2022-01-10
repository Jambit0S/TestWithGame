package operation;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.util.ArrayList;
import java.util.List;

import groovy.util.ObservableList;
import types.Tovar;

public class TovarOperationImpl extends UnicastRemoteObject implements TovarOperation {
    static List<Tovar> lstTovar = new ArrayList<Tovar>();

    static{
        lstTovar.add(new Tovar(0,"Товар1", 10, 100));
        lstTovar.add(new Tovar(1,"Товар2", 20, 200));
        lstTovar.add(new Tovar(2,"Товар3", 30, 300));
        lstTovar.add(new Tovar(3,"Товар4", 40, 400));
        lstTovar.add(new Tovar(4,"sds",1,13));
    }

    @Override
    public List<Tovar> getListOfTovar() throws RemoteException{
        System.out.println("Get list of tovar");
        return lstTovar;
    }

    @Override
    public List<Tovar> addNewTovar(Tovar item)throws RemoteException{
        System.out.println("Add new tovar");
        //lstTovar.add(item);
        int count=Count();
        //System.out.print(count);
        lstTovar.add(new Tovar(count,item.getName(),item.getCount(),item.getPrice()));
        return lstTovar;
    }
    @Override
    public int getSumOfTovar()throws RemoteException{
        System.out.println("Print summ of tovar");
        int sum = 0;
        for(Tovar tovar: lstTovar)
            sum += tovar.getCount() * tovar.getPrice();
        return sum;

    }


    public int Count()
    {
        int number=0;
        for(Tovar tovar:lstTovar)
        {
            number++;
        }
        return number;
    }
    public void Print()
    {
        for (Tovar tovar:lstTovar)
        {
            System.out.println("id "+tovar.getId());
            System.out.println("name "+tovar.getName());
        }
    }
    public String getMessage() throws RemoteException {

        return "Сообщение от сервера";

    }
    public TovarOperationImpl () throws RemoteException {
    }

}
