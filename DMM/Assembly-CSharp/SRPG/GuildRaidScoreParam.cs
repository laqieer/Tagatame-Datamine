// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidScoreParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B67")]
  public class GuildRaidScoreParam : GuildRaidMasterParam<JSON_GuildRaidScoreParam>
  {
    [Token(Token = "0x17000D88")]
    public int Id
    {
      [Token(Token = "0x6007114"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6007115"), Address(RVA = "0x28D5D0", Offset = "0x28C3D0", VA = "0x1028D5D0")] private set
      {
      }
    }

    [Token(Token = "0x17000D89")]
    public List<GuildRaidScoreDataParam> Score
    {
      [Token(Token = "0x6007116"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<GuildRaidScoreDataParam>) null;
      }
      [Token(Token = "0x6007117"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x6007118")]
    [Address(RVA = "0x370FC0", Offset = "0x36FDC0", VA = "0x10370FC0", Slot = "4")]
    public override bool Deserialize(JSON_GuildRaidScoreParam json) => new bool();

    [Token(Token = "0x6007119")]
    [Address(RVA = "0x3710F0", Offset = "0x36FEF0", VA = "0x103710F0")]
    public int GetScore(int round, int score) => new int();

    [Token(Token = "0x600711A")]
    [Address(RVA = "0x371210", Offset = "0x370010", VA = "0x10371210")]
    public GuildRaidScoreParam()
    {
    }
  }
}
