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


namespace Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs
{
    
    
    /// <summary>
    /// >> CreateItemData
    /// </summary>
    public enum CreateItemData
    {
        
        /// <summary>
        /// >> NFT
        /// </summary>
        NFT = 0,
        
        /// <summary>
        /// >> Fungible
        /// </summary>
        Fungible = 1,
        
        /// <summary>
        /// >> ReFungible
        /// </summary>
        ReFungible = 2,
    }
    
    /// <summary>
    /// >> 301 - Variant[up_data_structs.CreateItemData]
    /// </summary>
    public sealed class EnumCreateItemData : BaseEnumExt<CreateItemData, Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CreateNftData, Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CreateFungibleData, Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs.CreateReFungibleData>
    {
    }
}