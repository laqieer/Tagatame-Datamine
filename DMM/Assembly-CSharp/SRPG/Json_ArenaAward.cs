// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaAward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E56")]
  public class Json_ArenaAward
  {
    [Token(Token = "0x4002BB1")]
    [FieldOffset(Offset = "0x8")]
    public long rank_day;
    [Token(Token = "0x4002BB2")]
    [FieldOffset(Offset = "0x10")]
    public int rank;
    [Token(Token = "0x4002BB3")]
    [FieldOffset(Offset = "0x14")]
    public int rank_best;
    [Token(Token = "0x4002BB4")]
    [FieldOffset(Offset = "0x18")]
    public int defense_count;
    [Token(Token = "0x4002BB5")]
    [FieldOffset(Offset = "0x1C")]
    public Json_ArenaReward reward;

    [Token(Token = "0x6003B12")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaAward()
    {
    }
  }
}
