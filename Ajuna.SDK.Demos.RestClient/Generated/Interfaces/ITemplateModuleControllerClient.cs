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
   
   public interface ITemplateModuleControllerClient
   {
      Task<BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U32>> GetProofs(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 key);
      Task<bool> SubscribeProofs(Ajuna.SDK.Demos.NetApi.Generated.Model.FrameSupport.BoundedVecT1 key);
   }
}
