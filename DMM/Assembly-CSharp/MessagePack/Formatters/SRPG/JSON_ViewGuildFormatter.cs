// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ViewGuildFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000843")]
  public sealed class JSON_ViewGuildFormatter : 
    IMessagePackFormatter<JSON_ViewGuild>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001516")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001517")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002217")]
    [Address(RVA = "0xD78F70", Offset = "0xD77D70", VA = "0x10D78F70")]
    public JSON_ViewGuildFormatter()
    {
    }

    [Token(Token = "0x6002218")]
    [Address(RVA = "0xD78CB0", Offset = "0xD77AB0", VA = "0x10D78CB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ViewGuild value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002219")]
    [Address(RVA = "0xD78810", Offset = "0xD77610", VA = "0x10D78810", Slot = "5")]
    public JSON_ViewGuild Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ViewGuild) null;
    }
  }
}
