// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.LoginNewsInfo_JSON_PubInfoFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000731")]
  public sealed class LoginNewsInfo_JSON_PubInfoFormatter : 
    IMessagePackFormatter<LoginNewsInfo.JSON_PubInfo>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40012FA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40012FB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001EE1")]
    [Address(RVA = "0xC877C0", Offset = "0xC865C0", VA = "0x10C877C0")]
    public LoginNewsInfo_JSON_PubInfoFormatter()
    {
    }

    [Token(Token = "0x6001EE2")]
    [Address(RVA = "0xC875C0", Offset = "0xC863C0", VA = "0x10C875C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      LoginNewsInfo.JSON_PubInfo value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001EE3")]
    [Address(RVA = "0xC871F0", Offset = "0xC85FF0", VA = "0x10C871F0", Slot = "5")]
    public LoginNewsInfo.JSON_PubInfo Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (LoginNewsInfo.JSON_PubInfo) null;
    }
  }
}
