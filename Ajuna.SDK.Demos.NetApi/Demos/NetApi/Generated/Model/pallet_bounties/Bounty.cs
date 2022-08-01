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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_bounties
{
    
    
    /// <summary>
    /// >> 558 - Composite[pallet_bounties.Bounty]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Bounty : BaseType
    {
        
        /// <summary>
        /// >> proposer
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 _proposer;
        
        /// <summary>
        /// >> value
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _value;
        
        /// <summary>
        /// >> fee
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _fee;
        
        /// <summary>
        /// >> curator_deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _curatorDeposit;
        
        /// <summary>
        /// >> bond
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _bond;
        
        /// <summary>
        /// >> status
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_bounties.EnumBountyStatus _status;
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 Proposer
        {
            get
            {
                return this._proposer;
            }
            set
            {
                this._proposer = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 CuratorDeposit
        {
            get
            {
                return this._curatorDeposit;
            }
            set
            {
                this._curatorDeposit = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Bond
        {
            get
            {
                return this._bond;
            }
            set
            {
                this._bond = value;
            }
        }
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_bounties.EnumBountyStatus Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
        
        public override string TypeName()
        {
            return "Bounty";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Proposer.Encode());
            result.AddRange(Value.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(CuratorDeposit.Encode());
            result.AddRange(Bond.Encode());
            result.AddRange(Status.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Proposer = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
            Proposer.Decode(byteArray, ref p);
            Value = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Value.Decode(byteArray, ref p);
            Fee = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Fee.Decode(byteArray, ref p);
            CuratorDeposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            CuratorDeposit.Decode(byteArray, ref p);
            Bond = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Bond.Decode(byteArray, ref p);
            Status = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_bounties.EnumBountyStatus();
            Status.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
