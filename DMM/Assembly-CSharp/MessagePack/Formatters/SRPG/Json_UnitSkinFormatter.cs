// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_UnitSkinFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000893")]
  public sealed class Json_UnitSkinFormatter : 
    IMessagePackFormatter<Json_UnitSkin>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015B6")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015B7")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002307")]
    [Address(RVA = "0xDA9610", Offset = "0xDA8410", VA = "0x10DA9610")]
    public Json_UnitSkinFormatter()
    {
    }

    [Token(Token = "0x6002308")]
    [Address(RVA = "0xDA94C0", Offset = "0xDA82C0", VA = "0x10DA94C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_UnitSkin value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002309")]
    [Address(RVA = "0xDA9190", Offset = "0xDA7F90", VA = "0x10DA9190", Slot = "5")]
    public Json_UnitSkin Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_UnitSkin) null;
    }
  }
}
