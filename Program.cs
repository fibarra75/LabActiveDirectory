using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppActiveDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            String ldapPath2 = "adnet2.cl";

            try
            {
                LdapConnection connection = new LdapConnection(ldapPath2);
                var credentials = new NetworkCredential(@"fibarra", "P2ssw0rd");
                connection.Credential = credentials;
                connection.Bind();
            } catch (Exception e)
            {
                ;
            }

            bool authenticated = false;

            try
            {
                ITI.FWI.Seguridad.Autentificacion.ActiveDirectory objAD = new ITI.FWI.Seguridad.Autentificacion.ActiveDirectory("LDAP://DC=adnet2.cl,DC=CL");
                authenticated = objAD.ValidaUsuario("fibarra", "P2ssw0rd");
            } catch (Exception ex)
            {
                ;
            }

        }
    }
}
