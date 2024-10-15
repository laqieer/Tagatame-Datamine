// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.UInt64Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E9")]
  public sealed class UInt64Formatter : IMessagePackFormatter<ulong>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F78")]
    [FieldOffset(Offset = "0x0")]
    public static readonly UInt64Formatter Instance;

    [Token(Token = "0x60017D4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt64Formatter()
    {
    }

    [Token(Token = "0x60017D5")]
    [Address(RVA = "0x6AF490", Offset = "0x6AE290", VA = "0x106AF490", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ulong value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017D6")]
    [Address(RVA = "0x6AF440", Offset = "0x6AE240", VA = "0x106AF440", Slot = "5")]
    public ulong Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ulong();
    }

    [Token(Token = "0x60017D7")]
    [Address(RVA = "0x6AF4E0", Offset = "0x6AE2E0", VA = "0x106AF4E0")]
    static UInt64Formatter()
    {
    }
  }
}
