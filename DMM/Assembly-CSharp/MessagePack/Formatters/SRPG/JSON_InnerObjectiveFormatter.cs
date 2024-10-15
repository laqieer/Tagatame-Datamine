// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_InnerObjectiveFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000984")]
  public sealed class JSON_InnerObjectiveFormatter : 
    IMessagePackFormatter<JSON_InnerObjective>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001798")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001799")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025DA")]
    [Address(RVA = "0xE2A650", Offset = "0xE29450", VA = "0x10E2A650")]
    public JSON_InnerObjectiveFormatter()
    {
    }

    [Token(Token = "0x60025DB")]
    [Address(RVA = "0xE2A3E0", Offset = "0xE291E0", VA = "0x10E2A3E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_InnerObjective value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025DC")]
    [Address(RVA = "0xE29FB0", Offset = "0xE28DB0", VA = "0x10E29FB0", Slot = "5")]
    public JSON_InnerObjective Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_InnerObjective) null;
    }
  }
}
