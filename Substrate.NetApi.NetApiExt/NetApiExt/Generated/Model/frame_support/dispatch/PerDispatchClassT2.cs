//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.NetApi.NetApiExt.Generated.Model.frame_support.dispatch
{
    
    
    /// <summary>
    /// >> 392 - Composite[frame_support.dispatch.PerDispatchClassT2]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PerDispatchClassT2 : BaseType
    {
        
        /// <summary>
        /// >> normal
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.frame_system.limits.WeightsPerClass Normal { get; set; }
        /// <summary>
        /// >> operational
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.frame_system.limits.WeightsPerClass Operational { get; set; }
        /// <summary>
        /// >> mandatory
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.frame_system.limits.WeightsPerClass Mandatory { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PerDispatchClassT2";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Normal.Encode());
            result.AddRange(Operational.Encode());
            result.AddRange(Mandatory.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Normal = new Substrate.NetApi.NetApiExt.Generated.Model.frame_system.limits.WeightsPerClass();
            Normal.Decode(byteArray, ref p);
            Operational = new Substrate.NetApi.NetApiExt.Generated.Model.frame_system.limits.WeightsPerClass();
            Operational.Decode(byteArray, ref p);
            Mandatory = new Substrate.NetApi.NetApiExt.Generated.Model.frame_system.limits.WeightsPerClass();
            Mandatory.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
