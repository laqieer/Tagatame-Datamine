// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_QuestPartyParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A70")]
  public sealed class JSON_QuestPartyParamFormatter : 
    IMessagePackFormatter<JSON_QuestPartyParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001970")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001971")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600289E")]
    [Address(RVA = "0xECA9A0", Offset = "0xEC97A0", VA = "0x10ECA9A0")]
    public JSON_QuestPartyParamFormatter()
    {
    }

    [Token(Token = "0x600289F")]
    [Address(RVA = "0xECA4D0", Offset = "0xEC92D0", VA = "0x10ECA4D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_QuestPartyParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028A0")]
    [Address(RVA = "0xEC9E40", Offset = "0xEC8C40", VA = "0x10EC9E40", Slot = "5")]
    public JSON_QuestPartyParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_QuestPartyParam) null;
    }
  }
}
