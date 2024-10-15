// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGNPCUnitParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A81")]
  public sealed class JSON_GvGNPCUnitParamFormatter : 
    IMessagePackFormatter<JSON_GvGNPCUnitParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001992")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001993")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028D1")]
    [Address(RVA = "0xEE0080", Offset = "0xEDEE80", VA = "0x10EE0080")]
    public JSON_GvGNPCUnitParamFormatter()
    {
    }

    [Token(Token = "0x60028D2")]
    [Address(RVA = "0xEDF1C0", Offset = "0xEDDFC0", VA = "0x10EDF1C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGNPCUnitParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028D3")]
    [Address(RVA = "0xEDE080", Offset = "0xEDCE80", VA = "0x10EDE080", Slot = "5")]
    public JSON_GvGNPCUnitParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGNPCUnitParam) null;
    }
  }
}
