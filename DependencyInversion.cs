// Note: from https://exceptionnotfound.net/simply-solid-the-interface-segregation-principle/
/*******************************************************************************
 A. High-level modules should not depend on low-level modules.  Both should
    depend on abstractions.
 B. Abstractions should not depend upon details.  Details should depend upon
    abstractions
*******************************************************************************/

using System;
namespace SolidLib
{
    #region Violation
    public class CustomerBusinessLogicViolator
    {
        public CustomerBusinessLogicViolator()
        {
        }

        public string GetCustomerName(int id)
        {
            DataAccessViolator _dataAccess = DataAccessFactoryViolator.GetDataAccessObj();

            return _dataAccess.GetCustomerName(id);
        }
    }

    public class DataAccessFactoryViolator
    {
        public static DataAccessViolator GetDataAccessObj()
        {
            return new DataAccessViolator();
        }
    }

    public class DataAccessViolator
    {
        public DataAccessViolator()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name"; // get it from DB in real app
        }
    }
    #endregion

    #region Applying DependencyInversion
    public interface ICustomerDataAccess
    {
        string GetCustomerName(int id);
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {
        }

        public string GetCustomerName(int id)
        {
            return "Dummy Customer Name";
        }
    }

    public class DataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerDataAccessObj()
        {
            return new CustomerDataAccess();
        }
    }

    public class CustomerBusinessLogic
    {
        ICustomerDataAccess _custDataAccess;

        public CustomerBusinessLogic()
        {
            _custDataAccess = DataAccessFactory.GetCustomerDataAccessObj();
        }

        public string GetCustomerName(int id)
        {
            return _custDataAccess.GetCustomerName(id);
        }
    }
    #endregion
}
