// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqInvalidSkillSetList_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A44")]
  public sealed class ReqInvalidSkillSetList_ResponseFormatter : 
    IMessagePackFormatter<ReqInvalidSkillSetList.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001918")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001919")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600281A")]
    [Address(RVA = "0xEBA140", Offset = "0xEB8F40", VA = "0x10EBA140")]
    public ReqInvalidSkillSetList_ResponseFormatter()
    {
    }

    [Token(Token = "0x600281B")]
    [Address(RVA = "0xEB9FD0", Offset = "0xEB8DD0", VA = "0x10EB9FD0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqInvalidSkillSetList.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600281C")]
    [Address(RVA = "0xEB9D00", Offset = "0xEB8B00", VA = "0x10EB9D00", Slot = "5")]
    public ReqInvalidSkillSetList.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqInvalidSkillSetList.Response) null;
    }
  }
}
