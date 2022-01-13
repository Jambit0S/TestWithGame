package registration;

import service.endpoint.UserService;
import javax.xml.ws.Endpoint;

public class PublicWS {
    public static void main(String[] argv){
        Endpoint.publish("http://localhost:8805/UserService",
            new UserService());
    }
}
