// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaPlayerHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E50")]
  public class Json_ArenaPlayerHistory
  {
    [Token(Token = "0x4002B94")]
    [FieldOffset(Offset = "0x8")]
    public string type;
    [Token(Token = "0x4002B95")]
    [FieldOffset(Offset = "0xC")]
    public string result;
    [Token(Token = "0x4002B96")]
    [FieldOffset(Offset = "0x10")]
    public JSON_ArenaRankInfo ranking;
    [Token(Token = "0x4002B97")]
    [FieldOffset(Offset = "0x18")]
    public long at;
    [Token(Token = "0x4002B98")]
    [FieldOffset(Offset = "0x20")]
    public Json_ArenaPlayer my;
    [Token(Token = "0x4002B99")]
    [FieldOffset(Offset = "0x24")]
    public Json_ArenaPlayer enemy;

    [Token(Token = "0x6003B06")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaPlayerHistory()
    {
    }
  }
}
