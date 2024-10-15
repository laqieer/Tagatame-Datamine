// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableSByteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F8")]
  public sealed class NullableSByteFormatter : IMessagePackFormatter<sbyte?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F87")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableSByteFormatter Instance;

    [Token(Token = "0x6001810")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableSByteFormatter()
    {
    }

    [Token(Token = "0x6001811")]
    [Address(RVA = "0x6A4620", Offset = "0x6A3420", VA = "0x106A4620", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      sbyte? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001812")]
    [Address(RVA = "0x6A4560", Offset = "0x6A3360", VA = "0x106A4560", Slot = "5")]
    public sbyte? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new sbyte?();
    }

    [Token(Token = "0x6001813")]
    [Address(RVA = "0x6A46D0", Offset = "0x6A34D0", VA = "0x106A46D0")]
    static NullableSByteFormatter()
    {
    }
  }
}
