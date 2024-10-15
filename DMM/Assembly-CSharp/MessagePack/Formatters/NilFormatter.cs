// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.NilFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x200052A")]
  public class NilFormatter : IMessagePackFormatter<Nil>, IMessagePackFormatter
  {
    [Token(Token = "0x4000FB2")]
    [FieldOffset(Offset = "0x0")]
    public static readonly IMessagePackFormatter<Nil> Instance;

    [Token(Token = "0x60018CA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private NilFormatter()
    {
    }

    [Token(Token = "0x60018CB")]
    [Address(RVA = "0x6A1A10", Offset = "0x6A0810", VA = "0x106A1A10", Slot = "4")]
    public int Serialize(ref byte[] bytes, int offset, Nil value, IFormatterResolver typeResolver)
    {
      return new int();
    }

    [Token(Token = "0x60018CC")]
    [Address(RVA = "0x6A19C0", Offset = "0x6A07C0", VA = "0x106A19C0", Slot = "5")]
    public Nil Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver typeResolver,
      out int readSize)
    {
      return new Nil();
    }

    [Token(Token = "0x60018CD")]
    [Address(RVA = "0x6A1A60", Offset = "0x6A0860", VA = "0x106A1A60")]
    static NilFormatter()
    {
    }
  }
}
