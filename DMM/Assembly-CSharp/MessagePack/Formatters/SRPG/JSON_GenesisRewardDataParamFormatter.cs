// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisRewardDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A78")]
  public sealed class JSON_GenesisRewardDataParamFormatter : 
    IMessagePackFormatter<JSON_GenesisRewardDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001980")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001981")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028B6")]
    [Address(RVA = "0xEDB180", Offset = "0xED9F80", VA = "0x10EDB180")]
    public JSON_GenesisRewardDataParamFormatter()
    {
    }

    [Token(Token = "0x60028B7")]
    [Address(RVA = "0xEDB020", Offset = "0xED9E20", VA = "0x10EDB020", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisRewardDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028B8")]
    [Address(RVA = "0xEDACD0", Offset = "0xED9AD0", VA = "0x10EDACD0", Slot = "5")]
    public JSON_GenesisRewardDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisRewardDataParam) null;
    }
  }
}
