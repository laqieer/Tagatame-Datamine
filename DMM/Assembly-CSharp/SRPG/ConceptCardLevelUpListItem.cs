// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLevelUpListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002218")]
  [AddComponentMenu("UI/ConceptCardLevelUpListItem")]
  public class ConceptCardLevelUpListItem : MonoBehaviour
  {
    [Token(Token = "0x40096B0")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Slider UseExpItemSlider;
    [Token(Token = "0x40096B1")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button PlusBtn;
    [Token(Token = "0x40096B2")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button MinusBtn;
    [Token(Token = "0x40096B3")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text SelectUseNum;
    [Token(Token = "0x40096B4")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle CheckUseMax;
    [Token(Token = "0x40096B5")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text UseItemNum;
    [Token(Token = "0x40096B6")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text ConceptCardEnExp;
    [Token(Token = "0x40096B7")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ConceptCardIcon CardIcon;
    [Token(Token = "0x40096B8")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text CardNum;
    [Token(Token = "0x40096B9")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject ExpObject;
    [Token(Token = "0x40096BA")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private int MaxCardNum;
    [Token(Token = "0x40096BB")]
    [FieldOffset(Offset = "0x38")]
    public ConceptCardLevelUpListItem.SelectExpItem OnSelect;
    [Token(Token = "0x40096BC")]
    [FieldOffset(Offset = "0x3C")]
    public ConceptCardLevelUpListItem.ChangeToggleEvent ChangeUseMax;
    [Token(Token = "0x40096BD")]
    [FieldOffset(Offset = "0x40")]
    public ConceptCardLevelUpListItem.CheckSliderValue OnCheck;
    [Token(Token = "0x40096BE")]
    [FieldOffset(Offset = "0x44")]
    private string mCurrentItemID;
    [Token(Token = "0x40096BF")]
    [FieldOffset(Offset = "0x48")]
    private int mMaxValue;
    [Token(Token = "0x40096C0")]
    [FieldOffset(Offset = "0x4C")]
    private bool IsLock;
    [Token(Token = "0x40096C1")]
    [FieldOffset(Offset = "0x50")]
    private float mPrevValue;
    [Token(Token = "0x40096C2")]
    [FieldOffset(Offset = "0x54")]
    private ConceptCardMaterialData mConceptCardMaterialData;
    [Token(Token = "0x40096C3")]
    [FieldOffset(Offset = "0x58")]
    private ConceptCardData mCardData;

    [Token(Token = "0x60090B0")]
    [Address(RVA = "0x53F8A0", Offset = "0x53E6A0", VA = "0x1053F8A0")]
    private void Start()
    {
    }

    [Token(Token = "0x60090B1")]
    [Address(RVA = "0x53E3D0", Offset = "0x53D1D0", VA = "0x1053E3D0")]
    public void Init()
    {
    }

    [Token(Token = "0x60090B2")]
    [Address(RVA = "0x53F190", Offset = "0x53DF90", VA = "0x1053F190")]
    private void Refresh(float value)
    {
    }

    [Token(Token = "0x60090B3")]
    [Address(RVA = "0x53F0A0", Offset = "0x53DEA0", VA = "0x1053F0A0")]
    private void OnSelectUseNumChanged(float value)
    {
    }

    [Token(Token = "0x60090B4")]
    [Address(RVA = "0x53EF10", Offset = "0x53DD10", VA = "0x1053EF10")]
    private void OnAddNum()
    {
    }

    [Token(Token = "0x60090B5")]
    [Address(RVA = "0x53EFE0", Offset = "0x53DDE0", VA = "0x1053EFE0")]
    private void OnRemoveNum()
    {
    }

    [Token(Token = "0x60090B6")]
    [Address(RVA = "0x53EFB0", Offset = "0x53DDB0", VA = "0x1053EFB0")]
    public void OnChangeUseMax(bool value)
    {
    }

    [Token(Token = "0x60090B7")]
    [Address(RVA = "0x53EEA0", Offset = "0x53DCA0", VA = "0x1053EEA0")]
    public bool IsUseMax() => new bool();

    [Token(Token = "0x60090B8")]
    [Address(RVA = "0x53F7D0", Offset = "0x53E5D0", VA = "0x1053F7D0")]
    public void SetUseParamItemSliderValue(int value)
    {
    }

    [Token(Token = "0x60090B9")]
    [Address(RVA = "0x53F4C0", Offset = "0x53E2C0", VA = "0x1053F4C0")]
    public void Reset()
    {
    }

    [Token(Token = "0x60090BA")]
    [Address(RVA = "0x53F610", Offset = "0x53E410", VA = "0x1053F610")]
    public void SetInputLock(bool islock)
    {
    }

    [Token(Token = "0x60090BB")]
    [Address(RVA = "0x53F710", Offset = "0x53E510", VA = "0x1053F710")]
    public void SetUseMax(bool is_on)
    {
    }

    [Token(Token = "0x60090BC")]
    [Address(RVA = "0x53E300", Offset = "0x53D100", VA = "0x1053E300")]
    public void AddConceptCardData(ConceptCardMaterialData material_data)
    {
    }

    [Token(Token = "0x60090BD")]
    [Address(RVA = "0x53E320", Offset = "0x53D120", VA = "0x1053E320")]
    public string GetConceptCardIName() => (string) null;

    [Token(Token = "0x60090BE")]
    [Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")]
    public ConceptCardData GetConceptCardData() => (ConceptCardData) null;

    [Token(Token = "0x60090BF")]
    [Address(RVA = "0x53F5A0", Offset = "0x53E3A0", VA = "0x1053F5A0")]
    public void SetExpObject(bool flag)
    {
    }

    [Token(Token = "0x60090C0")]
    [Address(RVA = "0x53E340", Offset = "0x53D140", VA = "0x1053E340")]
    public int GetSliderValue() => new int();

    [Token(Token = "0x60090C1")]
    [Address(RVA = "0x53F9D0", Offset = "0x53E7D0", VA = "0x1053F9D0")]
    public ConceptCardLevelUpListItem()
    {
    }

    [Token(Token = "0x2002219")]
    public delegate void SelectExpItem(string iname, int value);

    [Token(Token = "0x200221A")]
    public delegate void ChangeToggleEvent(string iname, bool is_on);

    [Token(Token = "0x200221B")]
    public delegate int CheckSliderValue(string iname, int value);
  }
}
