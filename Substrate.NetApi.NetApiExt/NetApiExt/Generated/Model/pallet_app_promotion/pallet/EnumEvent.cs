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


namespace Substrate.NetApi.NetApiExt.Generated.Model.pallet_app_promotion.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> StakingRecalculation
        /// Staking recalculation was performed
        /// 
        /// # Arguments
        /// * AccountId: account of the staker.
        /// * Balance : recalculation base
        /// * Balance : total income
        /// </summary>
        StakingRecalculation = 0,
        
        /// <summary>
        /// >> Stake
        /// Staking was performed
        /// 
        /// # Arguments
        /// * AccountId: account of the staker
        /// * Balance : staking amount
        /// </summary>
        Stake = 1,
        
        /// <summary>
        /// >> Unstake
        /// Unstaking was performed
        /// 
        /// # Arguments
        /// * AccountId: account of the staker
        /// * Balance : unstaking amount
        /// </summary>
        Unstake = 2,
        
        /// <summary>
        /// >> SetAdmin
        /// The admin was set
        /// 
        /// # Arguments
        /// * AccountId: account address of the admin
        /// </summary>
        SetAdmin = 3,
    }
    
    /// <summary>
    /// >> 371 - Variant[pallet_app_promotion.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>
    {
    }
}
