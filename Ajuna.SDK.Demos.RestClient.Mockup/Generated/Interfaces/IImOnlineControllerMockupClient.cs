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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.weak_bounded_vec;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.misc;
   
   public interface IImOnlineControllerMockupClient
   {
      Task<bool> SetHeartbeatAfter(U32 value);
      Task<bool> SetKeys(WeakBoundedVecT4 value);
      Task<bool> SetReceivedHeartbeats(WrapperOpaque value, Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key);
      Task<bool> SetAuthoredBlocks(U32 value, Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32> key);
   }
}