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


namespace Substrate.NetApi.NetApiExt.Generated.Model.cumulus_pallet_dmp_queue.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> Unknown
        /// The message index given is unknown.
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// >> OverLimit
        /// The amount of weight given is possibly not enough for executing the message.
        /// </summary>
        OverLimit = 1,
    }
    
    /// <summary>
    /// >> 581 - Variant[cumulus_pallet_dmp_queue.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
