// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GUildRoleBonusRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000693")]
  public sealed class JSON_GUildRoleBonusRewardFormatter : 
    IMessagePackFormatter<JSON_GUildRoleBonusReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40011BE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40011BF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D07")]
    [Address(RVA = "0xBFAB50", Offset = "0xBF9950", VA = "0x10BFAB50")]
    public JSON_GUildRoleBonusRewardFormatter()
    {
    }

    [Token(Token = "0x6001D08")]
    [Address(RVA = "0xBFA9F0", Offset = "0xBF97F0", VA = "0x10BFA9F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GUildRoleBonusReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D09")]
    [Address(RVA = "0xBFA6A0", Offset = "0xBF94A0", VA = "0x10BFA6A0", Slot = "5")]
    public JSON_GUildRoleBonusReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GUildRoleBonusReward) null;
    }
  }
}
