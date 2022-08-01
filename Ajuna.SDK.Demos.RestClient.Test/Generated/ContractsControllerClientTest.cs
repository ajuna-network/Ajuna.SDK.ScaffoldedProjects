//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Test.Generated
{
   using System;
   using NUnit.Framework;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Clients;
   using Ajuna.SDK.Demos.RestClient.Generated.Clients;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage;
   
   public class ContractsControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17 GetTestValue2()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 GetTestValue3()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
         result.Value = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestPristineCode()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17 mockupValue = this.GetTestValue2();
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue3();

         Assert.IsTrue(await rpcClient.SubscribePristineCode(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetPristineCode(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT17 rpcResult = await rpcClient.GetPristineCode(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule GetTestValue5()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule();
         result.InstructionWeightsVersion = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.InstructionWeightsVersion.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU32().Value));
         result.Initial = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Initial.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU32().Value));
         result.Maximum = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Maximum.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU32().Value));
         result.Code = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT18();
         result.Code = this.GetTestValue6();
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT18 GetTestValue6()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT18 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT18();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 GetTestValue7()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
         result.Value = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestCodeStorage()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule mockupValue = this.GetTestValue5();
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue7();

         Assert.IsTrue(await rpcClient.SubscribeCodeStorage(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetCodeStorage(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.PrefabWasmModule rpcResult = await rpcClient.GetCodeStorage(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo GetTestValue9()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo();
         result.Owner = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Owner = this.GetTestValue10();
         result.Deposit = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
         result.Deposit.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU128().Value));
         result.Refcount = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U64>();
         result.Refcount.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU64().Value));
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue10()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 GetTestValue11()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
         result.Value = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestOwnerInfoOf()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo mockupValue = this.GetTestValue9();
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue11();

         Assert.IsTrue(await rpcClient.SubscribeOwnerInfoOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetOwnerInfoOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.wasm.OwnerInfo rpcResult = await rpcClient.GetOwnerInfoOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestNonce()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U64 mockupValue = this.GetTestValueU64();


         Assert.IsTrue(await rpcClient.SubscribeNonce());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetNonce(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U64 rpcResult = await rpcClient.GetNonce();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo GetTestValue14()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo();
         result.TrieId = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19();
         result.TrieId = this.GetTestValue15();
         result.CodeHash = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
         result.CodeHash = this.GetTestValue16();
         result.StorageDeposit = this.GetTestValueU128();
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19 GetTestValue15()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 GetTestValue16()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
         result.Value = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue17()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Value = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr32U8();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestContractInfoOf()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo mockupValue = this.GetTestValue14();
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeContractInfoOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetContractInfoOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.RawContractInfo rpcResult = await rpcClient.GetContractInfoOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20 GetTestValue19()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract>();
         result.Value.Create(new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract[] {
                  this.GetTestValue20()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract GetTestValue20()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_contracts.storage.DeletedContract();
         result.TrieId = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19();
         result.TrieId = this.GetTestValue21();
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19 GetTestValue21()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT19();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDeletionQueue()
      {
         // Construct new Mockup client to test with.
         ContractsControllerMockupClient mockupClient = new ContractsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         ContractsControllerClient rpcClient = new ContractsControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20 mockupValue = this.GetTestValue19();


         Assert.IsTrue(await rpcClient.SubscribeDeletionQueue());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDeletionQueue(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT20 rpcResult = await rpcClient.GetDeletionQueue();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}