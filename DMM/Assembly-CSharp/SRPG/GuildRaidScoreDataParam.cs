// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidScoreDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B65")]
  public class GuildRaidScoreDataParam
  {
    [Token(Token = "0x17000D86")]
    public int Round
    {
      [Token(Token = "0x600710D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x600710E"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000D87")]
    public int Scale
    {
      [Token(Token = "0x600710F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007110"), Address(RVA = "0x28D5C0", Offset = "0x28C3C0", VA = "0x1028D5C0")] private set
      {
      }
    }

    [Token(Token = "0x6007111")]
    [Address(RVA = "0x370F90", Offset = "0x36FD90", VA = "0x10370F90")]
    public bool Deserialize(JSON_GuildRaidScoreDataParam json) => new bool();

    [Token(Token = "0x6007112")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildRaidScoreDataParam()
    {
    }
  }
}
