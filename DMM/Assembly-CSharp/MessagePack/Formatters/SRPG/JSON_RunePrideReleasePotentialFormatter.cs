// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RunePrideReleasePotentialFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005BC")]
  public sealed class JSON_RunePrideReleasePotentialFormatter : 
    IMessagePackFormatter<JSON_RunePrideReleasePotential>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001010")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001011")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A82")]
    [Address(RVA = "0x792E80", Offset = "0x791C80", VA = "0x10792E80")]
    public JSON_RunePrideReleasePotentialFormatter()
    {
    }

    [Token(Token = "0x6001A83")]
    [Address(RVA = "0x792CA0", Offset = "0x791AA0", VA = "0x10792CA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RunePrideReleasePotential value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A84")]
    [Address(RVA = "0x792960", Offset = "0x791760", VA = "0x10792960", Slot = "5")]
    public JSON_RunePrideReleasePotential Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RunePrideReleasePotential) null;
    }
  }
}
