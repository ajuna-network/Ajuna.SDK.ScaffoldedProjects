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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm
{
    
    
    /// <summary>
    /// >> 483 - Composite[pallet_contracts.wasm.OwnerInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class OwnerInfo : BaseType
    {
        
        /// <summary>
        /// >> owner
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 _owner;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _deposit;
        
        /// <summary>
        /// >> refcount
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> _refcount;
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 Owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                this._owner = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> Refcount
        {
            get
            {
                return this._refcount;
            }
            set
            {
                this._refcount = value;
            }
        }
        
        public override string TypeName()
        {
            return "OwnerInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Owner.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Refcount.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Owner = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Owner.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Deposit.Decode(byteArray, ref p);
            Refcount = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>();
            Refcount.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}