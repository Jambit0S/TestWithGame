package AddForm;

import javafx.application.Platform;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.Button;
import javafx.scene.control.ToggleGroup;
import javafx.stage.Stage;
import service.endpoint.TovarServiceService;
import types.Tovar;

import javax.swing.*;
import java.net.URL;
import java.util.ResourceBundle;

public class AddFormController implements Initializable {
    @FXML
    javafx.scene.control.ScrollBar MyScroll;
    @FXML
    javafx.scene.control.Label MyLabel;

    @FXML
    javafx.scene.control.RadioButton FirstRButton;

    @FXML
    javafx.scene.control.RadioButton SecondRButton;
    @FXML
    javafx.scene.control.ComboBox MyComboBox;
    @FXML
    javafx.scene.control.Spinner MySpinner;

    javafx.scene.control.ToggleGroup RadioButtonGroup;

    @FXML
    void DragDone()
    {
        MyScroll.setValue(Math.round(MyScroll.getValue()));
        MyLabel.setText(String.valueOf(MyScroll.getValue()));

        //System.out.println("move scrollbar");

    }

    @Override
    public void initialize(URL url, ResourceBundle resourceBundle)
    {
        MyScroll.setMax(100);
        MyScroll.setMin(1);
        System.out.println(MyScroll.getValue());
        RadioButtonGroup= new ToggleGroup();
        FirstRButton.setToggleGroup(RadioButtonGroup);
        FirstRButton.setSelected(true);
        SecondRButton.setToggleGroup(RadioButtonGroup);
        MyComboBox.getItems().addAll("SObaka","Penek","Pencil");

    }
    public void AddInTable(ActionEvent event)
    {
        TovarServiceService tovarService = new TovarServiceService();
        Tovar newtovar = new Tovar();
        newtovar.setName(String.valueOf(MyComboBox.getValue()));
        newtovar.setCount(Integer.valueOf(MySpinner.getValue().toString()));
        newtovar.setPrice(Integer.valueOf(MySpinner.getValue().toString()));
        tovarService.getTovarServicePort().setNewTovar(newtovar);
        //Platform.exit();
        ((Stage)(((Button)event.getSource()).getScene().getWindow())).close();
    }
    public void ExitButt(ActionEvent event)
    {
        ((Stage)(((Button)event.getSource()).getScene().getWindow())).close();
    }
}
