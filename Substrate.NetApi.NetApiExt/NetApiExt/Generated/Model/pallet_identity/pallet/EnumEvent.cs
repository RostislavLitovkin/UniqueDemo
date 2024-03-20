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


namespace Substrate.NetApi.NetApiExt.Generated.Model.pallet_identity.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> IdentitySet
        /// A name was set or reset (which will remove all judgements).
        /// </summary>
        IdentitySet = 0,
        
        /// <summary>
        /// >> IdentityCleared
        /// A name was cleared, and the given balance returned.
        /// </summary>
        IdentityCleared = 1,
        
        /// <summary>
        /// >> IdentityKilled
        /// A name was removed and the given balance slashed.
        /// </summary>
        IdentityKilled = 2,
        
        /// <summary>
        /// >> IdentitiesInserted
        /// A number of identities and associated info were forcibly inserted.
        /// </summary>
        IdentitiesInserted = 3,
        
        /// <summary>
        /// >> IdentitiesRemoved
        /// A number of identities and all associated info were forcibly removed.
        /// </summary>
        IdentitiesRemoved = 4,
        
        /// <summary>
        /// >> JudgementRequested
        /// A judgement was asked from a registrar.
        /// </summary>
        JudgementRequested = 5,
        
        /// <summary>
        /// >> JudgementUnrequested
        /// A judgement request was retracted.
        /// </summary>
        JudgementUnrequested = 6,
        
        /// <summary>
        /// >> JudgementGiven
        /// A judgement was given by a registrar.
        /// </summary>
        JudgementGiven = 7,
        
        /// <summary>
        /// >> RegistrarAdded
        /// A registrar was added.
        /// </summary>
        RegistrarAdded = 8,
        
        /// <summary>
        /// >> SubIdentityAdded
        /// A sub-identity was added to an identity and the deposit paid.
        /// </summary>
        SubIdentityAdded = 9,
        
        /// <summary>
        /// >> SubIdentityRemoved
        /// A sub-identity was removed from an identity and the deposit freed.
        /// </summary>
        SubIdentityRemoved = 10,
        
        /// <summary>
        /// >> SubIdentityRevoked
        /// A sub-identity was cleared, and the given deposit repatriated from the
        /// main identity account to the sub-identity account.
        /// </summary>
        SubIdentityRevoked = 11,
        
        /// <summary>
        /// >> SubIdentitiesInserted
        /// A number of identities were forcibly updated with new sub-identities.
        /// </summary>
        SubIdentitiesInserted = 12,
    }
    
    /// <summary>
    /// >> 66 - Variant[pallet_identity.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.NetApi.Model.Types.Primitive.U32, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U128>, Substrate.NetApi.Model.Types.Primitive.U32>
    {
    }
}
