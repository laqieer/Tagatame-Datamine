// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InitItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000706")]
  public sealed class JSON_InitItemFormatter : 
    IMessagePackFormatter<JSON_InitItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012A4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012A5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001E60")]
    [Address(RVA = "0xC54640", Offset = "0xC53440", VA = "0x10C54640")]
    public JSON_InitItemFormatter()
    {
    }

    [Token(Token = "0x6001E61")]
    [Address(RVA = "0xC54510", Offset = "0xC53310", VA = "0x10C54510", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InitItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001E62")]
    [Address(RVA = "0xC54200", Offset = "0xC53000", VA = "0x10C54200", Slot = "5")]
    public JSON_InitItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InitItem) null;
    }
  }
}
