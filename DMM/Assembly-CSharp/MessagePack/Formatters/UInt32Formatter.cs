// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.UInt32Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004E6")]
  public sealed class UInt32Formatter : IMessagePackFormatter<uint>, IMessagePackFormatter
  {
    [Token(Token = "0x4000F75")]
    [FieldOffset(Offset = "0x0")]
    public static readonly UInt32Formatter Instance;

    [Token(Token = "0x60017C8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private UInt32Formatter()
    {
    }

    [Token(Token = "0x60017C9")]
    [Address(RVA = "0x6AF000", Offset = "0x6ADE00", VA = "0x106AF000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      uint value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60017CA")]
    [Address(RVA = "0x6AEFA0", Offset = "0x6ADDA0", VA = "0x106AEFA0", Slot = "5")]
    public uint Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new uint();
    }

    [Token(Token = "0x60017CB")]
    [Address(RVA = "0x6AF050", Offset = "0x6ADE50", VA = "0x106AF050")]
    static UInt32Formatter()
    {
    }
  }
}
