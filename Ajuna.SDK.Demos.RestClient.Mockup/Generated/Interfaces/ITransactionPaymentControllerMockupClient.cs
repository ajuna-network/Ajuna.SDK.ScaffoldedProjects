//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Mockup.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.SpArithmetic;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.PalletTransactionPayment;
   
   public interface ITransactionPaymentControllerMockupClient
   {
      Task<bool> SetNextFeeMultiplier(FixedU128 value);
      Task<bool> SetStorageVersion(EnumReleases value);
   }
}
