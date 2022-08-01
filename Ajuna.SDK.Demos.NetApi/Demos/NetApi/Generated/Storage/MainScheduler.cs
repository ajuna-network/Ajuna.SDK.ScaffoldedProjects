//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.SDK.Demos.NetApi.Generated.Storage
{
    
    
    public sealed class SchedulerStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SchedulerStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Scheduler", "Agenda"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_scheduler.ScheduledV3>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Scheduler", "Lookup"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>), typeof(Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>)));
        }
        
        /// <summary>
        /// >> AgendaParams
        ///  Items to be executed, indexed by the block number that they should be executed on.
        /// </summary>
        public static string AgendaParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("Scheduler", "Agenda", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Agenda
        ///  Items to be executed, indexed by the block number that they should be executed on.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_scheduler.ScheduledV3>>> Agenda(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = SchedulerStorage.AgendaParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.SDK.Demos.NetApi.Generated.Model.pallet_scheduler.ScheduledV3>>>(parameters, token);
        }
        
        /// <summary>
        /// >> LookupParams
        ///  Lookup from identity to the block number and index of the task.
        /// </summary>
        public static string LookupParams(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> key)
        {
            return RequestGenerator.GetStorage("Scheduler", "Lookup", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Lookup
        ///  Lookup from identity to the block number and index of the task.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> Lookup(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> key, CancellationToken token)
        {
            string parameters = SchedulerStorage.LookupParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>>(parameters, token);
        }
    }
    
    public sealed class SchedulerCalls
    {
        
        /// <summary>
        /// >> schedule
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Schedule(Ajuna.NetApi.Model.Types.Primitive.U32 when, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> maybe_periodic, Ajuna.NetApi.Model.Types.Primitive.U8 priority, Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.schedule.EnumMaybeHashed call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(when.Encode());
            byteArray.AddRange(maybe_periodic.Encode());
            byteArray.AddRange(priority.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(30, "Scheduler", 0, "schedule", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Cancel(Ajuna.NetApi.Model.Types.Primitive.U32 when, Ajuna.NetApi.Model.Types.Primitive.U32 index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(when.Encode());
            byteArray.AddRange(index.Encode());
            return new Method(30, "Scheduler", 1, "cancel", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> schedule_named
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ScheduleNamed(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> id, Ajuna.NetApi.Model.Types.Primitive.U32 when, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> maybe_periodic, Ajuna.NetApi.Model.Types.Primitive.U8 priority, Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.schedule.EnumMaybeHashed call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(when.Encode());
            byteArray.AddRange(maybe_periodic.Encode());
            byteArray.AddRange(priority.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(30, "Scheduler", 2, "schedule_named", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cancel_named
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method CancelNamed(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> id)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            return new Method(30, "Scheduler", 3, "cancel_named", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> schedule_after
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ScheduleAfter(Ajuna.NetApi.Model.Types.Primitive.U32 after, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> maybe_periodic, Ajuna.NetApi.Model.Types.Primitive.U8 priority, Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.schedule.EnumMaybeHashed call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(after.Encode());
            byteArray.AddRange(maybe_periodic.Encode());
            byteArray.AddRange(priority.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(30, "Scheduler", 4, "schedule_after", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> schedule_named_after
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ScheduleNamedAfter(Ajuna.NetApi.Model.Types.Base.BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> id, Ajuna.NetApi.Model.Types.Primitive.U32 after, Ajuna.NetApi.Model.Types.Base.BaseOpt<Ajuna.NetApi.Model.Types.Base.BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32, Ajuna.NetApi.Model.Types.Primitive.U32>> maybe_periodic, Ajuna.NetApi.Model.Types.Primitive.U8 priority, Ajuna.SDK.Demos.NetApi.Generated.Model.frame_support.traits.schedule.EnumMaybeHashed call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(id.Encode());
            byteArray.AddRange(after.Encode());
            byteArray.AddRange(maybe_periodic.Encode());
            byteArray.AddRange(priority.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(30, "Scheduler", 5, "schedule_named_after", byteArray.ToArray());
        }
    }
    
    public enum SchedulerErrors
    {
        
        /// <summary>
        /// >> FailedToSchedule
        /// Failed to schedule a call
        /// </summary>
        FailedToSchedule,
        
        /// <summary>
        /// >> NotFound
        /// Cannot find the scheduled call.
        /// </summary>
        NotFound,
        
        /// <summary>
        /// >> TargetBlockNumberInPast
        /// Given target block number is in the past.
        /// </summary>
        TargetBlockNumberInPast,
        
        /// <summary>
        /// >> RescheduleNoChange
        /// Reschedule failed because it does not change scheduled time.
        /// </summary>
        RescheduleNoChange,
    }
}
