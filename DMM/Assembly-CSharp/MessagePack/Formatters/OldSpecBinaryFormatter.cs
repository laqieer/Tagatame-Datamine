// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.OldSpecBinaryFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004D9")]
  public sealed class OldSpecBinaryFormatter : IMessagePackFormatter<byte[]>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F68")]
    [FieldOffset(Offset = "0x0")]
    public static readonly OldSpecBinaryFormatter Instance;

    [Token(Token = "0x6001794")]
    [Address(RVA = "0x6A78C0", Offset = "0x6A66C0", VA = "0x106A78C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      byte[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001795")]
    [Address(RVA = "0x6A7550", Offset = "0x6A6350", VA = "0x106A7550", Slot = "5")]
    public byte[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (byte[]) null;
    }

    [Token(Token = "0x6001796")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public OldSpecBinaryFormatter()
    {
    }

    [Token(Token = "0x6001797")]
    [Address(RVA = "0x6A7B00", Offset = "0x6A6900", VA = "0x106A7B00")]
    static OldSpecBinaryFormatter()
    {
    }
  }
}
