// Decompiled with JetBrains decompiler
// Type: FlowNode_OnUrlSchemeLaunch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;

#nullable disable
[Token(Token = "0x20001FA")]
[AddComponentMenu("")]
[FlowNode.NodeType("Event/OnUrlSchemeLaunch", 58751)]
[FlowNode.Pin(102, "StartCheck", FlowNode.PinTypes.Input, 102)]
[FlowNode.Pin(1, "OnMultiPlayLINE", FlowNode.PinTypes.Output, 1)]
[FlowNode.Pin(900, "ForceQRCodeReading", FlowNode.PinTypes.Input, 900)]
[FlowNode.Pin(999, "OnDebug", FlowNode.PinTypes.Input, 999)]
[FlowNode.Pin(901, "ForceLINEInvitation", FlowNode.PinTypes.Input, 901)]
[FlowNode.Pin(2, "OnQRCodeAccess", FlowNode.PinTypes.Output, 2)]
public class FlowNode_OnUrlSchemeLaunch : FlowNodePersistent
{
  [Token(Token = "0x400089F")]
  private const int PIN_OUT_MULTIPLAY_LINE = 1;
  [Token(Token = "0x40008A0")]
  private const int PIN_OUT_QRCODE_ACCESS = 2;
  [Token(Token = "0x40008A1")]
  private const int PIN_IN_START_CHECK = 102;
  [Token(Token = "0x40008A2")]
  private const int PIN_IN_FORCE_QRCODE_READING = 900;
  [Token(Token = "0x40008A3")]
  private const int PIN_IN_FORCE_LINE_INVITATION = 901;
  [Token(Token = "0x40008A4")]
  private const int PIN_IN_ON_DEBUG = 999;
  [Token(Token = "0x40008A5")]
  private const string URL_SCHEME_PREFIX = "jp.co.gu3.alchemist://join?param=";
  [Token(Token = "0x40008A6")]
  [FieldOffset(Offset = "0x0")]
  public static readonly int MP_LINE_ENCODE_KEY;
  [Token(Token = "0x40008A7")]
  [FieldOffset(Offset = "0x18")]
  private bool StartCheck;
  [Token(Token = "0x40008A8")]
  [FieldOffset(Offset = "0x19")]
  private bool StartExec;
  [Token(Token = "0x40008A9")]
  [FieldOffset(Offset = "0x4")]
  public static FlowNode_OnUrlSchemeLaunch.LINEParam LINEParam_Pending;
  [Token(Token = "0x40008AA")]
  [FieldOffset(Offset = "0x8")]
  public static FlowNode_OnUrlSchemeLaunch.LINEParam LINEParam_decided;
  [Token(Token = "0x40008AB")]
  [FieldOffset(Offset = "0xC")]
  public static bool IsQRAccess;
  [Token(Token = "0x40008AC")]
  [FieldOffset(Offset = "0x10")]
  public static int QRCampaignID;
  [Token(Token = "0x40008AD")]
  [FieldOffset(Offset = "0x14")]
  public static string QRSerialID;
  [Token(Token = "0x40008AE")]
  [FieldOffset(Offset = "0x18")]
  private static FlowNode_OnUrlSchemeLaunch mInstance;

  [Token(Token = "0x6000B26")]
  [Address(RVA = "0x107B650", Offset = "0x107A450", VA = "0x1107B650")]
  private static bool IsEqual(string s0, string s1) => new bool();

  [Token(Token = "0x1700015A")]
  public static FlowNode_OnUrlSchemeLaunch Instance
  {
    [Token(Token = "0x6000B27"), Address(RVA = "0x107C630", Offset = "0x107B430", VA = "0x1107C630")] get
    {
      return (FlowNode_OnUrlSchemeLaunch) null;
    }
  }

  [Token(Token = "0x1700015B")]
  public static bool IsExecuting
  {
    [Token(Token = "0x6000B28"), Address(RVA = "0x107C670", Offset = "0x107B470", VA = "0x1107C670")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000B29")]
  [Address(RVA = "0x107B440", Offset = "0x107A240", VA = "0x1107B440", Slot = "7")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000B2A")]
  [Address(RVA = "0x7E3D80", Offset = "0x7E2B80", VA = "0x107E3D80")]
  private void Start()
  {
  }

  [Token(Token = "0x6000B2B")]
  [Address(RVA = "0x107B6B0", Offset = "0x107A4B0", VA = "0x1107B6B0", Slot = "4")]
  public override void OnActivate(int pinID)
  {
  }

  [Token(Token = "0x6000B2C")]
  [Address(RVA = "0x107C070", Offset = "0x107AE70", VA = "0x1107C070")]
  private void Update()
  {
  }

  [Token(Token = "0x6000B2D")]
  [Address(RVA = "0x107B910", Offset = "0x107A710", VA = "0x1107B910")]
  public bool UpdatePendingParam() => new bool();

  [Token(Token = "0x6000B2E")]
  [Address(RVA = "0x107B750", Offset = "0x107A550", VA = "0x1107B750")]
  private string[] ParseSchemeParams(string str, int encode_key = -1) => (string[]) null;

  [Token(Token = "0x6000B2F")]
  [Address(RVA = "0x107B4B0", Offset = "0x107A2B0", VA = "0x1107B4B0")]
  private void CreateQRCode()
  {
  }

  [Token(Token = "0x6000B30")]
  [Address(RVA = "0x107B040", Offset = "0x1079E40", VA = "0x1107B040")]
  private FlowNode_OnUrlSchemeLaunch.LINEParam Analyze(string str)
  {
    return (FlowNode_OnUrlSchemeLaunch.LINEParam) null;
  }

  [Token(Token = "0x6000B31")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void ForceQRCodeReading()
  {
  }

  [Token(Token = "0x6000B32")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void ForceLINEInvitation()
  {
  }

  [Token(Token = "0x6000B33")]
  [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
  public FlowNode_OnUrlSchemeLaunch()
  {
  }

  [Token(Token = "0x6000B34")]
  [Address(RVA = "0x107C520", Offset = "0x107B320", VA = "0x1107C520")]
  static FlowNode_OnUrlSchemeLaunch()
  {
  }

  [Token(Token = "0x20001FB")]
  public class LINEParam
  {
    [Token(Token = "0x40008AF")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40008B0")]
    [FieldOffset(Offset = "0xC")]
    public PhotonRoomData.RoomType roomType;
    [Token(Token = "0x40008B1")]
    [FieldOffset(Offset = "0x10")]
    public string creatorFUID;
    [Token(Token = "0x40008B2")]
    [FieldOffset(Offset = "0x14")]
    public int roomid;

    [Token(Token = "0x6000B35")]
    [Address(RVA = "0x36AC30", Offset = "0x369A30", VA = "0x1036AC30", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x6000B36")]
    [Address(RVA = "0x1081D60", Offset = "0x1080B60", VA = "0x11081D60", Slot = "0")]
    public override bool Equals(object tgt) => new bool();

    [Token(Token = "0x6000B37")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LINEParam()
    {
    }
  }
}
