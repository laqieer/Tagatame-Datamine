// Decompiled with JetBrains decompiler
// Type: SRPG.VersusAudienceManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E27")]
  public class VersusAudienceManager
  {
    [Token(Token = "0x4002AE0")]
    [FieldOffset(Offset = "0x0")]
    public static readonly float CONNECTTIME_MAX;
    [Token(Token = "0x4002AE1")]
    [FieldOffset(Offset = "0x8")]
    public readonly int RETRY_MAX;
    [Token(Token = "0x4002AE2")]
    [FieldOffset(Offset = "0xC")]
    private Dictionary<int, List<SceneBattle.MultiPlayRecvData>> mTurnLog;
    [Token(Token = "0x4002AE3")]
    [FieldOffset(Offset = "0x10")]
    private Dictionary<int, List<VersusDraftList.VersusDraftMessageData>> mDraftTurnLog;
    [Token(Token = "0x4002AE4")]
    [FieldOffset(Offset = "0x14")]
    private Dictionary<int, List<PickBanPhotonData.VersusDraftBanMessageData>> mDraftBanLog;
    [Token(Token = "0x4002AE5")]
    [FieldOffset(Offset = "0x18")]
    private AudienceStartParam mStartedParam;
    [Token(Token = "0x4002AE6")]
    [FieldOffset(Offset = "0x1C")]
    private PhotonRoomData mRoomParam;
    [Token(Token = "0x4002AE7")]
    [FieldOffset(Offset = "0x20")]
    private DownloadLogger mDownloadLogger;
    [Token(Token = "0x4002AE8")]
    [FieldOffset(Offset = "0x24")]
    private int mReadCnt;
    [Token(Token = "0x4002AE9")]
    [FieldOffset(Offset = "0x28")]
    private int mSkipReadMax;
    [Token(Token = "0x4002AEA")]
    [FieldOffset(Offset = "0x2C")]
    private int mDraftReadCnt;
    [Token(Token = "0x4002AEB")]
    [FieldOffset(Offset = "0x30")]
    private int mDraftBanReadCnt;
    [Token(Token = "0x4002AEC")]
    [FieldOffset(Offset = "0x34")]
    private int mRetryStartQuestCnt;
    [Token(Token = "0x4002AED")]
    [FieldOffset(Offset = "0x38")]
    private bool mSkipLog;
    [Token(Token = "0x4002AEE")]
    [FieldOffset(Offset = "0x3C")]
    private float mNoneConnectedTime;
    [Token(Token = "0x4002AEF")]
    [FieldOffset(Offset = "0x40")]
    private string mNonAnalyzeLog;
    [Token(Token = "0x4002AF0")]
    [FieldOffset(Offset = "0x44")]
    private VersusAudienceManager.CONNECT_STATE mState;

    [Token(Token = "0x1700042C")]
    public bool IsConnected
    {
      [Token(Token = "0x6003A44"), Address(RVA = "0x10E0850", Offset = "0x10DF650", VA = "0x110E0850")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700042D")]
    public bool IsDisconnected
    {
      [Token(Token = "0x6003A45"), Address(RVA = "0x37AD00", Offset = "0x379B00", VA = "0x1037AD00")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700042E")]
    public DownloadLogger Logger
    {
      [Token(Token = "0x6003A46"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (DownloadLogger) null;
      }
    }

    [Token(Token = "0x1700042F")]
    public bool IsRetryError
    {
      [Token(Token = "0x6003A47"), Address(RVA = "0x10E08E0", Offset = "0x10DF6E0", VA = "0x110E08E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000430")]
    private int LogLength
    {
      [Token(Token = "0x6003A48"), Address(RVA = "0x10E0920", Offset = "0x10DF720", VA = "0x110E0920")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000431")]
    private int DraftLogLength
    {
      [Token(Token = "0x6003A49"), Address(RVA = "0x10E06C0", Offset = "0x10DF4C0", VA = "0x110E06C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000432")]
    private int DraftBanLogLength
    {
      [Token(Token = "0x6003A4A"), Address(RVA = "0x10E0530", Offset = "0x10DF330", VA = "0x110E0530")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6003A4B")]
    [Address(RVA = "0x10DF160", Offset = "0x10DDF60", VA = "0x110DF160")]
    public void Analyze(string log)
    {
    }

    [Token(Token = "0x6003A4C")]
    [Address(RVA = "0x10DF120", Offset = "0x10DDF20", VA = "0x110DF120")]
    public void AddStartQuest()
    {
    }

    [Token(Token = "0x6003A4D")]
    [Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")]
    public AudienceStartParam GetStartedParam() => (AudienceStartParam) null;

    [Token(Token = "0x6003A4E")]
    [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")]
    public PhotonRoomData GetRoomData() => (PhotonRoomData) null;

    [Token(Token = "0x6003A4F")]
    [Address(RVA = "0x10DFA60", Offset = "0x10DE860", VA = "0x110DFA60")]
    public SceneBattle.MultiPlayRecvData GetData() => (SceneBattle.MultiPlayRecvData) null;

    [Token(Token = "0x6003A50")]
    [Address(RVA = "0x10DFEA0", Offset = "0x10DECA0", VA = "0x110DFEA0")]
    public VersusDraftList.VersusDraftMessageData GetDraftData()
    {
      return (VersusDraftList.VersusDraftMessageData) null;
    }

    [Token(Token = "0x6003A51")]
    [Address(RVA = "0x10DFC80", Offset = "0x10DEA80", VA = "0x110DFC80")]
    public PickBanPhotonData.VersusDraftBanMessageData GetDraftBanDataList()
    {
      return (PickBanPhotonData.VersusDraftBanMessageData) null;
    }

    [Token(Token = "0x6003A52")]
    [Address(RVA = "0x10E0340", Offset = "0x10DF140", VA = "0x110E0340")]
    public void Restore()
    {
    }

    [Token(Token = "0x6003A53")]
    [Address(RVA = "0x10E00E0", Offset = "0x10DEEE0", VA = "0x110E00E0")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003A54")]
    [Address(RVA = "0x10DF130", Offset = "0x10DDF30", VA = "0x110DF130")]
    public void Add(string data)
    {
    }

    [Token(Token = "0x6003A55")]
    [Address(RVA = "0x10DFA30", Offset = "0x10DE830", VA = "0x110DFA30")]
    public void Disconnect()
    {
    }

    [Token(Token = "0x6003A56")]
    [Address(RVA = "0x10DFA40", Offset = "0x10DE840", VA = "0x110DFA40")]
    public void FinishLoad()
    {
    }

    [Token(Token = "0x6003A57")]
    [Address(RVA = "0x10E0360", Offset = "0x10DF160", VA = "0x110E0360")]
    public void Update()
    {
    }

    [Token(Token = "0x6003A58")]
    [Address(RVA = "0x10E00C0", Offset = "0x10DEEC0", VA = "0x110E00C0")]
    public void ResetTime()
    {
    }

    [Token(Token = "0x17000433")]
    public bool SkipMode
    {
      [Token(Token = "0x6003A59"), Address(RVA = "0xAAFB50", Offset = "0xAAE950", VA = "0x10AAFB50")] set
      {
      }
    }

    [Token(Token = "0x17000434")]
    public bool IsSkipEnd
    {
      [Token(Token = "0x6003A5A"), Address(RVA = "0x10E0900", Offset = "0x10DF700", VA = "0x110E0900")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000435")]
    public bool IsEnd
    {
      [Token(Token = "0x6003A5B"), Address(RVA = "0x10E0860", Offset = "0x10DF660", VA = "0x110E0860")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003A5C")]
    [Address(RVA = "0x10E0410", Offset = "0x10DF210", VA = "0x110E0410")]
    public VersusAudienceManager()
    {
    }

    [Token(Token = "0x6003A5D")]
    [Address(RVA = "0x10E03E0", Offset = "0x10DF1E0", VA = "0x110E03E0")]
    static VersusAudienceManager()
    {
    }

    [Token(Token = "0x2000E28")]
    private enum CONNECT_STATE
    {
      [Token(Token = "0x4002AF2")] NONE,
      [Token(Token = "0x4002AF3")] REQ,
      [Token(Token = "0x4002AF4")] CONNECTED,
    }
  }
}
