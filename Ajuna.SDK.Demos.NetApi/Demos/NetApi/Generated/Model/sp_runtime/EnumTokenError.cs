//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime
{
    
    
    public enum TokenError
    {
        
        NoFunds,
        
        WouldDie,
        
        BelowMinimum,
        
        CannotCreate,
        
        UnknownAsset,
        
        Frozen,
        
        Unsupported,
    }
    
    /// <summary>
    /// >> 24 - Variant[sp_runtime.TokenError]
    /// </summary>
    public sealed class EnumTokenError : BaseEnum<TokenError>
    {
    }
}
