package base;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.ButtonType;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.input.MouseEvent;
import service.endpoint.UserServiceService;
import types.User;

import javax.jws.soap.SOAPBinding;
import java.net.URL;
import java.util.ResourceBundle;

import service.endpoint.UserService;


public class Controller implements Initializable {
    public TableColumn UserFirstName;
    public TableColumn UserSecondName;
    public TableColumn UserPatronomic;
    public TableColumn UserLogin;
    public TableColumn UserPassword;
    public TableColumn UserCustomization;

    private ObservableList<User> users = FXCollections.observableArrayList();

    @FXML
    private TableView<User> tableView = new TableView<User>();

    @FXML
    void ButtonAdd()
    {
        System.out.println("add");
        //UserServiceService userService = new UserServiceService();
        //userService.getUserServicePort().setNewUser(new User("a","a","a","a","a","a"));
        StartProgram.OpenAddUserForm();

    }
    @FXML
    void ButtonUpdate()
    {
        System.out.println("update");
        users.clear();
        initData();
        //StartProgram.OpenAddUserForm();
    }
    @Override
    public void initialize(URL url, ResourceBundle resourceBundle)
    {
        System.out.println("Init data");
        UserFirstName.setCellValueFactory(new PropertyValueFactory<User,String>("firstname"));
        UserSecondName.setCellValueFactory(new PropertyValueFactory<User,String>("secondname"));
        UserPatronomic.setCellValueFactory(new PropertyValueFactory<User,String>("patronomic"));
        UserLogin.setCellValueFactory(new PropertyValueFactory<User,String>("login"));
        UserPassword.setCellValueFactory(new PropertyValueFactory<User,String>("password"));
        UserCustomization.setCellValueFactory(new PropertyValueFactory<User,String>("customization"));
        tableView.setItems(users);
        initData();
    }
    private void initData()
    {
        UserServiceService userService = new UserServiceService();
        int i=1;
        for(User user: userService.getUserServicePort().getAllUsers().getItem()){
            User a = new User(user.getId(), user.getLogin(),user.getPassword(),user.getFirstname(),user.getSecondname(),user.getPatronomic(),user.getCustomization());
            users.add(a);
            //System.out.println(a.getFirstname());
            i++;
        }

    }


    public void ClickedCell(MouseEvent mouseEvent) {
        User buffUser = (tableView.getSelectionModel().getSelectedItem());
        if(mouseEvent.getClickCount()==2 && buffUser!=null)
        {
            //System.out.println("clcik");

            Alert alert = new Alert(Alert.AlertType.INFORMATION);
            alert.setTitle("Удалить?");
            alert.setHeaderText("Данный пользователь будет удален");
            //alert.setContentText("I have a great message for you!");
            alert.showAndWait().ifPresent(rs -> {
                if (rs == ButtonType.OK) {
                    System.out.println("User is deleted");
                    UserServiceService userService = new UserServiceService();
                    userService.getUserServicePort().deleteUser(buffUser.getId());
                    ButtonUpdate();
                }

            });
            //System.out.println(buffUser.getId());
        }
    }
}
