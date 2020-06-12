using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dbManager.vscommerceDB.tables;

// DataContext funge da canale principale per la connessione a un database, il recupero degli oggetti e l'invio delle modifiche.
//Lo scopo di DataContext consiste nel convertire le richieste di oggetti in query SQL da eseguire sul database, quindi di assemblare gli oggetti dai risultati
namespace dbManager.vscommerceDB
{ 

    public class DBvscommerce : DataContext
    {
        public Table<TableProduct> products;
        public Table<TableBrand> brands;
        public Table<TableCategory> categories;
        public Table<TableUser> users;
        public Table<TableOrder> orders;
        public Table<TableOrderLine> orderLines;

        public DBvscommerce(string connection) : base(connection) { }
    
    }
}
