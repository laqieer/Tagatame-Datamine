// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SByteFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F7")]
  public sealed class SByteFormatter : IMessagePackFormatter<sbyte>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F86")]
    [FieldOffset(Offset = "0x0")]
    public static readonly SByteFormatter Instance;

    [Token(Token = "0x600180C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private SByteFormatter()
    {
    }

    [Token(Token = "0x600180D")]
    [Address(RVA = "0x6AA0A0", Offset = "0x6A8EA0", VA = "0x106AA0A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      sbyte value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600180E")]
    [Address(RVA = "0x6AA050", Offset = "0x6A8E50", VA = "0x106AA050", Slot = "5")]
    public sbyte Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new sbyte();
    }

    [Token(Token = "0x600180F")]
    [Address(RVA = "0x6AA0F0", Offset = "0x6A8EF0", VA = "0x106AA0F0")]
    static SByteFormatter()
    {
    }
  }
}
