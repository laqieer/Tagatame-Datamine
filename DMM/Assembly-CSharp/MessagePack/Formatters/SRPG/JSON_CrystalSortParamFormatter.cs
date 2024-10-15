// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_CrystalSortParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006D6")]
  public sealed class JSON_CrystalSortParamFormatter : 
    IMessagePackFormatter<JSON_CrystalSortParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001244")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001245")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001DD0")]
    [Address(RVA = "0xC14280", Offset = "0xC13080", VA = "0x10C14280")]
    public JSON_CrystalSortParamFormatter()
    {
    }

    [Token(Token = "0x6001DD1")]
    [Address(RVA = "0xC13F90", Offset = "0xC12D90", VA = "0x10C13F90", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_CrystalSortParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001DD2")]
    [Address(RVA = "0xC13B60", Offset = "0xC12960", VA = "0x10C13B60", Slot = "5")]
    public JSON_CrystalSortParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_CrystalSortParam) null;
    }
  }
}
