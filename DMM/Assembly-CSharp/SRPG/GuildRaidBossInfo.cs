// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBossInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FB0")]
  public class GuildRaidBossInfo
  {
    [Token(Token = "0x1700059B")]
    public int BossId
    {
      [Token(Token = "0x60040E7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040E8"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x1700059C")]
    public int CurrentHP
    {
      [Token(Token = "0x60040E9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040EA"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x1700059D")]
    public int MaxHP
    {
      [Token(Token = "0x60040EB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040EC"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x60040ED")]
    [Address(RVA = "0x1192770", Offset = "0x1191570", VA = "0x11192770")]
    public bool Deserialize(JSON_GuildRaidBossInfo json) => new bool();

    [Token(Token = "0x60040EE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidBossInfo()
    {
    }
  }
}
