// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_AdvanceRewardDataParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A7A")]
  public sealed class JSON_AdvanceRewardDataParamFormatter : 
    IMessagePackFormatter<JSON_AdvanceRewardDataParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001984")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001985")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60028BC")]
    [Address(RVA = "0xED4C20", Offset = "0xED3A20", VA = "0x10ED4C20")]
    public JSON_AdvanceRewardDataParamFormatter()
    {
    }

    [Token(Token = "0x60028BD")]
    [Address(RVA = "0xED4AC0", Offset = "0xED38C0", VA = "0x10ED4AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_AdvanceRewardDataParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60028BE")]
    [Address(RVA = "0xED4770", Offset = "0xED3570", VA = "0x10ED4770", Slot = "5")]
    public JSON_AdvanceRewardDataParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_AdvanceRewardDataParam) null;
    }
  }
}
