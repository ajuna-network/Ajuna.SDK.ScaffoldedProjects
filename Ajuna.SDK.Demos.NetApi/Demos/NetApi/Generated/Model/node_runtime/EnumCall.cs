//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Attributes;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime
{
    
    
    public enum Call
    {
        
        System,
        
        Utility,
        
        Babe,
        
        Timestamp,
        
        Authorship,
        
        Indices,
        
        Balances,
        
        ElectionProviderMultiPhase,
        
        Staking,
        
        Session,
        
        Democracy,
        
        Council,
        
        TechnicalCommittee,
        
        Elections,
        
        TechnicalMembership,
        
        Grandpa,
        
        Treasury,
        
        Contracts,
        
        Sudo,
        
        ImOnline,
        
        Identity,
        
        Society,
        
        Recovery,
        
        Vesting,
        
        Scheduler,
        
        Preimage,
        
        Proxy,
        
        Multisig,
        
        Bounties,
        
        Tips,
        
        Assets,
        
        Lottery,
        
        Gilt,
        
        Uniques,
        
        TransactionStorage,
        
        BagsList,
        
        StateTrieMigration,
        
        ChildBounties,
        
        Referenda,
        
        Remark,
        
        ConvictionVoting,
        
        Whitelist,
        
        AllianceMotion,
        
        Alliance,
        
        NominationPools,
        
        RankedPolls,
        
        RankedCollective,
    }
    
    /// <summary>
    /// >> 155 - Variant[node_runtime.Call]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Variant)]
    public sealed class EnumCall : BaseEnum<Call>
    {
    }
}
