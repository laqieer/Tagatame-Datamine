// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.VersionFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000509")]
  public sealed class VersionFormatter : IMessagePackFormatter<Version>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F99")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Version> Instance;

    [Token(Token = "0x6001855")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private VersionFormatter()
    {
    }

    [Token(Token = "0x6001856")]
    [Address(RVA = "0x6B0EC0", Offset = "0x6AFCC0", VA = "0x106B0EC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Version value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001857")]
    [Address(RVA = "0x6B0E00", Offset = "0x6AFC00", VA = "0x106B0E00", Slot = "5")]
    public Version Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Version) null;
    }

    [Token(Token = "0x6001858")]
    [Address(RVA = "0x6B0F70", Offset = "0x6AFD70", VA = "0x106B0F70")]
    static VersionFormatter()
    {
    }
  }
}
