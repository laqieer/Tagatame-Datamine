// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceUInt32BlockArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C5")]
  public sealed class ForceUInt32BlockArrayFormatter : 
    IMessagePackFormatter<uint[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F58")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceUInt32BlockArrayFormatter Instance;

    [Token(Token = "0x6001750")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceUInt32BlockArrayFormatter()
    {
    }

    [Token(Token = "0x6001751")]
    [Address(RVA = "0x69E240", Offset = "0x69D040", VA = "0x1069E240", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      uint[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001752")]
    [Address(RVA = "0x69E0B0", Offset = "0x69CEB0", VA = "0x1069E0B0", Slot = "5")]
    public uint[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (uint[]) null;
    }

    [Token(Token = "0x6001753")]
    [Address(RVA = "0x69E440", Offset = "0x69D240", VA = "0x1069E440")]
    static ForceUInt32BlockArrayFormatter()
    {
    }
  }
}
