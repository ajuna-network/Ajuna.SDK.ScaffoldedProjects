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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.generic.digest
{
    
    
    /// <summary>
    /// >> 11 - Composite[sp_runtime.generic.digest.Digest]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Digest : BaseType
    {
        
        /// <summary>
        /// >> logs
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.generic.digest.EnumDigestItem> _logs;
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.generic.digest.EnumDigestItem> Logs
        {
            get
            {
                return this._logs;
            }
            set
            {
                this._logs = value;
            }
        }
        
        public override string TypeName()
        {
            return "Digest";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Logs.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Logs = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.generic.digest.EnumDigestItem>();
            Logs.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
