// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DuelRewardDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000908")]
  public sealed class JSON_DuelRewardDataFormatter : 
    IMessagePackFormatter<JSON_DuelRewardData>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40016A0")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40016A1")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002466")]
    [Address(RVA = "0xDE1C90", Offset = "0xDE0A90", VA = "0x10DE1C90")]
    public JSON_DuelRewardDataFormatter()
    {
    }

    [Token(Token = "0x6002467")]
    [Address(RVA = "0xDE1B30", Offset = "0xDE0930", VA = "0x10DE1B30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DuelRewardData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002468")]
    [Address(RVA = "0xDE17E0", Offset = "0xDE05E0", VA = "0x10DE17E0", Slot = "5")]
    public JSON_DuelRewardData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DuelRewardData) null;
    }
  }
}
