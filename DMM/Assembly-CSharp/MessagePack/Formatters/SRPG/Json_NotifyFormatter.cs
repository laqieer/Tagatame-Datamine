// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.Json_NotifyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200089E")]
  public sealed class Json_NotifyFormatter : 
    IMessagePackFormatter<Json_Notify>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015CC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015CD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002328")]
    [Address(RVA = "0xDBC730", Offset = "0xDBB530", VA = "0x10DBC730")]
    public Json_NotifyFormatter()
    {
    }

    [Token(Token = "0x6002329")]
    [Address(RVA = "0xDBC470", Offset = "0xDBB270", VA = "0x10DBC470", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Json_Notify value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600232A")]
    [Address(RVA = "0xDBC0D0", Offset = "0xDBAED0", VA = "0x10DBC0D0", Slot = "5")]
    public Json_Notify Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Json_Notify) null;
    }
  }
}
