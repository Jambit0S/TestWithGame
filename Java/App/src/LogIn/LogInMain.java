package LogIn;

import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;

import javafx.application.Application;

public class LogInMain extends Application {
    public static void main(String[] args) {
        launch(args);
    }
    @Override
    public void start(Stage stage) throws Exception {

        Stage mainStage;
        Parent root = FXMLLoader.load(getClass().getResource("LogInForm.fxml"));
        stage.setTitle("Application");
        stage.setScene(new Scene(root));
        mainStage=stage;
        mainStage.show();

    }
}