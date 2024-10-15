// Decompiled with JetBrains decompiler
// Type: SRPG.GvGNodeInfo
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
  [Token(Token = "0x20025FA")]
  [FlowNode.Pin(11, "Refresh", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/GvG/GvGNodeInfo")]
  public class GvGNodeInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B0A4")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400B0A5")]
    public const int PIN_INPUT_REFRESH = 11;
    [Token(Token = "0x400B0A6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text NodeNameText;
    [Token(Token = "0x400B0A7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RewardListItem RewardItem;
    [Token(Token = "0x400B0A8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject MapParent;
    [Token(Token = "0x400B0A9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject GuildParent;
    [Token(Token = "0x400B0AA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text OccupyDay;
    [Token(Token = "0x400B0AB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text OccupyPoint;
    [Token(Token = "0x400B0AC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text OccupyHalfPoint;
    [Token(Token = "0x400B0AD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private List<ImageArray> ImageArrayList;
    [Token(Token = "0x400B0AE")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Space(10f)]
    private List<GameObject> NPCOffObjectList;
    [Token(Token = "0x400B0AF")]
    [FieldOffset(Offset = "0x30")]
    [Space(10f)]
    [SerializeField]
    private GameObject RemainDeclareCoolTime;
    [Token(Token = "0x400B0B0")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text RemainDeclareCoolTimeText;
    [Token(Token = "0x400B0B1")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button DeclareButton;
    [Token(Token = "0x400B0B2")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button AttackButton;
    [Token(Token = "0x400B0B3")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button DefenseSetButton;
    [Token(Token = "0x400B0B4")]
    [FieldOffset(Offset = "0x44")]
    [Space(10f)]
    [SerializeField]
    private ImageArray mDefensePartyIcon;
    [Token(Token = "0x400B0B7")]
    [FieldOffset(Offset = "0x4C")]
    private GvGNodeData CurrentNode;
    [Token(Token = "0x400B0B8")]
    [FieldOffset(Offset = "0x50")]
    private List<RewardListItem> RewardItemList;
    [Token(Token = "0x400B0B9")]
    [FieldOffset(Offset = "0x54")]
    private List<JSON_GvGUnitOverWriteData> mGvGtempParty;

    [Token(Token = "0x170017D9")]
    public static GvGNodeInfo Instance
    {
      [Token(Token = "0x600A92B"), Address(RVA = "0x6C0DA0", Offset = "0x6BFBA0", VA = "0x106C0DA0")] get
      {
        return (GvGNodeInfo) null;
      }
      [Token(Token = "0x600A92C"), Address(RVA = "0x6C0DD0", Offset = "0x6BFBD0", VA = "0x106C0DD0")] private set
      {
      }
    }

    [Token(Token = "0x170017DA")]
    public long[] EditPartyIds
    {
      [Token(Token = "0x600A92D"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (long[]) null;
      }
      [Token(Token = "0x600A92E"), Address(RVA = "0x288230", Offset = "0x287030", VA = "0x10288230")] private set
      {
      }
    }

    [Token(Token = "0x170017DB")]
    public List<JSON_GvGUnitOverWriteData> GvGtempParty
    {
      [Token(Token = "0x600A92F"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return (List<JSON_GvGUnitOverWriteData>) null;
      }
    }

    [Token(Token = "0x600A930")]
    [Address(RVA = "0x6BF4C0", Offset = "0x6BE2C0", VA = "0x106BF4C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A931")]
    [Address(RVA = "0x6BFC80", Offset = "0x6BEA80", VA = "0x106BFC80")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A932")]
    [Address(RVA = "0x6C0A10", Offset = "0x6BF810", VA = "0x106C0A10")]
    private void Update()
    {
    }

    [Token(Token = "0x600A933")]
    [Address(RVA = "0x6BF480", Offset = "0x6BE280", VA = "0x106BF480", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A934")]
    [Address(RVA = "0x6BF5B0", Offset = "0x6BE3B0", VA = "0x106BF5B0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600A935")]
    [Address(RVA = "0x6BFEF0", Offset = "0x6BECF0", VA = "0x106BFEF0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A936")]
    [Address(RVA = "0x6C0660", Offset = "0x6BF460", VA = "0x106C0660")]
    private void SetRewardIcon(GvGRewardDetailParam reward, RewardListItem listItem)
    {
    }

    [Token(Token = "0x600A937")]
    [Address(RVA = "0x6BFD60", Offset = "0x6BEB60", VA = "0x106BFD60")]
    private void RefreshButtons()
    {
    }

    [Token(Token = "0x600A938")]
    [Address(RVA = "0x6BFC20", Offset = "0x6BEA20", VA = "0x106BFC20")]
    public void OnDeclareCoolTimeButton()
    {
    }

    [Token(Token = "0x600A939")]
    [Address(RVA = "0x6C0580", Offset = "0x6BF380", VA = "0x106C0580")]
    public void SetEditParty(long[] units)
    {
    }

    [Token(Token = "0x600A93A")]
    [Address(RVA = "0x6C05B0", Offset = "0x6BF3B0", VA = "0x106C05B0")]
    public void SetOverWriteParty(PartyOverWrite party)
    {
    }

    [Token(Token = "0x600A93B")]
    [Address(RVA = "0x6C0C60", Offset = "0x6BFA60", VA = "0x106C0C60")]
    public GvGNodeInfo()
    {
    }
  }
}
