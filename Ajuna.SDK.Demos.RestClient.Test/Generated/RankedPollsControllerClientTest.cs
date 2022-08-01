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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public class RankedPollsControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      [Test()]
      public async System.Threading.Tasks.Task TestReferendumCount()
      {
         // Construct new Mockup client to test with.
         RankedPollsControllerMockupClient mockupClient = new RankedPollsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RankedPollsControllerClient rpcClient = new RankedPollsControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();


         Assert.IsTrue(await rpcClient.SubscribeReferendumCount());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetReferendumCount(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetReferendumCount();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo GetTestValue3()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo();
         result.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.ReferendumInfo>(), this.GetTestValue4());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.ReferendumStatusT2 GetTestValue4()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.ReferendumStatusT2 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.ReferendumStatusT2();
         result.Track = this.GetTestValueU16();
         result.Origin = new Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.EnumOriginCaller();
         result.Origin.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime.OriginCaller>(), this.GetTestValue5());
         result.ProposalHash = new Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256();
         result.ProposalHash = this.GetTestValue6();
         result.Enactment = new Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.schedule.EnumDispatchTime();
         result.Enactment.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.schedule.DispatchTime>(), this.GetTestValueU32());
         result.Submitted = this.GetTestValueU32();
         result.SubmissionDeposit = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit();
         result.SubmissionDeposit = this.GetTestValue7();
         result.DecisionDeposit = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit>();
         result.DecisionDeposit.Create(this.GetTestValue9());
         result.Deciding = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.DecidingStatus>();
         result.Deciding.Create(this.GetTestValue11());
         result.Tally = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_ranked_collective.Tally();
         result.Tally = this.GetTestValue12();
         result.InQueue = this.GetTestValueBool();
         result.Alarm = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>>();
         result.Alarm.Create(this.GetTestValue13());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.dispatch.EnumRawOrigin GetTestValue5()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.dispatch.EnumRawOrigin result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.dispatch.EnumRawOrigin();
         result.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.dispatch.RawOrigin>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 GetTestValue6()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit GetTestValue7()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit();
         result.Who = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Who = this.GetTestValue8();
         result.Amount = this.GetTestValueU128();
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue8()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit GetTestValue9()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.Deposit();
         result.Who = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Who = this.GetTestValue10();
         result.Amount = this.GetTestValueU128();
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.DecidingStatus GetTestValue11()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.DecidingStatus result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.DecidingStatus();
         result.Since = this.GetTestValueU32();
         result.Confirming = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Confirming.Create(this.GetTestValueU32());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_ranked_collective.Tally GetTestValue12()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_ranked_collective.Tally result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_ranked_collective.Tally();
         result.BareAyes = this.GetTestValueU32();
         result.Ayes = this.GetTestValueU32();
         result.Nays = this.GetTestValueU32();
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> GetTestValue13()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>();
         result.Create(this.GetTestValueU32(), this.GetTestValue14());
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue14()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValueU32(), this.GetTestValueU32());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestReferendumInfoFor()
      {
         // Construct new Mockup client to test with.
         RankedPollsControllerMockupClient mockupClient = new RankedPollsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RankedPollsControllerClient rpcClient = new RankedPollsControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo mockupValue = this.GetTestValue3();
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupKey = this.GetTestValueU32();

         Assert.IsTrue(await rpcClient.SubscribeReferendumInfoFor(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetReferendumInfoFor(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_referenda.types.EnumReferendumInfo rpcResult = await rpcClient.GetReferendumInfoFor(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT44 GetTestValue16()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT44 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT44();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>[] {
                  this.GetTestValue17()});
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> GetTestValue17()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>();
         result.Create(this.GetTestValueU32(), this.GetTestValueU32());
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestTrackQueue()
      {
         // Construct new Mockup client to test with.
         RankedPollsControllerMockupClient mockupClient = new RankedPollsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RankedPollsControllerClient rpcClient = new RankedPollsControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT44 mockupValue = this.GetTestValue16();
         Ajuna.NetApi.Model.Types.Primitive.U16 mockupKey = this.GetTestValueU16();

         Assert.IsTrue(await rpcClient.SubscribeTrackQueue(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetTrackQueue(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT44 rpcResult = await rpcClient.GetTrackQueue(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      [Test()]
      public async System.Threading.Tasks.Task TestDecidingCount()
      {
         // Construct new Mockup client to test with.
         RankedPollsControllerMockupClient mockupClient = new RankedPollsControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         RankedPollsControllerClient rpcClient = new RankedPollsControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Primitive.U32 mockupValue = this.GetTestValueU32();
         Ajuna.NetApi.Model.Types.Primitive.U16 mockupKey = this.GetTestValueU16();

         Assert.IsTrue(await rpcClient.SubscribeDecidingCount(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetDecidingCount(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Primitive.U32 rpcResult = await rpcClient.GetDecidingCount(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
