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
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface ISchedulerControllerClient
   {
      Task<BaseVec<BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_scheduler.ScheduledV3>>> GetAgenda(U32 key);
      Task<bool> SubscribeAgenda(U32 key);
      Task<BaseTuple<U32, U32>> GetLookup(BaseVec<U8> key);
      Task<bool> SubscribeLookup(BaseVec<U8> key);
   }
}
