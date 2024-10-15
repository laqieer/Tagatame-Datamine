// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_GvGNodeDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005C2")]
  public sealed class JSON_GvGNodeDataFormatter : 
    IMessagePackFormatter<JSON_GvGNodeData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400101C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400101D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A94")]
    [Address(RVA = "0x952C80", Offset = "0x951A80", VA = "0x10952C80")]
    public JSON_GvGNodeDataFormatter()
    {
    }

    [Token(Token = "0x6001A95")]
    [Address(RVA = "0x952A30", Offset = "0x951830", VA = "0x10952A30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_GvGNodeData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A96")]
    [Address(RVA = "0x9525C0", Offset = "0x9513C0", VA = "0x109525C0", Slot = "5")]
    public JSON_GvGNodeData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_GvGNodeData) null;
    }
  }
}
