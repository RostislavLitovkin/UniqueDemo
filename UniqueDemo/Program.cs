// See https://aka.ms/new-console-template for more information
using System.Text;
using Newtonsoft.Json.Linq;
using Schnorrkel.Keys;
using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using Substrate.NetApi.NetApiExt.Generated;
using Substrate.NetApi.NetApiExt.Generated.Model.bounded_collections.bounded_vec;
using Substrate.NetApi.NetApiExt.Generated.Model.sp_core.crypto;
using Substrate.NetApi.NetApiExt.Generated.Model.up_data_structs;
using Substrate.NetApi.NetApiExt.Generated.Storage;
using static Substrate.NetApi.Mnemonic;

var client = new SubstrateClientExt(
    new Uri("wss://ws-opal.unique.network"),
    ChargeTransactionPayment.Default());

await client.ConnectAsync();

Console.WriteLine(client.GenesisHash);


var mnemonics = "collect salad honey track clerk energy agent empty edit devote mixed injury";

ExpandMode expandMode = ExpandMode.Ed25519; // Currently preferred in Substrate
string password = "please_put_here_something_better_than_password123";

var secret = Mnemonic.GetSecretKeyFromMnemonic(mnemonics, password, BIP39Wordlist.English);

var miniSecret = new MiniSecret(secret, expandMode);

// Our actual Account, that will be used for signing extrinsics/messages
Account account = Account.Build(
    KeyType.Sr25519,
    miniSecret.ExpandToSecret().ToBytes(),
    miniSecret.GetPair().Public.Key);

var accountId = new AccountId32();
accountId.Create(Utils.GetPublicKeyFrom(account.Value));

var accountInfo = await client.SystemStorage.Account(accountId, null, CancellationToken.None);

//Console.WriteLine(accountInfo.Data.Free);

var createCollectionData = new CreateCollectionData();

var enumCollectionMode = new EnumCollectionMode();
enumCollectionMode.Create(CollectionMode.NFT, new BaseVoid());

createCollectionData.Mode = enumCollectionMode;

var name = new BoundedVecT8();

int p = 0;

var nameVec = new BaseVec<U16>();
nameVec.Create(new U16[] { new U16(97) });

name.Value = nameVec;

var descriptionVec = new BaseVec<U16>();
descriptionVec.Create(new U16[] { new U16(98) });


var description = new BoundedVecT9();

description.Value = descriptionVec;

var tokenPrefix = new BoundedVecT10();

BaseVec<U8> message = new BaseVec<U8>();
message.Create(new U8[] { new U8(99) });

tokenPrefix.Value = message;

createCollectionData.Name = name;

createCollectionData.Description = description;

createCollectionData.TokenPrefix = tokenPrefix;

Method method = UniqueCalls.CreateCollectionEx(createCollectionData);

await client.Author.SubmitExtrinsicAsync(
    method, account, ChargeTransactionPayment.Default(), 32, CancellationToken.None);

Console.ReadKey();