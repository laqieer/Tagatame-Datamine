// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidAreaClearRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200062B")]
  public sealed class JSON_RaidAreaClearRewardParamFormatter : 
    IMessagePackFormatter<JSON_RaidAreaClearRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010EE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010EF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BCF")]
    [Address(RVA = "0xBBE460", Offset = "0xBBD260", VA = "0x10BBE460")]
    public JSON_RaidAreaClearRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001BD0")]
    [Address(RVA = "0xBBE2C0", Offset = "0xBBD0C0", VA = "0x10BBE2C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidAreaClearRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BD1")]
    [Address(RVA = "0xBBDFB0", Offset = "0xBBCDB0", VA = "0x10BBDFB0", Slot = "5")]
    public JSON_RaidAreaClearRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidAreaClearRewardParam) null;
    }
  }
}
