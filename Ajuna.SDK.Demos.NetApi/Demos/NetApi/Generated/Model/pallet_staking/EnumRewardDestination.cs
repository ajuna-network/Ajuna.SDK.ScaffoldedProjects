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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking
{
    
    
    public enum RewardDestination
    {
        
        Staked,
        
        Stash,
        
        Controller,
        
        Account,
        
        None,
    }
    
    /// <summary>
    /// >> 234 - Variant[pallet_staking.RewardDestination]
    /// </summary>
    public sealed class EnumRewardDestination : BaseEnumExt<RewardDestination, BaseVoid, BaseVoid, BaseVoid, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, BaseVoid>
    {
    }
}
