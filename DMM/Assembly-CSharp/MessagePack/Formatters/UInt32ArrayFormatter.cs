// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.UInt32ArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E8")]
  public sealed class UInt32ArrayFormatter : IMessagePackFormatter<uint[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F77")]
    [FieldOffset(Offset = "0x0")]
    public static readonly UInt32ArrayFormatter Instance;

    [Token(Token = "0x60017D0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32ArrayFormatter()
    {
    }

    [Token(Token = "0x60017D1")]
    [Address(RVA = "0x6AEE20", Offset = "0x6ADC20", VA = "0x106AEE20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      uint[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017D2")]
    [Address(RVA = "0x6AEC90", Offset = "0x6ADA90", VA = "0x106AEC90", Slot = "5")]
    public uint[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (uint[]) null;
    }

    [Token(Token = "0x60017D3")]
    [Address(RVA = "0x6AEF40", Offset = "0x6ADD40", VA = "0x106AEF40")]
    static UInt32ArrayFormatter()
    {
    }
  }
}
