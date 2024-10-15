// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_VersusFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008A1")]
  public sealed class Json_VersusFormatter : 
    IMessagePackFormatter<Json_Versus>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002331")]
    [Address(RVA = "0xDC24D0", Offset = "0xDC12D0", VA = "0x10DC24D0")]
    public Json_VersusFormatter()
    {
    }

    [Token(Token = "0x6002332")]
    [Address(RVA = "0xDC2330", Offset = "0xDC1130", VA = "0x10DC2330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Versus value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002333")]
    [Address(RVA = "0xDC2020", Offset = "0xDC0E20", VA = "0x10DC2020", Slot = "5")]
    public Json_Versus Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Versus) null;
    }
  }
}
