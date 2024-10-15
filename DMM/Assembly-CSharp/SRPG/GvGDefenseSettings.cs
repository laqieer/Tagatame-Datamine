// Decompiled with JetBrains decompiler
// Type: SRPG.GvGDefenseSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025CC")]
  [FlowNode.Pin(12, "Hide Chat", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(13, "Open Chat", FlowNode.PinTypes.Input, 13)]
  [AddComponentMenu("UI/GvG/GvGDefenseSettings")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  public class GvGDefenseSettings : MonoBehaviour, IFlowInterface, IPagination
  {
    [Token(Token = "0x400AF61")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AF62")]
    public const int PIN_INPUT_HIDECHAT = 12;
    [Token(Token = "0x400AF63")]
    public const int PIN_INPUT_OPENCHAT = 13;
    [Token(Token = "0x400AF64")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text NodeNameText;
    [Token(Token = "0x400AF65")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GvGPartyContent PartyTemplate;
    [Token(Token = "0x400AF66")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Space(10f)]
    private Button PageNextButton;
    [Token(Token = "0x400AF67")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button PagePrevButton;
    [Token(Token = "0x400AF68")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text PageCurrentText;
    [Token(Token = "0x400AF69")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text PageTotalText;
    [Token(Token = "0x400AF6A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ScrollRect PartyScrollRect;
    [Token(Token = "0x400AF6B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mDefenseTotalBeat;
    [Token(Token = "0x400AF6C")]
    [FieldOffset(Offset = "0x2C")]
    private GvGNodeData CurrentNode;
    [Token(Token = "0x400AF6D")]
    [FieldOffset(Offset = "0x30")]
    private List<GvGParty> DefenseParties;
    [Token(Token = "0x400AF6E")]
    [FieldOffset(Offset = "0x34")]
    private List<GvGPartyContent> PartyList;
    [Token(Token = "0x400AF73")]
    [FieldOffset(Offset = "0x44")]
    private int TotalPage;
    [Token(Token = "0x400AF74")]
    [FieldOffset(Offset = "0x48")]
    private List<JSON_GvGUnitOverWriteData> mGvGtempParty;

    [Token(Token = "0x170017A2")]
    public static GvGDefenseSettings Instance
    {
      [Token(Token = "0x600A7F0"), Address(RVA = "0x6B3120", Offset = "0x6B1F20", VA = "0x106B3120")] get
      {
        return (GvGDefenseSettings) null;
      }
      [Token(Token = "0x600A7F1"), Address(RVA = "0x6B3150", Offset = "0x6B1F50", VA = "0x106B3150")] private set
      {
      }
    }

    [Token(Token = "0x170017A3")]
    public long[] EditPartyIds
    {
      [Token(Token = "0x600A7F2"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (long[]) null;
      }
      [Token(Token = "0x600A7F3"), Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")] private set
      {
      }
    }

    [Token(Token = "0x170017A4")]
    public int CurrentPage
    {
      [Token(Token = "0x600A7F4"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7F5"), Address(RVA = "0x373920", Offset = "0x372720", VA = "0x10373920")] private set
      {
      }
    }

    [Token(Token = "0x170017A5")]
    public int TotalBeatNum
    {
      [Token(Token = "0x600A7F6"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A7F7"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
      {
      }
    }

    [Token(Token = "0x170017A6")]
    public List<JSON_GvGUnitOverWriteData> GvGtempParty
    {
      [Token(Token = "0x600A7F8"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (List<JSON_GvGUnitOverWriteData>) null;
      }
    }

    [Token(Token = "0x600A7F9")]
    [Address(RVA = "0x6B2410", Offset = "0x6B1210", VA = "0x106B2410")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A7FA")]
    [Address(RVA = "0x6B29D0", Offset = "0x6B17D0", VA = "0x106B29D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A7FB")]
    [Address(RVA = "0x6B2E20", Offset = "0x6B1C20", VA = "0x106B2E20")]
    private void Start()
    {
    }

    [Token(Token = "0x600A7FC")]
    [Address(RVA = "0x6B2360", Offset = "0x6B1160", VA = "0x106B2360", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A7FD")]
    [Address(RVA = "0x6B2450", Offset = "0x6B1250", VA = "0x106B2450")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A7FE")]
    [Address(RVA = "0x6B2A10", Offset = "0x6B1810", VA = "0x106B2A10")]
    private void RefreshPagination()
    {
    }

    [Token(Token = "0x600A7FF")]
    [Address(RVA = "0x6B29B0", Offset = "0x6B17B0", VA = "0x106B29B0", Slot = "5")]
    public void NextPage()
    {
    }

    [Token(Token = "0x600A800")]
    [Address(RVA = "0x690F40", Offset = "0x68FD40", VA = "0x10690F40", Slot = "6")]
    public void PrevPage()
    {
    }

    [Token(Token = "0x600A801")]
    [Address(RVA = "0x6B2C30", Offset = "0x6B1A30", VA = "0x106B2C30")]
    public void SetEditParty(long[] units)
    {
    }

    [Token(Token = "0x600A802")]
    [Address(RVA = "0x6B2D10", Offset = "0x6B1B10", VA = "0x106B2D10")]
    public bool SetupDefenseParties(JSON_GvGParty[] json, int totalPage, int total_beat_num)
    {
      return new bool();
    }

    [Token(Token = "0x600A803")]
    [Address(RVA = "0x6B2C60", Offset = "0x6B1A60", VA = "0x106B2C60")]
    public void SetOverWriteParty(PartyOverWrite party)
    {
    }

    [Token(Token = "0x600A804")]
    [Address(RVA = "0x6B3020", Offset = "0x6B1E20", VA = "0x106B3020")]
    public GvGDefenseSettings()
    {
    }
  }
}
