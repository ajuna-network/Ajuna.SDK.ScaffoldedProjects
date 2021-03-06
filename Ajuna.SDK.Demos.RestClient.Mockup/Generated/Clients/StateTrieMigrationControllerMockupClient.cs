//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Mockup.Generated.Clients
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_state_trie_migration.pallet;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces;
   
   public sealed class StateTrieMigrationControllerMockupClient : MockupBaseClient, IStateTrieMigrationControllerMockupClient
   {
      private HttpClient _httpClient;
      public StateTrieMigrationControllerMockupClient(HttpClient httpClient)
      {
         _httpClient = httpClient;
      }
      public async Task<bool> SetMigrationProcess(MigrationTask value)
      {
         return await SendMockupRequestAsync(_httpClient, "StateTrieMigration/MigrationProcess", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.StateTrieMigrationStorage.MigrationProcessParams());
      }
      public async Task<bool> SetAutoLimits(BaseOpt<MigrationLimits> value)
      {
         return await SendMockupRequestAsync(_httpClient, "StateTrieMigration/AutoLimits", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.StateTrieMigrationStorage.AutoLimitsParams());
      }
      public async Task<bool> SetSignedMigrationMaxLimits(MigrationLimits value)
      {
         return await SendMockupRequestAsync(_httpClient, "StateTrieMigration/SignedMigrationMaxLimits", value.Encode(), Ajuna.SDK.Demos.NetApi.Generated.Storage.StateTrieMigrationStorage.SignedMigrationMaxLimitsParams());
      }
   }
}
