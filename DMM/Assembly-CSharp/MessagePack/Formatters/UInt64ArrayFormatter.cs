// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.UInt64ArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004EB")]
  public sealed class UInt64ArrayFormatter : IMessagePackFormatter<ulong[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F7A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly UInt64ArrayFormatter Instance;

    [Token(Token = "0x60017DC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt64ArrayFormatter()
    {
    }

    [Token(Token = "0x60017DD")]
    [Address(RVA = "0x6AF2B0", Offset = "0x6AE0B0", VA = "0x106AF2B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ulong[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017DE")]
    [Address(RVA = "0x6AF0B0", Offset = "0x6ADEB0", VA = "0x106AF0B0", Slot = "5")]
    public ulong[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ulong[]) null;
    }

    [Token(Token = "0x60017DF")]
    [Address(RVA = "0x6AF3E0", Offset = "0x6AE1E0", VA = "0x106AF3E0")]
    static UInt64ArrayFormatter()
    {
    }
  }
}
