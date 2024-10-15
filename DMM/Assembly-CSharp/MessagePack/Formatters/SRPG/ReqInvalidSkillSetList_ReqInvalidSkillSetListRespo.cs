// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqInvalidSkillSetList_ReqInvalidSkillSetListResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000A45")]
  public sealed class ReqInvalidSkillSetList_ReqInvalidSkillSetListResponseFormatter : 
    IMessagePackFormatter<ReqInvalidSkillSetList.ReqInvalidSkillSetListResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400191A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400191B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x600281D")]
    [Address(RVA = "0xEB9380", Offset = "0xEB8180", VA = "0x10EB9380")]
    public ReqInvalidSkillSetList_ReqInvalidSkillSetListResponseFormatter()
    {
    }

    [Token(Token = "0x600281E")]
    [Address(RVA = "0xEB9090", Offset = "0xEB7E90", VA = "0x10EB9090", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqInvalidSkillSetList.ReqInvalidSkillSetListResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600281F")]
    [Address(RVA = "0xEB8C60", Offset = "0xEB7A60", VA = "0x10EB8C60", Slot = "5")]
    public ReqInvalidSkillSetList.ReqInvalidSkillSetListResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqInvalidSkillSetList.ReqInvalidSkillSetListResponse) null;
    }
  }
}
