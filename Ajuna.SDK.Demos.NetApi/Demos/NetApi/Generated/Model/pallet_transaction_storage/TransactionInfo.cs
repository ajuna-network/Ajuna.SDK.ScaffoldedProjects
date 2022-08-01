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


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_transaction_storage
{
    
    
    /// <summary>
    /// >> 593 - Composite[pallet_transaction_storage.TransactionInfo]
    /// </summary>
    [AjunaNodeType(TypeDefEnum.Composite)]
    public sealed class TransactionInfo : BaseType
    {
        
        /// <summary>
        /// >> chunk_root
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 _chunkRoot;
        
        /// <summary>
        /// >> content_hash
        /// </summary>
        private Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 _contentHash;
        
        /// <summary>
        /// >> size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _size;
        
        /// <summary>
        /// >> block_chunks
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _blockChunks;
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 ChunkRoot
        {
            get
            {
                return this._chunkRoot;
            }
            set
            {
                this._chunkRoot = value;
            }
        }
        
        public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 ContentHash
        {
            get
            {
                return this._contentHash;
            }
            set
            {
                this._contentHash = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 BlockChunks
        {
            get
            {
                return this._blockChunks;
            }
            set
            {
                this._blockChunks = value;
            }
        }
        
        public override string TypeName()
        {
            return "TransactionInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ChunkRoot.Encode());
            result.AddRange(ContentHash.Encode());
            result.AddRange(Size.Encode());
            result.AddRange(BlockChunks.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ChunkRoot = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
            ChunkRoot.Decode(byteArray, ref p);
            ContentHash = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
            ContentHash.Decode(byteArray, ref p);
            Size = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Size.Decode(byteArray, ref p);
            BlockChunks = new Ajuna.NetApi.Model.Types.Primitive.U32();
            BlockChunks.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
