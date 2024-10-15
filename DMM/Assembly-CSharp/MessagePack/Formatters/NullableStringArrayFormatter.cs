// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableStringArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x2000503")]
  public sealed class NullableStringArrayFormatter : 
    IMessagePackFormatter<string[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F93")]
    [FieldOffset(Offset = "0x0")]
    public static readonly NullableStringArrayFormatter Instance;

    [Token(Token = "0x600183D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableStringArrayFormatter()
    {
    }

    [Token(Token = "0x600183E")]
    [Address(RVA = "0x6A4B60", Offset = "0x6A3960", VA = "0x106A4B60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      string[] value,
      IFormatterResolver typeResolver)
    {
      return new int();
    }

    [Token(Token = "0x600183F")]
    [Address(RVA = "0x6A4920", Offset = "0x6A3720", VA = "0x106A4920", Slot = "5")]
    public string[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver typeResolver,
      out int readSize)
    {
      return (string[]) null;
    }

    [Token(Token = "0x6001840")]
    [Address(RVA = "0x6A4C80", Offset = "0x6A3A80", VA = "0x106A4C80")]
    static NullableStringArrayFormatter()
    {
    }
  }
}
