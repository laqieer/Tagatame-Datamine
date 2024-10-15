// Decompiled with JetBrains decompiler
// Type: SRPG.RuneScrollList
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
  [Token(Token = "0x20029E4")]
  [AddComponentMenu("UI/Rune/RuneScrollList")]
  public class RuneScrollList : MonoBehaviour
  {
    [Token(Token = "0x400CB83")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text mEmptyMessageText;
    [Token(Token = "0x400CB84")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x400CB85")]
    [FieldOffset(Offset = "0x14")]
    private List<BindRuneData> mRuneDatas;
    [Token(Token = "0x400CB86")]
    [FieldOffset(Offset = "0x18")]
    private List<BindRuneData> mRuneDatasDefault;
    [Token(Token = "0x400CB87")]
    [FieldOffset(Offset = "0x1C")]
    private List<RuneIconParam> mIconParams;
    [Token(Token = "0x400CB88")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsEquipHide;
    [Token(Token = "0x400CB89")]
    [FieldOffset(Offset = "0x21")]
    private bool mIsHideButtonFlag;
    [Token(Token = "0x400CB8A")]
    [FieldOffset(Offset = "0x22")]
    private RuneSlotIndex mCurrentSlotFilter;

    [Token(Token = "0x170019B7")]
    public bool IsEquipHide
    {
      [Token(Token = "0x600BEDD"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170019B8")]
    public bool HideButtonFlag
    {
      [Token(Token = "0x600BEDE"), Address(RVA = "0x305F20", Offset = "0x304D20", VA = "0x10305F20")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170019B9")]
    public List<BindRuneData> RuneDatas
    {
      [Token(Token = "0x600BEDF"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<BindRuneData>) null;
      }
    }

    [Token(Token = "0x600BEE0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BEE1")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BEE2")]
    [Address(RVA = "0x864980", Offset = "0x863780", VA = "0x10864980")]
    public void Init(
      List<BindRuneData> rune_datas,
      RuneSlotIndex slotFilter,
      bool is_equip_hide = false,
      bool is_not_sort = false,
      bool _is_use_equip_button = false,
      UnitData currentUnit = null)
    {
    }

    [Token(Token = "0x600BEE3")]
    [Address(RVA = "0x8642D0", Offset = "0x8630D0", VA = "0x108642D0")]
    public void CreateContens()
    {
    }

    [Token(Token = "0x600BEE4")]
    [Address(RVA = "0x864AE0", Offset = "0x8638E0", VA = "0x10864AE0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BEE5")]
    [Address(RVA = "0x864C50", Offset = "0x863A50", VA = "0x10864C50")]
    public void Sort(UnitData selectedUnit = null)
    {
    }

    [Token(Token = "0x600BEE6")]
    [Address(RVA = "0x8647E0", Offset = "0x8635E0", VA = "0x108647E0")]
    public void Filter(RuneSlotIndex slotFilter)
    {
    }

    [Token(Token = "0x600BEE7")]
    [Address(RVA = "0x864730", Offset = "0x863530", VA = "0x10864730")]
    public void EquipHide(bool _change_flag, bool _is_use_button_flag = false, bool _is_equip_hide = false)
    {
    }

    [Token(Token = "0x600BEE8")]
    [Address(RVA = "0x8644E0", Offset = "0x8632E0", VA = "0x108644E0")]
    private List<BindRuneData> EquipHideList(List<BindRuneData> _rune_datas, bool _is_equip_hide)
    {
      return (List<BindRuneData>) null;
    }

    [Token(Token = "0x600BEE9")]
    [Address(RVA = "0x864BD0", Offset = "0x8639D0", VA = "0x10864BD0")]
    public void ReverseEquipHideFlag()
    {
    }

    [Token(Token = "0x600BEEA")]
    [Address(RVA = "0x864910", Offset = "0x863710", VA = "0x10864910")]
    public ContentScroller GetScroller() => (ContentScroller) null;

    [Token(Token = "0x600BEEB")]
    [Address(RVA = "0x864D00", Offset = "0x863B00", VA = "0x10864D00")]
    public RuneScrollList()
    {
    }

    [Token(Token = "0x20029E5")]
    public enum FilterType
    {
      [Token(Token = "0x400CB8C")] None,
      [Token(Token = "0x400CB8D")] Disable,
      [Token(Token = "0x400CB8E")] Hide,
    }
  }
}
