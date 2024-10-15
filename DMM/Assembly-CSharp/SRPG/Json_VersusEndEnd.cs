// Decompiled with JetBrains decompiler
// Type: SRPG.Json_VersusEndEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000DAE")]
  public class Json_VersusEndEnd : Json_PlayerDataAll
  {
    [Token(Token = "0x400278B")]
    [FieldOffset(Offset = "0xB0")]
    public JSON_QuestProgress[] quests;
    [Token(Token = "0x400278C")]
    [FieldOffset(Offset = "0xB4")]
    public int wincnt;
    [Token(Token = "0x400278D")]
    [FieldOffset(Offset = "0xB8")]
    public int win_bonus;
    [Token(Token = "0x400278E")]
    [FieldOffset(Offset = "0xBC")]
    public int key;
    [Token(Token = "0x400278F")]
    [FieldOffset(Offset = "0xC0")]
    public int rankup;
    [Token(Token = "0x4002790")]
    [FieldOffset(Offset = "0xC4")]
    public int floor;
    [Token(Token = "0x4002791")]
    [FieldOffset(Offset = "0xC8")]
    public int arravied;

    [Token(Token = "0x6003763")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public Json_VersusEndEnd()
    {
    }
  }
}
