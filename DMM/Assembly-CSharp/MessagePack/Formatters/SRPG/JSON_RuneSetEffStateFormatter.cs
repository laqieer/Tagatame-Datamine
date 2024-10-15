// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RuneSetEffStateFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200067F")]
  public sealed class JSON_RuneSetEffStateFormatter : 
    IMessagePackFormatter<JSON_RuneSetEffState>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001196")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001197")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001CCB")]
    [Address(RVA = "0xBECA20", Offset = "0xBEB820", VA = "0x10BECA20")]
    public JSON_RuneSetEffStateFormatter()
    {
    }

    [Token(Token = "0x6001CCC")]
    [Address(RVA = "0xBEC8F0", Offset = "0xBEB6F0", VA = "0x10BEC8F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RuneSetEffState value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001CCD")]
    [Address(RVA = "0xBEC5D0", Offset = "0xBEB3D0", VA = "0x10BEC5D0", Slot = "5")]
    public JSON_RuneSetEffState Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RuneSetEffState) null;
    }
  }
}
