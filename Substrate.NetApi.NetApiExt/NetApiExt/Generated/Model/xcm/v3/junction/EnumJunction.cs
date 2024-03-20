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


namespace Substrate.NetApi.NetApiExt.Generated.Model.xcm.v3.junction
{
    
    
    /// <summary>
    /// >> Junction
    /// </summary>
    public enum Junction
    {
        
        /// <summary>
        /// >> Parachain
        /// </summary>
        Parachain = 0,
        
        /// <summary>
        /// >> AccountId32
        /// </summary>
        AccountId32 = 1,
        
        /// <summary>
        /// >> AccountIndex64
        /// </summary>
        AccountIndex64 = 2,
        
        /// <summary>
        /// >> AccountKey20
        /// </summary>
        AccountKey20 = 3,
        
        /// <summary>
        /// >> PalletInstance
        /// </summary>
        PalletInstance = 4,
        
        /// <summary>
        /// >> GeneralIndex
        /// </summary>
        GeneralIndex = 5,
        
        /// <summary>
        /// >> GeneralKey
        /// </summary>
        GeneralKey = 6,
        
        /// <summary>
        /// >> OnlyChild
        /// </summary>
        OnlyChild = 7,
        
        /// <summary>
        /// >> Plurality
        /// </summary>
        Plurality = 8,
        
        /// <summary>
        /// >> GlobalConsensus
        /// </summary>
        GlobalConsensus = 9,
    }
    
    /// <summary>
    /// >> 55 - Variant[xcm.v3.junction.Junction]
    /// </summary>
    public sealed class EnumJunction : BaseEnumExt<Junction, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.xcm.v3.junction.EnumNetworkId>, Substrate.NetApi.NetApiExt.Generated.Types.Base.Arr32U8>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.xcm.v3.junction.EnumNetworkId>, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>, BaseTuple<Substrate.NetApi.Model.Types.Base.BaseOpt<Substrate.NetApi.NetApiExt.Generated.Model.xcm.v3.junction.EnumNetworkId>, Substrate.NetApi.NetApiExt.Generated.Types.Base.Arr20U8>, Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U8, Substrate.NetApi.NetApiExt.Generated.Types.Base.Arr32U8>, BaseVoid, BaseTuple<Substrate.NetApi.NetApiExt.Generated.Model.xcm.v3.junction.EnumBodyId, Substrate.NetApi.NetApiExt.Generated.Model.xcm.v3.junction.EnumBodyPart>, Substrate.NetApi.NetApiExt.Generated.Model.xcm.v3.junction.EnumNetworkId>
    {
    }
}
