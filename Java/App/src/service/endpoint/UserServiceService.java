
package service.endpoint;

import java.net.MalformedURLException;
import java.net.URL;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.WebEndpoint;
import javax.xml.ws.WebServiceClient;
import javax.xml.ws.WebServiceException;
import javax.xml.ws.WebServiceFeature;


/**
 * This class was generated by the JAX-WS RI.
 * JAX-WS RI 2.2.9-b130926.1035
 * Generated source version: 2.2
 * 
 */
@WebServiceClient(name = "UserServiceService", targetNamespace = "http://endpoint.service/", wsdlLocation = "http://localhost:8805/UserService?wsdl")
public class UserServiceService
    extends Service
{

    private final static URL USERSERVICESERVICE_WSDL_LOCATION;
    private final static WebServiceException USERSERVICESERVICE_EXCEPTION;
    private final static QName USERSERVICESERVICE_QNAME = new QName("http://endpoint.service/", "UserServiceService");

    static {
        URL url = null;
        WebServiceException e = null;
        try {
            url = new URL("http://localhost:8805/UserService?wsdl");
        } catch (MalformedURLException ex) {
            e = new WebServiceException(ex);
        }
        USERSERVICESERVICE_WSDL_LOCATION = url;
        USERSERVICESERVICE_EXCEPTION = e;
    }

    public UserServiceService() {
        super(__getWsdlLocation(), USERSERVICESERVICE_QNAME);
    }

    public UserServiceService(WebServiceFeature... features) {
        super(__getWsdlLocation(), USERSERVICESERVICE_QNAME, features);
    }

    public UserServiceService(URL wsdlLocation) {
        super(wsdlLocation, USERSERVICESERVICE_QNAME);
    }

    public UserServiceService(URL wsdlLocation, WebServiceFeature... features) {
        super(wsdlLocation, USERSERVICESERVICE_QNAME, features);
    }

    public UserServiceService(URL wsdlLocation, QName serviceName) {
        super(wsdlLocation, serviceName);
    }

    public UserServiceService(URL wsdlLocation, QName serviceName, WebServiceFeature... features) {
        super(wsdlLocation, serviceName, features);
    }

    /**
     * 
     * @return
     *     returns UserService
     */
    @WebEndpoint(name = "UserServicePort")
    public UserService getUserServicePort() {
        return super.getPort(new QName("http://endpoint.service/", "UserServicePort"), UserService.class);
    }

    /**
     * 
     * @param features
     *     A list of {@link javax.xml.ws.WebServiceFeature} to configure on the proxy.  Supported features not in the <code>features</code> parameter will have their default values.
     * @return
     *     returns UserService
     */
    @WebEndpoint(name = "UserServicePort")
    public UserService getUserServicePort(WebServiceFeature... features) {
        return super.getPort(new QName("http://endpoint.service/", "UserServicePort"), UserService.class, features);
    }

    private static URL __getWsdlLocation() {
        if (USERSERVICESERVICE_EXCEPTION!= null) {
            throw USERSERVICESERVICE_EXCEPTION;
        }
        return USERSERVICESERVICE_WSDL_LOCATION;
    }

}
