// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JobParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200078A")]
  public sealed class JobParamFormatter : IMessagePackFormatter<JobParam>, IMessagePackFormatter
  {
    [Token(Token = "0x40013AC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013AD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FEC")]
    [Address(RVA = "0xCCE8A0", Offset = "0xCCD6A0", VA = "0x10CCE8A0")]
    public JobParamFormatter()
    {
    }

    [Token(Token = "0x6001FED")]
    [Address(RVA = "0xCCD970", Offset = "0xCCC770", VA = "0x10CCD970", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JobParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FEE")]
    [Address(RVA = "0xCCCBF0", Offset = "0xCCB9F0", VA = "0x10CCCBF0", Slot = "5")]
    public JobParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JobParam) null;
    }
  }
}
