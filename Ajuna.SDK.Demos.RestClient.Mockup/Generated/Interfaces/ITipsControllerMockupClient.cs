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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_tips;
   using Ajuna.NetApi.Model.Types.Base;
   using Ajuna.NetApi.Model.Types.Primitive;
   
   public interface ITipsControllerMockupClient
   {
      Task<bool> SetTips(OpenTip value, Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key);
      Task<bool> SetReasons(BaseVec<U8> value, Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256 key);
   }
}