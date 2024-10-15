// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GrowCurveFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005EB")]
  public sealed class JSON_GrowCurveFormatter : 
    IMessagePackFormatter<JSON_GrowCurve>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400106E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400106F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B0F")]
    [Address(RVA = "0xB94DC0", Offset = "0xB93BC0", VA = "0x10B94DC0")]
    public JSON_GrowCurveFormatter()
    {
    }

    [Token(Token = "0x6001B10")]
    [Address(RVA = "0xB93CF0", Offset = "0xB92AF0", VA = "0x10B93CF0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GrowCurve value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B11")]
    [Address(RVA = "0xB928A0", Offset = "0xB916A0", VA = "0x10B928A0", Slot = "5")]
    public JSON_GrowCurve Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GrowCurve) null;
    }
  }
}
