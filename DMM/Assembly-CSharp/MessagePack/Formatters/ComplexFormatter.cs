// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ComplexFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Numerics;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200050E")]
  public sealed class ComplexFormatter : IMessagePackFormatter<Complex>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F9D")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Complex> Instance;

    [Token(Token = "0x6001868")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ComplexFormatter()
    {
    }

    [Token(Token = "0x6001869")]
    [Address(RVA = "0x697160", Offset = "0x695F60", VA = "0x10697160", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Complex value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600186A")]
    [Address(RVA = "0x697050", Offset = "0x695E50", VA = "0x10697050", Slot = "5")]
    public Complex Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Complex();
    }

    [Token(Token = "0x600186B")]
    [Address(RVA = "0x697290", Offset = "0x696090", VA = "0x10697290")]
    static ComplexFormatter()
    {
    }
  }
}
