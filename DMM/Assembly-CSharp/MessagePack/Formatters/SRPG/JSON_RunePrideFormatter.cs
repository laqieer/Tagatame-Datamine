// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005BD")]
  public sealed class JSON_RunePrideFormatter : 
    IMessagePackFormatter<JSON_RunePride>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001012")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001013")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A85")]
    [Address(RVA = "0x7917D0", Offset = "0x7905D0", VA = "0x107917D0")]
    public JSON_RunePrideFormatter()
    {
    }

    [Token(Token = "0x6001A86")]
    [Address(RVA = "0x7915A0", Offset = "0x7903A0", VA = "0x107915A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePride value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A87")]
    [Address(RVA = "0x791260", Offset = "0x790060", VA = "0x10791260", Slot = "5")]
    public JSON_RunePride Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePride) null;
    }
  }
}
