// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NativeDateTimeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004D6")]
  public sealed class NativeDateTimeFormatter : 
    IMessagePackFormatter<DateTime>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F65")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NativeDateTimeFormatter Instance;

    [Token(Token = "0x6001788")]
    [Address(RVA = "0x6A1740", Offset = "0x6A0540", VA = "0x106A1740", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      DateTime value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001789")]
    [Address(RVA = "0x6A15D0", Offset = "0x6A03D0", VA = "0x106A15D0", Slot = "5")]
    public DateTime Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new DateTime();
    }

    [Token(Token = "0x600178A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public NativeDateTimeFormatter()
    {
    }

    [Token(Token = "0x600178B")]
    [Address(RVA = "0x6A17C0", Offset = "0x6A05C0", VA = "0x106A17C0")]
    static NativeDateTimeFormatter()
    {
    }
  }
}
