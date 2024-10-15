// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneDedicatedCostParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008FE")]
  public sealed class RuneDedicatedCostParamFormatter : 
    IMessagePackFormatter<RuneDedicatedCostParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400168C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400168D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002448")]
    [Address(RVA = "0xDEDB30", Offset = "0xDEC930", VA = "0x10DEDB30")]
    public RuneDedicatedCostParamFormatter()
    {
    }

    [Token(Token = "0x6002449")]
    [Address(RVA = "0xDEDAC0", Offset = "0xDEC8C0", VA = "0x10DEDAC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneDedicatedCostParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600244A")]
    [Address(RVA = "0xDED850", Offset = "0xDEC650", VA = "0x10DED850", Slot = "5")]
    public RuneDedicatedCostParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneDedicatedCostParam) null;
    }
  }
}
