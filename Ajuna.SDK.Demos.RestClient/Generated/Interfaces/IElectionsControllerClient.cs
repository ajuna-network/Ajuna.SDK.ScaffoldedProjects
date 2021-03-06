//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ajuna.SDK.Demos.RestClient.Generated.Interfaces
{
   using System;
   using System.Threading.Tasks;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_elections_phragmen;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface IElectionsControllerClient
   {
      Task<BaseVec<SeatHolder>> GetMembers();
      Task<bool> SubscribeMembers();
      Task<BaseVec<SeatHolder>> GetRunnersUp();
      Task<bool> SubscribeRunnersUp();
      Task<BaseVec<BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32, U128>>> GetCandidates();
      Task<bool> SubscribeCandidates();
      Task<U32> GetElectionRounds();
      Task<bool> SubscribeElectionRounds();
      Task<Voter> GetVoting(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
      Task<bool> SubscribeVoting(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32 key);
   }
}
