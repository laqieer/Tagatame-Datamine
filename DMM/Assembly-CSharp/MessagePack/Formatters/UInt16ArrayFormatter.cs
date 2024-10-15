// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.UInt16ArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E5")]
  public sealed class UInt16ArrayFormatter : IMessagePackFormatter<ushort[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F74")]
    [FieldOffset(Offset = "0x0")]
    public static readonly UInt16ArrayFormatter Instance;

    [Token(Token = "0x60017C4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt16ArrayFormatter()
    {
    }

    [Token(Token = "0x60017C5")]
    [Address(RVA = "0x6AE8C0", Offset = "0x6AD6C0", VA = "0x106AE8C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ushort[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017C6")]
    [Address(RVA = "0x6AE6B0", Offset = "0x6AD4B0", VA = "0x106AE6B0", Slot = "5")]
    public ushort[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ushort[]) null;
    }

    [Token(Token = "0x60017C7")]
    [Address(RVA = "0x6AEB30", Offset = "0x6AD930", VA = "0x106AEB30")]
    static UInt16ArrayFormatter()
    {
    }
  }
}
