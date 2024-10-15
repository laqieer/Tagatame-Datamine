// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.GuidFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000507")]
  public sealed class GuidFormatter : IMessagePackFormatter<Guid>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F97")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Guid> Instance;

    [Token(Token = "0x600184D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private GuidFormatter()
    {
    }

    [Token(Token = "0x600184E")]
    [Address(RVA = "0x69ECA0", Offset = "0x69DAA0", VA = "0x1069ECA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Guid value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600184F")]
    [Address(RVA = "0x69EC20", Offset = "0x69DA20", VA = "0x1069EC20", Slot = "5")]
    public Guid Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Guid();
    }

    [Token(Token = "0x6001850")]
    [Address(RVA = "0x69ED80", Offset = "0x69DB80", VA = "0x1069ED80")]
    static GuidFormatter()
    {
    }
  }
}
