//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient
{
   using System;
   using System.Threading.Tasks;
   using System.Net.Http;
   using Ajuna.SDK.Demos.RestClient.Generated.Interfaces;
   using Ajuna.SDK.Demos.RestClient.Generated.Clients;
   
   public sealed class Client
   {
      private HttpClient _httpClient;
      private BaseSubscriptionClient _subscriptionClient;
      public IAuraControllerClient AuraControllerClient;
      public IBalancesControllerClient BalancesControllerClient;
      public IGrandpaControllerClient GrandpaControllerClient;
      public INicksControllerClient NicksControllerClient;
      public IRandomnessCollectiveFlipControllerClient RandomnessCollectiveFlipControllerClient;
      public ISudoControllerClient SudoControllerClient;
      public ISystemControllerClient SystemControllerClient;
      public ITemplateModuleControllerClient TemplateModuleControllerClient;
      public ITimestampControllerClient TimestampControllerClient;
      public ITransactionPaymentControllerClient TransactionPaymentControllerClient;
      public Client(HttpClient httpClient, BaseSubscriptionClient subscriptionClient)
      {
         _httpClient = httpClient;
         _subscriptionClient = subscriptionClient;
         AuraControllerClient = new AuraControllerClient(_httpClient, _subscriptionClient);
         BalancesControllerClient = new BalancesControllerClient(_httpClient, _subscriptionClient);
         GrandpaControllerClient = new GrandpaControllerClient(_httpClient, _subscriptionClient);
         NicksControllerClient = new NicksControllerClient(_httpClient, _subscriptionClient);
         RandomnessCollectiveFlipControllerClient = new RandomnessCollectiveFlipControllerClient(_httpClient, _subscriptionClient);
         SudoControllerClient = new SudoControllerClient(_httpClient, _subscriptionClient);
         SystemControllerClient = new SystemControllerClient(_httpClient, _subscriptionClient);
         TemplateModuleControllerClient = new TemplateModuleControllerClient(_httpClient, _subscriptionClient);
         TimestampControllerClient = new TimestampControllerClient(_httpClient, _subscriptionClient);
         TransactionPaymentControllerClient = new TransactionPaymentControllerClient(_httpClient, _subscriptionClient);
      }
   }
}
