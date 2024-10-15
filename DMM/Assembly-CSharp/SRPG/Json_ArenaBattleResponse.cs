// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaBattleResponse
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E53")]
  public class Json_ArenaBattleResponse
  {
    [Token(Token = "0x4002BA4")]
    [FieldOffset(Offset = "0x8")]
    public Json_ArenaRewardInfo reward_info;
    [Token(Token = "0x4002BA5")]
    [FieldOffset(Offset = "0xC")]
    public int new_rank;
    [Token(Token = "0x4002BA6")]
    [FieldOffset(Offset = "0x10")]
    public int def_rank;
    [Token(Token = "0x4002BA7")]
    [FieldOffset(Offset = "0x14")]
    public int got_pexp;
    [Token(Token = "0x4002BA8")]
    [FieldOffset(Offset = "0x18")]
    public int got_uexp;
    [Token(Token = "0x4002BA9")]
    [FieldOffset(Offset = "0x1C")]
    public int got_gold;

    [Token(Token = "0x6003B0E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaBattleResponse()
    {
    }
  }
}
