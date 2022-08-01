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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public class IdentityControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Registration GetTestValue2()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Registration result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Registration();
         result.Judgements = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT22();
         result.Judgements = this.GetTestValue3();
         result.Deposit = this.GetTestValueU128();
         result.Info = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.IdentityInfo();
         result.Info = this.GetTestValue6();
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT22 GetTestValue3()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT22 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT22();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement>>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement>[] {
                  this.GetTestValue4()});
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement>();
         result.Create(this.GetTestValueU32(), this.GetTestValue5());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement GetTestValue5()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumJudgement();
         result.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Judgement>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.IdentityInfo GetTestValue6()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.IdentityInfo result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.IdentityInfo();
         result.Additional = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6();
         result.Additional = this.GetTestValue7();
         result.Display = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Display.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Legal = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Legal.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Web = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Web.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Riot = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Riot.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Email = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Email.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.PgpFingerprint = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr20U8>();
         result.PgpFingerprint.Create(this.GetTestValue11());
         result.Image = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Image.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         result.Twitter = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Twitter.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6 GetTestValue7()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT6();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData>>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData>[] {
                  this.GetTestValue8()});
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData> GetTestValue8()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData>();
         result.Create(this.GetTestValue9(), this.GetTestValue10());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData GetTestValue9()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData GetTestValue10()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr20U8 GetTestValue11()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr20U8 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Types.Base.Arr20U8();
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
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8(),
                  this.GetTestValueU8()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue12()
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
      public async System.Threading.Tasks.Task TestIdentityOf()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Registration mockupValue = this.GetTestValue2();
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue12();

         Assert.IsTrue(await rpcClient.SubscribeIdentityOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetIdentityOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Registration rpcResult = await rpcClient.GetIdentityOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData> GetTestValue14()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData>();
         result.Create(this.GetTestValue15(), this.GetTestValue16());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue15()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData GetTestValue16()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData();
         result.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.Data>(), this.GetTestValueBaseVoid());
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
      public async System.Threading.Tasks.Task TestSuperOf()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData> mockupValue = this.GetTestValue14();
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue17();

         Assert.IsTrue(await rpcClient.SubscribeSuperOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSuperOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.EnumData> rpcResult = await rpcClient.GetSuperOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23> GetTestValue19()
      {
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23>();
         result.Create(this.GetTestValueU128(), this.GetTestValue20());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23 GetTestValue20()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32>();
         result.Value.Create(new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32[] {
                  this.GetTestValue21()});
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue21()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue22()
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
      public async System.Threading.Tasks.Task TestSubsOf()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23> mockupValue = this.GetTestValue19();
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 mockupKey = this.GetTestValue22();

         Assert.IsTrue(await rpcClient.SubscribeSubsOf(mockupKey));

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSubsOf(mockupValue, mockupKey);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U128, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT23> rpcResult = await rpcClient.GetSubsOf(mockupKey);

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT24 GetTestValue24()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT24 result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT24();
         result.Value = new Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo>>();
         result.Value.Create(new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo>[] {
                  this.GetTestValue25()});
         return result;
      }
      public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo> GetTestValue25()
      {
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo>();
         result.Create(this.GetTestValue26());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo GetTestValue26()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.RegistrarInfo();
         result.Account = new Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32();
         result.Account = this.GetTestValue27();
         result.Fee = this.GetTestValueU128();
         result.Fields = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.BitFlags();
         result.Fields = this.GetTestValue28();
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 GetTestValue27()
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
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.BitFlags GetTestValue28()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.BitFlags result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_identity.types.BitFlags();
         result.Value = this.GetTestValueU64();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestRegistrars()
      {
         // Construct new Mockup client to test with.
         IdentityControllerMockupClient mockupClient = new IdentityControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         IdentityControllerClient rpcClient = new IdentityControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT24 mockupValue = this.GetTestValue24();


         Assert.IsTrue(await rpcClient.SubscribeRegistrars());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetRegistrars(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT24 rpcResult = await rpcClient.GetRegistrars();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}