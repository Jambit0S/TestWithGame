package AddForm;

import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

public class AddFormMain extends Application {
    public static void main(String[] args) {
        launch(args);
    }
    Stage mainStage;
    @Override
    public void start(Stage stage) throws Exception {
        Parent root = FXMLLoader.load(getClass().getResource("AddForm.fxml"));
        stage.setTitle("Application");
        stage.setScene(new Scene(root));
        mainStage=stage;
        mainStage.show();

    }
}
