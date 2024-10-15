// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_VersusWinBonusRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009FC")]
  public sealed class JSON_VersusWinBonusRewardFormatter : 
    IMessagePackFormatter<JSON_VersusWinBonusReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001888")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001889")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002742")]
    [Address(RVA = "0xE86170", Offset = "0xE84F70", VA = "0x10E86170")]
    public JSON_VersusWinBonusRewardFormatter()
    {
    }

    [Token(Token = "0x6002743")]
    [Address(RVA = "0xE86010", Offset = "0xE84E10", VA = "0x10E86010", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_VersusWinBonusReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002744")]
    [Address(RVA = "0xE85CC0", Offset = "0xE84AC0", VA = "0x10E85CC0", Slot = "5")]
    public JSON_VersusWinBonusReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_VersusWinBonusReward) null;
    }
  }
}
