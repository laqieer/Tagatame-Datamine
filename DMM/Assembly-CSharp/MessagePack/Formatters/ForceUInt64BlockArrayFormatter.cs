// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.ForceUInt64BlockArrayFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Formatters
{
  [Token(Token = "0x20004C8")]
  public sealed class ForceUInt64BlockArrayFormatter : 
    IMessagePackFormatter<ulong[]>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000F5B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly ForceUInt64BlockArrayFormatter Instance;

    [Token(Token = "0x600175C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    private ForceUInt64BlockArrayFormatter()
    {
    }

    [Token(Token = "0x600175D")]
    [Address(RVA = "0x69E7A0", Offset = "0x69D5A0", VA = "0x1069E7A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ulong[] value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600175E")]
    [Address(RVA = "0x69E5A0", Offset = "0x69D3A0", VA = "0x1069E5A0", Slot = "5")]
    public ulong[] Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ulong[]) null;
    }

    [Token(Token = "0x600175F")]
    [Address(RVA = "0x69EA20", Offset = "0x69D820", VA = "0x1069EA20")]
    static ForceUInt64BlockArrayFormatter()
    {
    }
  }
}
