// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ConceptCardSlotExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003316")]
  public class ConceptCardSlotExModel
  {
    [Token(Token = "0x400F0F4")]
    [FieldOffset(Offset = "0x8")]
    private PartySlotData mPartySlotData;
    [Token(Token = "0x400F0F5")]
    [FieldOffset(Offset = "0xC")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x400F0F6")]
    [FieldOffset(Offset = "0x10")]
    private UnitData mUnitData;
    [Token(Token = "0x400F0F7")]
    [FieldOffset(Offset = "0x14")]
    private UnitData mLeaderUnit;
    [Token(Token = "0x400F0F8")]
    [FieldOffset(Offset = "0x18")]
    private bool mIsVisibleDisabled;
    [Token(Token = "0x400F0F9")]
    [FieldOffset(Offset = "0x19")]
    private bool mIsVisibleOverlayImage;
    [Token(Token = "0x400F0FA")]
    [FieldOffset(Offset = "0x1A")]
    private bool mIsVisibleEnableGroupEffect;
    [Token(Token = "0x400F0FB")]
    [FieldOffset(Offset = "0x1B")]
    private bool mIsVisibleSettableIcon;

    [Token(Token = "0x17001D9D")]
    public PartySlotData PartySlotData
    {
      [Token(Token = "0x600E0F7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (PartySlotData) null;
      }
    }

    [Token(Token = "0x17001D9E")]
    public ConceptCardData ConceptCardData
    {
      [Token(Token = "0x600E0F8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x17001D9F")]
    public UnitData UnitData
    {
      [Token(Token = "0x600E0F9"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001DA0")]
    public UnitData LeaderUnit
    {
      [Token(Token = "0x600E0FA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001DA1")]
    public bool IsVisibleDisabled
    {
      [Token(Token = "0x600E0FB"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DA2")]
    public bool IsVisibleOverlayImage
    {
      [Token(Token = "0x600E0FC"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DA3")]
    public bool IsVisibleEnableGroupEffect
    {
      [Token(Token = "0x600E0FD"), Address(RVA = "0x408500", Offset = "0x407300", VA = "0x10408500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DA4")]
    public bool IsVisibleSettableIcon
    {
      [Token(Token = "0x600E0FE"), Address(RVA = "0x4084F0", Offset = "0x4072F0", VA = "0x104084F0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E0FF")]
    [Address(RVA = "0xAAC450", Offset = "0xAAB250", VA = "0x10AAC450")]
    public void Initialize(
      PartySlotData partySlotData,
      ConceptCardData conceptCardData,
      UnitData unitData,
      UnitData leaderUnit = null)
    {
    }

    [Token(Token = "0x600E100")]
    [Address(RVA = "0xAAC510", Offset = "0xAAB310", VA = "0x10AAC510")]
    public void SetPartySlotData(PartySlotData partySlotData, bool isSetup = false)
    {
    }

    [Token(Token = "0x600E101")]
    [Address(RVA = "0xAAC4B0", Offset = "0xAAB2B0", VA = "0x10AAC4B0")]
    public void SetConceptCardData(ConceptCardData conceptCardData, bool isSetup = false)
    {
    }

    [Token(Token = "0x600E102")]
    [Address(RVA = "0xAAC540", Offset = "0xAAB340", VA = "0x10AAC540")]
    public void SetUnitData(UnitData unitData, bool isSetup = false)
    {
    }

    [Token(Token = "0x600E103")]
    [Address(RVA = "0xAAC4E0", Offset = "0xAAB2E0", VA = "0x10AAC4E0")]
    public void SetLeaderUnit(UnitData leaderUnitData, bool isSetup = false)
    {
    }

    [Token(Token = "0x600E104")]
    [Address(RVA = "0xAAC570", Offset = "0xAAB370", VA = "0x10AAC570")]
    public void Setup()
    {
    }

    [Token(Token = "0x600E105")]
    [Address(RVA = "0x5EFFD0", Offset = "0x5EEDD0", VA = "0x105EFFD0")]
    public void SetSlotDisabled()
    {
    }

    [Token(Token = "0x600E106")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardSlotExModel()
    {
    }
  }
}
