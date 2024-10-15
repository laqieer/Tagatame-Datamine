// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_MasterAbilityFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20005A9")]
  public sealed class Json_MasterAbilityFormatter : 
    IMessagePackFormatter<Json_MasterAbility>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FEA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FEB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A49")]
    [Address(RVA = "0x79DD50", Offset = "0x79CB50", VA = "0x1079DD50")]
    public Json_MasterAbilityFormatter()
    {
    }

    [Token(Token = "0x6001A4A")]
    [Address(RVA = "0x79DBE0", Offset = "0x79C9E0", VA = "0x1079DBE0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_MasterAbility value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A4B")]
    [Address(RVA = "0x79D870", Offset = "0x79C670", VA = "0x1079D870", Slot = "5")]
    public Json_MasterAbility Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_MasterAbility) null;
    }
  }
}
