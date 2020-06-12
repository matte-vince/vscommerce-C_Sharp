
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using dbManager.vscommerceDB.tables;
namespace dbManager.vscommerceDB
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "DBManager" nel codice e nel file di configurazione contemporaneamente.
    public class DBManager : IDBManager
    {

        private DBvscommerce connection;
        public DBManager()
        {
            connection = new DBvscommerce("Server=localhost;database=vscommerce;Trusted_Connection=True;");
        }


        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public User getUserByEmail(string Email)
        {
            try
            {
                var query =
                    (from user in this.connection.users
                     where user.email == Email
                     select user)
                    .First();

                return new User(query.ID, query.email, query.password, query.name, query.surname, query.isAdmin, query.fiscalCode, query.birthday);
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
        }

        public bool existUser(string Email)
        {
            try
            {
                var query =
                    (from user in this.connection.users
                     where user.email == Email
                     select user)
                    .First();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public User getUserById(int ID)
        {
            try
            {
                var query =
                    (from user in this.connection.users
                     where user.ID == ID
                     select user)
                    .First();

                return new User(query.ID, query.email, query.password, query.name, query.surname, query.isAdmin, query.fiscalCode, query.birthday);
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
        }

        public List<User> getUsers()
        {
            try
            {
                List<User> userList = new List<User>();
                var query =
                    (from user in this.connection.users
                     select user);
                foreach(var utente in query)
                {
                    userList.Add(new User(utente.ID, utente.email, utente.password, utente.name, utente.surname, utente.isAdmin, utente.fiscalCode, utente.birthday));
                }
                return userList;
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
        }

        public List<Product> getProducts()
        {
            List<Product> productList = new List<Product>();
            try
            {
                var query = from prodotti in this.connection.products select prodotti;
                foreach (var prod in query)
                {
                    productList.Add(new Product(prod.ID, prod.name, prod.description, prod.price, prod.tax, prod.qty, prod.barcode, this.getBrandById(prod.brand), this.getCategoryById(prod.category), prod.image));
                }
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
            return productList;
        }

        public Product getProductById(int id)
        {
            try
            {
                var prod =
                    (from prodotti in this.connection.products
                     where prodotti.ID == id
                     select prodotti)
                    .First();

                return new Product(prod.ID, prod.name, prod.description, prod.price, prod.tax, prod.qty, prod.barcode, this.getBrandById(prod.brand), this.getCategoryById(prod.category), prod.image);

            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
        }

        public Brand getBrandById(int id)
        {
            try
            {
                var query =
                    (from brand in this.connection.brands
                     where brand.ID == id
                     select brand)
                    .First();

                 return new Brand(query.ID, query.name);
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
        }

        public List<Brand> getBrands()
        {
            List<Brand> brandList = new List<Brand>();
            try
            {
                var query = from brand in this.connection.brands select brand;
                foreach (var marca in query)
                {
                    brandList.Add(new Brand(marca.ID, marca.name));
                }
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
            return brandList;
        }

        public Category getCategoryById(int id)
        {
            try
            {
                var query =
                    (from category in this.connection.categories
                     where category.ID == id
                     select category)
                    .First();

                return new Category(query.ID, query.name);
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
        }

        public List<Category> getCategories()
        {
            List<Category> categoryList = new List<Category>();
            try
            {
                var query = from category in this.connection.categories select category;
                foreach (var categoria in query)
                {
                    categoryList.Add(new Category(categoria.ID, categoria.name));
                }
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
            return categoryList;
        }


        public List<Order> getOrdersByPartner(int ID)
        {
            
            List<Order> orderlist = new List<Order>();
            try
            {
                var query = (from order in this.connection.orders
                             where order.customer == ID
                             select order);
                foreach (var order in query)
                {
                    
                    List<OrderLine> lines = new List<OrderLine>();
                    var queryLines = (from orderLine in this.connection.orderLines
                                        where orderLine.order == order.ID
                                        select orderLine);
                    foreach (var line in queryLines)
                    {
                        lines.Add(new OrderLine(line.ID, order.ID, getProductById(line.product), line.qty, line.priceUnit));
                    }

                    orderlist.Add(new Order(order.ID, this.getPartnerById(order.customer), order.date, order.total, lines));

                    
                }
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
            return orderlist;
        }

        public List<Order> getOrders()
        {

            List<Order> orderlist = new List<Order>();
            try
            {
                var query = from order in this.connection.orders
                             select order;
                foreach (var order in query)
                {
                    List<OrderLine> lines = new List<OrderLine>();
                    var queryLines = (from orderLine in this.connection.orderLines
                                 where orderLine.order == order.ID
                                 select orderLine);
                    foreach (var line in queryLines)
                    {
                        lines.Add(new OrderLine(line.ID, order.ID, getProductById(line.product), line.qty, line.priceUnit));
                    }

                    orderlist.Add(new Order(order.ID, this.getPartnerById(order.customer), order.date, order.total, lines));

                }
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
            return orderlist;
        }
        public Order getOrderById(int ID)
        {

            try
            {
                var query =
                    (from order in this.connection.orders
                     where order.ID == ID
                     select order)
                    .First();
                
                List<OrderLine> lines = new List<OrderLine>();
                var queryLines = (from orderLine in this.connection.orderLines
                                    where orderLine.order == query.ID
                                    select orderLine);
                foreach (var line in queryLines)
                {
                    lines.Add(new OrderLine(line.ID, query.ID, getProductById(line.product), line.qty, line.priceUnit));
                }

                return new Order(query.ID, this.getPartnerById(query.customer), query.date, query.total, lines);

                
            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
            
        }

        public User getPartnerById(int id)
        {
            try
            {
                var query =
                    (from user in this.connection.users
                     where user.ID == id
                     select user)
                    .First();

                return new User(query.ID, query.email, query.password, query.name, query.surname, query.isAdmin, query.fiscalCode, query.birthday);

            }
            catch (Exception e)
            {
                throw new FaultException<DBFault>(new DBFault(e.ToString()));
            }
        }

        public bool updateUser(User userUpdated)
        {
            //execute a transaction to update user
            //in this case a transaction is not necessary because i do only one submitchange
            connection.Connection.Open();
            using (connection.Transaction = connection.Connection.BeginTransaction())
            {
                try
                {
                    var userToUpdate =
                    (from user in this.connection.users
                     where user.ID == userUpdated.ID
                     select user)
                    .First();
                    userToUpdate.name = userUpdated.name;
                    userToUpdate.surname = userUpdated.surname;
                    userToUpdate.fiscalCode = userUpdated.fiscalCode;
                    userToUpdate.birthday = userUpdated.birthday;
                    if(userUpdated.password != null)
                    {
                        userToUpdate.password = userUpdated.password;
                    }
                    connection.SubmitChanges();
                    connection.Transaction.Commit();
                }
                catch (Exception e)
                {
                    connection.Transaction.Rollback();
                    connection.Connection.Close();
                    return false;
                }
                connection.Connection.Close();
                return true;
            }
            
        }

        public bool updateBrand(Brand brandUpdated)
        {
            try
            {
                var brandToUpdate =
                (from brand in this.connection.brands
                 where brand.ID == brandUpdated.ID
                 select brand)
                .First();
                brandToUpdate.name = brandUpdated.name;

                connection.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool updateCategory(Category categoryUpdated)
        {
            try
            {
                var categoryToUpdate =
                (from category in this.connection.categories
                 where category.ID == categoryUpdated.ID
                 select category)
                .First();
                categoryToUpdate.name = categoryUpdated.name;

                connection.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool updateProduct(Product productUpdated)
        {
            try
            {
                var productToUpdate =
                (from prodotti in this.connection.products
                 where prodotti.ID == productUpdated.ID
                 select prodotti)
                .First();
                productToUpdate.name = productUpdated.name;
                productToUpdate.description = productUpdated.description;
                productToUpdate.price = productUpdated.price;
                productToUpdate.tax = productUpdated.tax;
                productToUpdate.qty = productUpdated.qty;
                productToUpdate.barcode = productUpdated.barcode;
                productToUpdate.image = productUpdated.image;
                productToUpdate.brand = productUpdated.brand.ID;
                productToUpdate.category = productUpdated.category.ID;
                connection.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool createUser(User userToCreate)
        {
            try
            {
                TableUser createdUser = new TableUser(userToCreate.name, userToCreate.surname, userToCreate.birthday, userToCreate.fiscalCode, userToCreate.email, userToCreate.password, false);
                this.connection.users.InsertOnSubmit(createdUser);

                connection.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool createOrder(Order newOrder, List<OrderLine> orderLines)
        {
            //here i need a transaction because
            connection.Connection.Open();
            using (connection.Transaction = connection.Connection.BeginTransaction())
            {
                try
                {
                    TableOrder createdOrder = new TableOrder(newOrder.customer.ID, newOrder.date, newOrder.total);
                    this.connection.orders.InsertOnSubmit(createdOrder);
                    connection.SubmitChanges();
                    foreach(var line in orderLines)
                    {
                        line.order = createdOrder.ID;
                        this.connection.orderLines.InsertOnSubmit(new TableOrderLine(line.product.ID, line.order, line.qty, line.priceUnit));
                        var prod = (from prodotti in this.connection.products
                         where prodotti.ID == line.product.ID
                         select prodotti)
                        .First();
                        prod.qty = prod.qty - line.qty;
                        connection.SubmitChanges();
                    }
                    
                    connection.Transaction.Commit();
                }
                catch (Exception e)
                {
                    
                    return false;
                }
                connection.Connection.Close();
                return true;
            }
            
        }

        public bool createBrand(Brand brandToCreate)
        {
            
            //i don't need a transaction since i do only one insert operation
            //submitChanges manages rollback
            try
            {
                TableBrand createdBrand = new TableBrand(brandToCreate.name);
                this.connection.brands.InsertOnSubmit(createdBrand);
                    
                connection.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
            

        }
        public bool createProduct(Product productToCreat)
        {

            //i don't need a transaction since i do only one insert operation
            //submitChanges manages rollback
            try
            {
                TableProduct createdProduct = new TableProduct(productToCreat.name, productToCreat.description, productToCreat.price, productToCreat.tax,
                    productToCreat.qty, productToCreat.barcode, productToCreat.brand.ID, productToCreat.category.ID, productToCreat.image);
                this.connection.products.InsertOnSubmit(createdProduct);

                connection.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }

            return true;


        }

        public bool createCategory(Category categoryToCreate)
        {

            //i don't need a transaction since i do only one insert operation
            //submitChanges manages rollback
            try
            {
                TableCategory createdCategory = new TableCategory(categoryToCreate.name);
                this.connection.categories.InsertOnSubmit(createdCategory);

                connection.SubmitChanges();

            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public bool deleteOrder(int ID)
        {
            connection.Connection.Open();
            using (connection.Transaction = connection.Connection.BeginTransaction())
            {
                try
                {
                    var query =
                        (from orderLine in this.connection.orderLines
                         where orderLine.order == ID
                         select orderLine);
                    foreach(var line in query)
                    {
                        this.connection.orderLines.DeleteOnSubmit(line);
                    }

                    connection.SubmitChanges();

                    var ordine =
                    (from order in this.connection.orders
                     where order.ID == ID
                     select order)
                    .First();
                    this.connection.orders.DeleteOnSubmit(ordine);
                    connection.SubmitChanges();
                    connection.Transaction.Commit();
                }
                catch (Exception e)
                {
                    connection.Transaction.Rollback();
                    connection.Connection.Close();
                    return false;    
                }
                connection.Connection.Close();
                return true;
            }
        }
    }
}
