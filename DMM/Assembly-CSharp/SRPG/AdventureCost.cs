// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureCost
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F7D")]
  [AddComponentMenu("UI/Adventure/AdventureCost")]
  public class AdventureCost : MonoBehaviour
  {
    [Token(Token = "0x4008503")]
    [FieldOffset(Offset = "0xC")]
    public AdventureCost.eAdventureCostType CostType;
    [Token(Token = "0x4008504")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text CostNum;
    [Token(Token = "0x4008505")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text Amount;
    [Token(Token = "0x4008506")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private int DisplayCapNum;
    [Token(Token = "0x4008507")]
    [FieldOffset(Offset = "0x1C")]
    private AdventureData mData;
    [Token(Token = "0x4008508")]
    [FieldOffset(Offset = "0x20")]
    private AdventureCostParam.Cost mCostItem;
    [Token(Token = "0x4008509")]
    [FieldOffset(Offset = "0x24")]
    private ItemParam mItemParam;
    [Token(Token = "0x400850A")]
    [FieldOffset(Offset = "0x28")]
    private ItemData mItemData;
    [Token(Token = "0x400850B")]
    [FieldOffset(Offset = "0x2C")]
    private int mCostItemNum;
    [Token(Token = "0x400850C")]
    [FieldOffset(Offset = "0x30")]
    private int mCostAP;

    [Token(Token = "0x6008165")]
    [Address(RVA = "0x41F310", Offset = "0x41E110", VA = "0x1041F310")]
    public void SetUp(
      AdventureCost.eAdventureCostType _type,
      AdventureData _data,
      AdventureCostParam.Cost _cost_item,
      int _cost_ap)
    {
    }

    [Token(Token = "0x6008166")]
    [Address(RVA = "0x41F020", Offset = "0x41DE20", VA = "0x1041F020")]
    private void SetUpCostItem(AdventureCostParam.Cost _cost_item)
    {
    }

    [Token(Token = "0x6008167")]
    [Address(RVA = "0x41EF20", Offset = "0x41DD20", VA = "0x1041EF20")]
    private void SetUpCostAp(int _cost_ap)
    {
    }

    [Token(Token = "0x6008168")]
    [Address(RVA = "0x41EE40", Offset = "0x41DC40", VA = "0x1041EE40")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008169")]
    [Address(RVA = "0x41EDC0", Offset = "0x41DBC0", VA = "0x1041EDC0")]
    public bool IsEnoughCost() => new bool();

    [Token(Token = "0x600816A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureCost()
    {
    }

    [Token(Token = "0x2001F7E")]
    public enum eAdventureCostType
    {
      [Token(Token = "0x400850E")] ITEM,
      [Token(Token = "0x400850F")] AP,
    }
  }
}
