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
   using Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_child_bounties;
   using Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec;
   
   public interface IChildBountiesControllerMockupClient
   {
      Task<bool> SetChildBountyCount(U32 value);
      Task<bool> SetParentChildBounties(U32 value, U32 key);
      Task<bool> SetChildBounties(ChildBounty value, Ajuna.NetApi.Model.Types.Base.BaseTuple<U32, U32> key);
      Task<bool> SetChildBountyDescriptions(BoundedVecT30 value, U32 key);
      Task<bool> SetChildrenCuratorFees(U128 value, U32 key);
   }
}