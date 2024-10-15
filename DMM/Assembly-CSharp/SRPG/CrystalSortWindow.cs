// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSortWindow
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
  [Token(Token = "0x20022EB")]
  [FlowNode.Pin(1, "ソートセーブ", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "変更あり", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "変更なし", FlowNode.PinTypes.Output, 102)]
  public class CrystalSortWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009B9A")]
    private const int PIN_INPUT_CLOSE = 1;
    [Token(Token = "0x4009B9B")]
    private const int PIN_OUTPUT_CHANGE_SORT = 101;
    [Token(Token = "0x4009B9C")]
    private const int PIN_OUTPUT_NOT_CHANGE = 102;
    [Token(Token = "0x4009B9D")]
    private const string NONE_TITLE_INAME = "NoTitle";
    [Token(Token = "0x4009B9F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalCategorySortItem ItemTempleate;
    [Token(Token = "0x4009BA0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform Parent;
    [Token(Token = "0x4009BA1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CrystalCategorySortTab TabTempleate;
    [Token(Token = "0x4009BA2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform TabParent;
    [Token(Token = "0x4009BA3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle ToggleAscending;
    [Token(Token = "0x4009BA4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle mToggleDescending;
    [Token(Token = "0x4009BA5")]
    [FieldOffset(Offset = "0x28")]
    private SortUtility.SortPrefs mCurrentSortPrefs;
    [Token(Token = "0x4009BA6")]
    [FieldOffset(Offset = "0x2C")]
    private List<CrystalCategorySortToggle> mToggleList;
    [Token(Token = "0x4009BA7")]
    [FieldOffset(Offset = "0x30")]
    private List<CrystalCategorySortItem> mItemList;
    [Token(Token = "0x4009BA8")]
    [FieldOffset(Offset = "0x34")]
    private List<CrystalSortParam> mMaster;
    [Token(Token = "0x4009BA9")]
    [FieldOffset(Offset = "0x38")]
    private Dictionary<string, List<CrystalSortParam>> mTabDic;
    [Token(Token = "0x4009BAA")]
    [FieldOffset(Offset = "0x3C")]
    private string mSelectTabName;
    [Token(Token = "0x4009BAB")]
    [FieldOffset(Offset = "0x40")]
    private string mSelectSortIname;

    [Token(Token = "0x170014F3")]
    public string SelectCondIname
    {
      [Token(Token = "0x600960A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600960B"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x600960C")]
    [Address(RVA = "0x58D260", Offset = "0x58C060", VA = "0x1058D260", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600960D")]
    [Address(RVA = "0x58E920", Offset = "0x58D720", VA = "0x1058E920")]
    private void Start()
    {
    }

    [Token(Token = "0x600960E")]
    [Address(RVA = "0x58DA50", Offset = "0x58C850", VA = "0x1058DA50")]
    private void Init()
    {
    }

    [Token(Token = "0x600960F")]
    [Address(RVA = "0x58D410", Offset = "0x58C210", VA = "0x1058D410")]
    private void DisplayList()
    {
    }

    [Token(Token = "0x6009610")]
    [Address(RVA = "0x58D2A0", Offset = "0x58C0A0", VA = "0x1058D2A0")]
    private void ChangeTabActive()
    {
    }

    [Token(Token = "0x6009611")]
    [Address(RVA = "0x58E2A0", Offset = "0x58D0A0", VA = "0x1058E2A0")]
    private bool IsSavePrefs() => new bool();

    [Token(Token = "0x6009612")]
    [Address(RVA = "0x58E8E0", Offset = "0x58D6E0", VA = "0x1058E8E0")]
    public void SetToggleButton(CrystalCategorySortToggle _toggle)
    {
    }

    [Token(Token = "0x6009613")]
    [Address(RVA = "0x58E6B0", Offset = "0x58D4B0", VA = "0x1058E6B0")]
    public void SelectSortToggle(CrystalCategorySortToggle _toggle, bool _is_on)
    {
    }

    [Token(Token = "0x6009614")]
    [Address(RVA = "0x58E890", Offset = "0x58D690", VA = "0x1058E890")]
    public void SelectTabToggle(CrystalCategorySortTab _tab, bool _is_on)
    {
    }

    [Token(Token = "0x6009615")]
    [Address(RVA = "0x58E930", Offset = "0x58D730", VA = "0x1058E930")]
    public CrystalSortWindow()
    {
    }
  }
}
