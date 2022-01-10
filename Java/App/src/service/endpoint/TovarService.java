
package service.endpoint;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebResult;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;
import types.ListOfTovar;
import types.Tovar;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.9-b130926.1035
 * Generated source version: 2.2
 * 
 */
@WebService(name = "TovarService", targetNamespace = "http://endpoint.service/")
@XmlSeeAlso({
    service.endpoint.ObjectFactory.class,
    types.ObjectFactory.class
})
public interface TovarService {


    /**
     * 
     * @return
     *     returns types.ListOfTovar
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "getAllTovar", targetNamespace = "http://endpoint.service/", className = "service.endpoint.GetAllTovar")
    @ResponseWrapper(localName = "getAllTovarResponse", targetNamespace = "http://endpoint.service/", className = "service.endpoint.GetAllTovarResponse")
    @Action(input = "http://endpoint.service/TovarService/getAllTovarRequest", output = "http://endpoint.service/TovarService/getAllTovarResponse")
    public ListOfTovar getAllTovar();

    /**
     * 
     * @return
     *     returns int
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "getSumOfTovar", targetNamespace = "http://endpoint.service/", className = "service.endpoint.GetSumOfTovar")
    @ResponseWrapper(localName = "getSumOfTovarResponse", targetNamespace = "http://endpoint.service/", className = "service.endpoint.GetSumOfTovarResponse")
    @Action(input = "http://endpoint.service/TovarService/getSumOfTovarRequest", output = "http://endpoint.service/TovarService/getSumOfTovarResponse")
    public int getSumOfTovar();

    /**
     * 
     * @param arg1
     * @param arg0
     * @return
     *     returns boolean
     */
    @WebMethod(operationName = "CheckUser")
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "CheckUser", targetNamespace = "http://endpoint.service/", className = "service.endpoint.CheckUser")
    @ResponseWrapper(localName = "CheckUserResponse", targetNamespace = "http://endpoint.service/", className = "service.endpoint.CheckUserResponse")
    @Action(input = "http://endpoint.service/TovarService/CheckUserRequest", output = "http://endpoint.service/TovarService/CheckUserResponse")
    public boolean checkUser(
        @WebParam(name = "arg0", targetNamespace = "")
        String arg0,
        @WebParam(name = "arg1", targetNamespace = "")
        String arg1);

    /**
     * 
     * @param arg0
     * @return
     *     returns types.ListOfTovar
     */
    @WebMethod
    @WebResult(targetNamespace = "")
    @RequestWrapper(localName = "setNewTovar", targetNamespace = "http://endpoint.service/", className = "service.endpoint.SetNewTovar")
    @ResponseWrapper(localName = "setNewTovarResponse", targetNamespace = "http://endpoint.service/", className = "service.endpoint.SetNewTovarResponse")
    @Action(input = "http://endpoint.service/TovarService/setNewTovarRequest", output = "http://endpoint.service/TovarService/setNewTovarResponse")
    public ListOfTovar setNewTovar(
        @WebParam(name = "arg0", targetNamespace = "")
        Tovar arg0);

}
