package AddForm;

import javafx.collections.transformation.TransformationList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Alert;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.stage.Stage;
import service.endpoint.UserServiceService;
import sun.rmi.runtime.Log;
import types.User;

import java.net.URL;
import java.util.ResourceBundle;

public class AddFormController implements Initializable {

    @FXML
    private TextField LoginBox;
    @FXML
    private TextField PasswordBox;
    @FXML
    private TextField FirNameBox;
    @FXML
    private TextField SecNameBox;
    @FXML
    private TextField PatrBox;
    @FXML
    public void ButtonAddUser(ActionEvent event) {
        if(LoginBox.getText().length()>0 ||PasswordBox.getText().length()>0 ||FirNameBox.getText().length()>0|| SecNameBox.getText().length()>0) {
            System.out.println("correct input");
            UserServiceService userService = new UserServiceService();
            userService.getUserServicePort().setNewUser(new User(
                    LoginBox.getText(),
                    PasswordBox.getText(),
                    FirNameBox.getText(),
                    SecNameBox.getText(),
                    PasswordBox.getText(),
                    PatrBox.getText()));
            ((Stage)(((Button)event.getSource()).getScene().getWindow())).close();
        }
        else
        {
            System.out.println("wrong input");
            Alert alert=new Alert(Alert.AlertType.INFORMATION);
            alert.setTitle("Message");
            alert.setHeaderText("Введите данные корректно");
            alert.showAndWait();
        }

    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle) {
        initData();
    }
    private void initData()
    {}
}
