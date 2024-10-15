// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_ConceptCardEquipParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000610")]
  public sealed class JSON_ConceptCardEquipParamFormatter : 
    IMessagePackFormatter<JSON_ConceptCardEquipParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40010B8")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40010B9")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B7E")]
    [Address(RVA = "0xBB6760", Offset = "0xBB5560", VA = "0x10BB6760")]
    public JSON_ConceptCardEquipParamFormatter()
    {
    }

    [Token(Token = "0x6001B7F")]
    [Address(RVA = "0xBB6370", Offset = "0xBB5170", VA = "0x10BB6370", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_ConceptCardEquipParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B80")]
    [Address(RVA = "0xBB5DE0", Offset = "0xBB4BE0", VA = "0x10BB5DE0", Slot = "5")]
    public JSON_ConceptCardEquipParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_ConceptCardEquipParam) null;
    }
  }
}
