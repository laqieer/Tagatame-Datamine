// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNodeDetail
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
  [Token(Token = "0x20025F8")]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/GvG/GvGNodeDetail")]
  public class GvGNodeDetail : MonoBehaviour, IFlowInterface, IPagination
  {
    [Token(Token = "0x400B08F")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400B090")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text NodeNameText;
    [Token(Token = "0x400B091")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GvGPartyContent PartyTemplate;
    [Token(Token = "0x400B092")]
    [FieldOffset(Offset = "0x14")]
    [Space(10f)]
    [SerializeField]
    private Button PageNextButton;
    [Token(Token = "0x400B093")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button PagePrevButton;
    [Token(Token = "0x400B094")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text PageCurrentText;
    [Token(Token = "0x400B095")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text PageTotalText;
    [Token(Token = "0x400B096")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ScrollRect PartyScrollRect;
    [Token(Token = "0x400B097")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ImageArray mTitleImageArray;
    [Token(Token = "0x400B098")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ImageArray mDialogImageArray;
    [Token(Token = "0x400B099")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mDefenseTotalBeat;
    [Token(Token = "0x400B09A")]
    [FieldOffset(Offset = "0x34")]
    private GvGNodeData CurrentNode;
    [Token(Token = "0x400B09B")]
    [FieldOffset(Offset = "0x38")]
    private List<GvGParty> DefenseParties;
    [Token(Token = "0x400B09C")]
    [FieldOffset(Offset = "0x3C")]
    private List<GvGPartyContent> PartyList;
    [Token(Token = "0x400B0A0")]
    [FieldOffset(Offset = "0x48")]
    private int TotalPage;

    [Token(Token = "0x170017D6")]
    public static GvGNodeDetail Instance
    {
      [Token(Token = "0x600A917"), Address(RVA = "0x6BF410", Offset = "0x6BE210", VA = "0x106BF410")] get
      {
        return (GvGNodeDetail) null;
      }
      [Token(Token = "0x600A918"), Address(RVA = "0x6BF440", Offset = "0x6BE240", VA = "0x106BF440")] private set
      {
      }
    }

    [Token(Token = "0x170017D7")]
    public int CurrentPage
    {
      [Token(Token = "0x600A919"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A91A"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
      {
      }
    }

    [Token(Token = "0x170017D8")]
    public int TotalBeatNum
    {
      [Token(Token = "0x600A91B"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600A91C"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
      {
      }
    }

    [Token(Token = "0x600A91D")]
    [Address(RVA = "0x6BE600", Offset = "0x6BD400", VA = "0x106BE600")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A91E")]
    [Address(RVA = "0x6BED50", Offset = "0x6BDB50", VA = "0x106BED50")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A91F")]
    [Address(RVA = "0x6BF0F0", Offset = "0x6BDEF0", VA = "0x106BF0F0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A920")]
    [Address(RVA = "0x6BE5E0", Offset = "0x6BD3E0", VA = "0x106BE5E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A921")]
    [Address(RVA = "0x6BE640", Offset = "0x6BD440", VA = "0x106BE640")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A922")]
    [Address(RVA = "0x6BEDB0", Offset = "0x6BDBB0", VA = "0x106BEDB0")]
    private void RefreshPagination()
    {
    }

    [Token(Token = "0x600A923")]
    [Address(RVA = "0x6BED30", Offset = "0x6BDB30", VA = "0x106BED30", Slot = "5")]
    public void NextPage()
    {
    }

    [Token(Token = "0x600A924")]
    [Address(RVA = "0x6BED90", Offset = "0x6BDB90", VA = "0x106BED90", Slot = "6")]
    public void PrevPage()
    {
    }

    [Token(Token = "0x600A925")]
    [Address(RVA = "0x6BEFE0", Offset = "0x6BDDE0", VA = "0x106BEFE0")]
    public bool SetupDefenseParties(JSON_GvGParty[] json, int totalPage, int totalBeatNum)
    {
      return new bool();
    }

    [Token(Token = "0x600A926")]
    [Address(RVA = "0x6BF350", Offset = "0x6BE150", VA = "0x106BF350")]
    public GvGNodeDetail()
    {
    }
  }
}
