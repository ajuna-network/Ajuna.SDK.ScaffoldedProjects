//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.SDK.Demos.RestService.Generated.Storage;
using Ajuna.ServiceLayer.Attributes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ajuna.SDK.Demos.RestService.Generated.Controller
{
    
    
    /// <summary>
    /// ProxyController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class ProxyController : ControllerBase
    {
        
        private IProxyStorage _proxyStorage;
        
        /// <summary>
        /// ProxyController constructor.
        /// </summary>
        public ProxyController(IProxyStorage proxyStorage)
        {
            _proxyStorage = proxyStorage;
        }
        
        /// <summary>
        /// >> Proxies
        ///  The set of account proxies. Maps the account which has delegated to the accounts
        ///  which are being delegated to, together with the amount held on deposit.
        /// </summary>
        [HttpGet("Proxies")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT28, Ajuna.NetApi.Model.Types.Primitive.U128>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.ProxyStorage), "ProxiesParams", typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetProxies(string key)
        {
            return this.Ok(_proxyStorage.GetProxies(key));
        }
        
        /// <summary>
        /// >> Announcements
        ///  The announcements made by the proxy (key).
        /// </summary>
        [HttpGet("Announcements")]
        [ProducesResponseType(typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT29, Ajuna.NetApi.Model.Types.Primitive.U128>), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.ProxyStorage), "AnnouncementsParams", typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_core.crypto.AccountId32))]
        public IActionResult GetAnnouncements(string key)
        {
            return this.Ok(_proxyStorage.GetAnnouncements(key));
        }
    }
}
