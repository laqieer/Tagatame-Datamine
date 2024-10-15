// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.BinaryGuidFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000520")]
  public sealed class BinaryGuidFormatter : IMessagePackFormatter<Guid>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FB0")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Guid> Instance;

    [Token(Token = "0x60018AA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private BinaryGuidFormatter()
    {
    }

    [Token(Token = "0x60018AB")]
    [Address(RVA = "0x694090", Offset = "0x692E90", VA = "0x10694090", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Guid value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018AC")]
    [Address(RVA = "0x693E80", Offset = "0x692C80", VA = "0x10693E80", Slot = "5")]
    public Guid Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Guid();
    }

    [Token(Token = "0x60018AD")]
    [Address(RVA = "0x694180", Offset = "0x692F80", VA = "0x10694180")]
    static BinaryGuidFormatter()
    {
    }
  }
}
