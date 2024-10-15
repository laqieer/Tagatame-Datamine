// Decompiled with JetBrains decompiler
// Type: SRPG.GuildFacilityData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F95")]
  public class GuildFacilityData
  {
    [Token(Token = "0x40036DC")]
    [FieldOffset(Offset = "0x8")]
    private long mGid;
    [Token(Token = "0x40036DD")]
    [FieldOffset(Offset = "0x10")]
    private string mIname;
    [Token(Token = "0x40036DE")]
    [FieldOffset(Offset = "0x18")]
    private long mExp;
    [Token(Token = "0x40036DF")]
    [FieldOffset(Offset = "0x20")]
    private int mLevel;
    [Token(Token = "0x40036E0")]
    [FieldOffset(Offset = "0x24")]
    private int mInvestPoint;
    [Token(Token = "0x40036E1")]
    [FieldOffset(Offset = "0x28")]
    private GuildFacilityParam mParam;

    [Token(Token = "0x1700058F")]
    public long Gid
    {
      [Token(Token = "0x60040B3"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000590")]
    public string Iname
    {
      [Token(Token = "0x60040B4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000591")]
    public long Exp
    {
      [Token(Token = "0x60040B5"), Address(RVA = "0x34F480", Offset = "0x34E280", VA = "0x1034F480")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17000592")]
    public int Level
    {
      [Token(Token = "0x60040B6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000593")]
    public int InvestPoint
    {
      [Token(Token = "0x60040B7"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000594")]
    public GuildFacilityParam Param
    {
      [Token(Token = "0x60040B8"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (GuildFacilityParam) null;
      }
    }

    [Token(Token = "0x60040B9")]
    [Address(RVA = "0x1191EC0", Offset = "0x1190CC0", VA = "0x11191EC0")]
    public bool Deserialize(JSON_GuildFacilityData json) => new bool();

    [Token(Token = "0x60040BA")]
    [Address(RVA = "0x1191F60", Offset = "0x1190D60", VA = "0x11191F60")]
    public GuildFacilityEffectParam GetEffect() => (GuildFacilityEffectParam) null;

    [Token(Token = "0x60040BB")]
    [Address(RVA = "0x1192070", Offset = "0x1190E70", VA = "0x11192070")]
    public static long GetNeedExp(int from_lv, int to_lv, GuildFacilityParam.eFacilityType type)
    {
      return new long();
    }

    [Token(Token = "0x60040BC")]
    [Address(RVA = "0x1191F90", Offset = "0x1190D90", VA = "0x11191F90")]
    public static int GetLevelMax(GuildFacilityParam.eFacilityType type) => new int();

    [Token(Token = "0x60040BD")]
    [Address(RVA = "0x1192180", Offset = "0x1190F80", VA = "0x11192180")]
    public static void SimlateEnhance(
      GuildFacilityData facility,
      long add_exp,
      out int new_level,
      out long rest_next_exp)
    {
    }

    [Token(Token = "0x60040BE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildFacilityData()
    {
    }
  }
}
