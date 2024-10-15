// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_TowerRewardParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200059B")]
  public sealed class JSON_TowerRewardParamFormatter : 
    IMessagePackFormatter<JSON_TowerRewardParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4000FCE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4000FCF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001A1F")]
    [Address(RVA = "0x793CA0", Offset = "0x792AA0", VA = "0x10793CA0")]
    public JSON_TowerRewardParamFormatter()
    {
    }

    [Token(Token = "0x6001A20")]
    [Address(RVA = "0x793AC0", Offset = "0x7928C0", VA = "0x10793AC0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_TowerRewardParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001A21")]
    [Address(RVA = "0x793780", Offset = "0x792580", VA = "0x10793780", Slot = "5")]
    public JSON_TowerRewardParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_TowerRewardParam) null;
    }
  }
}
