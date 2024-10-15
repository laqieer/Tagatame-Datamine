// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidReportInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200258D")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Copy", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("UI/GuildRaid/GuildRaidReportInfo")]
  public class GuildRaidReportInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AE39")]
    private const int PIN_IN_INITIALIZE = 1;
    [Token(Token = "0x400AE3A")]
    private const int PIN_IN_COPY = 2;
    [Token(Token = "0x400AE3B")]
    [FieldOffset(Offset = "0x0")]
    private static GuildRaidReportInfo mInstance;
    [Token(Token = "0x400AE3C")]
    [FieldOffset(Offset = "0x4")]
    public static GuildRaidReportData StaticReportData;
    [Token(Token = "0x400AE3D")]
    [FieldOffset(Offset = "0xC")]
    private GuildRaidReportData ReportData;
    [Token(Token = "0x400AE3E")]
    [FieldOffset(Offset = "0x10")]
    private GuildRaidPartyList PartyList;
    [Token(Token = "0x400AE3F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform PartyListParent;
    [Token(Token = "0x400AE40")]
    [FieldOffset(Offset = "0x18")]
    [StringIsResourcePath(typeof (GuildRaidPartyList))]
    [SerializeField]
    private string PartyListPrefabPath;
    [Token(Token = "0x400AE41")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private FixedScrollablePulldown TeamPulldown;
    [Token(Token = "0x400AE42")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject PostButton;
    [Token(Token = "0x400AE43")]
    [FieldOffset(Offset = "0x24")]
    private bool IsPerfect;
    [Token(Token = "0x400AE44")]
    [FieldOffset(Offset = "0x25")]
    private bool IsChangeCardLeader;
    [Token(Token = "0x400AE45")]
    [FieldOffset(Offset = "0x28")]
    private UnitData LeaderUnit;

    [Token(Token = "0x17001761")]
    public static int CurrentReportId
    {
      [Token(Token = "0x600A6D2"), Address(RVA = "0x68C160", Offset = "0x68AF60", VA = "0x1068C160")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600A6D3")]
    [Address(RVA = "0x68BF00", Offset = "0x68AD00", VA = "0x1068BF00")]
    private void Start()
    {
    }

    [Token(Token = "0x600A6D4")]
    [Address(RVA = "0x68BDA0", Offset = "0x68ABA0", VA = "0x1068BDA0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A6D5")]
    [Address(RVA = "0x68A6F0", Offset = "0x6894F0", VA = "0x1068A6F0", Slot = "4")]
    public void Activated(int pinId)
    {
    }

    [Token(Token = "0x600A6D6")]
    [Address(RVA = "0x68BAA0", Offset = "0x68A8A0", VA = "0x1068BAA0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A6D7")]
    [Address(RVA = "0x68ADD0", Offset = "0x689BD0", VA = "0x1068ADD0")]
    private void CopyParty()
    {
    }

    [Token(Token = "0x600A6D8")]
    [Address(RVA = "0x68AA10", Offset = "0x689810", VA = "0x1068AA10")]
    private void CopyPartyCardLS()
    {
    }

    [Token(Token = "0x600A6D9")]
    [Address(RVA = "0x68B760", Offset = "0x68A560", VA = "0x1068B760")]
    private void EquipConceptCardCallBack(WWWResult www)
    {
    }

    [Token(Token = "0x600A6DA")]
    [Address(RVA = "0x68A720", Offset = "0x689520", VA = "0x1068A720")]
    private void ChangeCardLSCallBack(WWWResult www)
    {
    }

    [Token(Token = "0x600A6DB")]
    [Address(RVA = "0x68BDE0", Offset = "0x68ABE0", VA = "0x1068BDE0")]
    private void ShowMessage(GuildRaidReportInfo.MessageType type)
    {
    }

    [Token(Token = "0x600A6DC")]
    [Address(RVA = "0x68C140", Offset = "0x68AF40", VA = "0x1068C140")]
    public GuildRaidReportInfo()
    {
    }

    [Token(Token = "0x200258E")]
    private enum MessageType
    {
      [Token(Token = "0x400AE47")] NO_LEADER,
      [Token(Token = "0x400AE48")] NO_CARD_LS,
      [Token(Token = "0x400AE49")] NOT_PERFECT,
      [Token(Token = "0x400AE4A")] SUCCESS,
    }
  }
}
