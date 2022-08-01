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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking
{
    
    
    /// <summary>
    /// >> 70 - Composite[pallet_staking.Exposure]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Exposure : BaseType
    {
        
        /// <summary>
        /// >> total
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _total;
        
        /// <summary>
        /// >> own
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _own;
        
        /// <summary>
        /// >> others
        /// </summary>
        private Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure> _others;
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Own
        {
            get
            {
                return this._own;
            }
            set
            {
                this._own = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure> Others
        {
            get
            {
                return this._others;
            }
            set
            {
                this._others = value;
            }
        }
        
        public override string TypeName()
        {
            return "Exposure";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Total.Encode());
            result.AddRange(Own.Encode());
            result.AddRange(Others.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Total = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Total.Decode(byteArray, ref p);
            Own = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Own.Decode(byteArray, ref p);
            Others = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure>();
            Others.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
