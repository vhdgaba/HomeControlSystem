using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeControlSystem
{
    class HomeControlSystemServer : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            //create the custom node managers.
            nodeManagers.Add(new HomeControlSystemNodeManager(server, configuration));

            //create the master node manager
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "Emerson";
            properties.ProductName = "HomeControlSystem InformationModel Server";
            properties.ProductUri = "http://opcfoundation.org/HomeControlSystem/InformationModelServer/v1.0";
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();
            properties.BuildDate = Utils.GetAssemblyTimestamp();

            //TBD - All applications have certificates that need to be added to the properties.

            return properties;
        }
    }
}
