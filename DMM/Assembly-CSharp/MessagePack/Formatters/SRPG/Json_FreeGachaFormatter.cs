// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_FreeGachaFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200071D")]
  public sealed class Json_FreeGachaFormatter : 
    IMessagePackFormatter<Json_FreeGacha>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012D2")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012D3")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EA5")]
    [Address(RVA = "0xC5F550", Offset = "0xC5E350", VA = "0x10C5F550")]
    public Json_FreeGachaFormatter()
    {
    }

    [Token(Token = "0x6001EA6")]
    [Address(RVA = "0xC5F450", Offset = "0xC5E250", VA = "0x10C5F450", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_FreeGacha value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EA7")]
    [Address(RVA = "0xC5F150", Offset = "0xC5DF50", VA = "0x10C5F150", Slot = "5")]
    public Json_FreeGacha Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_FreeGacha) null;
    }
  }
}
