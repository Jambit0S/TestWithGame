package registration;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.rmi.Remote;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

import operation.MessageImpl;

import operation.TovarOperationImpl;

public class RunServer {
    public static void main (String[] argv) {
        try {/*
            // создание экземпляров классов для регистрации
            MessageImpl message = new MessageImpl();
            // создаём реестр
            Registry registry = LocateRegistry.createRegistry(8802);
            // регистрация классов
            registry.bind("rmiTest01", message);
            System.out.println ("Message Server is ready.");*/
            TovarOperationImpl tovarOperationImpl = new TovarOperationImpl();
            Registry registry = LocateRegistry.createRegistry(8802);
            registry.bind("rmiTest02", tovarOperationImpl);
            System.out.println("Tovar Server is ready");
            BufferedReader reader =new BufferedReader(new InputStreamReader(System.in));
            reader.readLine();
        } catch (Exception e) {
            System.out.println ("Message Server failed: " + e);

        }


    }
}

