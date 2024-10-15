// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.RuneDedicatedCostParam_RuneDedicatedCostItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20008FF")]
  public sealed class RuneDedicatedCostParam_RuneDedicatedCostItemParamFormatter : 
    IMessagePackFormatter<RuneDedicatedCostParam.RuneDedicatedCostItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400168E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400168F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600244B")]
    [Address(RVA = "0xDEDEA0", Offset = "0xDECCA0", VA = "0x10DEDEA0")]
    public RuneDedicatedCostParam_RuneDedicatedCostItemParamFormatter()
    {
    }

    [Token(Token = "0x600244C")]
    [Address(RVA = "0xDEDE30", Offset = "0xDECC30", VA = "0x10DEDE30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RuneDedicatedCostParam.RuneDedicatedCostItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600244D")]
    [Address(RVA = "0xDEDBC0", Offset = "0xDEC9C0", VA = "0x10DEDBC0", Slot = "5")]
    public RuneDedicatedCostParam.RuneDedicatedCostItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RuneDedicatedCostParam.RuneDedicatedCostItemParam) null;
    }
  }
}
