// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_DifferenceUpdateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005BF")]
  public sealed class Json_DifferenceUpdateFormatter : 
    IMessagePackFormatter<Json_DifferenceUpdate>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001016")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001017")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A8B")]
    [Address(RVA = "0x799070", Offset = "0x797E70", VA = "0x10799070")]
    public Json_DifferenceUpdateFormatter()
    {
    }

    [Token(Token = "0x6001A8C")]
    [Address(RVA = "0x798C10", Offset = "0x797A10", VA = "0x10798C10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_DifferenceUpdate value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A8D")]
    [Address(RVA = "0x798700", Offset = "0x797500", VA = "0x10798700", Slot = "5")]
    public Json_DifferenceUpdate Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_DifferenceUpdate) null;
    }
  }
}
