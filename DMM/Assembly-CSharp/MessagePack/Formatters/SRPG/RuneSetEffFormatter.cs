// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneSetEffFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008F3")]
  public sealed class RuneSetEffFormatter : IMessagePackFormatter<RuneSetEff>, IMessagePackFormatter
  {
    [Token(Token = "0x4001676")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001677")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002427")]
    [Address(RVA = "0xDF2A10", Offset = "0xDF1810", VA = "0x10DF2A10")]
    public RuneSetEffFormatter()
    {
    }

    [Token(Token = "0x6002428")]
    [Address(RVA = "0xDF2770", Offset = "0xDF1570", VA = "0x10DF2770", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneSetEff value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002429")]
    [Address(RVA = "0xDF2390", Offset = "0xDF1190", VA = "0x10DF2390", Slot = "5")]
    public RuneSetEff Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneSetEff) null;
    }
  }
}
