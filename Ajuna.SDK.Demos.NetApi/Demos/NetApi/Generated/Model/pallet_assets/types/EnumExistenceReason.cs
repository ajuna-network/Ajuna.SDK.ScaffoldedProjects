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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_assets.types
{
    
    
    public enum ExistenceReason
    {
        
        Consumer,
        
        Sufficient,
        
        DepositHeld,
        
        DepositRefunded,
    }
    
    /// <summary>
    /// >> 566 - Variant[pallet_assets.types.ExistenceReason]
    /// </summary>
    public sealed class EnumExistenceReason : BaseEnumExt<ExistenceReason, BaseVoid, BaseVoid, Ajuna.NetApi.Model.Types.Primitive.U128, BaseVoid>
    {
    }
}