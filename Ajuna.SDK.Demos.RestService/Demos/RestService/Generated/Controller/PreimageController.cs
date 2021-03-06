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
    /// PreimageController controller to access storages.
    /// </summary>
    [ApiController()]
    [Route("[controller]")]
    public sealed class PreimageController : ControllerBase
    {
        
        private IPreimageStorage _preimageStorage;
        
        /// <summary>
        /// PreimageController constructor.
        /// </summary>
        public PreimageController(IPreimageStorage preimageStorage)
        {
            _preimageStorage = preimageStorage;
        }
        
        /// <summary>
        /// >> StatusFor
        ///  The request status of a given hash.
        /// </summary>
        [HttpGet("StatusFor")]
        [ProducesResponseType(typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_preimage.EnumRequestStatus), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.PreimageStorage), "StatusForParams", typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetStatusFor(string key)
        {
            return this.Ok(_preimageStorage.GetStatusFor(key));
        }
        
        /// <summary>
        /// >> PreimageFor
        ///  The preimages stored by this pallet.
        /// </summary>
        [HttpGet("PreimageFor")]
        [ProducesResponseType(typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.sp_runtime.bounded.bounded_vec.BoundedVecT27), 200)]
        [StorageKeyBuilder(typeof(Ajuna.SDK.Demos.NetApi.Generated.Storage.PreimageStorage), "PreimageForParams", typeof(Ajuna.SDK.Demos.NetApi.Generated.Model.primitive_types.H256))]
        public IActionResult GetPreimageFor(string key)
        {
            return this.Ok(_preimageStorage.GetPreimageFor(key));
        }
    }
}
