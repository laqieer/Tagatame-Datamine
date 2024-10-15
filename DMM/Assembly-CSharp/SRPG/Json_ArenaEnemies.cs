// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ArenaEnemies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E4A")]
  public class Json_ArenaEnemies
  {
    [Token(Token = "0x4002B79")]
    [FieldOffset(Offset = "0x8")]
    public Json_ArenaPlayer[] coloenemies;
    [Token(Token = "0x4002B7A")]
    [FieldOffset(Offset = "0xC")]
    public string quest_iname;
    [Token(Token = "0x4002B7B")]
    [FieldOffset(Offset = "0x10")]
    public long end_at;

    [Token(Token = "0x6003AFB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ArenaEnemies()
    {
    }
  }
}
