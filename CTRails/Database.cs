using System.Data.OracleClient;
using CTRails.Users;

namespace CTRails
{
    public class Database
    {

        public Database Instance => instance ?? (instance = new Database());


        private Database instance;
        private OracleConnection connection;



        private Database()
        {
            
        }


        public void GetUser(User user)
        {
            
        }



        public void GetTram(Tram tram)
        {
            
        }



        public void GetTrack(Track track)
        {
            
        }
    }
}
