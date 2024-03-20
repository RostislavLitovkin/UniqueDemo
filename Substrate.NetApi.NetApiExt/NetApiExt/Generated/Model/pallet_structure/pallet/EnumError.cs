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


namespace Substrate.NetApi.NetApiExt.Generated.Model.pallet_structure.pallet
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> OuroborosDetected
        /// While nesting, encountered an already checked account, detecting a loop.
        /// </summary>
        OuroborosDetected = 0,
        
        /// <summary>
        /// >> DepthLimit
        /// While nesting, reached the depth limit of nesting, exceeding the provided budget.
        /// </summary>
        DepthLimit = 1,
        
        /// <summary>
        /// >> BreadthLimit
        /// While nesting, reached the breadth limit of nesting, exceeding the provided budget.
        /// </summary>
        BreadthLimit = 2,
        
        /// <summary>
        /// >> TokenNotFound
        /// Couldn't find the token owner that is itself a token.
        /// </summary>
        TokenNotFound = 3,
        
        /// <summary>
        /// >> CantNestTokenUnderCollection
        /// Tried to nest token under collection contract address, instead of token address
        /// </summary>
        CantNestTokenUnderCollection = 4,
    }
    
    /// <summary>
    /// >> 632 - Variant[pallet_structure.pallet.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
