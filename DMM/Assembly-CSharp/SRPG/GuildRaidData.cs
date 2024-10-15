// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FAF")]
  public class GuildRaidData
  {
    [Token(Token = "0x17000595")]
    public int PeriodId
    {
      [Token(Token = "0x60040D9"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040DA"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000596")]
    public int Round
    {
      [Token(Token = "0x60040DB"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040DC"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x17000597")]
    public GuildRaidBattlePoint BP
    {
      [Token(Token = "0x60040DD"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (GuildRaidBattlePoint) null;
      }
      [Token(Token = "0x60040DE"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000598")]
    public GuildRaidBossInfo BossInfo
    {
      [Token(Token = "0x60040DF"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (GuildRaidBossInfo) null;
      }
      [Token(Token = "0x60040E0"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17000599")]
    public int CanOpenAreaId
    {
      [Token(Token = "0x60040E1"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x60040E2"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x1700059A")]
    public int RefreshWaitSec
    {
      [Token(Token = "0x60040E3"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040E4"), Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")] private set
      {
      }
    }

    [Token(Token = "0x60040E5")]
    [Address(RVA = "0x1192A50", Offset = "0x1191850", VA = "0x11192A50")]
    public bool Deserialize(JSON_GuildRaidData json) => new bool();

    [Token(Token = "0x60040E6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidData()
    {
    }
  }
}
