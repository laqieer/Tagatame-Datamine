// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RunePrideReleasePotentialFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200079F")]
  public sealed class RunePrideReleasePotentialFormatter : 
    IMessagePackFormatter<RunePrideReleasePotential>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013D6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013D7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600202B")]
    [Address(RVA = "0xCE15D0", Offset = "0xCE03D0", VA = "0x10CE15D0")]
    public RunePrideReleasePotentialFormatter()
    {
    }

    [Token(Token = "0x600202C")]
    [Address(RVA = "0xCE13F0", Offset = "0xCE01F0", VA = "0x10CE13F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RunePrideReleasePotential value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600202D")]
    [Address(RVA = "0xCE10C0", Offset = "0xCDFEC0", VA = "0x10CE10C0", Slot = "5")]
    public RunePrideReleasePotential Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RunePrideReleasePotential) null;
    }
  }
}
