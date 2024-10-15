// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceSByteBlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004CC")]
  public sealed class NullableForceSByteBlockFormatter : 
    IMessagePackFormatter<sbyte?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F5F")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceSByteBlockFormatter Instance;

    [Token(Token = "0x600176C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceSByteBlockFormatter()
    {
    }

    [Token(Token = "0x600176D")]
    [Address(RVA = "0x6A3840", Offset = "0x6A2640", VA = "0x106A3840", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      sbyte? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600176E")]
    [Address(RVA = "0x6A3780", Offset = "0x6A2580", VA = "0x106A3780", Slot = "5")]
    public sbyte? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new sbyte?();
    }

    [Token(Token = "0x600176F")]
    [Address(RVA = "0x6A38F0", Offset = "0x6A26F0", VA = "0x106A38F0")]
    static NullableForceSByteBlockFormatter()
    {
    }
  }
}
