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


namespace Substrate.NetApi.NetApiExt.Generated.Model.pallet_test_utils.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> enable
        /// See `Pallet::enable`.
        /// </summary>
        enable = 0,
        
        /// <summary>
        /// >> set_test_value
        /// See `Pallet::set_test_value`.
        /// </summary>
        set_test_value = 1,
        
        /// <summary>
        /// >> set_test_value_and_rollback
        /// See `Pallet::set_test_value_and_rollback`.
        /// </summary>
        set_test_value_and_rollback = 2,
        
        /// <summary>
        /// >> inc_test_value
        /// See `Pallet::inc_test_value`.
        /// </summary>
        inc_test_value = 3,
        
        /// <summary>
        /// >> just_take_fee
        /// See `Pallet::just_take_fee`.
        /// </summary>
        just_take_fee = 4,
        
        /// <summary>
        /// >> batch_all
        /// See `Pallet::batch_all`.
        /// </summary>
        batch_all = 5,
    }
    
    /// <summary>
    /// >> 359 - Variant[pallet_test_utils.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.NetApiExt.Generated.Model.opal_runtime.EnumRuntimeCall>>
    {
    }
}
