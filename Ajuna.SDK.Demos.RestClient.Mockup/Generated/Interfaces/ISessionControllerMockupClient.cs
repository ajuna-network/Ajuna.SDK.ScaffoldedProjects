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
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto;
   using Ajuna.NetApi.Model.Types.Primitive;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.node_runtime;
   
   public interface ISessionControllerMockupClient
   {
      Task<bool> SetValidators(BaseVec<AccountId32> value);
      Task<bool> SetCurrentIndex(U32 value);
      Task<bool> SetQueuedChanged(Bool value);
      Task<bool> SetQueuedKeys(BaseVec<BaseTuple<AccountId32, SessionKeys>> value);
      Task<bool> SetDisabledValidators(BaseVec<U32> value);
      Task<bool> SetNextKeys(SessionKeys value, AccountId32 key);
      Task<bool> SetKeyOwner(AccountId32 value, BaseTuple<KeyTypeId, BaseVec<U8>> key);
   }
}
