// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceStarRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A0F")]
  public sealed class JSON_AdvanceStarRewardParamFormatter : 
    IMessagePackFormatter<JSON_AdvanceStarRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40018AE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40018AF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600277B")]
    [Address(RVA = "0xE9EE00", Offset = "0xE9DC00", VA = "0x10E9EE00")]
    public JSON_AdvanceStarRewardParamFormatter()
    {
    }

    [Token(Token = "0x600277C")]
    [Address(RVA = "0xE9ECD0", Offset = "0xE9DAD0", VA = "0x10E9ECD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceStarRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600277D")]
    [Address(RVA = "0xE9E9C0", Offset = "0xE9D7C0", VA = "0x10E9E9C0", Slot = "5")]
    public JSON_AdvanceStarRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceStarRewardParam) null;
    }
  }
}
