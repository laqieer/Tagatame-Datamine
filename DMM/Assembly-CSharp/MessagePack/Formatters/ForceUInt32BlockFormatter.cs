// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceUInt32BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C3")]
  public sealed class ForceUInt32BlockFormatter : IMessagePackFormatter<uint>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F56")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceUInt32BlockFormatter Instance;

    [Token(Token = "0x6001748")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceUInt32BlockFormatter()
    {
    }

    [Token(Token = "0x6001749")]
    [Address(RVA = "0x69E4F0", Offset = "0x69D2F0", VA = "0x1069E4F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      uint value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600174A")]
    [Address(RVA = "0x69E4A0", Offset = "0x69D2A0", VA = "0x1069E4A0", Slot = "5")]
    public uint Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new uint();
    }

    [Token(Token = "0x600174B")]
    [Address(RVA = "0x69E540", Offset = "0x69D340", VA = "0x1069E540")]
    static ForceUInt32BlockFormatter()
    {
    }
  }
}
