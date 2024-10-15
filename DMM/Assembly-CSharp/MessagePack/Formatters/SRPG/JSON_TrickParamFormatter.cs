// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TrickParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005FB")]
  public sealed class JSON_TrickParamFormatter : 
    IMessagePackFormatter<JSON_TrickParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400108E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400108F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B3F")]
    [Address(RVA = "0xBB05B0", Offset = "0xBAF3B0", VA = "0x10BB05B0")]
    public JSON_TrickParamFormatter()
    {
    }

    [Token(Token = "0x6001B40")]
    [Address(RVA = "0xBAFE10", Offset = "0xBAEC10", VA = "0x10BAFE10", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TrickParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B41")]
    [Address(RVA = "0xBAF4D0", Offset = "0xBAE2D0", VA = "0x10BAF4D0", Slot = "5")]
    public JSON_TrickParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TrickParam) null;
    }
  }
}
