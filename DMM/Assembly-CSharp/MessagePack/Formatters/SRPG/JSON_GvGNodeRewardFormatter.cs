// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGNodeRewardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000934")]
  public sealed class JSON_GvGNodeRewardFormatter : 
    IMessagePackFormatter<JSON_GvGNodeReward>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016F8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016F9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024EA")]
    [Address(RVA = "0xDFED50", Offset = "0xDFDB50", VA = "0x10DFED50")]
    public JSON_GvGNodeRewardFormatter()
    {
    }

    [Token(Token = "0x60024EB")]
    [Address(RVA = "0xDFEC00", Offset = "0xDFDA00", VA = "0x10DFEC00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGNodeReward value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024EC")]
    [Address(RVA = "0xDFE8D0", Offset = "0xDFD6D0", VA = "0x10DFE8D0", Slot = "5")]
    public JSON_GvGNodeReward Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGNodeReward) null;
    }
  }
}
