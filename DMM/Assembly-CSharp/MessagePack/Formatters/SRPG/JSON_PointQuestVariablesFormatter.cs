// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestVariablesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000867")]
  public sealed class JSON_PointQuestVariablesFormatter : 
    IMessagePackFormatter<JSON_PointQuestVariables>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400155E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400155F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002283")]
    [Address(RVA = "0xD8E530", Offset = "0xD8D330", VA = "0x10D8E530")]
    public JSON_PointQuestVariablesFormatter()
    {
    }

    [Token(Token = "0x6002284")]
    [Address(RVA = "0xD8E320", Offset = "0xD8D120", VA = "0x10D8E320", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestVariables value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002285")]
    [Address(RVA = "0xD8DF30", Offset = "0xD8CD30", VA = "0x10D8DF30", Slot = "5")]
    public JSON_PointQuestVariables Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestVariables) null;
    }
  }
}
