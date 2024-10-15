// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_ExpireItemFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A3")]
  public sealed class Json_ExpireItemFormatter : 
    IMessagePackFormatter<Json_ExpireItem>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002337")]
    [Address(RVA = "0xDB9C50", Offset = "0xDB8A50", VA = "0x10DB9C50")]
    public Json_ExpireItemFormatter()
    {
    }

    [Token(Token = "0x6002338")]
    [Address(RVA = "0xDB9B20", Offset = "0xDB8920", VA = "0x10DB9B20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_ExpireItem value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002339")]
    [Address(RVA = "0xDB9810", Offset = "0xDB8610", VA = "0x10DB9810", Slot = "5")]
    public Json_ExpireItem Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_ExpireItem) null;
    }
  }
}
