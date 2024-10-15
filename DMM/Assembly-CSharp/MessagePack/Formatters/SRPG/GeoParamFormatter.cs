// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.GeoParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007CD")]
  public sealed class GeoParamFormatter : IMessagePackFormatter<GeoParam>, IMessagePackFormatter
  {
    [Token(Token = "0x400142A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400142B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020B5")]
    [Address(RVA = "0xD05280", Offset = "0xD04080", VA = "0x10D05280")]
    public GeoParamFormatter()
    {
    }

    [Token(Token = "0x60020B6")]
    [Address(RVA = "0xD05020", Offset = "0xD03E20", VA = "0x10D05020", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      GeoParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020B7")]
    [Address(RVA = "0xD04C00", Offset = "0xD03A00", VA = "0x10D04C00", Slot = "5")]
    public GeoParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (GeoParam) null;
    }
  }
}
