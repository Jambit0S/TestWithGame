package service.endpoint;

import java.rmi.RemoteException;
import java.util.ArrayList;
import java.util.List;
import javax.jws.WebMethod;
import javax.jws.WebService;

import groovy.util.ObservableList;
import operation.TovarOperationImpl;
import types.ListOfTovar;
import types.Tovar;

@WebService()

public class TovarService {
    static TovarOperationImpl obj;
    static {
        try {
            obj = new TovarOperationImpl();
        } catch (RemoteException e) {
            e.printStackTrace();
        }
    }

    @WebMethod()

    public ListOfTovar getAllTovar(){
        ListOfTovar lstRet = null;

       List<Tovar> lst = null;
        try {
            lst = obj.getListOfTovar();
        } catch (RemoteException e) {
            e.printStackTrace();
        }

        if(lst != null){
            lstRet = new ListOfTovar();
            lstRet.setItem(lst);
        }
        return lstRet;
    }

    @WebMethod()

    public ListOfTovar setNewTovar(Tovar tovar){
        ListOfTovar lstRet = null;
        List<Tovar> lst = null;
        try {
            lst = obj.addNewTovar(tovar);
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        if(lst != null){
            lstRet = new ListOfTovar();
            lstRet.setItem(lst);
        }
        return lstRet;
    }

    @WebMethod()
    public int getSumOfTovar(){
        try {
            return obj.getSumOfTovar();
        } catch (RemoteException e) {
            e.printStackTrace();
        }
        return -1;
    }

    @WebMethod
    public boolean CheckUser(String log, String Pas)
    {
        System.out.println("Check User Data");
        List<String>UserLogs=new ArrayList<>();
        List<String>UserPass=new ArrayList<>();
        UserLogs.add("Admin");
        UserPass.add("Pass");
        for(String UserLOg: UserLogs) {
            System.out.println(UserLOg);
            if(log.equals(UserLOg))
            {
                for(String UserPas:UserPass)
                {
                    if (Pas.equals(UserPas)) {
                        System.out.println(UserPas);
                        return true;
                    }
                }
            }
        }
        return false;
    }

}
