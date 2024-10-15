// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceUInt64BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C6")]
  public sealed class ForceUInt64BlockFormatter : IMessagePackFormatter<ulong>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F59")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceUInt64BlockFormatter Instance;

    [Token(Token = "0x6001754")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceUInt64BlockFormatter()
    {
    }

    [Token(Token = "0x6001755")]
    [Address(RVA = "0x69EAD0", Offset = "0x69D8D0", VA = "0x1069EAD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ulong value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001756")]
    [Address(RVA = "0x69EA80", Offset = "0x69D880", VA = "0x1069EA80", Slot = "5")]
    public ulong Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ulong();
    }

    [Token(Token = "0x6001757")]
    [Address(RVA = "0x69EB20", Offset = "0x69D920", VA = "0x1069EB20")]
    static ForceUInt64BlockFormatter()
    {
    }
  }
}
