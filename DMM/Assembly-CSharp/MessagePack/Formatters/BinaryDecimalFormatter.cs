// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.BinaryDecimalFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000521")]
  public sealed class BinaryDecimalFormatter : IMessagePackFormatter<Decimal>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FB1")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Decimal> Instance;

    [Token(Token = "0x60018AE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private BinaryDecimalFormatter()
    {
    }

    [Token(Token = "0x60018AF")]
    [Address(RVA = "0x693D30", Offset = "0x692B30", VA = "0x10693D30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Decimal value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018B0")]
    [Address(RVA = "0x693B20", Offset = "0x692920", VA = "0x10693B20", Slot = "5")]
    public Decimal Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return 0M;
    }

    [Token(Token = "0x60018B1")]
    [Address(RVA = "0x693E20", Offset = "0x692C20", VA = "0x10693E20")]
    static BinaryDecimalFormatter()
    {
    }
  }
}
