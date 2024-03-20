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


namespace Substrate.NetApi.NetApiExt.Generated.Model.frame_system.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> remark
        /// See [`Pallet::remark`].
        /// </summary>
        remark = 0,
        
        /// <summary>
        /// >> set_heap_pages
        /// See [`Pallet::set_heap_pages`].
        /// </summary>
        set_heap_pages = 1,
        
        /// <summary>
        /// >> set_code
        /// See [`Pallet::set_code`].
        /// </summary>
        set_code = 2,
        
        /// <summary>
        /// >> set_code_without_checks
        /// See [`Pallet::set_code_without_checks`].
        /// </summary>
        set_code_without_checks = 3,
        
        /// <summary>
        /// >> set_storage
        /// See [`Pallet::set_storage`].
        /// </summary>
        set_storage = 4,
        
        /// <summary>
        /// >> kill_storage
        /// See [`Pallet::kill_storage`].
        /// </summary>
        kill_storage = 5,
        
        /// <summary>
        /// >> kill_prefix
        /// See [`Pallet::kill_prefix`].
        /// </summary>
        kill_prefix = 6,
        
        /// <summary>
        /// >> remark_with_event
        /// See [`Pallet::remark_with_event`].
        /// </summary>
        remark_with_event = 7,
    }
    
    /// <summary>
    /// >> 85 - Variant[frame_system.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U64, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>>
    {
    }
}
