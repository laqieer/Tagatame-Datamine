// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MapBreakObjFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20007C9")]
  public sealed class MapBreakObjFormatter : 
    IMessagePackFormatter<MapBreakObj>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001422")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001423")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60020A9")]
    [Address(RVA = "0xD05BC0", Offset = "0xD049C0", VA = "0x10D05BC0")]
    public MapBreakObjFormatter()
    {
    }

    [Token(Token = "0x60020AA")]
    [Address(RVA = "0xD05900", Offset = "0xD04700", VA = "0x10D05900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MapBreakObj value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60020AB")]
    [Address(RVA = "0xD054E0", Offset = "0xD042E0", VA = "0x10D054E0", Slot = "5")]
    public MapBreakObj Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MapBreakObj) null;
    }
  }
}
