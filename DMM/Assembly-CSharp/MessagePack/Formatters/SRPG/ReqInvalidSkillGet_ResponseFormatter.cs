// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqInvalidSkillGet_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000922")]
  public sealed class ReqInvalidSkillGet_ResponseFormatter : 
    IMessagePackFormatter<ReqInvalidSkillGet.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016D4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016D5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60024B4")]
    [Address(RVA = "0xE05860", Offset = "0xE04660", VA = "0x10E05860")]
    public ReqInvalidSkillGet_ResponseFormatter()
    {
    }

    [Token(Token = "0x60024B5")]
    [Address(RVA = "0xE056F0", Offset = "0xE044F0", VA = "0x10E056F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqInvalidSkillGet.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60024B6")]
    [Address(RVA = "0xE05420", Offset = "0xE04220", VA = "0x10E05420", Slot = "5")]
    public ReqInvalidSkillGet.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqInvalidSkillGet.Response) null;
    }
  }
}
