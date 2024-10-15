// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGNodeRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000935")]
  public sealed class JSON_GvGNodeRewardParamFormatter : 
    IMessagePackFormatter<JSON_GvGNodeRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024ED")]
    [Address(RVA = "0xDFF3F0", Offset = "0xDFE1F0", VA = "0x10DFF3F0")]
    public JSON_GvGNodeRewardParamFormatter()
    {
    }

    [Token(Token = "0x60024EE")]
    [Address(RVA = "0xDFF210", Offset = "0xDFE010", VA = "0x10DFF210", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGNodeRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024EF")]
    [Address(RVA = "0xDFEED0", Offset = "0xDFDCD0", VA = "0x10DFEED0", Slot = "5")]
    public JSON_GvGNodeRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGNodeRewardParam) null;
    }
  }
}
