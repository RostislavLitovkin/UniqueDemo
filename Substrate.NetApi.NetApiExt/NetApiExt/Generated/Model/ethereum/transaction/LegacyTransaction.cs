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


namespace Substrate.NetApi.NetApiExt.Generated.Model.ethereum.transaction
{
    
    
    /// <summary>
    /// >> 341 - Composite[ethereum.transaction.LegacyTransaction]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class LegacyTransaction : BaseType
    {
        
        /// <summary>
        /// >> nonce
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256 Nonce { get; set; }
        /// <summary>
        /// >> gas_price
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256 GasPrice { get; set; }
        /// <summary>
        /// >> gas_limit
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256 GasLimit { get; set; }
        /// <summary>
        /// >> action
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionAction Action { get; set; }
        /// <summary>
        /// >> value
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256 Value { get; set; }
        /// <summary>
        /// >> input
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Input { get; set; }
        /// <summary>
        /// >> signature
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.ethereum.transaction.TransactionSignature Signature { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "LegacyTransaction";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Nonce.Encode());
            result.AddRange(GasPrice.Encode());
            result.AddRange(GasLimit.Encode());
            result.AddRange(Action.Encode());
            result.AddRange(Value.Encode());
            result.AddRange(Input.Encode());
            result.AddRange(Signature.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Nonce = new Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256();
            Nonce.Decode(byteArray, ref p);
            GasPrice = new Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256();
            GasPrice.Decode(byteArray, ref p);
            GasLimit = new Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256();
            GasLimit.Decode(byteArray, ref p);
            Action = new Substrate.NetApi.NetApiExt.Generated.Model.ethereum.transaction.EnumTransactionAction();
            Action.Decode(byteArray, ref p);
            Value = new Substrate.NetApi.NetApiExt.Generated.Model.primitive_types.U256();
            Value.Decode(byteArray, ref p);
            Input = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Input.Decode(byteArray, ref p);
            Signature = new Substrate.NetApi.NetApiExt.Generated.Model.ethereum.transaction.TransactionSignature();
            Signature.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}