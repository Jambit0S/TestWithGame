package LogIn;

import AddForm.AddFormMain;
import ClientTypes.ClientTovar;
import base.StartProgram;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.stage.Stage;
import service.endpoint.TovarServiceService;

import java.awt.*;
import java.net.URL;
import java.util.ResourceBundle;

public class LogInController implements Initializable {
    public TextField MyTextField1;
    public TextField MyTextField2;

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle)
    {
        System.out.println("init");

        
    }

    public void CheckUser(ActionEvent actionEvent) {
        TovarServiceService tovarService = new TovarServiceService();
        String log=MyTextField1.getText();
        String pas = MyTextField2.getText();
        System.out.println(log);
        System.out.println(pas);
        System.out.println(String.valueOf(tovarService.getTovarServicePort().checkUser(log,pas)));
        if(tovarService.getTovarServicePort().checkUser(log,pas))
        {
            ((Stage)(((Button)actionEvent.getSource()).getScene().getWindow())).close();
            Stage form = new Stage();
            StartProgram root =new StartProgram();
            try {
                root.start(form);
            } catch (Exception ex)
            {
                ex.printStackTrace();
            }

        }
    }
    /*

     */

}
