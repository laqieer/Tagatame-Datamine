// Decompiled with JetBrains decompiler
// Type: SRPG.UnitLevelUpListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C70")]
  [AddComponentMenu("UI/UnitLevelUpListItem")]
  public class UnitLevelUpListItem : MonoBehaviour
  {
    [Token(Token = "0x400DBFD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Slider UseExpItemSlider;
    [Token(Token = "0x400DBFE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button PlusBtn;
    [Token(Token = "0x400DBFF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button MinusBtn;
    [Token(Token = "0x400DC00")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text SelectUseNum;
    [Token(Token = "0x400DC01")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle CheckUseMax;
    [Token(Token = "0x400DC02")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text UseItemNum;
    [Token(Token = "0x400DC03")]
    [FieldOffset(Offset = "0x24")]
    public UnitLevelUpListItem.SelectExpItem OnSelect;
    [Token(Token = "0x400DC04")]
    [FieldOffset(Offset = "0x28")]
    public UnitLevelUpListItem.ChangeToggleEvent ChangeUseMax;
    [Token(Token = "0x400DC05")]
    [FieldOffset(Offset = "0x2C")]
    public UnitLevelUpListItem.CheckSliderValue OnCheck;
    [Token(Token = "0x400DC06")]
    [FieldOffset(Offset = "0x30")]
    private string mCurrentItemID;
    [Token(Token = "0x400DC07")]
    [FieldOffset(Offset = "0x34")]
    private int mMaxValue;
    [Token(Token = "0x400DC08")]
    [FieldOffset(Offset = "0x38")]
    private bool IsLock;
    [Token(Token = "0x400DC09")]
    [FieldOffset(Offset = "0x3C")]
    private float mPrevValue;

    [Token(Token = "0x600CDE8")]
    [Address(RVA = "0x98B950", Offset = "0x98A750", VA = "0x1098B950")]
    private void Start()
    {
    }

    [Token(Token = "0x600CDE9")]
    [Address(RVA = "0x98ABB0", Offset = "0x9899B0", VA = "0x1098ABB0")]
    private void Init()
    {
    }

    [Token(Token = "0x600CDEA")]
    [Address(RVA = "0x98B370", Offset = "0x98A170", VA = "0x1098B370")]
    private void Refresh(float value)
    {
    }

    [Token(Token = "0x600CDEB")]
    [Address(RVA = "0x98B280", Offset = "0x98A080", VA = "0x1098B280")]
    private void OnSelectUseNumChanged(float value)
    {
    }

    [Token(Token = "0x600CDEC")]
    [Address(RVA = "0x98B120", Offset = "0x989F20", VA = "0x1098B120")]
    private void OnAddNum()
    {
    }

    [Token(Token = "0x600CDED")]
    [Address(RVA = "0x98B1C0", Offset = "0x989FC0", VA = "0x1098B1C0")]
    private void OnRemoveNum()
    {
    }

    [Token(Token = "0x600CDEE")]
    [Address(RVA = "0x4510A0", Offset = "0x44FEA0", VA = "0x104510A0")]
    public void OnChangeUseMax(bool value)
    {
    }

    [Token(Token = "0x600CDEF")]
    [Address(RVA = "0x98B0B0", Offset = "0x989EB0", VA = "0x1098B0B0")]
    public bool IsUseMax() => new bool();

    [Token(Token = "0x600CDF0")]
    [Address(RVA = "0x98B880", Offset = "0x98A680", VA = "0x1098B880")]
    public void SetUseExpItemSliderValue(int value)
    {
    }

    [Token(Token = "0x600CDF1")]
    [Address(RVA = "0x98B6A0", Offset = "0x98A4A0", VA = "0x1098B6A0")]
    public void Reset()
    {
    }

    [Token(Token = "0x600CDF2")]
    [Address(RVA = "0x98B780", Offset = "0x98A580", VA = "0x1098B780")]
    public void SetInputLock(bool islock)
    {
    }

    [Token(Token = "0x600CDF3")]
    [Address(RVA = "0x451860", Offset = "0x450660", VA = "0x10451860")]
    public void SetUseMax(bool is_on)
    {
    }

    [Token(Token = "0x600CDF4")]
    [Address(RVA = "0x98BA90", Offset = "0x98A890", VA = "0x1098BA90")]
    public UnitLevelUpListItem()
    {
    }

    [Token(Token = "0x2002C71")]
    public delegate void SelectExpItem(string iname, int value);

    [Token(Token = "0x2002C72")]
    public delegate void ChangeToggleEvent(string iname, bool is_on);

    [Token(Token = "0x2002C73")]
    public delegate int CheckSliderValue(string iname, int value);
  }
}
