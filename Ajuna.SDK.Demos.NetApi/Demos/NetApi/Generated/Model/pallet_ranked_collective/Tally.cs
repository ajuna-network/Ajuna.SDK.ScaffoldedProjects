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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_ranked_collective
{
    
    
    /// <summary>
    /// >> 128 - Composite[pallet_ranked_collective.Tally]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class Tally : BaseType
    {
        
        /// <summary>
        /// >> bare_ayes
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _bareAyes;
        
        /// <summary>
        /// >> ayes
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _ayes;
        
        /// <summary>
        /// >> nays
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _nays;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 BareAyes
        {
            get
            {
                return this._bareAyes;
            }
            set
            {
                this._bareAyes = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Ayes
        {
            get
            {
                return this._ayes;
            }
            set
            {
                this._ayes = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Nays
        {
            get
            {
                return this._nays;
            }
            set
            {
                this._nays = value;
            }
        }
        
        public override string TypeName()
        {
            return "Tally";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(BareAyes.Encode());
            result.AddRange(Ayes.Encode());
            result.AddRange(Nays.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            BareAyes = new Ajuna.NetApi.Model.Types.Primitive.U32();
            BareAyes.Decode(byteArray, ref p);
            Ayes = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Ayes.Decode(byteArray, ref p);
            Nays = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Nays.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
