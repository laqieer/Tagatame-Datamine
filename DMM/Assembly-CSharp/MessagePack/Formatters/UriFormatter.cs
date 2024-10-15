// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.UriFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000508")]
  public sealed class UriFormatter : IMessagePackFormatter<Uri>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F98")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Uri> Instance;

    [Token(Token = "0x6001851")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UriFormatter()
    {
    }

    [Token(Token = "0x6001852")]
    [Address(RVA = "0x6B0CD0", Offset = "0x6AFAD0", VA = "0x106B0CD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Uri value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001853")]
    [Address(RVA = "0x6B0C10", Offset = "0x6AFA10", VA = "0x106B0C10", Slot = "5")]
    public Uri Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Uri) null;
    }

    [Token(Token = "0x6001854")]
    [Address(RVA = "0x6B0DA0", Offset = "0x6AFBA0", VA = "0x106B0DA0")]
    static UriFormatter()
    {
    }
  }
}
