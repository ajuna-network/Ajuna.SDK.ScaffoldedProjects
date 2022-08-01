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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.SDK.Demos.NetApi.Generated.Storage
{
    
    
    public sealed class ContractsStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public ContractsStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "PristineCode"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256), typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "CodeStorage"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256), typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "OwnerInfoOf"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256), typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "Nonce"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U64)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "ContractInfoOf"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32), typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Contracts", "DeletionQueue"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20)));
        }
        
        /// <summary>
        /// >> PristineCodeParams
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public static string PristineCodeParams(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "PristineCode", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PristineCode
        ///  A mapping from an original code hash to the original code, untouched by instrumentation.
        /// </summary>
        public async Task<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17> PristineCode(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.PristineCodeParams(key);
            return await _client.GetStorageAsync<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17>(parameters, token);
        }
        
        /// <summary>
        /// >> CodeStorageParams
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public static string CodeStorageParams(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "CodeStorage", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> CodeStorage
        ///  A mapping between an original code hash and instrumented wasm code, ready for execution.
        /// </summary>
        public async Task<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule> CodeStorage(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.CodeStorageParams(key);
            return await _client.GetStorageAsync<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule>(parameters, token);
        }
        
        /// <summary>
        /// >> OwnerInfoOfParams
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        public static string OwnerInfoOfParams(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Contracts", "OwnerInfoOf", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Identity}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> OwnerInfoOf
        ///  A mapping between an original code hash and its owner information.
        /// </summary>
        public async Task<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo> OwnerInfoOf(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key, CancellationToken token)
        {
            string parameters = ContractsStorage.OwnerInfoOfParams(key);
            return await _client.GetStorageAsync<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo>(parameters, token);
        }
        
        /// <summary>
        /// >> NonceParams
        ///  This is a **monotonic** counter incremented on contract instantiation.
        /// 
        ///  This is used in order to generate unique trie ids for contracts.
        ///  The trie id of a new contract is calculated from hash(account_id, nonce).
        ///  The nonce is required because otherwise the following sequence would lead to
        ///  a possible collision of storage:
        /// 
        ///  1. Create a new contract.
        ///  2. Terminate the contract.
        ///  3. Immediately recreate the contract with the same account_id.
        /// 
        ///  This is bad because the contents of a trie are deleted lazily and there might be
        ///  storage of the old instantiation still in it when the new contract is created. Please
        ///  note that we can't replace the counter by the block number because the sequence above
        ///  can happen in the same block. We also can't keep the account counter in memory only
        ///  because storage is the only way to communicate across different extrinsics in the
        ///  same block.
        /// 
        ///  # Note
        /// 
        ///  Do not use it to determine the number of contracts. It won't be decremented if
        ///  a contract is destroyed.
        /// </summary>
        public static string NonceParams()
        {
            return RequestGenerator.GetStorage("Contracts", "Nonce", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Nonce
        ///  This is a **monotonic** counter incremented on contract instantiation.
        /// 
        ///  This is used in order to generate unique trie ids for contracts.
        ///  The trie id of a new contract is calculated from hash(account_id, nonce).
        ///  The nonce is required because otherwise the following sequence would lead to
        ///  a possible collision of storage:
        /// 
        ///  1. Create a new contract.
        ///  2. Terminate the contract.
        ///  3. Immediately recreate the contract with the same account_id.
        /// 
        ///  This is bad because the contents of a trie are deleted lazily and there might be
        ///  storage of the old instantiation still in it when the new contract is created. Please
        ///  note that we can't replace the counter by the block number because the sequence above
        ///  can happen in the same block. We also can't keep the account counter in memory only
        ///  because storage is the only way to communicate across different extrinsics in the
        ///  same block.
        /// 
        ///  # Note
        /// 
        ///  Do not use it to determine the number of contracts. It won't be decremented if
        ///  a contract is destroyed.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U64> Nonce(CancellationToken token)
        {
            string parameters = ContractsStorage.NonceParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        /// <summary>
        /// >> ContractInfoOfParams
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public static string ContractInfoOfParams(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Contracts", "ContractInfoOf", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ContractInfoOf
        ///  The code associated with a given account.
        /// 
        ///  TWOX-NOTE: SAFE since `AccountId` is a secure hash.
        /// </summary>
        public async Task<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo> ContractInfoOf(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key, CancellationToken token)
        {
            string parameters = ContractsStorage.ContractInfoOfParams(key);
            return await _client.GetStorageAsync<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo>(parameters, token);
        }
        
        /// <summary>
        /// >> DeletionQueueParams
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        public static string DeletionQueueParams()
        {
            return RequestGenerator.GetStorage("Contracts", "DeletionQueue", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DeletionQueue
        ///  Evicted contracts that await child trie deletion.
        /// 
        ///  Child trie deletion is a heavy operation depending on the amount of storage items
        ///  stored in said trie. Therefore this operation is performed lazily in `on_initialize`.
        /// </summary>
        public async Task<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20> DeletionQueue(CancellationToken token)
        {
            string parameters = ContractsStorage.DeletionQueueParams();
            return await _client.GetStorageAsync<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20>(parameters, token);
        }
    }
    
    public sealed class ContractsCalls
    {
        
        /// <summary>
        /// >> call
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Call(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> gas_limit, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> data)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(data.Encode());
            return new Method(19, "Contracts", 0, "call", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate_with_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method InstantiateWithCode(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> gas_limit, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> code, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> data, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(19, "Contracts", 1, "instantiate_with_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> instantiate
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Instantiate(Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> value, Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64> gas_limit, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit, Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 code_hash, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> data, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> salt)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(value.Encode());
            byteArray.AddRange(gas_limit.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            byteArray.AddRange(code_hash.Encode());
            byteArray.AddRange(data.Encode());
            byteArray.AddRange(salt.Encode());
            return new Method(19, "Contracts", 2, "instantiate", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> upload_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UploadCode(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> code, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>> storage_deposit_limit)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            byteArray.AddRange(storage_deposit_limit.Encode());
            return new Method(19, "Contracts", 3, "upload_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemoveCode(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 code_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code_hash.Encode());
            return new Method(19, "Contracts", 4, "remove_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCode(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress dest, Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 code_hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(dest.Encode());
            byteArray.AddRange(code_hash.Encode());
            return new Method(19, "Contracts", 5, "set_code", byteArray.ToArray());
        }
    }
    
    public enum ContractsErrors
    {
        
        /// <summary>
        /// >> InvalidScheduleVersion
        /// A new schedule must have a greater version than the current one.
        /// </summary>
        InvalidScheduleVersion,
        
        /// <summary>
        /// >> InvalidCallFlags
        /// Invalid combination of flags supplied to `seal_call` or `seal_delegate_call`.
        /// </summary>
        InvalidCallFlags,
        
        /// <summary>
        /// >> OutOfGas
        /// The executed contract exhausted its gas limit.
        /// </summary>
        OutOfGas,
        
        /// <summary>
        /// >> OutputBufferTooSmall
        /// The output buffer supplied to a contract API call was too small.
        /// </summary>
        OutputBufferTooSmall,
        
        /// <summary>
        /// >> TransferFailed
        /// Performing the requested transfer failed. Probably because there isn't enough
        /// free balance in the sender's account.
        /// </summary>
        TransferFailed,
        
        /// <summary>
        /// >> MaxCallDepthReached
        /// Performing a call was denied because the calling depth reached the limit
        /// of what is specified in the schedule.
        /// </summary>
        MaxCallDepthReached,
        
        /// <summary>
        /// >> ContractNotFound
        /// No contract was found at the specified address.
        /// </summary>
        ContractNotFound,
        
        /// <summary>
        /// >> CodeTooLarge
        /// The code supplied to `instantiate_with_code` exceeds the limit specified in the
        /// current schedule.
        /// </summary>
        CodeTooLarge,
        
        /// <summary>
        /// >> CodeNotFound
        /// No code could be found at the supplied code hash.
        /// </summary>
        CodeNotFound,
        
        /// <summary>
        /// >> OutOfBounds
        /// A buffer outside of sandbox memory was passed to a contract API function.
        /// </summary>
        OutOfBounds,
        
        /// <summary>
        /// >> DecodingFailed
        /// Input passed to a contract API function failed to decode as expected type.
        /// </summary>
        DecodingFailed,
        
        /// <summary>
        /// >> ContractTrapped
        /// Contract trapped during execution.
        /// </summary>
        ContractTrapped,
        
        /// <summary>
        /// >> ValueTooLarge
        /// The size defined in `T::MaxValueSize` was exceeded.
        /// </summary>
        ValueTooLarge,
        
        /// <summary>
        /// >> TerminatedWhileReentrant
        /// Termination of a contract is not allowed while the contract is already
        /// on the call stack. Can be triggered by `seal_terminate`.
        /// </summary>
        TerminatedWhileReentrant,
        
        /// <summary>
        /// >> InputForwarded
        /// `seal_call` forwarded this contracts input. It therefore is no longer available.
        /// </summary>
        InputForwarded,
        
        /// <summary>
        /// >> RandomSubjectTooLong
        /// The subject passed to `seal_random` exceeds the limit.
        /// </summary>
        RandomSubjectTooLong,
        
        /// <summary>
        /// >> TooManyTopics
        /// The amount of topics passed to `seal_deposit_events` exceeds the limit.
        /// </summary>
        TooManyTopics,
        
        /// <summary>
        /// >> DuplicateTopics
        /// The topics passed to `seal_deposit_events` contains at least one duplicate.
        /// </summary>
        DuplicateTopics,
        
        /// <summary>
        /// >> NoChainExtension
        /// The chain does not provide a chain extension. Calling the chain extension results
        /// in this error. Note that this usually  shouldn't happen as deploying such contracts
        /// is rejected.
        /// </summary>
        NoChainExtension,
        
        /// <summary>
        /// >> DeletionQueueFull
        /// Removal of a contract failed because the deletion queue is full.
        /// 
        /// This can happen when calling `seal_terminate`.
        /// The queue is filled by deleting contracts and emptied by a fixed amount each block.
        /// Trying again during another block is the only way to resolve this issue.
        /// </summary>
        DeletionQueueFull,
        
        /// <summary>
        /// >> DuplicateContract
        /// A contract with the same AccountId already exists.
        /// </summary>
        DuplicateContract,
        
        /// <summary>
        /// >> TerminatedInConstructor
        /// A contract self destructed in its constructor.
        /// 
        /// This can be triggered by a call to `seal_terminate`.
        /// </summary>
        TerminatedInConstructor,
        
        /// <summary>
        /// >> DebugMessageInvalidUTF8
        /// The debug message specified to `seal_debug_message` does contain invalid UTF-8.
        /// </summary>
        DebugMessageInvalidUTF8,
        
        /// <summary>
        /// >> ReentranceDenied
        /// A call tried to invoke a contract that is flagged as non-reentrant.
        /// </summary>
        ReentranceDenied,
        
        /// <summary>
        /// >> StorageDepositNotEnoughFunds
        /// Origin doesn't have enough balance to pay the required storage deposits.
        /// </summary>
        StorageDepositNotEnoughFunds,
        
        /// <summary>
        /// >> StorageDepositLimitExhausted
        /// More storage was created than allowed by the storage deposit limit.
        /// </summary>
        StorageDepositLimitExhausted,
        
        /// <summary>
        /// >> CodeInUse
        /// Code removal was denied because the code is still in use by at least one contract.
        /// </summary>
        CodeInUse,
        
        /// <summary>
        /// >> ContractReverted
        /// The contract ran to completion but decided to revert its storage changes.
        /// Please note that this error is only returned from extrinsics. When called directly
        /// or via RPC an `Ok` will be returned. In this case the caller needs to inspect the flags
        /// to determine whether a reversion has taken place.
        /// </summary>
        ContractReverted,
        
        /// <summary>
        /// >> CodeRejected
        /// The contract's code was found to be invalid during validation or instrumentation.
        /// A more detailed error can be found on the node console if debug messages are enabled
        /// or in the debug buffer which is returned to RPC clients.
        /// </summary>
        CodeRejected,
    }
}