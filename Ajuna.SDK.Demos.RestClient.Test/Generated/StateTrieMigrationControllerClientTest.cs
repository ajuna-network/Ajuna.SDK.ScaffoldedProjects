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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet;
   using Ajuna.NetApi.Model.Types.Base;
   
   public class StateTrieMigrationControllerClientTest : ClientTestBase
   {
      private System.Net.Http.HttpClient _httpClient;
      [SetUp()]
      public void Setup()
      {
         _httpClient = CreateHttpClient();
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask GetTestValue2()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask();
         result.ProgressTop = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.EnumProgress();
         result.ProgressTop.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.Progress>(), this.GetTestValueBaseVoid());
         result.ProgressChild = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.EnumProgress();
         result.ProgressChild.Create(this.GetTestValueEnum<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.Progress>(), this.GetTestValueBaseVoid());
         result.Size = this.GetTestValueU32();
         result.TopItems = this.GetTestValueU32();
         result.ChildItems = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestMigrationProcess()
      {
         // Construct new Mockup client to test with.
         StateTrieMigrationControllerMockupClient mockupClient = new StateTrieMigrationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         StateTrieMigrationControllerClient rpcClient = new StateTrieMigrationControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask mockupValue = this.GetTestValue2();


         Assert.IsTrue(await rpcClient.SubscribeMigrationProcess());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetMigrationProcess(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationTask rpcResult = await rpcClient.GetMigrationProcess();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> GetTestValue4()
      {
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> result;
         result = new Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits>();
         result.Create(this.GetTestValue5());
         return result;
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits GetTestValue5()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits();
         result.Size = this.GetTestValueU32();
         result.Item = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestAutoLimits()
      {
         // Construct new Mockup client to test with.
         StateTrieMigrationControllerMockupClient mockupClient = new StateTrieMigrationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         StateTrieMigrationControllerClient rpcClient = new StateTrieMigrationControllerClient(_httpClient, subscriptionClient);
         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> mockupValue = this.GetTestValue4();


         Assert.IsTrue(await rpcClient.SubscribeAutoLimits());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetAutoLimits(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits> rpcResult = await rpcClient.GetAutoLimits();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
      public Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits GetTestValue7()
      {
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits result;
         result = new Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits();
         result.Size = this.GetTestValueU32();
         result.Item = this.GetTestValueU32();
         return result;
      }
      [Test()]
      public async System.Threading.Tasks.Task TestSignedMigrationMaxLimits()
      {
         // Construct new Mockup client to test with.
         StateTrieMigrationControllerMockupClient mockupClient = new StateTrieMigrationControllerMockupClient(_httpClient);

         // Construct new subscription client to test with.
         var subscriptionClient = CreateSubscriptionClient();

         // Construct new RPC client to test with.
         StateTrieMigrationControllerClient rpcClient = new StateTrieMigrationControllerClient(_httpClient, subscriptionClient);
         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits mockupValue = this.GetTestValue7();


         Assert.IsTrue(await rpcClient.SubscribeSignedMigrationMaxLimits());

         // Save the previously generated mockup value in RPC service storage.
         bool mockupSetResult = await mockupClient.SetSignedMigrationMaxLimits(mockupValue);

         // Test that the expected mockup value was handled successfully from RPC service.
         Assert.IsTrue(mockupSetResult);
         var cts = new System.Threading.CancellationTokenSource(TimeSpan.FromSeconds(1));
         Assert.IsTrue(await subscriptionClient.ReceiveNextAsync(cts.Token));

         Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet.MigrationLimits rpcResult = await rpcClient.GetSignedMigrationMaxLimits();

         // Test that the expected mockup value matches the actual result from RPC service.
         Assert.AreEqual(mockupValue.Encode(), rpcResult.Encode());
      }
   }
}
