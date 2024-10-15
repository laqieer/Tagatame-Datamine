// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JobRankParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000789")]
  public sealed class JobRankParamFormatter : 
    IMessagePackFormatter<JobRankParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40013AA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013AB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001FE9")]
    [Address(RVA = "0xCD0060", Offset = "0xCCEE60", VA = "0x10CD0060")]
    public JobRankParamFormatter()
    {
    }

    [Token(Token = "0x6001FEA")]
    [Address(RVA = "0xCCFC60", Offset = "0xCCEA60", VA = "0x10CCFC60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JobRankParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001FEB")]
    [Address(RVA = "0xCCF790", Offset = "0xCCE590", VA = "0x10CCF790", Slot = "5")]
    public JobRankParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JobRankParam) null;
    }
  }
}
