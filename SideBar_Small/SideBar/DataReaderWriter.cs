using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Win32;

namespace RegistryReaderWriter
{
    class RegistryReaderWriter
    {
        // CLASS VARS /////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// The address of the key
        /// </summary>
        private static string keyAddr;

        /// <summary>
        /// The registry key
        /// </summary>
        private static RegistryKey key;

        // DELEGATES //////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// The delegate that happens on error
        /// </summary>
        public delegate void FailureDelegate();

        // GETTERS & SETTERS //////////////////////////////////////////////////////////////////////

        /// <summary>
        /// The address of the key
        /// </summary>
        public static string KeyAddr
        {
            get { return keyAddr; }
            set { keyAddr = value; }
        }

        /// <summary>
        /// The key
        /// </summary>
        public static RegistryKey Key
        {
            get { return key; }
            set { key = value; }
        }

        // PUBLIC METHODS /////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Creates a new key or opens one if it doesn't exist
        /// </summary>
        /// <param name="keyAddr">The addres of the key</param>
        /// <param name="onFailure">A delegate specifiying what happens in case of error</param>
        /// <returns>Returns TRUE, if action was successful, otherwise returns FALSE</returns>
        public static bool createKey(String keyAddr, FailureDelegate onFailure)
        {
            RegistryReaderWriter.keyAddr = keyAddr;

            try     // key initializing
            {
                key = Registry.LocalMachine.CreateSubKey(keyAddr);
                return true;
            }
            catch
            {
                onFailure();
                return false;
            }
        }

        /// <summary>
        /// Closes the key. Don't forget to use it!
        /// </summary>
        public static void closeKey()
        {
            key.Close();
        }

        /// <summary>
        /// Opens the key.
        /// </summary>
        /// <param name="onFailure">A delegate specifiying what happens in case of error</param>
        /// /// <returns>Returns TRUE, if action was successful, otherwise returns FALSE</returns>
        public static bool openKey( FailureDelegate onFailure)
        {
            try     // key initializing
            {
                key = Registry.LocalMachine.CreateSubKey(keyAddr);
                return true;
            }
            catch
            {
                onFailure();
                return false;
            }
        }

        /// <summary>
        /// Returns the value of the specified name of the key. Use it for Strings
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="onFailure">A string specifiying the return value in case of error</param>
        /// <returns>Returns the value of the given name</returns>
        public static string getValueString(string name, string onFailure)
        {
            string val = null;

            try
            {
                val = (string)key.GetValue(name);          
            }
            catch
            {
                return onFailure;
            }

            if (val == null)
                return onFailure;
            return val;
        }


        /// <summary>
        /// Returns the value of the specified name of the key. Use it for DWords
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="onFailure">An int specifiying the return value in case of error</param>
        /// <returns>Returns the value of the given name</returns>
        public static int getValueInt(string name, int onFailure)
        {
            int val;

            try
            {
                val = (int)key.GetValue(name);
            }
            catch
            {
                return onFailure;
            }

            return val;
        }

        /// <summary>
        /// Returns the value of the specified name of the key, use it for strings "True" and "False"
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="onFailure">A bool specifying the return value in case of error</param>
        /// <returns>Returns the value of the given name</returns>
        public static bool getValueBool(string name, bool onFailure)
        {
            string val = null;

            try     // autoHide
            {
                val = (key.GetValue(name).ToString() );
            }
            catch
            {
                return onFailure;
            }

            if ( val == "True")
                return true;
            else if ( val == "False")
                return false;
            else
                return onFailure;
        }

        /// <summary>
        /// Writes the specified value to the given name
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="value">The value</param>
        /// <returns>Returns TRUE, if the action was successful, otherwise returns FALSE</returns>
        public static bool setValue( string name, int value)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.CreateSubKey(keyAddr);
                key.SetValue(name, value);
                key.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Writes the specified value to the given name
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="value">The value</param>
        /// <returns>Returns TRUE, if the action was successful, otherwise returns FALSE</returns>
        public static bool setValue( string name, string value)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.CreateSubKey(keyAddr);
                key.SetValue(name, value);
                key.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Writes the specified value to the given name
        /// </summary>
        /// <param name="name">The name</param>
        /// <param name="value">The value</param>
        /// <returns>Returns TRUE, if the action was successful, otherwise returns FALSE</returns>
        public static bool setValue(string name, bool value)
        {
            try
            {
                RegistryKey key = Registry.LocalMachine.CreateSubKey(keyAddr);
                key.SetValue( name, value);
                key.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

    } // END Class
}
