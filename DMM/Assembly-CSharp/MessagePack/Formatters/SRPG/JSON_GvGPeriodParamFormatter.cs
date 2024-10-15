// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGPeriodParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A33")]
  public sealed class JSON_GvGPeriodParamFormatter : 
    IMessagePackFormatter<JSON_GvGPeriodParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60027E7")]
    [Address(RVA = "0xEAF460", Offset = "0xEAE260", VA = "0x10EAF460")]
    public JSON_GvGPeriodParamFormatter()
    {
    }

    [Token(Token = "0x60027E8")]
    [Address(RVA = "0xEAECC0", Offset = "0xEADAC0", VA = "0x10EAECC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGPeriodParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60027E9")]
    [Address(RVA = "0xEAE3B0", Offset = "0xEAD1B0", VA = "0x10EAE3B0", Slot = "5")]
    public JSON_GvGPeriodParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGPeriodParam) null;
    }
  }
}
