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


namespace Substrate.NetApi.NetApiExt.Generated.Model.pallet_nonfungible
{
    
    
    /// <summary>
    /// >> 626 - Composite[pallet_nonfungible.ItemData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ItemData : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr Owner { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "ItemData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Substrate.NetApi.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr();
            Owner.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
