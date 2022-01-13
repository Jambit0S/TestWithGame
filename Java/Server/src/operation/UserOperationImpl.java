package operation;

import types.User;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;

public class UserOperationImpl extends UnicastRemoteObject implements UserOperation
{
    static List<User> userList = new ArrayList<User>();

   /* static
    {
        userList.add(new User(1,"ds","ds","ds","ds","ds","ds"));
    }*/

    @Override
    public List<User>getListOfUser() throws RemoteException
    {
        System.out.println("Get list of Users");
        userList.clear();
        //System.out.print(users);
        try {
            Class.forName("org.postgresql.Driver");
            Connection conn = DriverManager.getConnection("jdbc:postgresql://localhost:5432/mydatabase", "postgres", "admin");
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery("SELECT * FROM myuser");
            while (rs.next())
            {
                User pr = new User();
                pr.setId(rs.getInt("id"));
                pr.setLogin(rs.getString("login"));
                pr.setPassword(rs.getString("password"));
                pr.setFirstname(rs.getString("name"));
                pr.setSecondname(rs.getString("secondname"));
                //System.out.println(pr.getId());
                pr.setPatronomic(rs.getString("patronomic"));

                userList.add(pr);
            }
            //res.setText(sum.toString());
        } catch (SQLException | ClassNotFoundException e) {
            e.printStackTrace();
        }
        return  userList;
    }
    @Override
    public List<User> addNewUser(User item) throws RemoteException
    {
        try {
            System.out.println("Add new User");
            Class.forName("org.postgresql.Driver");
            Connection conn = DriverManager.getConnection("jdbc:postgresql://localhost:5432/mydatabase", "postgres", "admin");
            PreparedStatement st = conn.prepareStatement("INSERT INTO myuser (login,password,name,secondname,patronomic,customization) VALUES (?,?,?,?,?,?)");
            st.setString(1, item.getLogin());
            st.setString(2, item.getPassword());
            st.setString(3, item.getFirstname());
            st.setString(4, item.getSecondname());
            st.setString(5, item.getPatronomic());

            //JSONObject obj= new JSONObject();
            st.setNull(6, 0);
            userList.add(item);
            boolean execute=st.execute();
            System.out.println("User is added");
            return userList;
        }catch (SQLException | ClassNotFoundException e) {
            System.out.print("SQL ERROR");
            e.printStackTrace();
        }
        return userList;
    }
    @Override
    public List<User> deleteUser(int id) throws RemoteException
    {
        try {
            System.out.println("Add new User");
            Class.forName("org.postgresql.Driver");
            Connection conn = DriverManager.getConnection("jdbc:postgresql://localhost:5432/mydatabase", "postgres", "admin");
            PreparedStatement st = conn.prepareStatement("DELETE FROM myuser WHERE id="+id);
            //st.setInt(1, id);
            boolean execute=st.execute();
            System.out.println("User with id="+id+" is deleted");
            return userList;
        }catch (SQLException | ClassNotFoundException e) {
            System.out.print("SQL ERROR");
            e.printStackTrace();
        }
        return userList;
    }
    public String getMessage() throws RemoteException {
        return "Сообщение от сервера";

    }
    public UserOperationImpl() throws RemoteException{}
}
