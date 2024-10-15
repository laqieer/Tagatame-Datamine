// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestDropParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010BE")]
  public class JSON_QuestDropParam
  {
    [Token(Token = "0x4003C5B")]
    [FieldOffset(Offset = "0x8")]
    public JSON_SimpleDropTableParam[] simpleDropTable;
    [Token(Token = "0x4003C5C")]
    [FieldOffset(Offset = "0xC")]
    public JSON_SimpleLocalMapsParam[] simpleLocalMaps;
    [Token(Token = "0x4003C5D")]
    [FieldOffset(Offset = "0x10")]
    public JSON_SimpleQuestDropParam[] simpleQuestDrops;

    [Token(Token = "0x60046D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestDropParam()
    {
    }
  }
}
