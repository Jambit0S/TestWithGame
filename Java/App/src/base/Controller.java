package base;

import ClientTypes.ClientTovar;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.fxml.FXML;
import javafx.fxml.Initializable;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;

import service.endpoint.SetNewTovar;
import service.endpoint.TovarService;
import service.endpoint.TovarServiceService;
import types.ListOfTovar;
import types.Tovar;

import java.net.URL;
import java.util.List;
import java.util.ResourceBundle;

import service.endpoint.SetNewTovar;

import javax.xml.ws.Service;

public class Controller implements Initializable {

    private ObservableList<ClientTovar> products = FXCollections.observableArrayList();

    @FXML
    private TableView<ClientTovar> tableView = new TableView<ClientTovar>();
    @FXML
    private TableColumn<ClientTovar, Integer> ProductNumber;
    @FXML
    private TableColumn <ClientTovar, String> ProductName;
    @FXML
    private TableColumn <ClientTovar, Double> ProductPrice;
    @FXML
    private TableColumn <ClientTovar, Integer> ProductCount;
    @FXML
    private TableColumn <ClientTovar, Integer> ProductSumm;

    @FXML
    private javafx.scene.control.TextField MyTextField;

    @FXML
    void ButtonAdd()
    {
        System.out.println("add");
        StartProgram.OpenAddUserForm();
    }
    @FXML
    void ButtonCount()
    {
        System.out.println("count");
        Double summ=0.0d;
        TovarServiceService tovarService = new TovarServiceService();
        MyTextField.setText(String.valueOf(tovarService.getTovarServicePort().getSumOfTovar()));
    }
    @FXML
    void ButtonExit()
    {
        System.out.println("update");
        products.clear();
        TovarServiceService tovarService = new TovarServiceService();
        int i=1;
        for(Tovar tovar: tovarService.getTovarServicePort().getAllTovar().getItem()){
            ClientTovar a = new ClientTovar(tovar.getId(),tovar.getName(),tovar.getCount(),tovar.getPrice());
            products.add(a.getId(),a);
            i++;
        }
    }
    @Override
    public void initialize(URL url, ResourceBundle resourceBundle)
    {
        System.out.println("init");
        ProductNumber.setCellValueFactory(new PropertyValueFactory<ClientTovar, Integer>("id"));
        ProductName.setCellValueFactory(new PropertyValueFactory<ClientTovar, String>("name"));
        ProductPrice.setCellValueFactory(new PropertyValueFactory<ClientTovar, Double>("price"));
        ProductCount.setCellValueFactory(new PropertyValueFactory<ClientTovar, Integer>("count"));
        ProductSumm.setCellValueFactory(new PropertyValueFactory<ClientTovar, Integer>("summa"));
        tableView.setItems(products);
        initData();
    }
    private void initData()
    {
        TovarServiceService tovarService = new TovarServiceService();
        int i=1;
        for(Tovar tovar: tovarService.getTovarServicePort().getAllTovar().getItem()){
            ClientTovar a = new ClientTovar(tovar.getId(),tovar.getName(),tovar.getCount(),tovar.getPrice());
            products.add(a.getId(),a);
            i++;
        }

    }

}
