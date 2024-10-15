// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaPlayers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E49")]
  public class Json_ArenaPlayers
  {
    [Token(Token = "0x4002B71")]
    [FieldOffset(Offset = "0x8")]
    public Json_ArenaPlayer[] coloenemies;
    [Token(Token = "0x4002B72")]
    [FieldOffset(Offset = "0xC")]
    public int rank_myself;
    [Token(Token = "0x4002B73")]
    [FieldOffset(Offset = "0x10")]
    public int best_myself;
    [Token(Token = "0x4002B74")]
    [FieldOffset(Offset = "0x18")]
    public long btl_at;
    [Token(Token = "0x4002B75")]
    [FieldOffset(Offset = "0x20")]
    public string quest_iname;
    [Token(Token = "0x4002B76")]
    [FieldOffset(Offset = "0x24")]
    public int seed;
    [Token(Token = "0x4002B77")]
    [FieldOffset(Offset = "0x28")]
    public int maxActionNum;
    [Token(Token = "0x4002B78")]
    [FieldOffset(Offset = "0x30")]
    public long end_at;

    [Token(Token = "0x6003AFA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaPlayers()
    {
    }
  }
}
