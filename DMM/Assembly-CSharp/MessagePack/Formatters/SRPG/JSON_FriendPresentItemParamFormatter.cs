// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_FriendPresentItemParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000601")]
  public sealed class JSON_FriendPresentItemParamFormatter : 
    IMessagePackFormatter<JSON_FriendPresentItemParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400109A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400109B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001B51")]
    [Address(RVA = "0xBA7060", Offset = "0xBA5E60", VA = "0x10BA7060")]
    public JSON_FriendPresentItemParamFormatter()
    {
    }

    [Token(Token = "0x6001B52")]
    [Address(RVA = "0xBA6D30", Offset = "0xBA5B30", VA = "0x10BA6D30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_FriendPresentItemParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001B53")]
    [Address(RVA = "0xBA6850", Offset = "0xBA5650", VA = "0x10BA6850", Slot = "5")]
    public JSON_FriendPresentItemParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_FriendPresentItemParam) null;
    }
  }
}
