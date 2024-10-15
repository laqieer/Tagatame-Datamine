// Decompiled with JetBrains decompiler
// Type: SRPG.LoginNewsInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026FB")]
  [AddComponentMenu("")]
  [FlowNode.Pin(2, "OpenNews", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "SetUrl", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("System/Login/LoginNewsInfo", 32741)]
  public class LoginNewsInfo : FlowNode
  {
    [Token(Token = "0x400B7A8")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GameObject mRootNewsInfoObj;
    [Token(Token = "0x400B7A9")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public Text mTitleText;
    [Token(Token = "0x400B7AA")]
    [FieldOffset(Offset = "0x0")]
    private static LoginNewsInfo.JSON_PubInfo mPubinfo;
    [Token(Token = "0x400B7AB")]
    [FieldOffset(Offset = "0x20")]
    private LoginNewsInfo.JSON_PubInfo mCurrentPubInfo;
    [Token(Token = "0x400B7AC")]
    private const int TEXT_LIMIT_LENGTH = 52;
    [Token(Token = "0x400B7AD")]
    private const int PIN_SET_URL = 1;
    [Token(Token = "0x400B7AE")]
    private const int PIN_OPEN_NEWS = 2;
    [Token(Token = "0x400B7AF")]
    public const string URL_KEY = "LOGIN_NEWS_URL";
    [Token(Token = "0x400B7B0")]
    [FieldOffset(Offset = "0x4")]
    private static bool isShowNews;

    [Token(Token = "0x1700182E")]
    public static LoginNewsInfo.JSON_PubInfo Pubinfo
    {
      [Token(Token = "0x600AEAA"), Address(RVA = "0x72C460", Offset = "0x72B260", VA = "0x1072C460")] get
      {
        return (LoginNewsInfo.JSON_PubInfo) null;
      }
    }

    [Token(Token = "0x1700182F")]
    public string PageID
    {
      [Token(Token = "0x600AEAB"), Address(RVA = "0x72C410", Offset = "0x72B210", VA = "0x1072C410")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600AEAC")]
    [Address(RVA = "0x72BA90", Offset = "0x72A890", VA = "0x1072BA90", Slot = "7")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600AEAD")]
    [Address(RVA = "0x72BDC0", Offset = "0x72ABC0", VA = "0x1072BDC0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600AEAE")]
    [Address(RVA = "0x72BE10", Offset = "0x72AC10", VA = "0x1072BE10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AEAF")]
    [Address(RVA = "0x72BCB0", Offset = "0x72AAB0", VA = "0x1072BCB0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600AEB0")]
    [Address(RVA = "0x72C2A0", Offset = "0x72B0A0", VA = "0x1072C2A0")]
    public static void SetPubInfo(LoginNewsInfo.JSON_PubInfo pubinfo)
    {
    }

    [Token(Token = "0x600AEB1")]
    [Address(RVA = "0x72BB90", Offset = "0x72A990", VA = "0x1072BB90")]
    public static bool IsChangePubInfo() => new bool();

    [Token(Token = "0x600AEB2")]
    [Address(RVA = "0x72C370", Offset = "0x72B170", VA = "0x1072C370")]
    public static void UpdateBeforePubInfo()
    {
    }

    [Token(Token = "0x600AEB3")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public LoginNewsInfo()
    {
    }

    [Token(Token = "0x20026FC")]
    [MessagePackObject(true)]
    public class JSON_PubInfo
    {
      [Token(Token = "0x400B7B1")]
      [FieldOffset(Offset = "0x8")]
      public string id;
      [Token(Token = "0x400B7B2")]
      [FieldOffset(Offset = "0xC")]
      public string token;
      [Token(Token = "0x400B7B3")]
      [FieldOffset(Offset = "0x10")]
      public string category;
      [Token(Token = "0x400B7B4")]
      [FieldOffset(Offset = "0x14")]
      public string message;

      [Token(Token = "0x600AEB4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_PubInfo()
      {
      }
    }
  }
}
