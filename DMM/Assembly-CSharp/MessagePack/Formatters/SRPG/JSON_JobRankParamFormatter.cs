// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_JobRankParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005E2")]
  public sealed class JSON_JobRankParamFormatter : 
    IMessagePackFormatter<JSON_JobRankParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400105C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400105D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001AF4")]
    [Address(RVA = "0xB446C0", Offset = "0xB434C0", VA = "0x10B446C0")]
    public JSON_JobRankParamFormatter()
    {
    }

    [Token(Token = "0x6001AF5")]
    [Address(RVA = "0xB44080", Offset = "0xB42E80", VA = "0x10B44080", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_JobRankParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001AF6")]
    [Address(RVA = "0xB438F0", Offset = "0xB426F0", VA = "0x10B438F0", Slot = "5")]
    public JSON_JobRankParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_JobRankParam) null;
    }
  }
}
