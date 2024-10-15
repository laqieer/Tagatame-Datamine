// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007E1")]
  public sealed class JSON_GvGRewardParamFormatter : 
    IMessagePackFormatter<JSON_GvGRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001452")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001453")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020F1")]
    [Address(RVA = "0xD17E20", Offset = "0xD16C20", VA = "0x10D17E20")]
    public JSON_GvGRewardParamFormatter()
    {
    }

    [Token(Token = "0x60020F2")]
    [Address(RVA = "0xD17C40", Offset = "0xD16A40", VA = "0x10D17C40", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020F3")]
    [Address(RVA = "0xD17900", Offset = "0xD16700", VA = "0x10D17900", Slot = "5")]
    public JSON_GvGRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGRewardParam) null;
    }
  }
}
