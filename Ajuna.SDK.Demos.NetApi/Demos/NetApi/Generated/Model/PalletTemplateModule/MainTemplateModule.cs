//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport;
using Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.SDK.Demos.NetApi.Generated.Model.PalletTemplateModule
{
    
    
    public sealed class TemplateModuleStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public TemplateModuleStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("TemplateModule", "Proofs"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1), typeof(BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore.AccountId32,Ajuna.NetApi.Model.Types.Primitive.U32>)));
        }
        
        /// <summary>
        /// >> ProofsParams
        ///  Maps each proof to its owner and block number when the proof was made
        /// </summary>
        public static string ProofsParams(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 key)
        {
            return RequestGenerator.GetStorage("TemplateModule", "Proofs", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Proofs
        ///  Maps each proof to its owner and block number when the proof was made
        /// </summary>
        public async Task<BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore.AccountId32,Ajuna.NetApi.Model.Types.Primitive.U32>> Proofs(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 key, CancellationToken token)
        {
            string parameters = TemplateModuleStorage.ProofsParams(key);
            return await _client.GetStorageAsync<BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore.AccountId32,Ajuna.NetApi.Model.Types.Primitive.U32>>(parameters, token);
        }
    }
    
    public sealed class TemplateModuleCalls
    {
        
        /// <summary>
        /// >> create_claim
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CreateClaim(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            return new Method(8, "TemplateModule", 0, "create_claim", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> revoke_claim
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RevokeClaim(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(proof.Encode());
            return new Method(8, "TemplateModule", 1, "revoke_claim", byteArray.ToArray());
        }
    }
    
    public enum TemplateModuleErrors
    {
        
        /// <summary>
        /// >> ProofAlreadyClaimed
        /// The proof has already been claimed.
        /// </summary>
        ProofAlreadyClaimed,
        
        /// <summary>
        /// >> NoSuchProof
        /// The proof does not exist, so it cannot be revoked.
        /// </summary>
        NoSuchProof,
        
        /// <summary>
        /// >> NotProofOwner
        /// The proof is claimed by another account, so caller can't revoke it.
        /// </summary>
        NotProofOwner,
    }
}
