package service.endpoint;

import javax.jws.WebMethod;
import javax.jws.WebService;
import java.rmi.RemoteException;
import java.util.List;
import java.util.ArrayList;

import operation.UserOperationImpl;
import types.ListOfUsers;
import types.User;

@WebService
public class UserService {
    static UserOperationImpl obj;
    static
    {
        try {
            obj=new UserOperationImpl();
        }catch (RemoteException e){
            e.printStackTrace();
        }
    }
    @WebMethod()
    public ListOfUsers getAllUsers()
    {
        ListOfUsers userList=null;
        List<User> bufferList =null;
        try
        {
            bufferList=obj.getListOfUser();
        }
        catch (RemoteException e)
        {
            e.printStackTrace();
        }
        if(bufferList!=null)
        {
            userList=new ListOfUsers();
            userList.setItem(bufferList);
        }
        return userList;
    }
    @WebMethod()
    public ListOfUsers setNewUser(User user)
    {
        ListOfUsers userList=null;
        List<User> bufferList =null;
        try
        {
            bufferList=obj.addNewUser(user);
        }
        catch (RemoteException e)
        {
            e.printStackTrace();
        }
        if(bufferList!=null)
        {
            userList=new ListOfUsers();
            userList.setItem(bufferList);
        }
        return userList;

    }
    @WebMethod()
    public ListOfUsers deleteUser (int id)
    {
        ListOfUsers userList=null;
        List<User> bufferList =null;
        try
        {
            bufferList=obj.deleteUser(id);
        }
        catch (RemoteException e)
        {
            e.printStackTrace();
        }
        if(bufferList!=null)
        {
            userList=new ListOfUsers();
            userList.setItem(bufferList);
        }
        return userList;

    }

}
