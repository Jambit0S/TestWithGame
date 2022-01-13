package types;

public class User {

    private int id;
    private String login;
    private String password;
    private String firstname;
    private String secondname;
    private String patronomic;
    private String customization;

    public User(int id, String login, String password, String firstname, String secondname, String patronomic, String customization) {
        this.id = id;
        this.login = login;
        this.password = password;
        this.firstname = firstname;
        this.secondname = secondname;
        this.patronomic = patronomic;
        this.customization = customization;
    }

    public User(String login, String password, String name, String secondname, String patronomic, String customization) {
        this.login = login;
        this.password = password;
        this.firstname = name;
        this.secondname = secondname;
        this.patronomic = patronomic;
        this.customization = customization;
    }

    public int getId() {
        return id;
    }

    public String getLogin() {
        return login;
    }

    public String getPassword() {
        return password;
    }

    public String getFirstname() {
        return firstname;
    }

    public String getSecondname() {
        return secondname;
    }

    public String getPatronomic() {
        return patronomic;
    }

    public String getCustomization() {
        return customization;
    }


    public User() {
    }

    public void setId(int id) {
        this.id = id;
    }

    public void setLogin(String login) {
        this.login = login;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public void setFirstname(String name) {
        this.firstname = name;
    }

    public void setSecondname(String secondname) {
        this.secondname = secondname;
    }

    public void setPatronomic(String patronomic) {
        this.patronomic = patronomic;
    }

    public void setCustomization(String customization) {
        this.customization = customization;
    }
}
