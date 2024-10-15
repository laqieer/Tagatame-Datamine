// Decompiled with JetBrains decompiler
// Type: SRPG.GachaDropData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F1C")]
  public class GachaDropData
  {
    [Token(Token = "0x4002EF9")]
    [FieldOffset(Offset = "0x0")]
    public static int DEFAULT_EXCITES;
    [Token(Token = "0x4002EFA")]
    [FieldOffset(Offset = "0x8")]
    public GachaDropData.Type type;
    [Token(Token = "0x4002EFB")]
    [FieldOffset(Offset = "0xC")]
    public UnitParam unit;
    [Token(Token = "0x4002EFC")]
    [FieldOffset(Offset = "0x10")]
    public ItemParam item;
    [Token(Token = "0x4002EFD")]
    [FieldOffset(Offset = "0x14")]
    public ArtifactParam artifact;
    [Token(Token = "0x4002EFE")]
    [FieldOffset(Offset = "0x18")]
    public int num;
    [Token(Token = "0x4002EFF")]
    [FieldOffset(Offset = "0x1C")]
    public UnitParam unitOrigin;
    [Token(Token = "0x4002F00")]
    [FieldOffset(Offset = "0x20")]
    public bool isNew;
    [Token(Token = "0x4002F01")]
    [FieldOffset(Offset = "0x24")]
    public int[] excites;
    [Token(Token = "0x4002F02")]
    [FieldOffset(Offset = "0x28")]
    private int rarity;
    [Token(Token = "0x4002F03")]
    [FieldOffset(Offset = "0x2C")]
    public ConceptCardParam conceptcard;
    [Token(Token = "0x4002F04")]
    [FieldOffset(Offset = "0x30")]
    public UnitParam cardunit;
    [Token(Token = "0x4002F05")]
    [FieldOffset(Offset = "0x34")]
    public bool isGift;
    [Token(Token = "0x4002F06")]
    [FieldOffset(Offset = "0x35")]
    public bool isFeatureItem;
    [Token(Token = "0x4002F07")]
    [FieldOffset(Offset = "0x38")]
    public int ch_piece_coin_num;
    [Token(Token = "0x4002F08")]
    [FieldOffset(Offset = "0x3C")]
    private bool pickup;
    [Token(Token = "0x4002F09")]
    [FieldOffset(Offset = "0x40")]
    private string iname;
    [Token(Token = "0x4002F0A")]
    [FieldOffset(Offset = "0x44")]
    private string itype;
    [Token(Token = "0x4002F0B")]
    [FieldOffset(Offset = "0x48")]
    private bool m_is_disassemble;
    [Token(Token = "0x4002F0C")]
    [FieldOffset(Offset = "0x4C")]
    public CrystalParam crystal;
    [Token(Token = "0x4002F0D")]
    [FieldOffset(Offset = "0x50")]
    private int rank;

    [Token(Token = "0x17000544")]
    public bool isCoin
    {
      [Token(Token = "0x6003F11"), Address(RVA = "0x1175D40", Offset = "0x1174B40", VA = "0x11175D40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000545")]
    public bool isGold
    {
      [Token(Token = "0x6003F12"), Address(RVA = "0x1175D50", Offset = "0x1174B50", VA = "0x11175D50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000546")]
    public bool isPickup
    {
      [Token(Token = "0x6003F13"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000547")]
    public int FirstExcite
    {
      [Token(Token = "0x6003F14"), Address(RVA = "0x1175CE0", Offset = "0x1174AE0", VA = "0x11175CE0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000548")]
    public string Iname
    {
      [Token(Token = "0x6003F15"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000549")]
    public string Itype
    {
      [Token(Token = "0x6003F16"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700054A")]
    public bool IsDisassemble
    {
      [Token(Token = "0x6003F17"), Address(RVA = "0x661B10", Offset = "0x660910", VA = "0x10661B10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700054B")]
    public int Rank
    {
      [Token(Token = "0x6003F18"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700054C")]
    public int Rare
    {
      [Token(Token = "0x6003F19"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
      [Token(Token = "0x6003F1A"), Address(RVA = "0x36F650", Offset = "0x36E450", VA = "0x1036F650")] set
      {
      }
    }

    [Token(Token = "0x6003F1B")]
    [Address(RVA = "0x1175630", Offset = "0x1174430", VA = "0x11175630")]
    public void Init()
    {
    }

    [Token(Token = "0x6003F1C")]
    [Address(RVA = "0x1174DB0", Offset = "0x1173BB0", VA = "0x11174DB0")]
    public bool Deserialize(Json_DropInfo json) => new bool();

    [Token(Token = "0x6003F1D")]
    [Address(RVA = "0x1174B50", Offset = "0x1173950", VA = "0x11174B50")]
    public bool Deserialize(Json_GachaPickups json) => new bool();

    [Token(Token = "0x6003F1E")]
    [Address(RVA = "0x11753D0", Offset = "0x11741D0", VA = "0x111753D0")]
    public bool Deserialize(GachaSelectedPickup pickup) => new bool();

    [Token(Token = "0x6003F1F")]
    [Address(RVA = "0x1174A00", Offset = "0x1173800", VA = "0x11174A00")]
    public void CopyTo(GachaDropData data)
    {
    }

    [Token(Token = "0x6003F20")]
    [Address(RVA = "0x11756F0", Offset = "0x11744F0", VA = "0x111756F0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x6003F21")]
    [Address(RVA = "0x1175C80", Offset = "0x1174A80", VA = "0x11175C80")]
    public GachaDropData()
    {
    }

    [Token(Token = "0x6003F22")]
    [Address(RVA = "0x1175C50", Offset = "0x1174A50", VA = "0x11175C50")]
    static GachaDropData()
    {
    }

    [Token(Token = "0x2000F1D")]
    public enum Type
    {
      [Token(Token = "0x4002F0F")] None,
      [Token(Token = "0x4002F10")] Item,
      [Token(Token = "0x4002F11")] Unit,
      [Token(Token = "0x4002F12")] Artifact,
      [Token(Token = "0x4002F13")] ConceptCard,
      [Token(Token = "0x4002F14")] Crystal,
      [Token(Token = "0x4002F15")] Coin,
      [Token(Token = "0x4002F16")] Gold,
      [Token(Token = "0x4002F17")] End,
    }
  }
}
