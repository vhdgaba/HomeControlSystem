﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HomeControlSystem
{
    [DataContract(Namespace = Namespaces.HomeControlSystem)]
    public class HomeControlSystemServerConfiguration
    {
        public HomeControlSystemServerConfiguration()
        {
            Initialize();
        }

        // <summary>
        // Initializes the object during deserialization
        // </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        // <summary>
        // Sets private members to default values.
        // </summary>
        private void Initialize()
        {

        }
    }
}
