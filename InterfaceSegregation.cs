/*******************************************************************************
 Clients should not be forced to depend on methods they do not use.
*******************************************************************************/

using System;
namespace SolidLib
{
    public class InterfaceSegregation
    {
        #region Violation
        //public interface IProduct
        //{
        //    int ID { get; set; }
        //    double Weight { get; set; }
        //    int Stock { get; set; }
        //    int Inseam { get; set; }
        //    int WaistSize { get; set; }
        //}

        //public class Jeans : IProduct
        //{
        //    public int ID { get; set; }
        //    public double Weight { get; set; }
        //    public int Stock { get; set; }
        //    public int Inseam { get; set; }
        //    public int WaistSize { get; set; }
        //}

        // why does BaseballCap have Inseam and WaistSize properties? - not needed
        //public class BaseballCap : IProduct
        //{
        //    public int ID { get; set; }
        //    public double Weight { get; set; }
        //    public int Stock { get; set; }
        //    public int Inseam { get; set; }
        //    public int WaistSize { get; set; }
        //    public int HatSize { get; set; }
        //}
        #endregion

        public interface IProduct
        {
            int ID { get; set; }
            double Weight { get; set; }
            int Stock { get; set; }
        }

        public interface IPants
        {
            public int Inseam { get; set; }
            public int WaistSize { get; set; }
        }

        public interface IHat
        {
            public int HatSize { get; set; }
        }

        public class Jeans : IProduct, IPants
        {
            public int ID { get; set; }
            public double Weight { get; set; }
            public int Stock { get; set; }
            public int Inseam { get; set; }
            public int WaistSize { get; set; }
        }

        public class BaseballCap : IProduct, IHat
        {
            public int ID { get; set; }
            public double Weight { get; set; }
            public int Stock { get; set; }
            public int HatSize { get; set; }
        }
    }
}
