// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_JobSelectableFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005AF")]
  public sealed class Json_JobSelectableFormatter : 
    IMessagePackFormatter<Json_JobSelectable>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FF6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FF7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A5B")]
    [Address(RVA = "0x79D680", Offset = "0x79C480", VA = "0x1079D680")]
    public Json_JobSelectableFormatter()
    {
    }

    [Token(Token = "0x6001A5C")]
    [Address(RVA = "0x79D440", Offset = "0x79C240", VA = "0x1079D440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_JobSelectable value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A5D")]
    [Address(RVA = "0x79D0A0", Offset = "0x79BEA0", VA = "0x1079D0A0", Slot = "5")]
    public Json_JobSelectable Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_JobSelectable) null;
    }
  }
}
