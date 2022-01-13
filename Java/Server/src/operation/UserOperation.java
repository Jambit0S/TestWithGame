package operation;

import java.rmi.Remote;
import java.rmi.RemoteException;
import java.util.List;

import types.User;

public interface UserOperation extends Remote {
    List<User> getListOfUser() throws RemoteException;
    List<User> addNewUser(User item) throws  RemoteException;
    List<User> deleteUser(int id) throws  RemoteException;

}
