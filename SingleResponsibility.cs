/*******************************************************************************
 A class should have only one reason to change.
*******************************************************************************/

using System;

namespace SolidLib.SingleResponsibility
{
    #region SRP violation
    public interface Modem
    {
        public void Dial(string pno);
        public void Hangup();
        public void Send(char c);
        public char Receive();
    }
    #endregion

    #region SRP implementation
    public interface DataChannel
    {
        public void Send(char c);
        public char Receive();
    }

    public interface Connection
    {
        public void Dial(string pno);
        public void Hangup();
    }

    public class ModemImplentation : Connection, DataChannel
    {
        public void Dial(string pno)
        {
            throw new NotImplementedException();
        }

        public void Hangup()
        {
            throw new NotImplementedException();
        }

        public char Receive()
        {
            throw new NotImplementedException();
        }

        public void Send(char c)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}