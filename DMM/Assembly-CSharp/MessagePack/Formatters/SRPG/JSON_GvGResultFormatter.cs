// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGResultFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005CB")]
  public sealed class JSON_GvGResultFormatter : 
    IMessagePackFormatter<JSON_GvGResult>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400102E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400102F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AAF")]
    [Address(RVA = "0x9583B0", Offset = "0x9571B0", VA = "0x109583B0")]
    public JSON_GvGResultFormatter()
    {
    }

    [Token(Token = "0x6001AB0")]
    [Address(RVA = "0x958250", Offset = "0x957050", VA = "0x10958250", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGResult value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AB1")]
    [Address(RVA = "0x957F00", Offset = "0x956D00", VA = "0x10957F00", Slot = "5")]
    public JSON_GvGResult Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGResult) null;
    }
  }
}
