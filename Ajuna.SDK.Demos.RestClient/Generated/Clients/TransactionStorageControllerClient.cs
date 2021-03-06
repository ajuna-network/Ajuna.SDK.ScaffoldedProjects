//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   
   public sealed class TransactionStorageControllerClient : BaseClient, ITransactionStorageControllerClient
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public TransactionStorageControllerClient(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
      }
      public async Task<BoundedVecT34> GetTransactions(U32 key)
      {
         return await SendRequestAsync<BoundedVecT34>(_httpClient, "transactionstorage/transactions", Ajuna.SDK.Demos.NetApi.Generated.Storage.TransactionStorageStorage.TransactionsParams(key));
      }
      public async Task<bool> SubscribeTransactions(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("TransactionStorage.Transactions", Ajuna.SDK.Demos.NetApi.Generated.Storage.TransactionStorageStorage.TransactionsParams(key));
      }
      public async Task<U32> GetChunkCount(U32 key)
      {
         return await SendRequestAsync<U32>(_httpClient, "transactionstorage/chunkcount", Ajuna.SDK.Demos.NetApi.Generated.Storage.TransactionStorageStorage.ChunkCountParams(key));
      }
      public async Task<bool> SubscribeChunkCount(U32 key)
      {
         return await _subscriptionClient.SubscribeAsync("TransactionStorage.ChunkCount", Ajuna.SDK.Demos.NetApi.Generated.Storage.TransactionStorageStorage.ChunkCountParams(key));
      }
      public async Task<U128> GetByteFee()
      {
         return await SendRequestAsync<U128>(_httpClient, "transactionstorage/bytefee");
      }
      public async Task<bool> SubscribeByteFee()
      {
         return await _subscriptionClient.SubscribeAsync("TransactionStorage.ByteFee");
      }
      public async Task<U128> GetEntryFee()
      {
         return await SendRequestAsync<U128>(_httpClient, "transactionstorage/entryfee");
      }
      public async Task<bool> SubscribeEntryFee()
      {
         return await _subscriptionClient.SubscribeAsync("TransactionStorage.EntryFee");
      }
      public async Task<U32> GetStoragePeriod()
      {
         return await SendRequestAsync<U32>(_httpClient, "transactionstorage/storageperiod");
      }
      public async Task<bool> SubscribeStoragePeriod()
      {
         return await _subscriptionClient.SubscribeAsync("TransactionStorage.StoragePeriod");
      }
      public async Task<BoundedVecT34> GetBlockTransactions()
      {
         return await SendRequestAsync<BoundedVecT34>(_httpClient, "transactionstorage/blocktransactions");
      }
      public async Task<bool> SubscribeBlockTransactions()
      {
         return await _subscriptionClient.SubscribeAsync("TransactionStorage.BlockTransactions");
      }
      public async Task<Bool> GetProofChecked()
      {
         return await SendRequestAsync<Bool>(_httpClient, "transactionstorage/proofchecked");
      }
      public async Task<bool> SubscribeProofChecked()
      {
         return await _subscriptionClient.SubscribeAsync("TransactionStorage.ProofChecked");
      }
   }
}
