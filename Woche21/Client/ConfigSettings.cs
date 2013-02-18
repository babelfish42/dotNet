using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Reflection;

namespace ZHAW.Philipp.Bachmann.L12
{
    public class ConfigSettings    
    {         
        private static string NodePath = "//system.serviceModel//client//endpoint";
            
        private ConfigSettings()
        { }
            
        public static string GetEndpointAddress()   
        {            
            return ConfigSettings.loadConfigDocument().SelectSingleNode(NodePath).Attributes["address"].Value;       
        }  
            
        public static void SaveEndpointAddress(string endpointAddress)  
        {        
            XmlDocument doc = loadConfigDocument();     
            XmlNode node = doc.SelectSingleNode(NodePath);      
            if (node == null)     
                throw new InvalidOperationException("Error. Could not find endpoint node in config file.");     
                
            try
            {        
                node.Attributes["address"].Value = endpointAddress;     
                doc.Save(getConfigFilePath());    
            }       
            catch( Exception e )      
            {             
                throw e;      
            }    
        }  
 
        public static XmlDocument loadConfigDocument()   
        {       
            XmlDocument doc = null;       
            try       
            {            
                doc = new XmlDocument();     
                doc.Load(getConfigFilePath());   
                return doc;   
            }          
            catch (System.IO.FileNotFoundException e)  
            {            
                throw new Exception("No configuration file found.", e); 
            }      
        }        

        private static string getConfigFilePath()  
        {       
            return Assembly.GetExecutingAssembly().Location + ".config";   
        }  
    } 
}
