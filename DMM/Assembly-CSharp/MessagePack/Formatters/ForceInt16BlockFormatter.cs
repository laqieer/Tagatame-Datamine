// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceInt16BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004B7")]
  public sealed class ForceInt16BlockFormatter : IMessagePackFormatter<short>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F4A")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceInt16BlockFormatter Instance;

    [Token(Token = "0x6001718")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceInt16BlockFormatter()
    {
    }

    [Token(Token = "0x6001719")]
    [Address(RVA = "0x69CAA0", Offset = "0x69B8A0", VA = "0x1069CAA0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      short value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600171A")]
    [Address(RVA = "0x69CA50", Offset = "0x69B850", VA = "0x1069CA50", Slot = "5")]
    public short Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new short();
    }

    [Token(Token = "0x600171B")]
    [Address(RVA = "0x69CAF0", Offset = "0x69B8F0", VA = "0x1069CAF0")]
    static ForceInt16BlockFormatter()
    {
    }
  }
}
