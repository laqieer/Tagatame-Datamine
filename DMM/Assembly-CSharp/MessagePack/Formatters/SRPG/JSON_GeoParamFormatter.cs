// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GeoParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E7")]
  public sealed class JSON_GeoParamFormatter : 
    IMessagePackFormatter<JSON_GeoParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001066")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001067")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B03")]
    [Address(RVA = "0xB92640", Offset = "0xB91440", VA = "0x10B92640")]
    public JSON_GeoParamFormatter()
    {
    }

    [Token(Token = "0x6001B04")]
    [Address(RVA = "0xB92480", Offset = "0xB91280", VA = "0x10B92480", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GeoParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B05")]
    [Address(RVA = "0xB920F0", Offset = "0xB90EF0", VA = "0x10B920F0", Slot = "5")]
    public JSON_GeoParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GeoParam) null;
    }
  }
}
