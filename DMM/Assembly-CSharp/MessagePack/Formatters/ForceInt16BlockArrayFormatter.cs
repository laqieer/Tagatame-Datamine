// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceInt16BlockArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B9")]
  public sealed class ForceInt16BlockArrayFormatter : 
    IMessagePackFormatter<short[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F4C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceInt16BlockArrayFormatter Instance;

    [Token(Token = "0x6001720")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceInt16BlockArrayFormatter()
    {
    }

    [Token(Token = "0x6001721")]
    [Address(RVA = "0x69C840", Offset = "0x69B640", VA = "0x1069C840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      short[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001722")]
    [Address(RVA = "0x69C630", Offset = "0x69B430", VA = "0x1069C630", Slot = "5")]
    public short[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (short[]) null;
    }

    [Token(Token = "0x6001723")]
    [Address(RVA = "0x69C9F0", Offset = "0x69B7F0", VA = "0x1069C9F0")]
    static ForceInt16BlockArrayFormatter()
    {
    }
  }
}
