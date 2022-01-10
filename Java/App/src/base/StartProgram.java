package base;

import AddForm.AddFormMain;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

import AddForm.AddFormMain;
import service.endpoint.TovarServiceService;

public class StartProgram extends Application {
    public static void main(String[] args) {

        launch(args);
    }

    @Override
    public void start(Stage stage) throws Exception {

        Stage mainStage;
        Parent root = FXMLLoader.load(getClass().getResource("Frame.fxml"));
        stage.setTitle("Application");
        stage.setScene(new Scene(root));
        mainStage=stage;
        mainStage.show();

    }
    protected static void OpenAddUserForm()
    {
        Stage AddUser = new Stage();
        AddFormMain root = new AddFormMain();
        try {
            root.start(AddUser);
        } catch (Exception ex)
        {
            ex.printStackTrace();
        }
    }
}
