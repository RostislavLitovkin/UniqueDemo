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


namespace Substrate.NetApi.NetApiExt.Generated.Model.pallet_ranked_collective
{
    
    
    /// <summary>
    /// >> 81 - Composite[pallet_ranked_collective.Tally]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Tally : BaseType
    {
        
        /// <summary>
        /// >> bare_ayes
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 BareAyes { get; set; }
        /// <summary>
        /// >> ayes
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Ayes { get; set; }
        /// <summary>
        /// >> nays
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Nays { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Tally";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BareAyes.Encode());
            result.AddRange(Ayes.Encode());
            result.AddRange(Nays.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BareAyes = new Substrate.NetApi.Model.Types.Primitive.U32();
            BareAyes.Decode(byteArray, ref p);
            Ayes = new Substrate.NetApi.Model.Types.Primitive.U32();
            Ayes.Decode(byteArray, ref p);
            Nays = new Substrate.NetApi.Model.Types.Primitive.U32();
            Nays.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
