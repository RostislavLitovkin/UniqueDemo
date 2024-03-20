//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.NetApi.NetApiExt.Generated.Model.pallet_foreign_assets.module
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> force_register_foreign_asset
        /// See [`Pallet::force_register_foreign_asset`].
        /// </summary>
        force_register_foreign_asset = 0,
    }
    
    /// <summary>
    /// >> 330 - Variant[pallet_foreign_assets.module.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.xcm.EnumVersionedAssetId, Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8, Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10, Substrate.NetApi.NetApiExt.Generated.Model.pallet_foreign_assets.EnumForeignCollectionMode>>
    {
    }
}