// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLimitUpListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002226")]
  [AddComponentMenu("UI/ConceptCardLimitUpListItem")]
  public class ConceptCardLimitUpListItem : MonoBehaviour
  {
    [Token(Token = "0x4009718")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Slider UseLimitUpItemSlider;
    [Token(Token = "0x4009719")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button PlusBtn;
    [Token(Token = "0x400971A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button MinusBtn;
    [Token(Token = "0x400971B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text TextUseItemNum;
    [Token(Token = "0x400971C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject ItemStatus;
    [Token(Token = "0x400971D")]
    [FieldOffset(Offset = "0x20")]
    private bool IsLock;
    [Token(Token = "0x400971E")]
    [FieldOffset(Offset = "0x24")]
    private int mValueMax;
    [Token(Token = "0x400971F")]
    [FieldOffset(Offset = "0x28")]
    private ItemData mItemData;
    [Token(Token = "0x4009720")]
    [FieldOffset(Offset = "0x2C")]
    private int mUseNum;
    [Token(Token = "0x4009721")]
    [FieldOffset(Offset = "0x30")]
    private int mNeedNum;
    [Token(Token = "0x4009722")]
    [FieldOffset(Offset = "0x34")]
    private Action OnRefresh;
    [Token(Token = "0x4009723")]
    [FieldOffset(Offset = "0x38")]
    private ConceptCardLimitUpListItem.CheckSliderValue OnCheck;
    [Token(Token = "0x4009724")]
    [FieldOffset(Offset = "0x3C")]
    private float mPreValue;

    [Token(Token = "0x600910F")]
    [Address(RVA = "0x548280", Offset = "0x547080", VA = "0x10548280")]
    private void Start()
    {
    }

    [Token(Token = "0x6009110")]
    [Address(RVA = "0x547530", Offset = "0x546330", VA = "0x10547530")]
    public void Init(
      int current_awake,
      int awake_cap,
      int need_num,
      ItemData item_data,
      ConceptCardLimitUpListItem.CheckSliderValue onCheck,
      Action onRefresh)
    {
    }

    [Token(Token = "0x6009111")]
    [Address(RVA = "0x547E90", Offset = "0x546C90", VA = "0x10547E90")]
    private void Refresh(float value)
    {
    }

    [Token(Token = "0x6009112")]
    [Address(RVA = "0x547B30", Offset = "0x546930", VA = "0x10547B30")]
    private void OnValueChanged(float value)
    {
    }

    [Token(Token = "0x6009113")]
    [Address(RVA = "0x5483B0", Offset = "0x5471B0", VA = "0x105483B0")]
    private void UpdateButtonInterctable()
    {
    }

    [Token(Token = "0x6009114")]
    [Address(RVA = "0x5481F0", Offset = "0x546FF0", VA = "0x105481F0")]
    public void SetUseParamItemSliderValue(int value)
    {
    }

    [Token(Token = "0x6009115")]
    [Address(RVA = "0x547910", Offset = "0x546710", VA = "0x10547910")]
    private void OnAddNum()
    {
    }

    [Token(Token = "0x6009116")]
    [Address(RVA = "0x5479B0", Offset = "0x5467B0", VA = "0x105479B0")]
    private void OnRemoveNum()
    {
    }

    [Token(Token = "0x6009117")]
    [Address(RVA = "0x547A50", Offset = "0x546850", VA = "0x10547A50")]
    public void OnReset()
    {
    }

    [Token(Token = "0x6009118")]
    [Address(RVA = "0x5480E0", Offset = "0x546EE0", VA = "0x105480E0")]
    public void SetInputLock(bool islock)
    {
    }

    [Token(Token = "0x6009119")]
    [Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")]
    public ItemData GetItemData() => (ItemData) null;

    [Token(Token = "0x600911A")]
    [Address(RVA = "0x547520", Offset = "0x546320", VA = "0x10547520")]
    public int GetUpCount() => new int();

    [Token(Token = "0x600911B")]
    [Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")]
    public int GetUseNum() => new int();

    [Token(Token = "0x600911C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardLimitUpListItem()
    {
    }

    [Token(Token = "0x2002227")]
    public delegate int CheckSliderValue(string iname, int value);
  }
}
