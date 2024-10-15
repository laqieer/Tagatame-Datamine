// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_MasteryRewardItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20006C0")]
  public sealed class JSON_MasteryRewardItemParamFormatter : 
    IMessagePackFormatter<JSON_MasteryRewardItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001218")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001219")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001D8E")]
    [Address(RVA = "0xC16EA0", Offset = "0xC15CA0", VA = "0x10C16EA0")]
    public JSON_MasteryRewardItemParamFormatter()
    {
    }

    [Token(Token = "0x6001D8F")]
    [Address(RVA = "0xC16D40", Offset = "0xC15B40", VA = "0x10C16D40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_MasteryRewardItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001D90")]
    [Address(RVA = "0xC169F0", Offset = "0xC157F0", VA = "0x10C169F0", Slot = "5")]
    public JSON_MasteryRewardItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_MasteryRewardItemParam) null;
    }
  }
}
