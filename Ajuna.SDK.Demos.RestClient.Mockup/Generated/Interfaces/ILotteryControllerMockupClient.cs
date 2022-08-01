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
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_lottery;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   
   public interface ILotteryControllerMockupClient
   {
      Task<bool> SetLotteryIndex(U32 value);
      Task<bool> SetLottery(LotteryConfig value);
      Task<bool> SetParticipants(BaseTuple<U32, BoundedVecT31> value, AccountId32 key);
      Task<bool> SetTicketsCount(U32 value);
      Task<bool> SetTickets(AccountId32 value, U32 key);
      Task<bool> SetCallIndices(BoundedVecT31 value);
   }
}