// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200080C")]
  public sealed class JSON_DuelRewardFormatter : 
    IMessagePackFormatter<JSON_DuelReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40014A8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40014A9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002172")]
    [Address(RVA = "0xD42320", Offset = "0xD41120", VA = "0x10D42320")]
    public JSON_DuelRewardFormatter()
    {
    }

    [Token(Token = "0x6002173")]
    [Address(RVA = "0xD421C0", Offset = "0xD40FC0", VA = "0x10D421C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002174")]
    [Address(RVA = "0xD41E70", Offset = "0xD40C70", VA = "0x10D41E70", Slot = "5")]
    public JSON_DuelReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelReward) null;
    }
  }
}
