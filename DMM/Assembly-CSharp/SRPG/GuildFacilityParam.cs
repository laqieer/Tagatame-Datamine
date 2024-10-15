// Decompiled with JetBrains decompiler
// Type: SRPG.GuildFacilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B40")]
  public class GuildFacilityParam
  {
    [Token(Token = "0x40067D9")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40067DA")]
    [FieldOffset(Offset = "0xC")]
    private string name;
    [Token(Token = "0x40067DB")]
    [FieldOffset(Offset = "0x10")]
    private string image;
    [Token(Token = "0x40067DC")]
    [FieldOffset(Offset = "0x14")]
    private GuildFacilityParam.eFacilityType type;
    [Token(Token = "0x40067DD")]
    [FieldOffset(Offset = "0x18")]
    private GuildFacilityParam.eEnhanceType enhance_type;
    [Token(Token = "0x40067DE")]
    [FieldOffset(Offset = "0x1C")]
    private int increment;
    [Token(Token = "0x40067DF")]
    [FieldOffset(Offset = "0x20")]
    private long day_limit_invest;
    [Token(Token = "0x40067E0")]
    [FieldOffset(Offset = "0x28")]
    private int release_cnds_type;
    [Token(Token = "0x40067E1")]
    [FieldOffset(Offset = "0x2C")]
    private string release_cnds_val1;
    [Token(Token = "0x40067E2")]
    [FieldOffset(Offset = "0x30")]
    private int release_cnds_val2;
    [Token(Token = "0x40067E3")]
    [FieldOffset(Offset = "0x34")]
    private GuildFacilityEffectParam[] effects;

    [Token(Token = "0x17000D3C")]
    public string Iname
    {
      [Token(Token = "0x6007045"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D3D")]
    public string Name
    {
      [Token(Token = "0x6007046"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D3E")]
    public string Image
    {
      [Token(Token = "0x6007047"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D3F")]
    public GuildFacilityParam.eFacilityType Type
    {
      [Token(Token = "0x6007048"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new GuildFacilityParam.eFacilityType();
      }
    }

    [Token(Token = "0x17000D40")]
    public GuildFacilityParam.eEnhanceType EnhanceType
    {
      [Token(Token = "0x6007049"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new GuildFacilityParam.eEnhanceType();
      }
    }

    [Token(Token = "0x17000D41")]
    public int Increment
    {
      [Token(Token = "0x600704A"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D42")]
    public long DayLimitInvest
    {
      [Token(Token = "0x600704B"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000D43")]
    public int ReleaseCndsType
    {
      [Token(Token = "0x600704C"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D44")]
    public string ReleaseCndsVal1
    {
      [Token(Token = "0x600704D"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D45")]
    public int ReleaseCndsVal2
    {
      [Token(Token = "0x600704E"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000D46")]
    public GuildFacilityEffectParam[] Effects
    {
      [Token(Token = "0x600704F"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (GuildFacilityEffectParam[]) null;
      }
    }

    [Token(Token = "0x6007050")]
    [Address(RVA = "0x36EDF0", Offset = "0x36DBF0", VA = "0x1036EDF0")]
    public bool Deserialize(JSON_GuildFacilityParam json) => new bool();

    [Token(Token = "0x6007051")]
    [Address(RVA = "0x36F0B0", Offset = "0x36DEB0", VA = "0x1036F0B0")]
    public GuildFacilityEffectParam GetEffect(int level) => (GuildFacilityEffectParam) null;

    [Token(Token = "0x6007052")]
    [Address(RVA = "0x36F250", Offset = "0x36E050", VA = "0x1036F250")]
    public int GetGuildShopLevelRequiredUnlockShop(int no) => new int();

    [Token(Token = "0x6007053")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildFacilityParam()
    {
    }

    [Token(Token = "0x2001B41")]
    public enum eFacilityType
    {
      [Token(Token = "0x40067E5")] NONE,
      [Token(Token = "0x40067E6")] BASE_CAMP,
      [Token(Token = "0x40067E7")] GUILD_SHOP,
    }

    [Token(Token = "0x2001B42")]
    public enum eEnhanceType
    {
      [Token(Token = "0x40067E9")] NONE,
      [Token(Token = "0x40067EA")] ITEM,
      [Token(Token = "0x40067EB")] GOLD,
    }
  }
}
