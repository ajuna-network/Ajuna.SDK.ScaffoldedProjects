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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.NodeTemplateRuntime
{
    
    
    public enum NodeCall
    {
        
        System,
        
        Timestamp,
        
        Grandpa,
        
        Balances,
        
        Sudo,
        
        TemplateModule,
        
        Nicks,
    }
    
    /// <summary>
    /// >> 112 - Variant[node_template_runtime.Call]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Variant)]
    public sealed class EnumNodeCall : BaseEnum<NodeCall>
    {
    }
}
