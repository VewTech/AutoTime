namespace Library.Schemas
{
    public class User
    {
        public int USER_ID { get; set; }
        public string USER_COMPANY { get; set; }
        public string USER_NAME { get; set; }
        public string USER_EMAIL { get; set; }
        public string USER_TOKEN { get; set; }
        public string USER_IMAGE { get; set; }
        public string USER_NIF { get; set; }
        public string USER_AFFILIATION { get; set; }
        public int USER_WORKING_TIME { get; set; }
        public string USER_USERNAME { get; set; }
        public string USER_PASWORD { get; set; }
        public Project[] projects { get; set; }
        public Workcenter[] workcenters { get; set; }
        public Company company { get; set; }
    }

    public class Company
    {
        public int COMPANY_ID { get; set; }
        public string COMPANY_UNIQUE_ID { get; set; }
        public string COMPANY_NAME { get; set; }
        public object COMPANY_CIF { get; set; }
        public object COMPANY_CCC { get; set; }
        public string COMPANY_ADDRESS { get; set; }
        public string COMPANY_COUNTRY { get; set; }
        public string COMPANY_LOCATION { get; set; }
        public string COMPANY_CP { get; set; }
        public object COMPANY_COORDINATES { get; set; }
        public string COMPANY_MAIL { get; set; }
        public string COMPANY_PASSWORD { get; set; }
        public int COMPANY_PRO { get; set; }
        public object COMPANY_RATE { get; set; }
        public object COMPANY_DELETION_DATE { get; set; }
        public int COMPANY_HAS_ADS { get; set; }
        public string COMPANIES_TOKEN { get; set; }
        public object COMPANY_LOGO { get; set; }
        public object COMPANY_SIGNATURE { get; set; }
        public int COMPANY_CONTINUOUS_WORKDAYS { get; set; }
        public int COMPANY_USE_SERVER_TIME { get; set; }
        public int COMPANY_FORCE_LOCATION { get; set; }
        public int COMPANY_CALENDAR_DAYS { get; set; }
        public int COMPANY_SHOW_CLIENT { get; set; }
        public int COMPANY_SHOW_CLIENT_SELECT { get; set; }
        public int COMPANY_EMAIL_UPDATES { get; set; }
        public int COMPANY_API_COMMENTS { get; set; }
        public string COMPANY_TIMEZONE { get; set; }
    }

    public class Project
    {
        public int PROJECT_ID { get; set; }
        public string PROJECT_NAME { get; set; }
        public string PROJECT_COMPANY { get; set; }
        public object PID_OLD { get; set; }
        public Client client { get; set; }
    }

    public class Client
    {
        public int CLIENT_ID { get; set; }
        public string CLIENT_COMPANY { get; set; }
        public string CLIENT_NAME { get; set; }
        public string CLIENT_COUNTRY { get; set; }
        public string CLIENT_REGION { get; set; }
        public string CLIENT_CITY { get; set; }
        public string CLIENT_ADDRESS { get; set; }
        public string CLIENT_CP { get; set; }
        public string CLIENT_COORDINATES { get; set; }
        public object CID_OLD { get; set; }
    }

    public class Workcenter
    {
        public int WORKCENTER_ID { get; set; }
        public string WORKCENTER_COMPANY { get; set; }
        public string WORKCENTER_NAME { get; set; }
        public string WORKCENTER_COUNTRY { get; set; }
        public string WORKCENTER_REGION { get; set; }
        public string WORKCENTER_CITY { get; set; }
        public string WORKCENTER_ADDRESS { get; set; }
        public string WORKCENTER_CP { get; set; }
        public string WORKCENTER_COORDINATES { get; set; }
        public string WORKCENTER_CREATION_DATE { get; set; }
        public object WCID_OLD { get; set; }
    }

 
}
