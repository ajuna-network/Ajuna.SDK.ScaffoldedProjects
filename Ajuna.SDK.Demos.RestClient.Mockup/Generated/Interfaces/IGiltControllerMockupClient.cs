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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_gilt.pallet;
   
   public interface IGiltControllerMockupClient
   {
      Task<bool> SetQueueTotals(BoundedVecT32 value);
      Task<bool> SetQueues(BoundedVecT33 value, Ajuna.NetApi.Model.Types.Primitive.U32 key);
      Task<bool> SetActiveTotal(ActiveGiltsTotal value);
      Task<bool> SetActive(ActiveGilt value, Ajuna.NetApi.Model.Types.Primitive.U32 key);
   }
}