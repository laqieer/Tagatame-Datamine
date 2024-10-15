// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBattlePoint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FB2")]
  public class GuildRaidBattlePoint
  {
    [Token(Token = "0x170005A4")]
    public int PT
    {
      [Token(Token = "0x60040FD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x60040FE"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x170005A5")]
    public int Max
    {
      [Token(Token = "0x60040FF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004100"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x170005A6")]
    public int AP
    {
      [Token(Token = "0x6004101"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004102"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x170005A7")]
    public int DefBP
    {
      [Token(Token = "0x6004103"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x6004104"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x6004105")]
    [Address(RVA = "0x1192740", Offset = "0x1191540", VA = "0x11192740")]
    public bool Deserialize(JSON_GuildRaidBattlePoint json) => new bool();

    [Token(Token = "0x6004106")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidBattlePoint()
    {
    }
  }
}
