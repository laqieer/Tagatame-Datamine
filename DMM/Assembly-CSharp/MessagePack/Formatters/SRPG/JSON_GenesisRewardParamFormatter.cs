// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GenesisRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A79")]
  public sealed class JSON_GenesisRewardParamFormatter : 
    IMessagePackFormatter<JSON_GenesisRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001982")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001983")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028B9")]
    [Address(RVA = "0xEDB890", Offset = "0xEDA690", VA = "0x10EDB890")]
    public JSON_GenesisRewardParamFormatter()
    {
    }

    [Token(Token = "0x60028BA")]
    [Address(RVA = "0xEDB6B0", Offset = "0xEDA4B0", VA = "0x10EDB6B0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GenesisRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028BB")]
    [Address(RVA = "0xEDB370", Offset = "0xEDA170", VA = "0x10EDB370", Slot = "5")]
    public JSON_GenesisRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GenesisRewardParam) null;
    }
  }
}
