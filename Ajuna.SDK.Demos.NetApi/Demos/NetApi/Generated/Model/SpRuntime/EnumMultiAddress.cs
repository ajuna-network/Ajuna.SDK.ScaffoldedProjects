//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Ajuna.SDK.Demos.NetApi.Generated.Model.Base;
using Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.SpRuntime
{
    
    
    public enum MultiAddress
    {
        
        Id,
        
        Index,
        
        Raw,
        
        Address32,
        
        Address20,
    }
    
    /// <summary>
    /// >> 102 - Variant[sp_runtime.multiaddress.MultiAddress]
    /// </summary>
    public sealed class EnumMultiAddress : BaseEnumExt<MultiAddress, Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore.AccountId32, BaseCom<BaseTuple>, BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>, Ajuna.SDK.Demos.NetApi.Generated.Model.Base.Arr32U8, Ajuna.SDK.Demos.NetApi.Generated.Model.Base.Arr20U8>
    {
    }
}
