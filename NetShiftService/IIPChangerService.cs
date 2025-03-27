﻿using System.ServiceModel;
using NetShift.Models;

namespace NetShiftService
{
    [ServiceContract]
    public interface IIPChangerService
    {
        [OperationContract]
        void SetStaticIP(Preset preset);

        [OperationContract]
        void ResetToDhcp(string adapterName);
    }
}