// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200062F")]
  public sealed class JSON_RaidRewardParamFormatter : 
    IMessagePackFormatter<JSON_RaidRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010F6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010F7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BDB")]
    [Address(RVA = "0xBC6870", Offset = "0xBC5670", VA = "0x10BC6870")]
    public JSON_RaidRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001BDC")]
    [Address(RVA = "0xBC6690", Offset = "0xBC5490", VA = "0x10BC6690", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BDD")]
    [Address(RVA = "0xBC6350", Offset = "0xBC5150", VA = "0x10BC6350", Slot = "5")]
    public JSON_RaidRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidRewardParam) null;
    }
  }
}
