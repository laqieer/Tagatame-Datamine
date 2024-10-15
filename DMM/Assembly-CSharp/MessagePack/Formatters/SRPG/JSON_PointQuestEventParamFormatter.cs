// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_PointQuestEventParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A93")]
  public sealed class JSON_PointQuestEventParamFormatter : 
    IMessagePackFormatter<JSON_PointQuestEventParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40019B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40019B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002907")]
    [Address(RVA = "0xEE4C10", Offset = "0xEE3A10", VA = "0x10EE4C10")]
    public JSON_PointQuestEventParamFormatter()
    {
    }

    [Token(Token = "0x6002908")]
    [Address(RVA = "0xEE43D0", Offset = "0xEE31D0", VA = "0x10EE43D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_PointQuestEventParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002909")]
    [Address(RVA = "0xEE3AE0", Offset = "0xEE28E0", VA = "0x10EE3AE0", Slot = "5")]
    public JSON_PointQuestEventParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_PointQuestEventParam) null;
    }
  }
}
