//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.NetApi.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> FellowshipCollectiveStorage
    /// </summary>
    public sealed class FellowshipCollectiveStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> FellowshipCollectiveStorage Constructor
        /// </summary>
        public FellowshipCollectiveStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "MemberCount"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U16), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "Members"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32), typeof(Substrate.NetApi.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "IdToIndex"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(Substrate.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "IndexToId"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "Voting"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>), typeof(Substrate.NetApi.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("FellowshipCollective", "VotingCleanup"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Substrate.NetApi.Model.Types.Primitive.U32), typeof(Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35)));
        }
        
        /// <summary>
        /// >> MemberCountParams
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        public static string MemberCountParams(Substrate.NetApi.Model.Types.Primitive.U16 key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "MemberCount", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MemberCountDefault
        /// Default value as hex string
        /// </summary>
        public static string MemberCountDefault()
        {
            return "0x00000000";
        }
        
        /// <summary>
        /// >> MemberCount
        ///  The number of members in the collective who have at least the rank according to the index
        ///  of the vec.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> MemberCount(Substrate.NetApi.Model.Types.Primitive.U16 key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.MemberCountParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> MembersParams
        ///  The current members of the collective.
        /// </summary>
        public static string MembersParams(Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "Members", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> MembersDefault
        /// Default value as hex string
        /// </summary>
        public static string MembersDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Members
        ///  The current members of the collective.
        /// </summary>
        public async Task<Substrate.NetApi.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord> Members(Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.MembersParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.NetApiExt.Generated.Model.pallet_ranked_collective.MemberRecord>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> IdToIndexParams
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        public static string IdToIndexParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "IdToIndex", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> IdToIndexDefault
        /// Default value as hex string
        /// </summary>
        public static string IdToIndexDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> IdToIndex
        ///  The index of each ranks's member into the group of members who have at least that rank.
        /// </summary>
        public async Task<Substrate.NetApi.Model.Types.Primitive.U32> IdToIndex(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.IdToIndexParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.Model.Types.Primitive.U32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> IndexToIdParams
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        public static string IndexToIdParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "IndexToId", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> IndexToIdDefault
        /// Default value as hex string
        /// </summary>
        public static string IndexToIdDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> IndexToId
        ///  The members in the collective by index. All indices in the range `0..MemberCount` will
        ///  return `Some`, however a member's index is not guaranteed to remain unchanged over time.
        /// </summary>
        public async Task<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> IndexToId(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U16, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.IndexToIdParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> VotingParams
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public static string VotingParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "Voting", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat,
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, key.Value);
        }
        
        /// <summary>
        /// >> VotingDefault
        /// Default value as hex string
        /// </summary>
        public static string VotingDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Voting
        ///  Votes on a given proposal, if it is ongoing.
        /// </summary>
        public async Task<Substrate.NetApi.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord> Voting(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.VotingParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.NetApiExt.Generated.Model.pallet_ranked_collective.EnumVoteRecord>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> VotingCleanupParams
        /// </summary>
        public static string VotingCleanupParams(Substrate.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("FellowshipCollective", "VotingCleanup", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> VotingCleanupDefault
        /// Default value as hex string
        /// </summary>
        public static string VotingCleanupDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> VotingCleanup
        /// </summary>
        public async Task<Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35> VotingCleanup(Substrate.NetApi.Model.Types.Primitive.U32 key, string blockhash, CancellationToken token)
        {
            string parameters = FellowshipCollectiveStorage.VotingCleanupParams(key);
            var result = await _client.GetStorageAsync<Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT35>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> FellowshipCollectiveCalls
    /// </summary>
    public sealed class FellowshipCollectiveCalls
    {
        
        /// <summary>
        /// >> add_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method AddMember(Substrate.NetApi.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(47, "FellowshipCollective", 0, "add_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> promote_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method PromoteMember(Substrate.NetApi.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(47, "FellowshipCollective", 1, "promote_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> demote_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method DemoteMember(Substrate.NetApi.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            return new Method(47, "FellowshipCollective", 2, "demote_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remove_member
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method RemoveMember(Substrate.NetApi.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Substrate.NetApi.Model.Types.Primitive.U16 min_rank)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(min_rank.Encode());
            return new Method(47, "FellowshipCollective", 3, "remove_member", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vote
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method Vote(Substrate.NetApi.Model.Types.Primitive.U32 poll, Substrate.NetApi.Model.Types.Primitive.Bool aye)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll.Encode());
            byteArray.AddRange(aye.Encode());
            return new Method(47, "FellowshipCollective", 4, "vote", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> cleanup_poll
        /// Contains a variant per dispatchable extrinsic that this pallet has.
        /// </summary>
        public static Method CleanupPoll(Substrate.NetApi.Model.Types.Primitive.U32 poll_index, Substrate.NetApi.Model.Types.Primitive.U32 max)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(poll_index.Encode());
            byteArray.AddRange(max.Encode());
            return new Method(47, "FellowshipCollective", 5, "cleanup_poll", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> FellowshipCollectiveConstants
    /// </summary>
    public sealed class FellowshipCollectiveConstants
    {
    }
    
    /// <summary>
    /// >> FellowshipCollectiveErrors
    /// </summary>
    public enum FellowshipCollectiveErrors
    {
        
        /// <summary>
        /// >> AlreadyMember
        /// Account is already a member.
        /// </summary>
        AlreadyMember,
        
        /// <summary>
        /// >> NotMember
        /// Account is not a member.
        /// </summary>
        NotMember,
        
        /// <summary>
        /// >> NotPolling
        /// The given poll index is unknown or has closed.
        /// </summary>
        NotPolling,
        
        /// <summary>
        /// >> Ongoing
        /// The given poll is still ongoing.
        /// </summary>
        Ongoing,
        
        /// <summary>
        /// >> NoneRemaining
        /// There are no further records to be removed.
        /// </summary>
        NoneRemaining,
        
        /// <summary>
        /// >> Corruption
        /// Unexpected error in state.
        /// </summary>
        Corruption,
        
        /// <summary>
        /// >> RankTooLow
        /// The member's rank is too low to vote.
        /// </summary>
        RankTooLow,
        
        /// <summary>
        /// >> InvalidWitness
        /// The information provided is incorrect.
        /// </summary>
        InvalidWitness,
        
        /// <summary>
        /// >> NoPermission
        /// The origin is not sufficiently privileged to do the operation.
        /// </summary>
        NoPermission,
    }
}
