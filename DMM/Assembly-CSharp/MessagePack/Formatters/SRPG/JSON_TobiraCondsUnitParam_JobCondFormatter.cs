// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TobiraCondsUnitParam_JobCondFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200060C")]
  public sealed class JSON_TobiraCondsUnitParam_JobCondFormatter : 
    IMessagePackFormatter<JSON_TobiraCondsUnitParam.JobCond>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010B0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010B1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B72")]
    [Address(RVA = "0xBABC90", Offset = "0xBAAA90", VA = "0x10BABC90")]
    public JSON_TobiraCondsUnitParam_JobCondFormatter()
    {
    }

    [Token(Token = "0x6001B73")]
    [Address(RVA = "0xBABB60", Offset = "0xBAA960", VA = "0x10BABB60", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TobiraCondsUnitParam.JobCond value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B74")]
    [Address(RVA = "0xBAB850", Offset = "0xBAA650", VA = "0x10BAB850", Slot = "5")]
    public JSON_TobiraCondsUnitParam.JobCond Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TobiraCondsUnitParam.JobCond) null;
    }
  }
}
