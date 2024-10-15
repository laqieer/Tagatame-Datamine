// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceUInt16BlockFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C0")]
  public sealed class ForceUInt16BlockFormatter : 
    IMessagePackFormatter<ushort>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F53")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceUInt16BlockFormatter Instance;

    [Token(Token = "0x600173C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceUInt16BlockFormatter()
    {
    }

    [Token(Token = "0x600173D")]
    [Address(RVA = "0x69E000", Offset = "0x69CE00", VA = "0x1069E000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ushort value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600173E")]
    [Address(RVA = "0x69DFB0", Offset = "0x69CDB0", VA = "0x1069DFB0", Slot = "5")]
    public ushort Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ushort();
    }

    [Token(Token = "0x600173F")]
    [Address(RVA = "0x69E050", Offset = "0x69CE50", VA = "0x1069E050")]
    static ForceUInt16BlockFormatter()
    {
    }
  }
}
