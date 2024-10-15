// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactLevelUpListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002008")]
  [AddComponentMenu("UI/ArtifactLevelUpListItem")]
  public class ArtifactLevelUpListItem : MonoBehaviour
  {
    [Token(Token = "0x40088B0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Slider UseExpItemSlider;
    [Token(Token = "0x40088B1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button PlusBtn;
    [Token(Token = "0x40088B2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button MinusBtn;
    [Token(Token = "0x40088B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text SelectUseNum;
    [Token(Token = "0x40088B4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle CheckUseMax;
    [Token(Token = "0x40088B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text UseItemNum;
    [Token(Token = "0x40088B6")]
    [FieldOffset(Offset = "0x24")]
    public ArtifactLevelUpListItem.SelectExpItem OnSelect;
    [Token(Token = "0x40088B7")]
    [FieldOffset(Offset = "0x28")]
    public ArtifactLevelUpListItem.ChangeToggleEvent ChangeUseMax;
    [Token(Token = "0x40088B8")]
    [FieldOffset(Offset = "0x2C")]
    public ArtifactLevelUpListItem.CheckSliderValue OnCheck;
    [Token(Token = "0x40088B9")]
    [FieldOffset(Offset = "0x30")]
    private string mCurrentItemID;
    [Token(Token = "0x40088BA")]
    [FieldOffset(Offset = "0x34")]
    private int mMaxValue;
    [Token(Token = "0x40088BB")]
    [FieldOffset(Offset = "0x38")]
    private bool IsLock;
    [Token(Token = "0x40088BC")]
    [FieldOffset(Offset = "0x3C")]
    private float mPrevValue;

    [Token(Token = "0x600845B")]
    [Address(RVA = "0x451890", Offset = "0x450690", VA = "0x10451890")]
    private void Start()
    {
    }

    [Token(Token = "0x600845C")]
    [Address(RVA = "0x450A80", Offset = "0x44F880", VA = "0x10450A80")]
    private void Init()
    {
    }

    [Token(Token = "0x600845D")]
    [Address(RVA = "0x451280", Offset = "0x450080", VA = "0x10451280")]
    private void Refresh(float value)
    {
    }

    [Token(Token = "0x600845E")]
    [Address(RVA = "0x451190", Offset = "0x44FF90", VA = "0x10451190")]
    private void OnSelectUseNumChanged(float value)
    {
    }

    [Token(Token = "0x600845F")]
    [Address(RVA = "0x451000", Offset = "0x44FE00", VA = "0x10451000")]
    private void OnAddNum()
    {
    }

    [Token(Token = "0x6008460")]
    [Address(RVA = "0x4510D0", Offset = "0x44FED0", VA = "0x104510D0")]
    private void OnRemoveNum()
    {
    }

    [Token(Token = "0x6008461")]
    [Address(RVA = "0x4510A0", Offset = "0x44FEA0", VA = "0x104510A0")]
    public void OnChangeUseMax(bool value)
    {
    }

    [Token(Token = "0x6008462")]
    [Address(RVA = "0x450F80", Offset = "0x44FD80", VA = "0x10450F80")]
    public bool IsUseMax() => new bool();

    [Token(Token = "0x6008463")]
    [Address(RVA = "0x451790", Offset = "0x450590", VA = "0x10451790")]
    public void SetUseExpItemSliderValue(int value)
    {
    }

    [Token(Token = "0x6008464")]
    [Address(RVA = "0x4515B0", Offset = "0x4503B0", VA = "0x104515B0")]
    public void Reset()
    {
    }

    [Token(Token = "0x6008465")]
    [Address(RVA = "0x451690", Offset = "0x450490", VA = "0x10451690")]
    public void SetInputLock(bool islock)
    {
    }

    [Token(Token = "0x6008466")]
    [Address(RVA = "0x451860", Offset = "0x450660", VA = "0x10451860")]
    public void SetUseMax(bool is_on)
    {
    }

    [Token(Token = "0x6008467")]
    [Address(RVA = "0x4519D0", Offset = "0x4507D0", VA = "0x104519D0")]
    public ArtifactLevelUpListItem()
    {
    }

    [Token(Token = "0x2002009")]
    public delegate void SelectExpItem(string iname, int value);

    [Token(Token = "0x200200A")]
    public delegate void ChangeToggleEvent(string iname, bool is_on);

    [Token(Token = "0x200200B")]
    public delegate int CheckSliderValue(string iname, int value);
  }
}
