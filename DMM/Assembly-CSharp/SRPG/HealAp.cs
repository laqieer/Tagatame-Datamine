// Decompiled with JetBrains decompiler
// Type: SRPG.HealAp
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
  [Token(Token = "0x2002613")]
  [FlowNode.Pin(2, "NotRequiredHeal", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(1, "Close", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(3, "HealCoin", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(4, "Heal", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/HealAp")]
  [FlowNode.Pin(10, "Click Use", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(5, "HealOverFlow", FlowNode.PinTypes.Output, 5)]
  public class HealAp : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B14A")]
    [FieldOffset(Offset = "0xC")]
    private List<ItemData> mHealItemList;
    [Token(Token = "0x400B14B")]
    [FieldOffset(Offset = "0x10")]
    public GameObject mItemParent;
    [Token(Token = "0x400B14C")]
    [FieldOffset(Offset = "0x14")]
    public GameObject mItemBase;
    [Token(Token = "0x400B14D")]
    [FieldOffset(Offset = "0x18")]
    public Text LackAp;
    [Token(Token = "0x400B14E")]
    [FieldOffset(Offset = "0x1C")]
    public QuestParam mQuestParam;
    [Token(Token = "0x400B14F")]
    [FieldOffset(Offset = "0x20")]
    public Slider silder;
    [Token(Token = "0x400B150")]
    [FieldOffset(Offset = "0x24")]
    public GameObject QuestInfo;
    [Token(Token = "0x400B151")]
    [FieldOffset(Offset = "0x28")]
    public HealApBar bar;
    [Token(Token = "0x400B152")]
    [FieldOffset(Offset = "0x2C")]
    public Text now_ap;
    [Token(Token = "0x400B153")]
    [FieldOffset(Offset = "0x30")]
    public Text max_ap;
    [Token(Token = "0x400B154")]
    [FieldOffset(Offset = "0x34")]
    public Text heal_coin_text;
    [Token(Token = "0x400B155")]
    [FieldOffset(Offset = "0x38")]
    public Text heal_coin_num;
    [Token(Token = "0x400B156")]
    [FieldOffset(Offset = "0x3C")]
    public Text pre_ap;
    [Token(Token = "0x400B157")]
    [FieldOffset(Offset = "0x40")]
    public Text new_ap;
    [Token(Token = "0x400B158")]
    [FieldOffset(Offset = "0x44")]
    private AdventureData mAdvData;

    [Token(Token = "0x600A9C3")]
    [Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x106D0BB0")]
    public void Refresh(bool is_quest, FlowNode_HealApWindow heal_ap_window, bool _is_adventure = false)
    {
    }

    [Token(Token = "0x600A9C4")]
    [Address(RVA = "0x6D0C10", Offset = "0x6CFA10", VA = "0x106D0C10")]
    public void Refresh(bool is_quest, PartyWindow2 _party_window, bool _is_adventure = false)
    {
    }

    [Token(Token = "0x600A9C5")]
    [Address(RVA = "0x6D0B40", Offset = "0x6CF940", VA = "0x106D0B40")]
    public void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600A9C6")]
    [Address(RVA = "0x6D0A60", Offset = "0x6CF860", VA = "0x106D0A60")]
    public void HealApCoin()
    {
    }

    [Token(Token = "0x600A9C7")]
    [Address(RVA = "0x6D0A80", Offset = "0x6CF880", VA = "0x106D0A80")]
    public void OnClickHeal()
    {
    }

    [Token(Token = "0x600A9C8")]
    [Address(RVA = "0x6D09A0", Offset = "0x6CF7A0", VA = "0x106D09A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A9C9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HealAp()
    {
    }
  }
}
