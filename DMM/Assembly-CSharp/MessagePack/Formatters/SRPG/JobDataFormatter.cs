// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JobDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000793")]
  public sealed class JobDataFormatter : IMessagePackFormatter<JobData>, IMessagePackFormatter
  {
    [Token(Token = "0x40013BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002007")]
    [Address(RVA = "0xCDEA30", Offset = "0xCDD830", VA = "0x10CDEA30")]
    public JobDataFormatter()
    {
    }

    [Token(Token = "0x6002008")]
    [Address(RVA = "0xCDE040", Offset = "0xCDCE40", VA = "0x10CDE040", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JobData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002009")]
    [Address(RVA = "0xCDD940", Offset = "0xCDC740", VA = "0x10CDD940", Slot = "5")]
    public JobData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JobData) null;
    }
  }
}
