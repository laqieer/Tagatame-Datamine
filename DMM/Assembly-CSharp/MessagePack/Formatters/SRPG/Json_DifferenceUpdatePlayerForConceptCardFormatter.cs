// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_DifferenceUpdatePlayerForConceptCardFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009F9")]
  public sealed class Json_DifferenceUpdatePlayerForConceptCardFormatter : 
    IMessagePackFormatter<Json_DifferenceUpdatePlayerForConceptCard>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001882")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001883")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002739")]
    [Address(RVA = "0xE87C90", Offset = "0xE86A90", VA = "0x10E87C90")]
    public Json_DifferenceUpdatePlayerForConceptCardFormatter()
    {
    }

    [Token(Token = "0x600273A")]
    [Address(RVA = "0xE87680", Offset = "0xE86480", VA = "0x10E87680", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_DifferenceUpdatePlayerForConceptCard value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600273B")]
    [Address(RVA = "0xE870A0", Offset = "0xE85EA0", VA = "0x10E870A0", Slot = "5")]
    public Json_DifferenceUpdatePlayerForConceptCard Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_DifferenceUpdatePlayerForConceptCard) null;
    }
  }
}
