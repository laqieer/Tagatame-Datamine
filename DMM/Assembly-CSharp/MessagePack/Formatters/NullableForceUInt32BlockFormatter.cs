// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceUInt32BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C4")]
  public sealed class NullableForceUInt32BlockFormatter : 
    IMessagePackFormatter<uint?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F57")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceUInt32BlockFormatter Instance;

    [Token(Token = "0x600174C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceUInt32BlockFormatter()
    {
    }

    [Token(Token = "0x600174D")]
    [Address(RVA = "0x6A3BE0", Offset = "0x6A29E0", VA = "0x106A3BE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      uint? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600174E")]
    [Address(RVA = "0x6A3B10", Offset = "0x6A2910", VA = "0x106A3B10", Slot = "5")]
    public uint? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new uint?();
    }

    [Token(Token = "0x600174F")]
    [Address(RVA = "0x6A3C80", Offset = "0x6A2A80", VA = "0x106A3C80")]
    static NullableForceUInt32BlockFormatter()
    {
    }
  }
}
