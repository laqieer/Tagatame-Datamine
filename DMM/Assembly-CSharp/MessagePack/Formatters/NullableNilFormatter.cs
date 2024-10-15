// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NullableNilFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200052B")]
  public class NullableNilFormatter : IMessagePackFormatter<Nil?>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FB3")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Nil?> Instance;

    [Token(Token = "0x60018CE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NullableNilFormatter()
    {
    }

    [Token(Token = "0x60018CF")]
    [Address(RVA = "0x6A44B0", Offset = "0x6A32B0", VA = "0x106A44B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Nil? value,
      IFormatterResolver typeResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018D0")]
    [Address(RVA = "0x6A4430", Offset = "0x6A3230", VA = "0x106A4430", Slot = "5")]
    public Nil? Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver typeResolver,
      out int readSize)
    {
      return new Nil?();
    }

    [Token(Token = "0x60018D1")]
    [Address(RVA = "0x6A4500", Offset = "0x6A3300", VA = "0x106A4500")]
    static NullableNilFormatter()
    {
    }
  }
}
