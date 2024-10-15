// Decompiled with JetBrains decompiler
// Type: SRPG.Network
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Gsc.App;
using Gsc.App.NetworkHelper;
using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E2D")]
  [AddComponentMenu("Scripts/SRPG/Manager/Network")]
  public class Network : MonoSingleton<Network>
  {
    [Token(Token = "0x400E620")]
    [FieldOffset(Offset = "0x0")]
    public static Network.RequestResults RequestResult;
    [Token(Token = "0x400E621")]
    [FieldOffset(Offset = "0x4")]
    public static readonly float WEBAPI_TIMEOUT_SEC;
    [Token(Token = "0x400E622")]
    [FieldOffset(Offset = "0x8")]
    public static Network.EConnectMode Mode;
    [Token(Token = "0x400E623")]
    [FieldOffset(Offset = "0xC")]
    public static readonly string OfficialUrl;
    [Token(Token = "0x400E624")]
    [FieldOffset(Offset = "0x10")]
    public static readonly string DefaultHost;
    [Token(Token = "0x400E625")]
    [FieldOffset(Offset = "0x14")]
    public static readonly string DefaultDLHost;
    [Token(Token = "0x400E626")]
    [FieldOffset(Offset = "0x18")]
    public static readonly string DefaultSiteHost;
    [Token(Token = "0x400E627")]
    [FieldOffset(Offset = "0x1C")]
    public static readonly string DefaultNewsHost;
    [Token(Token = "0x400E628")]
    [FieldOffset(Offset = "0x20")]
    private static long ServerTime;
    [Token(Token = "0x400E629")]
    [FieldOffset(Offset = "0x28")]
    private static long LastRealTime;
    [Token(Token = "0x400E62A")]
    [FieldOffset(Offset = "0xC")]
    private string mSessionID;
    [Token(Token = "0x400E62B")]
    [FieldOffset(Offset = "0x10")]
    private string mVersion;
    [Token(Token = "0x400E62C")]
    [FieldOffset(Offset = "0x14")]
    private string mAssets;
    [Token(Token = "0x400E62D")]
    [FieldOffset(Offset = "0x18")]
    private string mAssetsEx;
    [Token(Token = "0x400E62E")]
    [FieldOffset(Offset = "0x1C")]
    private int mTicket;
    [Token(Token = "0x400E62F")]
    [FieldOffset(Offset = "0x20")]
    private bool mBusy;
    [Token(Token = "0x400E630")]
    [FieldOffset(Offset = "0x21")]
    private bool mRetry;
    [Token(Token = "0x400E631")]
    [FieldOffset(Offset = "0x22")]
    private bool mError;
    [Token(Token = "0x400E632")]
    [FieldOffset(Offset = "0x24")]
    private string mErrMsg;
    [Token(Token = "0x400E633")]
    [FieldOffset(Offset = "0x28")]
    private Network.EErrCode mErrCode;
    [Token(Token = "0x400E634")]
    [FieldOffset(Offset = "0x2C")]
    private bool mImmediateMode;
    [Token(Token = "0x400E635")]
    [FieldOffset(Offset = "0x2D")]
    private bool mMenteCheckFlag;
    [Token(Token = "0x400E636")]
    [FieldOffset(Offset = "0x30")]
    private WebAPI mCurrentRequest;
    [Token(Token = "0x400E637")]
    [FieldOffset(Offset = "0x34")]
    private List<WebAPI> mRequests;
    [Token(Token = "0x400E638")]
    [FieldOffset(Offset = "0x38")]
    private bool mIndicator;
    [Token(Token = "0x400E639")]
    [FieldOffset(Offset = "0x3C")]
    private UnityWebRequest mWebReq;
    [Token(Token = "0x400E63A")]
    [FieldOffset(Offset = "0x40")]
    private bool mAbort;
    [Token(Token = "0x400E63B")]
    [FieldOffset(Offset = "0x41")]
    private bool mNoVersion;
    [Token(Token = "0x400E63C")]
    [FieldOffset(Offset = "0x42")]
    private bool mForceBusy;
    [Token(Token = "0x400E63D")]
    [FieldOffset(Offset = "0x44")]
    private string mDefaultHostConfigured;
    [Token(Token = "0x400E63E")]
    [FieldOffset(Offset = "0x30")]
    private static string _updatedMasterDigest;
    [Token(Token = "0x400E63F")]
    [FieldOffset(Offset = "0x34")]
    private static string _updatedQuestDigest;
    [Token(Token = "0x400E640")]
    [FieldOffset(Offset = "0x38")]
    private static string _updatedEnvFlg2;

    [Token(Token = "0x17001CE2")]
    public static bool IsImmediateMode
    {
      [Token(Token = "0x600DA1C"), Address(RVA = "0xA4BF70", Offset = "0xA4AD70", VA = "0x10A4BF70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600DA1D")]
    [Address(RVA = "0xA4AE40", Offset = "0xA49C40", VA = "0x10A4AE40")]
    public static void SetDefaultHostConfigured(string host)
    {
    }

    [Token(Token = "0x600DA1E")]
    [Address(RVA = "0xA4A6A0", Offset = "0xA494A0", VA = "0x10A4A6A0")]
    public static string GetDefaultHostConfigured() => (string) null;

    [Token(Token = "0x17001CE3")]
    public static Environment GetEnvironment
    {
      [Token(Token = "0x600DA1F"), Address(RVA = "0xA4BCC0", Offset = "0xA4AAC0", VA = "0x10A4BCC0")] get
      {
        return new Environment();
      }
    }

    [Token(Token = "0x17001CE4")]
    public static Environment.EnvironmentFlagBit GetEnvironmentFlagBitSafely
    {
      [Token(Token = "0x600DA20"), Address(RVA = "0xA4BBE0", Offset = "0xA4A9E0", VA = "0x10A4BBE0")] get
      {
        return new Environment.EnvironmentFlagBit();
      }
    }

    [Token(Token = "0x17001CE5")]
    public static string Host
    {
      [Token(Token = "0x600DA21"), Address(RVA = "0xA4BD50", Offset = "0xA4AB50", VA = "0x10A4BD50")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CE6")]
    public static string DLHost
    {
      [Token(Token = "0x600DA22"), Address(RVA = "0xA4BA50", Offset = "0xA4A850", VA = "0x10A4BA50")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CE7")]
    public static string SiteHost
    {
      [Token(Token = "0x600DA23"), Address(RVA = "0xA4C440", Offset = "0xA4B240", VA = "0x10A4C440")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CE8")]
    public static string NewsHost
    {
      [Token(Token = "0x600DA24"), Address(RVA = "0xA4C210", Offset = "0xA4B010", VA = "0x10A4C210")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CE9")]
    public static string MasterDigest
    {
      [Token(Token = "0x600DA25"), Address(RVA = "0xA4C130", Offset = "0xA4AF30", VA = "0x10A4C130")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA26"), Address(RVA = "0xA4C910", Offset = "0xA4B710", VA = "0x10A4C910")] set
      {
      }
    }

    [Token(Token = "0x17001CEA")]
    public static string QuestDigest
    {
      [Token(Token = "0x600DA27"), Address(RVA = "0xA4C360", Offset = "0xA4B160", VA = "0x10A4C360")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA28"), Address(RVA = "0xA4CA00", Offset = "0xA4B800", VA = "0x10A4CA00")] set
      {
      }
    }

    [Token(Token = "0x17001CEB")]
    public static string EnvFlg2
    {
      [Token(Token = "0x600DA29"), Address(RVA = "0xA4BAC0", Offset = "0xA4A8C0", VA = "0x10A4BAC0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA2A"), Address(RVA = "0xA4C650", Offset = "0xA4B450", VA = "0x10A4C650")] set
      {
      }
    }

    [Token(Token = "0x17001CEC")]
    public static string Pub
    {
      [Token(Token = "0x600DA2B"), Address(RVA = "0xA4C2F0", Offset = "0xA4B0F0", VA = "0x10A4C2F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CED")]
    public static string PubU
    {
      [Token(Token = "0x600DA2C"), Address(RVA = "0xA4C280", Offset = "0xA4B080", VA = "0x10A4C280")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001CEE")]
    public static string AssetVersion
    {
      [Token(Token = "0x600DA2D"), Address(RVA = "0xA4BA10", Offset = "0xA4A810", VA = "0x10A4BA10")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA2E"), Address(RVA = "0xA4C600", Offset = "0xA4B400", VA = "0x10A4C600")] set
      {
      }
    }

    [Token(Token = "0x17001CEF")]
    public static string AssetVersionEx
    {
      [Token(Token = "0x600DA2F"), Address(RVA = "0xA4B9D0", Offset = "0xA4A7D0", VA = "0x10A4B9D0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA30"), Address(RVA = "0xA4C5B0", Offset = "0xA4B3B0", VA = "0x10A4C5B0")] set
      {
      }
    }

    [Token(Token = "0x17001CF0")]
    public static string Version
    {
      [Token(Token = "0x600DA31"), Address(RVA = "0xA4C4F0", Offset = "0xA4B2F0", VA = "0x10A4C4F0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA32"), Address(RVA = "0xA4CB40", Offset = "0xA4B940", VA = "0x10A4CB40")] set
      {
      }
    }

    [Token(Token = "0x17001CF1")]
    public static string SessionID
    {
      [Token(Token = "0x600DA33"), Address(RVA = "0xA4C400", Offset = "0xA4B200", VA = "0x10A4C400")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA34"), Address(RVA = "0xA4CAB0", Offset = "0xA4B8B0", VA = "0x10A4CAB0")] set
      {
      }
    }

    [Token(Token = "0x17001CF2")]
    public static int TicketID
    {
      [Token(Token = "0x600DA35"), Address(RVA = "0xA4C4B0", Offset = "0xA4B2B0", VA = "0x10A4C4B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600DA36"), Address(RVA = "0xA4CB00", Offset = "0xA4B900", VA = "0x10A4CB00")] private set
      {
      }
    }

    [Token(Token = "0x17001CF3")]
    public static bool IsBusy
    {
      [Token(Token = "0x600DA37"), Address(RVA = "0xA4BDC0", Offset = "0xA4ABC0", VA = "0x10A4BDC0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA38"), Address(RVA = "0xA4C790", Offset = "0xA4B590", VA = "0x10A4C790")] private set
      {
      }
    }

    [Token(Token = "0x17001CF4")]
    public static bool IsRetry
    {
      [Token(Token = "0x600DA39"), Address(RVA = "0xA4C030", Offset = "0xA4AE30", VA = "0x10A4C030")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA3A"), Address(RVA = "0xA4C8D0", Offset = "0xA4B6D0", VA = "0x10A4C8D0")] set
      {
      }
    }

    [Token(Token = "0x17001CF5")]
    public static bool IsError
    {
      [Token(Token = "0x600DA3B"), Address(RVA = "0xA4BEE0", Offset = "0xA4ACE0", VA = "0x10A4BEE0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA3C"), Address(RVA = "0xA4C7D0", Offset = "0xA4B5D0", VA = "0x10A4C7D0")] private set
      {
      }
    }

    [Token(Token = "0x17001CF6")]
    public static string ErrMsg
    {
      [Token(Token = "0x600DA3D"), Address(RVA = "0xA4BBA0", Offset = "0xA4A9A0", VA = "0x10A4BBA0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600DA3E"), Address(RVA = "0xA4C740", Offset = "0xA4B540", VA = "0x10A4C740")] set
      {
      }
    }

    [Token(Token = "0x17001CF7")]
    public static Network.EErrCode ErrCode
    {
      [Token(Token = "0x600DA3F"), Address(RVA = "0xA4BB60", Offset = "0xA4A960", VA = "0x10A4BB60")] get
      {
        return new Network.EErrCode();
      }
      [Token(Token = "0x600DA40"), Address(RVA = "0xA4C700", Offset = "0xA4B500", VA = "0x10A4C700")] set
      {
      }
    }

    [Token(Token = "0x17001CF8")]
    public static bool IsConnecting
    {
      [Token(Token = "0x600DA41"), Address(RVA = "0xA4BE60", Offset = "0xA4AC60", VA = "0x10A4BE60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CF9")]
    public static bool IsIndicator
    {
      [Token(Token = "0x600DA42"), Address(RVA = "0xA4BFB0", Offset = "0xA4ADB0", VA = "0x10A4BFB0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA43"), Address(RVA = "0xA4C850", Offset = "0xA4B650", VA = "0x10A4C850")] set
      {
      }
    }

    [Token(Token = "0x17001CFA")]
    public static UnityWebRequest uniWebRequest
    {
      [Token(Token = "0x600DA44"), Address(RVA = "0xA4C530", Offset = "0xA4B330", VA = "0x10A4C530")] get
      {
        return (UnityWebRequest) null;
      }
      [Token(Token = "0x600DA45"), Address(RVA = "0xA4CB90", Offset = "0xA4B990", VA = "0x10A4CB90")] set
      {
      }
    }

    [Token(Token = "0x17001CFB")]
    public static bool IsStreamConnecting
    {
      [Token(Token = "0x600DA46"), Address(RVA = "0xA4C070", Offset = "0xA4AE70", VA = "0x10A4C070")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001CFC")]
    public static bool Aborted
    {
      [Token(Token = "0x600DA47"), Address(RVA = "0xA4B990", Offset = "0xA4A790", VA = "0x10A4B990")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA48"), Address(RVA = "0xA4C570", Offset = "0xA4B370", VA = "0x10A4C570")] set
      {
      }
    }

    [Token(Token = "0x17001CFD")]
    public static bool IsNoVersion
    {
      [Token(Token = "0x600DA49"), Address(RVA = "0xA4BFF0", Offset = "0xA4ADF0", VA = "0x10A4BFF0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA4A"), Address(RVA = "0xA4C890", Offset = "0xA4B690", VA = "0x10A4C890")] set
      {
      }
    }

    [Token(Token = "0x17001CFE")]
    public static bool IsForceBusy
    {
      [Token(Token = "0x600DA4B"), Address(RVA = "0xA4BF30", Offset = "0xA4AD30", VA = "0x10A4BF30")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA4C"), Address(RVA = "0xA4C810", Offset = "0xA4B610", VA = "0x10A4C810")] set
      {
      }
    }

    [Token(Token = "0x17001CFF")]
    public static bool MenteCheckFlag
    {
      [Token(Token = "0x600DA4D"), Address(RVA = "0xA4C1D0", Offset = "0xA4AFD0", VA = "0x10A4C1D0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600DA4E"), Address(RVA = "0xA4C9C0", Offset = "0xA4B7C0", VA = "0x10A4C9C0")] set
      {
      }
    }

    [Token(Token = "0x600DA4F")]
    [Address(RVA = "0xA4A7D0", Offset = "0xA495D0", VA = "0x10A4A7D0", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x600DA50")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    protected override void Release()
    {
    }

    [Token(Token = "0x600DA51")]
    [Address(RVA = "0xA4ADB0", Offset = "0xA49BB0", VA = "0x10A4ADB0")]
    public static void Reset()
    {
    }

    [Token(Token = "0x600DA52")]
    [Address(RVA = "0xA4AC50", Offset = "0xA49A50", VA = "0x10A4AC50")]
    public static void RequestAPI(WebAPI api, bool highPriority = false)
    {
    }

    [Token(Token = "0x600DA53")]
    [Address(RVA = "0xA4AA00", Offset = "0xA49800", VA = "0x10A4AA00")]
    public static void RequestAPIImmediate(WebAPI api, bool autoRetry)
    {
    }

    [Token(Token = "0x600DA54")]
    [Address(RVA = "0xA4A8C0", Offset = "0xA496C0", VA = "0x10A4A8C0")]
    public static void RemoveAPI()
    {
    }

    [Token(Token = "0x600DA55")]
    [Address(RVA = "0xA4AD60", Offset = "0xA49B60", VA = "0x10A4AD60")]
    public static void ResetError()
    {
    }

    [Token(Token = "0x600DA56")]
    [Address(RVA = "0xA4AE90", Offset = "0xA49C90", VA = "0x10A4AE90")]
    public static void SetRetry()
    {
    }

    [Token(Token = "0x600DA57")]
    [Address(RVA = "0xA4A4C0", Offset = "0xA492C0", VA = "0x10A4A4C0")]
    private static int FindStat(string response) => new int();

    [Token(Token = "0x600DA58")]
    [Address(RVA = "0xA4A3F0", Offset = "0xA491F0", VA = "0x10A4A3F0")]
    private static string FindMessage(string response) => (string) null;

    [Token(Token = "0x600DA59")]
    [Address(RVA = "0xA4A5B0", Offset = "0xA493B0", VA = "0x10A4A5B0")]
    private static long FindTime(string response) => new long();

    [Token(Token = "0x600DA5A")]
    [Address(RVA = "0xA4A6E0", Offset = "0xA494E0", VA = "0x10A4A6E0")]
    public static long GetServerTime() => new long();

    [Token(Token = "0x17001D00")]
    public static long LastConnectionTime
    {
      [Token(Token = "0x600DA5B"), Address(RVA = "0xA4C0E0", Offset = "0xA4AEE0", VA = "0x10A4C0E0")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x600DA5C")]
    [Address(RVA = "0xA4B3A0", Offset = "0xA4A1A0", VA = "0x10A4B3A0")]
    private void Update()
    {
    }

    [Token(Token = "0x600DA5D")]
    [Address(RVA = "0xA4A040", Offset = "0xA48E40", VA = "0x10A4A040")]
    private void ConnectingGsc(WebAPI api)
    {
    }

    [Token(Token = "0x600DA5E")]
    [Address(RVA = "0xA4A190", Offset = "0xA48F90", VA = "0x10A4A190")]
    public static void ConnectingResponse(WebResponse response, Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x600DA5F")]
    [Address(RVA = "0xA4B300", Offset = "0xA4A100", VA = "0x10A4B300")]
    public static void SetServerTime(long time)
    {
    }

    [Token(Token = "0x600DA60")]
    [Address(RVA = "0xA4A390", Offset = "0xA49190", VA = "0x10A4A390")]
    private static IEnumerator Connecting(WebAPI api) => (IEnumerator) null;

    [Token(Token = "0x600DA61")]
    [Address(RVA = "0xA4B1E0", Offset = "0xA49FE0", VA = "0x10A4B1E0")]
    public static void SetServerSessionExpired()
    {
    }

    [Token(Token = "0x600DA62")]
    [Address(RVA = "0xA4B0C0", Offset = "0xA49EC0", VA = "0x10A4B0C0")]
    public static void SetServerMetaDataAsError()
    {
    }

    [Token(Token = "0x600DA63")]
    [Address(RVA = "0xA4AEA0", Offset = "0xA49CA0", VA = "0x10A4AEA0")]
    public static void SetServerInvalidDeviceError()
    {
    }

    [Token(Token = "0x600DA64")]
    [Address(RVA = "0xA4AFD0", Offset = "0xA49DD0", VA = "0x10A4AFD0")]
    public static void SetServerMetaDataAsError(Network.EErrCode code, string msg)
    {
    }

    [Token(Token = "0x600DA65")]
    [Address(RVA = "0xA4A7A0", Offset = "0xA495A0", VA = "0x10A4A7A0")]
    private static long GetSystemUptime() => new long();

    [Token(Token = "0x600DA66")]
    [Address(RVA = "0xA49F40", Offset = "0xA48D40", VA = "0x10A49F40")]
    public static void Abort()
    {
    }

    [Token(Token = "0x600DA67")]
    [Address(RVA = "0xA4B860", Offset = "0xA4A660", VA = "0x10A4B860")]
    public Network()
    {
    }

    [Token(Token = "0x600DA68")]
    [Address(RVA = "0xA4B6A0", Offset = "0xA4A4A0", VA = "0x10A4B6A0")]
    static Network()
    {
    }

    [Token(Token = "0x2002E2E")]
    public enum EErrCode
    {
      [Token(Token = "0x400E642")] TimeOut = -2, // 0xFFFFFFFE
      [Token(Token = "0x400E643")] Failed = -1, // 0xFFFFFFFF
      [Token(Token = "0x400E644")] Success = 0,
      [Token(Token = "0x400E645")] Unknown = 1,
      [Token(Token = "0x400E646")] Version = 2,
      [Token(Token = "0x400E647")] AssetVersion = 3,
      [Token(Token = "0x400E648")] NoVersionDbg = 4,
      [Token(Token = "0x400E649")] NoSID = 100, // 0x00000064
      [Token(Token = "0x400E64A")] Maintenance = 200, // 0x000000C8
      [Token(Token = "0x400E64B")] ChatMaintenance = 201, // 0x000000C9
      [Token(Token = "0x400E64C")] MultiMaintenance = 202, // 0x000000CA
      [Token(Token = "0x400E64D")] VsMaintenance = 203, // 0x000000CB
      [Token(Token = "0x400E64E")] BattleRecordMaintenance = 204, // 0x000000CC
      [Token(Token = "0x400E64F")] MultiVersionMaintenance = 205, // 0x000000CD
      [Token(Token = "0x400E650")] MultiTowerMaintenance = 206, // 0x000000CE
      [Token(Token = "0x400E651")] RankingQuestMaintenance = 207, // 0x000000CF
      [Token(Token = "0x400E652")] IllegalParam = 300, // 0x0000012C
      [Token(Token = "0x400E653")] API = 400, // 0x00000190
      [Token(Token = "0x400E709")] NotLocation = 401, // 0x00000191
      [Token(Token = "0x400E654")] ServerNotify = 500, // 0x000001F4
      [Token(Token = "0x400E655")] ServerNotifyAndGoToHome = 501, // 0x000001F5
      [Token(Token = "0x400E656")] ServerNotifyAndReloadScene = 502, // 0x000001F6
      [Token(Token = "0x400E657")] NoFile = 1000, // 0x000003E8
      [Token(Token = "0x400E658")] NoVersion = 1100, // 0x0000044C
      [Token(Token = "0x400E659")] SessionFailure = 1200, // 0x000004B0
      [Token(Token = "0x400E65A")] CreateStopped = 1300, // 0x00000514
      [Token(Token = "0x400E65B")] IllegalName = 1400, // 0x00000578
      [Token(Token = "0x400E65C")] IllegalComment = 1401, // 0x00000579
      [Token(Token = "0x400E65D")] NotExistUser = 1402, // 0x0000057A
      [Token(Token = "0x400E65E")] NoMail = 1500, // 0x000005DC
      [Token(Token = "0x400E65F")] MailReadable = 1501, // 0x000005DD
      [Token(Token = "0x400E660")] ReqFriendRequestMax = 1600, // 0x00000640
      [Token(Token = "0x400E661")] ReqFriendIsFull = 1601, // 0x00000641
      [Token(Token = "0x400E662")] ReqNoFriend = 1602, // 0x00000642
      [Token(Token = "0x400E663")] ReqFriendRegistered = 1603, // 0x00000643
      [Token(Token = "0x400E664")] ReqFriendRequesting = 1604, // 0x00000644
      [Token(Token = "0x400E665")] RmNoFriend = 1700, // 0x000006A4
      [Token(Token = "0x400E666")] RmFriendIsMe = 1701, // 0x000006A5
      [Token(Token = "0x400E66D")] NoUnitParty = 1800, // 0x00000708
      [Token(Token = "0x400E66E")] IllegalParty = 1801, // 0x00000709
      [Token(Token = "0x400E66F")] NotPartyUnit = 1802, // 0x0000070A
      [Token(Token = "0x400E670")] ExpMaterialShort = 1900, // 0x0000076C
      [Token(Token = "0x400E671")] RareMaterialShort = 2000, // 0x000007D0
      [Token(Token = "0x400E672")] RarePlayerLvShort = 2001, // 0x000007D1
      [Token(Token = "0x400E673")] PlusMaterialShot = 2100, // 0x00000834
      [Token(Token = "0x400E674")] PlusPlayerLvShort = 2101, // 0x00000835
      [Token(Token = "0x400E675")] AbilityMaterialShort = 2200, // 0x00000898
      [Token(Token = "0x400E676")] AbilityNotFound = 2201, // 0x00000899
      [Token(Token = "0x400E677")] NoJobSetJob = 2300, // 0x000008FC
      [Token(Token = "0x400E678")] CantSelectJob = 2301, // 0x000008FD
      [Token(Token = "0x400E679")] NoUnitSetJob = 2302, // 0x000008FE
      [Token(Token = "0x400E67A")] NoAbilitySetAbility = 2400, // 0x00000960
      [Token(Token = "0x400E67B")] NoJobSetAbility = 2401, // 0x00000961
      [Token(Token = "0x400E67C")] UnsetAbility = 2402, // 0x00000962
      [Token(Token = "0x400E67D")] NoJobSetEquip = 2500, // 0x000009C4
      [Token(Token = "0x400E67E")] NoEquipItem = 2501, // 0x000009C5
      [Token(Token = "0x400E67F")] Equipped = 2502, // 0x000009C6
      [Token(Token = "0x400E680")] NoJobEnforceEquip = 2600, // 0x00000A28
      [Token(Token = "0x400E681")] NoEquipEnforce = 2601, // 0x00000A29
      [Token(Token = "0x400E682")] ForceMax = 2602, // 0x00000A2A
      [Token(Token = "0x400E683")] MaterialShort = 2603, // 0x00000A2B
      [Token(Token = "0x400E684")] EnforcePlayerLvShort = 2604, // 0x00000A2C
      [Token(Token = "0x400E685")] NoJobLvUpEquip = 2700, // 0x00000A8C
      [Token(Token = "0x400E686")] EquipNotComp = 2701, // 0x00000A8D
      [Token(Token = "0x400E687")] PlusShort = 2702, // 0x00000A8E
      [Token(Token = "0x400E691")] NoItemSell = 2800, // 0x00000AF0
      [Token(Token = "0x400E692")] ConvertAnotherItem = 2801, // 0x00000AF1
      [Token(Token = "0x400E693")] GoldOverSell = 2802, // 0x00000AF2
      [Token(Token = "0x400E694")] StaminaCoinShort = 2900, // 0x00000B54
      [Token(Token = "0x400E695")] AddStaminaLimit = 2901, // 0x00000B55
      [Token(Token = "0x400E696")] AbilityCoinShort = 3000, // 0x00000BB8
      [Token(Token = "0x400E697")] AbilityVipLvShort = 3001, // 0x00000BB9
      [Token(Token = "0x400E698")] AbilityPlayerLvShort = 3002, // 0x00000BBA
      [Token(Token = "0x400E699")] GouseiNoTarget = 3200, // 0x00000C80
      [Token(Token = "0x400E69A")] GouseiMaterialShort = 3201, // 0x00000C81
      [Token(Token = "0x400E69B")] GouseiCostShort = 3202, // 0x00000C82
      [Token(Token = "0x400E69C")] UnSelectable = 3300, // 0x00000CE4
      [Token(Token = "0x400E69D")] OutOfDateQuest = 3301, // 0x00000CE5
      [Token(Token = "0x400E69E")] QuestNotEnd = 3302, // 0x00000CE6
      [Token(Token = "0x400E69F")] ChallengeLimit = 3303, // 0x00000CE7
      [Token(Token = "0x400E6A0")] TimeSpent = 3306, // 0x00000CEA
      [Token(Token = "0x400E70A")] NotGpsQuest = 3308, // 0x00000CEC
      [Token(Token = "0x400E6A1")] RecordLimitUpload = 3309, // 0x00000CED
      [Token(Token = "0x400E6A2")] CanNotResetQuest = 3320, // 0x00000CF8
      [Token(Token = "0x400E6A3")] NotEnoughItemToReset = 3321, // 0x00000CF9
      [Token(Token = "0x400E6A4")] ChallengesCountStillRemain = 3322, // 0x00000CFA
      [Token(Token = "0x400E6A5")] QuestResetNotEnoughCoin = 3323, // 0x00000CFB
      [Token(Token = "0x400E6A6")] QuestResume = 3400, // 0x00000D48
      [Token(Token = "0x400E6A7")] QuestEnd = 3500, // 0x00000DAC
      [Token(Token = "0x400E6A8")] ContinueCostShort = 3600, // 0x00000E10
      [Token(Token = "0x400E6A9")] CantContinue = 3601, // 0x00000E11
      [Token(Token = "0x400E796")] Advance_KeyClose = 3604, // 0x00000E14
      [Token(Token = "0x400E6E1")] NoBtlInfo = 3700, // 0x00000E74
      [Token(Token = "0x400E6E2")] MultiPlayerLvShort = 3701, // 0x00000E75
      [Token(Token = "0x400E6E3")] MultiBtlNotEnd = 3702, // 0x00000E76
      [Token(Token = "0x400E6E4")] MultiVersionMismatch = 3704, // 0x00000E78
      [Token(Token = "0x400E6E5")] DiffBattleVersion = 3705, // 0x00000E79
      [Token(Token = "0x400E6AA")] ColoCantSelect = 3800, // 0x00000ED8
      [Token(Token = "0x400E6AB")] ColoIsBusy = 3801, // 0x00000ED9
      [Token(Token = "0x400E6AC")] ColoCostShort = 3802, // 0x00000EDA
      [Token(Token = "0x400E6AD")] ColoIntervalShort = 3803, // 0x00000EDB
      [Token(Token = "0x400E6AE")] ColoBattleNotEnd = 3804, // 0x00000EDC
      [Token(Token = "0x400E6AF")] ColoPlayerLvShort = 3805, // 0x00000EDD
      [Token(Token = "0x400E6B0")] ColoVipShort = 3806, // 0x00000EDE
      [Token(Token = "0x400E6B1")] ColoRankLower = 3807, // 0x00000EDF
      [Token(Token = "0x400E6B2")] ColoNoBattle = 3900, // 0x00000F3C
      [Token(Token = "0x400E6B3")] ColoRankModify = 3901, // 0x00000F3D
      [Token(Token = "0x400E6B4")] ColoMyRankModify = 3902, // 0x00000F3E
      [Token(Token = "0x400E6B7")] NoGacha = 4000, // 0x00000FA0
      [Token(Token = "0x400E6B8")] GachaCostShort = 4001, // 0x00000FA1
      [Token(Token = "0x400E6B9")] GachaItemMax = 4002, // 0x00000FA2
      [Token(Token = "0x400E6BA")] GachaNotFree = 4003, // 0x00000FA3
      [Token(Token = "0x400E6BB")] GachaPaidLimitOver = 4004, // 0x00000FA4
      [Token(Token = "0x400E6BC")] GachaPlyLvOver = 4005, // 0x00000FA5
      [Token(Token = "0x400E6BD")] GachaPlyNewOver = 4006, // 0x00000FA6
      [Token(Token = "0x400E6BE")] GachaLimitSoldOut = 4007, // 0x00000FA7
      [Token(Token = "0x400E6BF")] GachaLimitCntOver = 4008, // 0x00000FA8
      [Token(Token = "0x400E6C0")] GachaOutofPeriod = 4010, // 0x00000FAA
      [Token(Token = "0x400E6C1")] CanNotApplyDiscount = 4011, // 0x00000FAB
      [Token(Token = "0x400E6C2")] AlreadyApplyDiscount = 4012, // 0x00000FAC
      [Token(Token = "0x400E6C3")] NotInPeriod = 4014, // 0x00000FAE
      [Token(Token = "0x400E6C4")] NotPickupSelect = 4017, // 0x00000FB1
      [Token(Token = "0x400E6C5")] NotPickupItems = 4018, // 0x00000FB2
      [Token(Token = "0x400E6C6")] IncorrectPickups = 4019, // 0x00000FB3
      [Token(Token = "0x400E6C7")] NoGachaPickup = 4020, // 0x00000FB4
      [Token(Token = "0x400E6C8")] CanNotChangePickupItems = 4021, // 0x00000FB5
      [Token(Token = "0x400E6C9")] EnoughCostItem = 4022, // 0x00000FB6
      [Token(Token = "0x400E6CA")] TrophyRewarded = 4100, // 0x00001004
      [Token(Token = "0x400E6CB")] TrophyOutOfDate = 4101, // 0x00001005
      [Token(Token = "0x400E6CC")] TrophyRollBack = 4102, // 0x00001006
      [Token(Token = "0x400E6CD")] BingoOutofDate = 4110, // 0x0000100E
      [Token(Token = "0x400E6CE")] BingoRemainingChildren = 4111, // 0x0000100F
      [Token(Token = "0x400E6CF")] BingoOutofDateReceive = 4112, // 0x00001010
      [Token(Token = "0x400E6D0")] ShopRefreshCostShort = 4200, // 0x00001068
      [Token(Token = "0x400E6D1")] ShopRefreshLvSort = 4201, // 0x00001069
      [Token(Token = "0x400E6D2")] ShopSoldOut = 4300, // 0x000010CC
      [Token(Token = "0x400E6D3")] ShopBuyCostShort = 4301, // 0x000010CD
      [Token(Token = "0x400E6D4")] ShopBuyLvShort = 4302, // 0x000010CE
      [Token(Token = "0x400E6D5")] ShopBuyNotFound = 4303, // 0x000010CF
      [Token(Token = "0x400E6D6")] ShopBuyItemNotFound = 4304, // 0x000010D0
      [Token(Token = "0x400E6D7")] ShopRefreshItemList = 4305, // 0x000010D1
      [Token(Token = "0x400E6D8")] ShopBuyOutofItemPeriod = 4306, // 0x000010D2
      [Token(Token = "0x400E6D9")] GoldBuyCostShort = 4400, // 0x00001130
      [Token(Token = "0x400E6DA")] GoldBuyLimit = 4401, // 0x00001131
      [Token(Token = "0x400E703")] EventShopOutOfPeriod = 4403, // 0x00001133
      [Token(Token = "0x400E701")] LimitedShopOutOfPeriod = 4403, // 0x00001133
      [Token(Token = "0x400E6DB")] ShopBuyOutofPeriod = 4403, // 0x00001133
      [Token(Token = "0x400E704")] EventShopOutOfBuyLimit = 4405, // 0x00001135
      [Token(Token = "0x400E702")] LimitedShopOutOfBuyLimit = 4405, // 0x00001135
      [Token(Token = "0x400E6DC")] ShopLimitOver = 4405, // 0x00001135
      [Token(Token = "0x400E6DD")] ProductIllegalDate = 4500, // 0x00001194
      [Token(Token = "0x400E6DE")] ProductPurchaseMax = 4600, // 0x000011F8
      [Token(Token = "0x400E6DF")] ProductCantPurchase = 4601, // 0x000011F9
      [Token(Token = "0x400E6E0")] HikkoshiNoToken = 4700, // 0x0000125C
      [Token(Token = "0x400E6E6")] RoomFailedMakeRoom = 4800, // 0x000012C0
      [Token(Token = "0x400E6E7")] RoomIllegalComment = 4801, // 0x000012C1
      [Token(Token = "0x400E6E8")] RoomNoRoom = 4900, // 0x00001324
      [Token(Token = "0x400E6E9")] NoWatching = 4901, // 0x00001325
      [Token(Token = "0x400E759")] RepelledBlockList = 4902, // 0x00001326
      [Token(Token = "0x400E6EB")] NoDevice = 5000, // 0x00001388
      [Token(Token = "0x400E6EC")] Authorize = 5001, // 0x00001389
      [Token(Token = "0x400E6ED")] GauthNoSid = 5002, // 0x0000138A
      [Token(Token = "0x400E6EE")] ReturnForceTitle = 5003, // 0x0000138B
      [Token(Token = "0x400E6EF")] MigrateIllCode = 5100, // 0x000013EC
      [Token(Token = "0x400E6F0")] MigrateSameDev = 5101, // 0x000013ED
      [Token(Token = "0x400E6F1")] MigrateLockCode = 5102, // 0x000013EE
      [Token(Token = "0x400E6B6")] ColoResetCostShort = 5500, // 0x0000157C
      [Token(Token = "0x400E6B5")] RaidTicketShort = 5600, // 0x000015E0
      [Token(Token = "0x400E688")] UnitAddExist = 5700, // 0x00001644
      [Token(Token = "0x400E689")] UnitAddCostShort = 5701, // 0x00001645
      [Token(Token = "0x400E68A")] UnitAddCantUnlock = 5702, // 0x00001646
      [Token(Token = "0x400E6EA")] RoomPlayerLvShort = 5800, // 0x000016A8
      [Token(Token = "0x400E669")] ApprNoFriend = 5900, // 0x0000170C
      [Token(Token = "0x400E66A")] ApprNoRequest = 5901, // 0x0000170D
      [Token(Token = "0x400E66B")] ApprRequestMax = 5902, // 0x0000170E
      [Token(Token = "0x400E66C")] ApprFriendIsFull = 5903, // 0x0000170F
      [Token(Token = "0x400E667")] FindNoFriend = 6000, // 0x00001770
      [Token(Token = "0x400E668")] FindIsMine = 6001, // 0x00001771
      [Token(Token = "0x400E6F2")] CountLimitForPlayer = 8005, // 0x00001F45
      [Token(Token = "0x400E738")] QR_OutOfPeriod = 8008, // 0x00001F48
      [Token(Token = "0x400E739")] QR_InvalidQRSerial = 8009, // 0x00001F49
      [Token(Token = "0x400E73A")] QR_CanNotReward = 8010, // 0x00001F4A
      [Token(Token = "0x400E73B")] QR_LockSerialCampaign = 8011, // 0x00001F4B
      [Token(Token = "0x400E73C")] QR_AlreadyRewardSkin = 8012, // 0x00001F4C
      [Token(Token = "0x400E6F3")] ChargeError = 8100, // 0x00001FA4
      [Token(Token = "0x400E6F4")] ChargeAge000 = 8101, // 0x00001FA5
      [Token(Token = "0x400E6F5")] ChargeVipRemains = 8102, // 0x00001FA6
      [Token(Token = "0x400E6F6")] FirstChargeInvalid = 8103, // 0x00001FA7
      [Token(Token = "0x400E6F7")] FirstChargeNoLog = 8104, // 0x00001FA8
      [Token(Token = "0x400E6F8")] FirstChargeReceipt = 8105, // 0x00001FA9
      [Token(Token = "0x400E6F9")] FirstChargePast = 8106, // 0x00001FAA
      [Token(Token = "0x400E6FA")] ChargePremiumRemains = 8107, // 0x00001FAB
      [Token(Token = "0x400E6FB")] ChargePremiumInvalid = 8108, // 0x00001FAC
      [Token(Token = "0x400E6FC")] CoinCanNotBuyAnyMore = 8109, // 0x00001FAD
      [Token(Token = "0x400E6FD")] CoinSalesHaveEnded = 8110, // 0x00001FAE
      [Token(Token = "0x400E6FE")] ExpansionTermRemains = 8111, // 0x00001FAF
      [Token(Token = "0x400E6FF")] CanNotBuyUnlockLv = 8112, // 0x00001FB0
      [Token(Token = "0x400E700")] ServiceEnd = 8121, // 0x00001FB9
      [Token(Token = "0x400E712")] TowerLocked = 8201, // 0x00002009
      [Token(Token = "0x400E713")] ConditionsErr = 8202, // 0x0000200A
      [Token(Token = "0x400E714")] NotRecovery_permit = 8203, // 0x0000200B
      [Token(Token = "0x400E715")] NotExist_tower = 8211, // 0x00002013
      [Token(Token = "0x400E716")] NotExist_reward = 8212, // 0x00002014
      [Token(Token = "0x400E717")] NotExist_floor = 8213, // 0x00002015
      [Token(Token = "0x400E718")] NoMatch_party = 8221, // 0x0000201D
      [Token(Token = "0x400E719")] NoMatch_mid = 8222, // 0x0000201E
      [Token(Token = "0x400E71A")] IncorrectCoin = 8231, // 0x00002027
      [Token(Token = "0x400E71B")] IncorrectBtlparam = 8232, // 0x00002028
      [Token(Token = "0x400E71C")] AlreadyClear = 8241, // 0x00002031
      [Token(Token = "0x400E71D")] AlreadyBtlend = 8242, // 0x00002032
      [Token(Token = "0x400E71E")] FaildRegistration = 8243, // 0x00002033
      [Token(Token = "0x400E71F")] FaildReset = 8244, // 0x00002034
      [Token(Token = "0x400E705")] NoChannelAction = 8500, // 0x00002134
      [Token(Token = "0x400E706")] NoUserAction = 8501, // 0x00002135
      [Token(Token = "0x400E707")] SendChatInterval = 8502, // 0x00002136
      [Token(Token = "0x400E708")] CanNotAddBlackList = 8503, // 0x00002137
      [Token(Token = "0x400E70B")] NotGpsMail = 8600, // 0x00002198
      [Token(Token = "0x400E70C")] ReceivedGpsMail = 8601, // 0x00002199
      [Token(Token = "0x400E70D")] MailIDDupulicate = 8602, // 0x0000219A
      [Token(Token = "0x400E70E")] AcheiveMigrateIllcode = 8800, // 0x00002260
      [Token(Token = "0x400E70F")] AcheiveMigrateNoCoop = 8801, // 0x00002261
      [Token(Token = "0x400E710")] AcheiveMigrateLock = 8802, // 0x00002262
      [Token(Token = "0x400E711")] AcheiveMigrateAuthorize = 8803, // 0x00002263
      [Token(Token = "0x400E68B")] ArtifactBoxLimit = 9000, // 0x00002328
      [Token(Token = "0x400E68C")] ArtifactPieceShort = 9001, // 0x00002329
      [Token(Token = "0x400E68D")] ArtifactMatShort = 9002, // 0x0000232A
      [Token(Token = "0x400E68E")] ArtifactFavorite = 9003, // 0x0000232B
      [Token(Token = "0x400E68F")] SkinNoSkin = 9010, // 0x00002332
      [Token(Token = "0x400E690")] SkinNoJob = 9011, // 0x00002333
      [Token(Token = "0x400E758")] Gift_ConceptCardBoxLimit = 9020, // 0x0000233C
      [Token(Token = "0x400E7D4")] NotExistConceptCard = 9022, // 0x0000233E
      [Token(Token = "0x400E720")] not_open_door = 9030, // 0x00002346
      [Token(Token = "0x400E721")] all_mastered = 9031, // 0x00002347
      [Token(Token = "0x400E722")] not_in_period = 9032, // 0x00002348
      [Token(Token = "0x400E723")] VS_NotSelfBattle = 10000, // 0x00002710
      [Token(Token = "0x400E724")] VS_NotPlayer = 10001, // 0x00002711
      [Token(Token = "0x400E725")] VS_NotQuestInfo = 10002, // 0x00002712
      [Token(Token = "0x400E726")] VS_NotLINERoomInfo = 10003, // 0x00002713
      [Token(Token = "0x400E727")] VS_FailRoomID = 10004, // 0x00002714
      [Token(Token = "0x400E728")] VS_BattleEnd = 10005, // 0x00002715
      [Token(Token = "0x400E729")] VS_NotQuestData = 10006, // 0x00002716
      [Token(Token = "0x400E72A")] VS_NotPhotonAppID = 10007, // 0x00002717
      [Token(Token = "0x400E72B")] VS_Version = 10008, // 0x00002718
      [Token(Token = "0x400E72C")] VS_IllComment = 10009, // 0x00002719
      [Token(Token = "0x400E72D")] VS_LvShort = 10010, // 0x0000271A
      [Token(Token = "0x400E72E")] VS_BattleNotEnd = 10011, // 0x0000271B
      [Token(Token = "0x400E72F")] VS_NoRoom = 10012, // 0x0000271C
      [Token(Token = "0x400E730")] VS_ComBattleEnd = 10013, // 0x0000271D
      [Token(Token = "0x400E731")] VS_FaildSeasonGift = 10014, // 0x0000271E
      [Token(Token = "0x400E732")] VS_TowerNotPlay = 10015, // 0x0000271F
      [Token(Token = "0x400E733")] VS_NotContinuousEnemy = 10016, // 0x00002720
      [Token(Token = "0x400E734")] VS_RowerNotMatching = 10017, // 0x00002721
      [Token(Token = "0x400E735")] VS_EnableTimeOutOfPriod = 10018, // 0x00002722
      [Token(Token = "0x400E736")] VS_NotAvailableUnit = 10021, // 0x00002725
      [Token(Token = "0x400E73D")] QuestBookmark_RequestMax = 10100, // 0x00002774
      [Token(Token = "0x400E73E")] QuestBookmark_AlreadyLimited = 10101, // 0x00002775
      [Token(Token = "0x400E737")] DmmSessionExpired = 11000, // 0x00002AF8
      [Token(Token = "0x400E73F")] MT_NotClearFloor = 12001, // 0x00002EE1
      [Token(Token = "0x400E740")] MT_AlreadyFinish = 12002, // 0x00002EE2
      [Token(Token = "0x400E741")] MT_NoRoom = 12003, // 0x00002EE3
      [Token(Token = "0x400E742")] MT_CanNotSkipFloor = 12004, // 0x00002EE4
      [Token(Token = "0x400E743")] RankingQuest_NotNewScore = 13001, // 0x000032C9
      [Token(Token = "0x400E744")] RankingQuest_AlreadyEntry = 13002, // 0x000032CA
      [Token(Token = "0x400E745")] RankingQuest_OutOfPeriod = 13003, // 0x000032CB
      [Token(Token = "0x400E746")] Gallery_MigrationInProgress = 14001, // 0x000036B1
      [Token(Token = "0x400E747")] Gallery_JukeBox_NotHaveBgm = 14101, // 0x00003715
      [Token(Token = "0x400E748")] Gallery_JukeBox_NotCreatePlayList = 14102, // 0x00003716
      [Token(Token = "0x400E749")] Gallery_JukeBox_NotInPlayList = 14103, // 0x00003717
      [Token(Token = "0x400E74A")] Gallery_JukeBox_AlreadyAddPlayList = 14104, // 0x00003718
      [Token(Token = "0x400E74B")] QuestArchive_ArchiveNotFound = 16001, // 0x00003E81
      [Token(Token = "0x400E74C")] QuestArchive_ArchiveNotOpened = 16002, // 0x00003E82
      [Token(Token = "0x400E74D")] QuestArchive_ArchiveAlreadyOpened = 16003, // 0x00003E83
      [Token(Token = "0x400E74E")] InspSkill_IncorrectParam = 17001, // 0x00004269
      [Token(Token = "0x400E74F")] InspSkill_NotExistArtifact = 17002, // 0x0000426A
      [Token(Token = "0x400E750")] InspSkill_NotExistInspirationSkill = 17003, // 0x0000426B
      [Token(Token = "0x400E751")] InspSkill_ArtifactFavorite = 17004, // 0x0000426C
      [Token(Token = "0x400E752")] InspSkill_IncorrectMixArtifact = 17005, // 0x0000426D
      [Token(Token = "0x400E753")] InspSkill_CannotLevelUpLevelMax = 17006, // 0x0000426E
      [Token(Token = "0x400E754")] InspSkill_CannotResetNotFound = 17007, // 0x0000426F
      [Token(Token = "0x400E755")] InspSkill_CostShort = 17008, // 0x00004270
      [Token(Token = "0x400E756")] InspSkill_CannotAddSlotArtifact = 17009, // 0x00004271
      [Token(Token = "0x400E757")] InspSkill_CannotAddSlotNumMax = 17010, // 0x00004272
      [Token(Token = "0x400E791")] BoxGacha_NotExistBox = 18001, // 0x00004651
      [Token(Token = "0x400E792")] BoxGacha_CostShort = 18002, // 0x00004652
      [Token(Token = "0x400E793")] BoxGacha_RemainShort = 18003, // 0x00004653
      [Token(Token = "0x400E794")] BoxGacha_NotResetBox = 18004, // 0x00004654
      [Token(Token = "0x400E790")] Genesis_OutOfPeriod = 19001, // 0x00004A39
      [Token(Token = "0x400E75A")] CoinBuyUse_OutOfPeriod = 20001, // 0x00004E21
      [Token(Token = "0x400E75B")] Guild_JoinedAlready = 20010, // 0x00004E2A
      [Token(Token = "0x400E75C")] Guild_NotJoined_First = 20020, // 0x00004E34
      [Token(Token = "0x400E75D")] Guild_NotJoined = 20021, // 0x00004E35
      [Token(Token = "0x400E75E")] Guild_AutoJoinTargetMissing = 20022, // 0x00004E36
      [Token(Token = "0x400E75F")] Guild_NotFound = 20040, // 0x00004E48
      [Token(Token = "0x400E760")] Guild_NotFoundEntryRequest = 20050, // 0x00004E52
      [Token(Token = "0x400E761")] Guild_NotMaster = 20060, // 0x00004E5C
      [Token(Token = "0x400E762")] Guild_AlredyMember = 20070, // 0x00004E66
      [Token(Token = "0x400E763")] Guild_MemberMax = 20080, // 0x00004E70
      [Token(Token = "0x400E764")] Guild_SubMasterMax = 20081, // 0x00004E71
      [Token(Token = "0x400E765")] Guild_RaidDissolutionFaild = 20091, // 0x00004E7B
      [Token(Token = "0x400E766")] Guild_NotDissoluteGVGInPeriod = 20092, // 0x00004E7C
      [Token(Token = "0x400E767")] Guild_RaidLeaveFaild = 20102, // 0x00004E86
      [Token(Token = "0x400E768")] Guild_NotLeaveGVGInPeriod = 20103, // 0x00004E87
      [Token(Token = "0x400E769")] Guild_LeaveFailed = 20110, // 0x00004E8E
      [Token(Token = "0x400E76A")] Guild_RaidKickFaild = 20135, // 0x00004EA7
      [Token(Token = "0x400E76B")] Guild_NotBanishGVGInPeriod = 20136, // 0x00004EA8
      [Token(Token = "0x400E76C")] Guild_InputNgWord = 20140, // 0x00004EAC
      [Token(Token = "0x400E76D")] Guild_InvestLimitOneDay = 20202, // 0x00004EEA
      [Token(Token = "0x400E76E")] Guild_PayerCoinShort = 20220, // 0x00004EFC
      [Token(Token = "0x400E76F")] Guild_ShortPlayerLv = 20230, // 0x00004F06
      [Token(Token = "0x400E770")] Guild_ApplySendLevelShort = 20231, // 0x00004F07
      [Token(Token = "0x400E771")] Guild_EntryCoolTime = 20240, // 0x00004F10
      [Token(Token = "0x400E772")] Guild_InvestCoolTime = 20241, // 0x00004F11
      [Token(Token = "0x400E7EF")] Guild_NotAttendJoinDay = 20250, // 0x00004F1A
      [Token(Token = "0x400E7F0")] Guild_OutOfAttendPeriod = 20251, // 0x00004F1B
      [Token(Token = "0x400E7F1")] Guild_MasterOnly = 20260, // 0x00004F24
      [Token(Token = "0x400E7F2")] Guild_OutOfMasterRewarPeriod = 20261, // 0x00004F25
      [Token(Token = "0x400E7F3")] Guild_NotAchieveTrophy = 20280, // 0x00004F38
      [Token(Token = "0x400E7F4")] Guild_PastTrophy = 20281, // 0x00004F39
      [Token(Token = "0x400E7F5")] Guild_ReceivedTrophyReward = 20282, // 0x00004F3A
      [Token(Token = "0x400E795")] Advance_NotOpen = 21001, // 0x00005209
      [Token(Token = "0x400E773")] Raid_OutOfPeriod = 21010, // 0x00005212
      [Token(Token = "0x400E774")] Raid_OutOfOenTime = 21011, // 0x00005213
      [Token(Token = "0x400E775")] Raid_NotRaidbossCurrent = 21020, // 0x0000521C
      [Token(Token = "0x400E776")] Raid_IncorrectBtlparam = 21030, // 0x00005226
      [Token(Token = "0x400E777")] Raid_AlreadyClear = 21040, // 0x00005230
      [Token(Token = "0x400E778")] Raid_AlreadyBtlend = 21050, // 0x0000523A
      [Token(Token = "0x400E779")] Raid_AlreadyRaidbossSelected = 21060, // 0x00005244
      [Token(Token = "0x400E77A")] Raid_AlreadyBeat = 21070, // 0x0000524E
      [Token(Token = "0x400E77B")] Raid_NotFound = 21080, // 0x00005258
      [Token(Token = "0x400E77C")] Raid_NotRewardReady = 21090, // 0x00005262
      [Token(Token = "0x400E77D")] Raid_NotRescueBattle = 21100, // 0x0000526C
      [Token(Token = "0x400E77E")] Raid_OverRescue = 21101, // 0x0000526D
      [Token(Token = "0x400E77F")] Raid_AlredyRescueCancel = 21102, // 0x0000526E
      [Token(Token = "0x400E780")] Raid_NotRewardAreaRound = 21110, // 0x00005276
      [Token(Token = "0x400E781")] Raid_CanNotNextAreaBossNotBeat = 21120, // 0x00005280
      [Token(Token = "0x400E782")] Raid_CanNotNextAreaNotGetReward = 21130, // 0x0000528A
      [Token(Token = "0x400E783")] Raid_CanNotNextAreaCurrentAreaIsLast = 21140, // 0x00005294
      [Token(Token = "0x400E784")] Raid_CanNotRoundBossNotBeat = 21150, // 0x0000529E
      [Token(Token = "0x400E785")] Raid_CanNotRoundNotGetReward = 21160, // 0x000052A8
      [Token(Token = "0x400E786")] Raid_CanNotRoundCurrentAreaIsNotLast = 21170, // 0x000052B2
      [Token(Token = "0x400E787")] Raid_NotComplete = 21180, // 0x000052BC
      [Token(Token = "0x400E788")] Raid_CanNotSubBp = 21190, // 0x000052C6
      [Token(Token = "0x400E789")] Raid_CanNotSelectAreaClear = 21200, // 0x000052D0
      [Token(Token = "0x400E78A")] Raid_CanNotRescuePlLvShort = 21300, // 0x00005334
      [Token(Token = "0x400E78B")] Raid_CanNotRescueTimeOver = 21400, // 0x00005398
      [Token(Token = "0x400E78C")] Raid_RankRewardOutOfPeriod = 21500, // 0x000053FC
      [Token(Token = "0x400E78D")] Raid_RankRewardAlreadyReceived = 21600, // 0x00005460
      [Token(Token = "0x400E78E")] Raid_HealBpOver = 21700, // 0x000054C4
      [Token(Token = "0x400E78F")] Raid_HealBpVariation = 21800, // 0x00005528
      [Token(Token = "0x400E797")] UnitRental_OutOfPeriod = 22001, // 0x000055F1
      [Token(Token = "0x400E798")] UnitRental_AlreadyRented = 22002, // 0x000055F2
      [Token(Token = "0x400E799")] UnitRental_AlreadyJoin = 22003, // 0x000055F3
      [Token(Token = "0x400E79A")] UnitRental_FavpointShort = 22004, // 0x000055F4
      [Token(Token = "0x400E79B")] UnitRental_FavpointMax = 22005, // 0x000055F5
      [Token(Token = "0x400E79C")] UnitRental_NotFoundUnit = 22006, // 0x000055F6
      [Token(Token = "0x400E79D")] DrawCard_OutOfPeriod = 23001, // 0x000059D9
      [Token(Token = "0x400E79E")] DrawCard_CanNotExec = 23002, // 0x000059DA
      [Token(Token = "0x400E79F")] TrophyStarMission_AlreadyReceived = 24001, // 0x00005DC1
      [Token(Token = "0x400E7A0")] TrophyStarMission_NotAchieved = 24002, // 0x00005DC2
      [Token(Token = "0x400E7A1")] TrophyStarMission_Future = 24003, // 0x00005DC3
      [Token(Token = "0x400E7A2")] TrophyStarMission_OutOfPeriod = 24004, // 0x00005DC4
      [Token(Token = "0x400E7A3")] MonthlyLoginBonus_OutOfPeriod = 25001, // 0x000061A9
      [Token(Token = "0x400E7A4")] MonthlyLoginBonus_RemainRecoverShort = 25002, // 0x000061AA
      [Token(Token = "0x400E7A5")] MonthlyLoginBonus_AlreadyReceived = 25003, // 0x000061AB
      [Token(Token = "0x400E7A6")] MonthlyLoginBonus_CanNotRecoverFuture = 25004, // 0x000061AC
      [Token(Token = "0x400E7D5")] AutoRepeatQuest_NotQuest = 26001, // 0x00006591
      [Token(Token = "0x400E7D6")] AutoRepeatQuest_NotQuestMissionComplete = 26002, // 0x00006592
      [Token(Token = "0x400E7D7")] AutoRepeatQuest_AlreadyLap = 26003, // 0x00006593
      [Token(Token = "0x400E7D8")] AutoRepeatQuest_NotReqLap = 26004, // 0x00006594
      [Token(Token = "0x400E7D9")] AutoRepeatQuest_InvalidLapNum = 26005, // 0x00006595
      [Token(Token = "0x400E7DA")] AutoRepeatQuest_AutoRepeatLocked = 26006, // 0x00006596
      [Token(Token = "0x400E7DB")] AutoRepeatQuest_InvalidTurnNum = 26007, // 0x00006597
      [Token(Token = "0x400E7DC")] AutoRepeatQuest_NotStart = 26008, // 0x00006598
      [Token(Token = "0x400E7DD")] AutoRepeatQuest_BoxSizeLimit = 26009, // 0x00006599
      [Token(Token = "0x400E7DE")] AutoRepeatQuest_NotEnoughCoin = 26010, // 0x0000659A
      [Token(Token = "0x400E7A7")] GuildRaid_OutOfPeriod = 27001, // 0x00006979
      [Token(Token = "0x400E7A8")] GuildRaid_EnableTimeOutOfPeriod = 27002, // 0x0000697A
      [Token(Token = "0x400E7A9")] GuildRaid_ChallengeLimit = 27003, // 0x0000697B
      [Token(Token = "0x400E7AA")] GuildRaid_AlreadyBeat = 27004, // 0x0000697C
      [Token(Token = "0x400E7AB")] GuildRaid_CanNotChallengeByThereIsNoBoss = 27005, // 0x0000697D
      [Token(Token = "0x400E7AC")] GuildRaid_NotChallenge = 27006, // 0x0000697E
      [Token(Token = "0x400E7AD")] GuildRaid_NotMainBattle = 27007, // 0x0000697F
      [Token(Token = "0x400E7AE")] GuildRaid_CanNotChallengeBossGroup = 27008, // 0x00006980
      [Token(Token = "0x400E7AF")] GuildRaid_NewAreaCanBeReleased = 27010, // 0x00006982
      [Token(Token = "0x400E7B0")] GuildRaid_CanNotOpenAreaNotBeatBosses = 27011, // 0x00006983
      [Token(Token = "0x400E7B1")] GuildRaid_CanNotOpenAreaNotEnoughGuildLevel = 27012, // 0x00006984
      [Token(Token = "0x400E7B2")] GuildRaid_CanNotNextAreaCurrentAreaIsLast = 27013, // 0x00006985
      [Token(Token = "0x400E7B3")] GuildRaid_AlreadyMailReceived = 27030, // 0x00006996
      [Token(Token = "0x400E7B4")] GuildRaid_MailNotReceived = 27031, // 0x00006997
      [Token(Token = "0x400E7B5")] GvG_OutOfPeriod = 28000, // 0x00006D60
      [Token(Token = "0x400E7B6")] GvG_NotGvGEntry = 28001, // 0x00006D61
      [Token(Token = "0x400E7B7")] GvG_NotUsedUnit = 28002, // 0x00006D62
      [Token(Token = "0x400E7B8")] GvG_NotMatchUnit = 28003, // 0x00006D63
      [Token(Token = "0x400E7B9")] GvG_ExceedUnitUsedCount = 28004, // 0x00006D64
      [Token(Token = "0x400E7BA")] GVG_InPreparePeriod = 28005, // 0x00006D65
      [Token(Token = "0x400E7BB")] GVG_NotUsedItem = 28006, // 0x00006D66
      [Token(Token = "0x400E7BC")] GvG_AlreadyDeclare = 28010, // 0x00006D6A
      [Token(Token = "0x400E7BD")] GvG_DeclareLimitOver = 28011, // 0x00006D6B
      [Token(Token = "0x400E7BE")] GvG_DeclareOutOfPeriod = 28012, // 0x00006D6C
      [Token(Token = "0x400E7BF")] GvG_CanNotAuthorityInDeclare = 28013, // 0x00006D6D
      [Token(Token = "0x400E7C0")] GvG_NotAdjacentNode = 28016, // 0x00006D70
      [Token(Token = "0x400E7C1")] GvG_NotDeclareNode = 28017, // 0x00006D71
      [Token(Token = "0x400E7C2")] GvG_NotDeclareForOnTheDay = 28018, // 0x00006D72
      [Token(Token = "0x400E7C3")] GvG_IsDeclareCoolTime = 28019, // 0x00006D73
      [Token(Token = "0x400E7C4")] GvG_MaxDefense = 28020, // 0x00006D74
      [Token(Token = "0x400E7C5")] GvG_HasNotDeclare = 28021, // 0x00006D75
      [Token(Token = "0x400E7C6")] GvG_CanNotModifiedOffenseParty = 28022, // 0x00006D76
      [Token(Token = "0x400E7C7")] GvG_NotOffensePartyEntryForOnTheDay = 28023, // 0x00006D77
      [Token(Token = "0x400E7C8")] GvG_HasNotCapture = 28030, // 0x00006D7E
      [Token(Token = "0x400E7C9")] GvG_NotDefensePartyEntryForOnTheDay = 28031, // 0x00006D7F
      [Token(Token = "0x400E7CA")] GvG_NotReachedDefenseUnitMinNum = 28032, // 0x00006D80
      [Token(Token = "0x400E7CB")] GvG_BtlOutOfPeriod = 28040, // 0x00006D88
      [Token(Token = "0x400E7CC")] GvG_CanNotAttack = 28041, // 0x00006D89
      [Token(Token = "0x400E7CD")] GvG_AlreadyBeat = 28042, // 0x00006D8A
      [Token(Token = "0x400E7CE")] GvG_OtherUserAttacking = 28043, // 0x00006D8B
      [Token(Token = "0x400E7CF")] GvG_HasCapture = 28044, // 0x00006D8C
      [Token(Token = "0x400E7D0")] GvG_CanNotCapture = 28045, // 0x00006D8D
      [Token(Token = "0x400E7D1")] GvG_IsCoolTime = 28046, // 0x00006D8E
      [Token(Token = "0x400E7D2")] GvG_NoAttackParty = 28047, // 0x00006D8F
      [Token(Token = "0x400E7D3")] GvG_BattleHalfTime = 28048, // 0x00006D90
      [Token(Token = "0x400E7DF")] Rune_CanNotEquip = 29001, // 0x00007149
      [Token(Token = "0x400E7E0")] Rune_CanNotEquipToSlot = 29002, // 0x0000714A
      [Token(Token = "0x400E7E1")] Rune_IsUpperLimitForEnforce = 29003, // 0x0000714B
      [Token(Token = "0x400E7E2")] Rune_NotEnoughMaterial = 29004, // 0x0000714C
      [Token(Token = "0x400E7E3")] Rune_NotEnoughCurrency = 29005, // 0x0000714D
      [Token(Token = "0x400E7E4")] Rune_NotHaveRune = 29006, // 0x0000714E
      [Token(Token = "0x400E7E5")] Rune_CanNotSetSameRune = 29007, // 0x0000714F
      [Token(Token = "0x400E7E6")] Rune_IsUpperLimitForEvo = 29008, // 0x00007150
      [Token(Token = "0x400E7E7")] Rune_CanNotEvoEnforceShort = 29009, // 0x00007151
      [Token(Token = "0x400E7E8")] Rune_IncludesEquippedRunes = 29010, // 0x00007152
      [Token(Token = "0x400E7E9")] Rune_IsRuneStorageFull = 29011, // 0x00007153
      [Token(Token = "0x400E7EA")] Rune_NotFoundEvoSlot = 29012, // 0x00007154
      [Token(Token = "0x400E7EB")] Rune_IsUpperLimitForStorage = 29013, // 0x00007155
      [Token(Token = "0x400E7EC")] Rune_NotEnoughCoin = 29014, // 0x00007156
      [Token(Token = "0x400E7ED")] Rune_IsFavorite = 29015, // 0x00007157
      [Token(Token = "0x400E7EE")] Rune_ContinueReinforceFailed = 29017, // 0x00007159
      [Token(Token = "0x400E7F6")] WorldRaid_OutOfPeriod = 30000, // 0x00007530
      [Token(Token = "0x400E7F7")] WorldRaid_EnabletimeOutOfPeriod = 30001, // 0x00007531
      [Token(Token = "0x400E7F8")] WorldRaid_IncorrectParam = 30002, // 0x00007532
      [Token(Token = "0x400E7F9")] WorldRaid_NotFound = 30003, // 0x00007533
      [Token(Token = "0x400E7FA")] WorldRaid_AlreadyBeat = 30004, // 0x00007534
      [Token(Token = "0x400E7FB")] WorldRaid_NotEnableAP = 30005, // 0x00007535
      [Token(Token = "0x400E7FC")] WorldRaid_AlreadyUsedUnit = 30006, // 0x00007536
      [Token(Token = "0x400E7FD")] WorldRaid_AlreadyBtlEnd = 30007, // 0x00007537
      [Token(Token = "0x400E7FE")] WorldRaid_NotAppearLastBoss = 30008, // 0x00007538
      [Token(Token = "0x400E7FF")] WorldRaid_DiffLap = 30009, // 0x00007539
      [Token(Token = "0x400E800")] WorldRaid_LimitBp = 30011, // 0x0000753B
      [Token(Token = "0x400E801")] WorldRaid_ChangeBP = 30012, // 0x0000753C
      [Token(Token = "0x400E802")] WorldRaid_NotUseBp = 30013, // 0x0000753D
      [Token(Token = "0x400E803")] Duel_OutOfPeriod = 31000, // 0x00007918
      [Token(Token = "0x400E804")] Duel_CantSelect = 31001, // 0x00007919
      [Token(Token = "0x400E805")] Duel_CostOver = 31002, // 0x0000791A
      [Token(Token = "0x400E806")] Duel_NotEnd = 31003, // 0x0000791B
      [Token(Token = "0x400E807")] Duel_PlayerLvShot = 31004, // 0x0000791C
      [Token(Token = "0x400E808")] Duel_IntervalNow = 31006, // 0x0000791E
      [Token(Token = "0x400E809")] Duel_CalcRankingNow = 31007, // 0x0000791F
      [Token(Token = "0x400E80A")] Duel_NotFoundMap = 31008, // 0x00007920
      [Token(Token = "0x400E80B")] Duel_TurnZero = 31009, // 0x00007921
      [Token(Token = "0x400E80C")] Duel_InvalidBattle = 31010, // 0x00007922
      [Token(Token = "0x400E80D")] Adventure_OutOfPeriod = 33000, // 0x000080E8
      [Token(Token = "0x400E80E")] Adventure_SallyOfUnit = 33001, // 0x000080E9
      [Token(Token = "0x400E80F")] Adventure_Use = 33003, // 0x000080EB
      [Token(Token = "0x400E810")] Adventure_SallyNotCondition = 33004, // 0x000080EC
      [Token(Token = "0x400E811")] Adventure_NotFix = 33006, // 0x000080EE
      [Token(Token = "0x400E812")] Adventure_SallyNumMax = 33007, // 0x000080EF
      [Token(Token = "0x400E813")] Adventure_End = 33008, // 0x000080F0
      [Token(Token = "0x400E814")] Adventure_NotStart = 33009, // 0x000080F1
      [Token(Token = "0x400E815")] CAN_NOT_UNIT_SET = 34000, // 0x000084D0
      [Token(Token = "0x400E816")] CAN_NOT_UNIT_SAME = 34001, // 0x000084D1
      [Token(Token = "0x400E817")] OVER_ENERGY = 34002, // 0x000084D2
      [Token(Token = "0x400E818")] NOT_USE_COST = 34003, // 0x000084D3
      [Token(Token = "0x400E819")] NOT_OPEN_SLOT = 34004, // 0x000084D4
      [Token(Token = "0x400E81A")] NOT_OPEN_DRAGONGOD = 35000, // 0x000088B8
      [Token(Token = "0x400E81B")] POINTQUEST_NOT_ENOUGH_POINT = 36000, // 0x00008CA0
      [Token(Token = "0x400E81C")] POINTQUEST_REWARDED = 36001, // 0x00008CA1
      [Token(Token = "0x400E81D")] POINTQUEST_NOT_ENOUGH_GUILD_POINT = 36002, // 0x00008CA2
      [Token(Token = "0x400E81E")] POINTQUEST_NOTHING_BEST_SCORE = 36003, // 0x00008CA3
      [Token(Token = "0x400E81F")] NOT_RESONANCE_CURRENT = 37000, // 0x00009088
      [Token(Token = "0x400E820")] SCORECHALLENGE_GUILD_LEAVE_FAILED = 38000, // 0x00009470
      [Token(Token = "0x400E821")] RUNEPRIDE_BOARDOPEN_FAILED = 39000, // 0x00009858
      [Token(Token = "0x400E822")] ACCOUNT_FLOW_TOKEN_EXPIRED = 41001, // 0x0000A029
      [Token(Token = "0x400E823")] ACCOUNT_DELETED = 41002, // 0x0000A02A
      [Token(Token = "0x400E824")] NOT_EXIST_ACCOUNT = 41003, // 0x0000A02B
      [Token(Token = "0x400E825")] GPGS_MISSING_ACCOUNT = 42001, // 0x0000A411
      [Token(Token = "0x400E826")] GPGS_ALREADY_RELATE_ACCOUNT = 42002, // 0x0000A412
      [Token(Token = "0x400E827")] GPGS_INVALID_GRANT = 42003, // 0x0000A413
      [Token(Token = "0x400E828")] GPGS_NOT_COMPLETE_REGISTRATION = 42004, // 0x0000A414
      [Token(Token = "0x400E829")] GPGS_TIMEOUT = 42005, // 0x0000A415
      [Token(Token = "0x400E82A")] LEAGUEMATCH_BATTLE_TIME_ERROR = 50000, // 0x0000C350
    }

    [Token(Token = "0x2002E2F")]
    public enum RequestResults
    {
      [Token(Token = "0x400E82C")] Success,
      [Token(Token = "0x400E82D")] Failure,
      [Token(Token = "0x400E82E")] Retry,
      [Token(Token = "0x400E82F")] Back,
      [Token(Token = "0x400E830")] Timeout,
      [Token(Token = "0x400E831")] Maintenance,
      [Token(Token = "0x400E832")] VersionMismatch,
      [Token(Token = "0x400E833")] InvalidSession,
      [Token(Token = "0x400E834")] IllegalParam,
      [Token(Token = "0x400E835")] ServerNotify,
      [Token(Token = "0x400E836")] ServerNotifyAndGoToHome,
      [Token(Token = "0x400E837")] ServerNotifyAndReloadScene,
    }

    [Token(Token = "0x2002E30")]
    public delegate void ResponseCallback(WWWResult result);

    [Token(Token = "0x2002E31")]
    public enum EConnectMode
    {
      [Token(Token = "0x400E839")] Online,
      [Token(Token = "0x400E83A")] Offline,
    }
  }
}
