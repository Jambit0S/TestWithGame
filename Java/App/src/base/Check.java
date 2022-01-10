package base;

import service.endpoint.TovarServiceService;
import types.ListOfTovar;
import types.Tovar;



public class Check {
    public static void main (String[] argv) {
        TovarServiceService tovarService = new TovarServiceService();
        doVivod(tovarService.getTovarServicePort().getAllTovar());

    }
    private static void doVivod(ListOfTovar lstTovar){
        int i = 1;
        for(Tovar tovar: lstTovar.getItem()){
            System.out.println(tovar.getName());
        }

    }
}
