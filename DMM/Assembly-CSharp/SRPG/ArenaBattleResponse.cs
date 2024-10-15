// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaBattleResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E55")]
  public class ArenaBattleResponse
  {
    [Token(Token = "0x4002BAB")]
    [FieldOffset(Offset = "0x8")]
    public Json_ArenaRewardInfo reward_info;
    [Token(Token = "0x4002BAC")]
    [FieldOffset(Offset = "0xC")]
    public int new_rank;
    [Token(Token = "0x4002BAD")]
    [FieldOffset(Offset = "0x10")]
    public int def_rank;
    [Token(Token = "0x4002BAE")]
    [FieldOffset(Offset = "0x14")]
    public int got_pexp;
    [Token(Token = "0x4002BAF")]
    [FieldOffset(Offset = "0x18")]
    public int got_uexp;
    [Token(Token = "0x4002BB0")]
    [FieldOffset(Offset = "0x1C")]
    public int got_gold;

    [Token(Token = "0x6003B10")]
    [Address(RVA = "0x10CC980", Offset = "0x10CB780", VA = "0x110CC980")]
    public void Deserialize(Json_ArenaBattleResponse json)
    {
    }

    [Token(Token = "0x6003B11")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArenaBattleResponse()
    {
    }
  }
}
