// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.BooleanFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004F2")]
  public sealed class BooleanFormatter : IMessagePackFormatter<bool>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F81")]
    [FieldOffset(Offset = "0x0")]
    public static readonly BooleanFormatter Instance;

    [Token(Token = "0x60017F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private BooleanFormatter()
    {
    }

    [Token(Token = "0x60017F9")]
    [Address(RVA = "0x694910", Offset = "0x693710", VA = "0x10694910", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      bool value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017FA")]
    [Address(RVA = "0x6948C0", Offset = "0x6936C0", VA = "0x106948C0", Slot = "5")]
    public bool Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new bool();
    }

    [Token(Token = "0x60017FB")]
    [Address(RVA = "0x694960", Offset = "0x693760", VA = "0x10694960")]
    static BooleanFormatter()
    {
    }
  }
}
