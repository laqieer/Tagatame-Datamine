// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLevelupListItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021C3")]
  public class ConceptCardLevelupListItemParam : ContentSource.Param
  {
    [Token(Token = "0x4009404")]
    [FieldOffset(Offset = "0x10")]
    private ConceptCardLevelupListItemNode mNode;
    [Token(Token = "0x4009405")]
    [FieldOffset(Offset = "0x14")]
    private ConceptCardLevelUpListItem.SelectExpItem _onSelect;
    [Token(Token = "0x4009406")]
    [FieldOffset(Offset = "0x18")]
    private ConceptCardLevelUpListItem.ChangeToggleEvent _changeUseMax;
    [Token(Token = "0x4009407")]
    [FieldOffset(Offset = "0x1C")]
    private ConceptCardLevelUpListItem.CheckSliderValue _onCheck;
    [Token(Token = "0x4009408")]
    [FieldOffset(Offset = "0x20")]
    private ConceptCardMaterialData _materialData;
    [Token(Token = "0x4009409")]
    [FieldOffset(Offset = "0x24")]
    private ConceptCardData _cardData;
    [Token(Token = "0x400940A")]
    [FieldOffset(Offset = "0x28")]
    private bool _isUseMax;
    [Token(Token = "0x400940B")]
    [FieldOffset(Offset = "0x29")]
    private bool _enabledExp;
    [Token(Token = "0x400940C")]
    [FieldOffset(Offset = "0x2A")]
    private bool _isCached;
    [Token(Token = "0x400940D")]
    [FieldOffset(Offset = "0x2C")]
    private int _cacheSliderValue;
    [Token(Token = "0x400940E")]
    [FieldOffset(Offset = "0x30")]
    private bool _cacheUseMax;

    [Token(Token = "0x17001412")]
    public ConceptCardMaterialData MaterialData
    {
      [Token(Token = "0x6008E48"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (ConceptCardMaterialData) null;
      }
    }

    [Token(Token = "0x17001413")]
    public ConceptCardLevelUpListItem.SelectExpItem OnSelect
    {
      [Token(Token = "0x6008E49"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (ConceptCardLevelUpListItem.SelectExpItem) null;
      }
    }

    [Token(Token = "0x17001414")]
    public ConceptCardLevelUpListItem.ChangeToggleEvent ChangeUseMax
    {
      [Token(Token = "0x6008E4A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (ConceptCardLevelUpListItem.ChangeToggleEvent) null;
      }
    }

    [Token(Token = "0x17001415")]
    public ConceptCardLevelUpListItem.CheckSliderValue OnCheck
    {
      [Token(Token = "0x6008E4B"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (ConceptCardLevelUpListItem.CheckSliderValue) null;
      }
    }

    [Token(Token = "0x17001416")]
    public bool IsUseMax
    {
      [Token(Token = "0x6008E4C"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001417")]
    public bool EnabledExp
    {
      [Token(Token = "0x6008E4D"), Address(RVA = "0x3550A0", Offset = "0x353EA0", VA = "0x103550A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001418")]
    public bool IsCached
    {
      [Token(Token = "0x6008E4E"), Address(RVA = "0x51AB90", Offset = "0x519990", VA = "0x1051AB90")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001419")]
    public int CacheSlderValue
    {
      [Token(Token = "0x6008E4F"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700141A")]
    public bool CacheUseMax
    {
      [Token(Token = "0x6008E50"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008E51")]
    [Address(RVA = "0x51A610", Offset = "0x519410", VA = "0x1051A610", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x6008E52")]
    [Address(RVA = "0x51A4C0", Offset = "0x5192C0", VA = "0x1051A4C0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x6008E53")]
    [Address(RVA = "0x51A830", Offset = "0x519630", VA = "0x1051A830")]
    private void SaveSelected()
    {
    }

    [Token(Token = "0x6008E54")]
    [Address(RVA = "0x51A790", Offset = "0x519590", VA = "0x1051A790")]
    public void ResetSelected()
    {
    }

    [Token(Token = "0x6008E55")]
    [Address(RVA = "0x51A720", Offset = "0x519520", VA = "0x1051A720")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6008E56")]
    [Address(RVA = "0x51A7B0", Offset = "0x5195B0", VA = "0x1051A7B0")]
    public void Reset()
    {
    }

    [Token(Token = "0x6008E57")]
    [Address(RVA = "0x51AA90", Offset = "0x519890", VA = "0x1051AA90")]
    public void SetInputLock(bool is_lock)
    {
    }

    [Token(Token = "0x6008E58")]
    [Address(RVA = "0x51AB00", Offset = "0x519900", VA = "0x1051AB00")]
    public void SetSliderValue(int value)
    {
    }

    [Token(Token = "0x6008E59")]
    [Address(RVA = "0x51AA70", Offset = "0x519870", VA = "0x1051AA70")]
    public void SetFlag(bool is_use_max, bool enable_max)
    {
    }

    [Token(Token = "0x6008E5A")]
    [Address(RVA = "0x51AA30", Offset = "0x519830", VA = "0x1051AA30")]
    public void SetDelegate(
      ConceptCardLevelUpListItem.SelectExpItem select,
      ConceptCardLevelUpListItem.ChangeToggleEvent use_max,
      ConceptCardLevelUpListItem.CheckSliderValue check)
    {
    }

    [Token(Token = "0x6008E5B")]
    [Address(RVA = "0x51A910", Offset = "0x519710", VA = "0x1051A910")]
    public void SetData(ConceptCardMaterialData data)
    {
    }

    [Token(Token = "0x6008E5C")]
    [Address(RVA = "0x51A300", Offset = "0x519100", VA = "0x1051A300")]
    private ConceptCardData CreateConceptCardData(ConceptCardMaterialData material)
    {
      return (ConceptCardData) null;
    }

    [Token(Token = "0x6008E5D")]
    [Address(RVA = "0x51A400", Offset = "0x519200", VA = "0x1051A400")]
    public ConceptCardData GetConceptCardData() => (ConceptCardData) null;

    [Token(Token = "0x6008E5E")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public ConceptCardLevelupListItemParam()
    {
    }
  }
}
