// Decompiled with JetBrains decompiler
// Type: SRPG.GiftData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001041")]
  public class GiftData
  {
    [Token(Token = "0x40039F8")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40039F9")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x40039FA")]
    [FieldOffset(Offset = "0x10")]
    public int gold;
    [Token(Token = "0x40039FB")]
    [FieldOffset(Offset = "0x14")]
    public int coin;
    [Token(Token = "0x40039FC")]
    [FieldOffset(Offset = "0x18")]
    public int arenacoin;
    [Token(Token = "0x40039FD")]
    [FieldOffset(Offset = "0x1C")]
    public int multicoin;
    [Token(Token = "0x40039FE")]
    [FieldOffset(Offset = "0x20")]
    public int kakeracoin;
    [Token(Token = "0x40039FF")]
    [FieldOffset(Offset = "0x24")]
    public GiftData.GiftConceptCard conceptCard;
    [Token(Token = "0x4003A00")]
    [FieldOffset(Offset = "0x28")]
    public GiftData.GiftCrystal crystal;
    [Token(Token = "0x4003A01")]
    [FieldOffset(Offset = "0x30")]
    public long giftTypes;
    [Token(Token = "0x4003A02")]
    [FieldOffset(Offset = "0x38")]
    public int rarity;

    [Token(Token = "0x1700061A")]
    public string ConceptCardIname
    {
      [Token(Token = "0x60042B2"), Address(RVA = "0x11DD8B0", Offset = "0x11DC6B0", VA = "0x111DD8B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700061B")]
    public int ConceptCardNum
    {
      [Token(Token = "0x60042B3"), Address(RVA = "0x53A070", Offset = "0x538E70", VA = "0x1053A070")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700061C")]
    public bool IsGetConceptCardUnit
    {
      [Token(Token = "0x60042B4"), Address(RVA = "0x11DD970", Offset = "0x11DC770", VA = "0x111DD970")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700061D")]
    public string ConceptCardGetUnitIname
    {
      [Token(Token = "0x60042B5"), Address(RVA = "0x11DD870", Offset = "0x11DC670", VA = "0x111DD870")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700061E")]
    public int LimitBreakCount
    {
      [Token(Token = "0x60042B6"), Address(RVA = "0x11DD9B0", Offset = "0x11DC7B0", VA = "0x111DD9B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700061F")]
    public bool IsValidRarity
    {
      [Token(Token = "0x60042B7"), Address(RVA = "0x11DD9A0", Offset = "0x11DC7A0", VA = "0x111DD9A0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000620")]
    public bool NotSet
    {
      [Token(Token = "0x60042B8"), Address(RVA = "0x11DD9D0", Offset = "0x11DC7D0", VA = "0x111DD9D0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000621")]
    public string CrystalIname
    {
      [Token(Token = "0x60042B9"), Address(RVA = "0x11DD8F0", Offset = "0x11DC6F0", VA = "0x111DD8F0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000622")]
    public int CrystalNum
    {
      [Token(Token = "0x60042BA"), Address(RVA = "0x11DD930", Offset = "0x11DC730", VA = "0x111DD930")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000623")]
    public int CrystalRank
    {
      [Token(Token = "0x60042BB"), Address(RVA = "0x11DD950", Offset = "0x11DC750", VA = "0x111DD950")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60042BC")]
    [Address(RVA = "0x11DCF00", Offset = "0x11DBD00", VA = "0x111DCF00")]
    public bool CheckGiftTypeIncluded(GiftTypes flag) => new bool();

    [Token(Token = "0x60042BD")]
    [Address(RVA = "0x11DD4D0", Offset = "0x11DC2D0", VA = "0x111DD4D0")]
    public void SetGiftTypeIncluded(GiftTypes flag)
    {
    }

    [Token(Token = "0x60042BE")]
    [Address(RVA = "0x11DD4F0", Offset = "0x11DC2F0", VA = "0x111DD4F0")]
    public void UpdateGiftTypes()
    {
    }

    [Token(Token = "0x60042BF")]
    [Address(RVA = "0x11DCF30", Offset = "0x11DBD30", VA = "0x111DCF30")]
    public ArtifactData CreateArtifactData() => (ArtifactData) null;

    [Token(Token = "0x60042C0")]
    [Address(RVA = "0x11DD060", Offset = "0x11DBE60", VA = "0x111DD060")]
    public void Deserialize(Json_Gift json_gift)
    {
    }

    [Token(Token = "0x60042C1")]
    [Address(RVA = "0x11DD210", Offset = "0x11DC010", VA = "0x111DD210")]
    public void GetRewardNameAndAmount(out string name, out int amount)
    {
    }

    [Token(Token = "0x60042C2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GiftData()
    {
    }

    [Token(Token = "0x2001042")]
    public class GiftConceptCard
    {
      [Token(Token = "0x4003A03")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4003A04")]
      [FieldOffset(Offset = "0xC")]
      public int num;
      [Token(Token = "0x4003A05")]
      [FieldOffset(Offset = "0x10")]
      public string get_unit;
      [Token(Token = "0x4003A06")]
      [FieldOffset(Offset = "0x14")]
      public int plus;

      [Token(Token = "0x60042C3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public GiftConceptCard()
      {
      }
    }

    [Token(Token = "0x2001043")]
    public class GiftCrystal
    {
      [Token(Token = "0x4003A07")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x4003A08")]
      [FieldOffset(Offset = "0xC")]
      public int num;
      [Token(Token = "0x4003A09")]
      [FieldOffset(Offset = "0x10")]
      public int rank;

      [Token(Token = "0x60042C4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public GiftCrystal()
      {
      }
    }
  }
}
