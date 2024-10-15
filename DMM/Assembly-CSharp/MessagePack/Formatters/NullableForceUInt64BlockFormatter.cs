// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableForceUInt64BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C7")]
  public sealed class NullableForceUInt64BlockFormatter : 
    IMessagePackFormatter<ulong?>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F5A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableForceUInt64BlockFormatter Instance;

    [Token(Token = "0x6001758")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableForceUInt64BlockFormatter()
    {
    }

    [Token(Token = "0x6001759")]
    [Address(RVA = "0x6A3DB0", Offset = "0x6A2BB0", VA = "0x106A3DB0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ulong? value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600175A")]
    [Address(RVA = "0x6A3CE0", Offset = "0x6A2AE0", VA = "0x106A3CE0", Slot = "5")]
    public ulong? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ulong?();
    }

    [Token(Token = "0x600175B")]
    [Address(RVA = "0x6A3E60", Offset = "0x6A2C60", VA = "0x106A3E60")]
    static NullableForceUInt64BlockFormatter()
    {
    }
  }
}
