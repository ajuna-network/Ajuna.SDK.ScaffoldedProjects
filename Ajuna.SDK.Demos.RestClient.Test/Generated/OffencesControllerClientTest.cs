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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_staking.offence;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public class OffencesControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_staking.offence.OffenceDetails GetTestValue2()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_staking.offence.OffenceDetails result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_staking.offence.OffenceDetails();
         result.Offender = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.Exposure>();
         result.Offender.Create(this.GetTestValue3(), this.GetTestValue4());
         result.Reporters = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>();
         result.Reporters.Create(new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue7()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue3()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.Exposure GetTestValue4()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.Exposure result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.Exposure();
         result.Total = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
         result.Total.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU128().Value));
         result.Own = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
         result.Own.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU128().Value));
         result.Others = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure>();
         result.Others.Create(new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure[] {
                  this.GetTestValue5()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure GetTestValue5()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_staking.IndividualExposure();
         result.Who = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Who = this.GetTestValue6();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
         result.Value.Create(new Ajuna.NetApi.CompactInteger(this.GetTestValueU128().Value));
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue6()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue7()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 GetTestValue8()
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
      public async System.Threading.Tasks.Task TestReports()
      {
         // Construct new Mockup client to test with.
         OffencesControllerMockupClient mockupClient = new OffencesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         OffencesControllerClient rpcClient = new OffencesControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_staking.offence.OffenceDetails mockupValue = this.GetTestValue2();
         Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 mockupKey = this.GetTestValue8();

         Assert.IsTrue(await rpcClient.SubscribeReports(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetReports(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_staking.offence.OffenceDetails rpcResult = await rpcClient.GetReports(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256> GetTestValue10()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256>();
         result.Create(new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256[] {
                  this.GetTestValue11()});
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
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> GetTestValue12()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>();
         result.Create(this.GetTestValue13(), this.GetTestValue14());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8 GetTestValue13()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
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
      public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> GetTestValue14()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestConcurrentReportsIndex()
      {
         // Construct new Mockup client to test with.
         OffencesControllerMockupClient mockupClient = new OffencesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         OffencesControllerClient rpcClient = new OffencesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256> mockupValue = this.GetTestValue10();
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8, Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> mockupKey = this.GetTestValue12();

         Assert.IsTrue(await rpcClient.SubscribeConcurrentReportsIndex(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetConcurrentReportsIndex(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256> rpcResult = await rpcClient.GetConcurrentReportsIndex(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> GetTestValue16()
      {
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8 GetTestValue17()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8();
         result.Create(new Ajuna.NetApi.Model.Types.Primitive.U8[] {
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
      public async System.Threading.Tasks.Task TestReportsByKindIndex()
      {
         // Construct new Mockup client to test with.
         OffencesControllerMockupClient mockupClient = new OffencesControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         OffencesControllerClient rpcClient = new OffencesControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> mockupValue = this.GetTestValue16();
         Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr16U8 mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeReportsByKindIndex(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetReportsByKindIndex(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> rpcResult = await rpcClient.GetReportsByKindIndex(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
