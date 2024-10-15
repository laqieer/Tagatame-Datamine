// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.FlowNode_ReqUpdateTrophy_MP_TrophyPlayerDataAllResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000880")]
  public sealed class FlowNode_ReqUpdateTrophy_MP_TrophyPlayerDataAllResponseFormatter : 
    IMessagePackFormatter<FlowNode_ReqUpdateTrophy.MP_TrophyPlayerDataAllResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001590")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001591")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60022CE")]
    [Address(RVA = "0xD9DC40", Offset = "0xD9CA40", VA = "0x10D9DC40")]
    public FlowNode_ReqUpdateTrophy_MP_TrophyPlayerDataAllResponseFormatter()
    {
    }

    [Token(Token = "0x60022CF")]
    [Address(RVA = "0xD9D950", Offset = "0xD9C750", VA = "0x10D9D950", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      FlowNode_ReqUpdateTrophy.MP_TrophyPlayerDataAllResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60022D0")]
    [Address(RVA = "0xD9D520", Offset = "0xD9C320", VA = "0x10D9D520", Slot = "5")]
    public FlowNode_ReqUpdateTrophy.MP_TrophyPlayerDataAllResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (FlowNode_ReqUpdateTrophy.MP_TrophyPlayerDataAllResponse) null;
    }
  }
}
