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
using Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
using System.Collections.Generic;


namespace Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> 272 - Composite[up_data_structs.CreateCollectionData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CreateCollectionData : BaseType
    {
        
        /// <summary>
        /// >> mode
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.EnumCollectionMode Mode { get; set; }
        /// <summary>
        /// >> access
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.EnumAccessMode> Access { get; set; } = new BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.EnumAccessMode>();
        /// <summary>
        /// >> name
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 Name { get; set; }
        /// <summary>
        /// >> description
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT9 Description { get; set; }
        /// <summary>
        /// >> token_prefix
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 TokenPrefix { get; set; }
        /// <summary>
        /// >> limits
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CollectionLimits> Limits { get; set; } = new BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CollectionLimits>();
        /// <summary>
        /// >> permissions
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions> Permissions { get; set; } = new BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions>();
        /// <summary>
        /// >> token_property_permissions
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11 TokenPropertyPermissions { get; set; };
        /// <summary>
        /// >> properties
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13 Properties { get; set; }
        /// <summary>
        /// >> admin_list
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> AdminList { get; set; }
        /// <summary>
        /// >> pending_sponsor
        /// </summary>
        public Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr> PendingSponsor { get; set; } = new BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>();
        /// <summary>
        /// >> flags
        /// </summary>
        public Substrate.NetApi.NetApiExt.Generated.Types.Base.Arr1U8 Flags { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CreateCollectionData";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Mode.Encode());
            result.AddRange(Access.Encode());
            result.AddRange(Name.Encode());
            result.AddRange(Description.Encode());
            result.AddRange(TokenPrefix.Encode());
            result.AddRange(Limits.Encode());
            result.AddRange(Permissions.Encode());
            result.AddRange(TokenPropertyPermissions.Encode());
            result.AddRange(Properties.Encode());
            result.AddRange(AdminList.Encode());
            result.AddRange(PendingSponsor.Encode());
            result.AddRange(Flags.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Mode = new Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.EnumCollectionMode();
            Mode.Decode(byteArray, ref p);
            Access = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.EnumAccessMode>();
            Access.Decode(byteArray, ref p);
            Name = new Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8();
            Name.Decode(byteArray, ref p);
            Description = new Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT9();
            Description.Decode(byteArray, ref p);
            TokenPrefix = new Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10();
            TokenPrefix.Decode(byteArray, ref p);
            Limits = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CollectionLimits>();
            Limits.Decode(byteArray, ref p);
            Permissions = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CollectionPermissions>();
            Permissions.Decode(byteArray, ref p);
            TokenPropertyPermissions = new Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT11();
            TokenPropertyPermissions.Decode(byteArray, ref p);
            Properties = new Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT13();
            Properties.Decode(byteArray, ref p);
            AdminList = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>();
            AdminList.Decode(byteArray, ref p);
            PendingSponsor = new Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.pallet_evm.account.EnumBasicCrossAccountIdRepr>();
            PendingSponsor.Decode(byteArray, ref p);
            Flags = new Substrate.NetApi.NetApiExt.Generated.Types.Base.Arr1U8();
            Flags.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
