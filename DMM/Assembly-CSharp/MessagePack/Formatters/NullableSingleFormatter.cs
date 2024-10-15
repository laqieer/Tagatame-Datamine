// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableSingleFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004ED")]
  public sealed class NullableSingleFormatter : IMessagePackFormatter<float?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F7C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableSingleFormatter Instance;

    [Token(Token = "0x60017E4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableSingleFormatter()
    {
    }

    [Token(Token = "0x60017E5")]
    [Address(RVA = "0x6A4810", Offset = "0x6A3610", VA = "0x106A4810", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      float? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017E6")]
    [Address(RVA = "0x6A4730", Offset = "0x6A3530", VA = "0x106A4730", Slot = "5")]
    public float? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new float?();
    }

    [Token(Token = "0x60017E7")]
    [Address(RVA = "0x6A48C0", Offset = "0x6A36C0", VA = "0x106A48C0")]
    static NullableSingleFormatter()
    {
    }
  }
}
