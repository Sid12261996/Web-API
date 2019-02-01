using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver.Linq;


namespace toFindUserDetails
{
    using Properties;
    class MongoBase

    {
        public MongoDatabase db;
        public MongoBase()
        {

            var client = new MongoClient(Settings.Default.connectionString);
            var server = client.GetServer();
            db = server.GetDatabase(Settings.Default.dbname);
        }
            public MongoCollection<User> Users => db.GetCollection<User>("users");



    
       /* public MongoCollection<User> GettingCollection {
            get
            {
                return db.GetCollection<User>("user");
            }
        }
      //  public MongoCollection<User> ExecuteQry(string id)
        //{
            
          //  var query = Query<User>.EQ(ref=>ref.userid,id) ;
            //return query;
       // }
       */
       
    }
}
