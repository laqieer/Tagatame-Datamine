// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_RaidAreaClearRewardDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200062A")]
  public sealed class JSON_RaidAreaClearRewardDataParamFormatter : 
    IMessagePackFormatter<JSON_RaidAreaClearRewardDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010EC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010ED")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001BCC")]
    [Address(RVA = "0xBBDE30", Offset = "0xBBCC30", VA = "0x10BBDE30")]
    public JSON_RaidAreaClearRewardDataParamFormatter()
    {
    }

    [Token(Token = "0x6001BCD")]
    [Address(RVA = "0xBBDD00", Offset = "0xBBCB00", VA = "0x10BBDD00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_RaidAreaClearRewardDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001BCE")]
    [Address(RVA = "0xBBD9F0", Offset = "0xBBC7F0", VA = "0x10BBD9F0", Slot = "5")]
    public JSON_RaidAreaClearRewardDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_RaidAreaClearRewardDataParam) null;
    }
  }
}
