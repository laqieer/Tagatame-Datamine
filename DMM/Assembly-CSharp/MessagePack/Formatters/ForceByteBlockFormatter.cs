// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceByteBlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C9")]
  public sealed class ForceByteBlockFormatter : IMessagePackFormatter<byte>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F5C")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceByteBlockFormatter Instance;

    [Token(Token = "0x6001760")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceByteBlockFormatter()
    {
    }

    [Token(Token = "0x6001761")]
    [Address(RVA = "0x69C580", Offset = "0x69B380", VA = "0x1069C580", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      byte value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001762")]
    [Address(RVA = "0x69C530", Offset = "0x69B330", VA = "0x1069C530", Slot = "5")]
    public byte Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new byte();
    }

    [Token(Token = "0x6001763")]
    [Address(RVA = "0x69C5D0", Offset = "0x69B3D0", VA = "0x1069C5D0")]
    static ForceByteBlockFormatter()
    {
    }
  }
}
