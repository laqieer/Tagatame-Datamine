// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceSByteBlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004CB")]
  public sealed class ForceSByteBlockFormatter : IMessagePackFormatter<sbyte>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F5E")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceSByteBlockFormatter Instance;

    [Token(Token = "0x6001768")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceSByteBlockFormatter()
    {
    }

    [Token(Token = "0x6001769")]
    [Address(RVA = "0x69DAE0", Offset = "0x69C8E0", VA = "0x1069DAE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      sbyte value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600176A")]
    [Address(RVA = "0x69DA90", Offset = "0x69C890", VA = "0x1069DA90", Slot = "5")]
    public sbyte Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new sbyte();
    }

    [Token(Token = "0x600176B")]
    [Address(RVA = "0x69DB30", Offset = "0x69C930", VA = "0x1069DB30")]
    static ForceSByteBlockFormatter()
    {
    }
  }
}
