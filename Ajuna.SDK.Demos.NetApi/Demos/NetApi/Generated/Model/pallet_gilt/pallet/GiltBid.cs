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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet
{
    
    
    /// <summary>
    /// >> 578 - Composite[pallet_gilt.pallet.GiltBid]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class GiltBid : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _amount;
        
        /// <summary>
        /// >> who
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 _who;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 Who
        {
            get
            {
                return this._who;
            }
            set
            {
                this._who = value;
            }
        }
        
        public override string TypeName()
        {
            return "GiltBid";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(Who.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Who = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Who.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
