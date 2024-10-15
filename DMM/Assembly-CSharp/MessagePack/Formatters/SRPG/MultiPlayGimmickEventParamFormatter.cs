// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.MultiPlayGimmickEventParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200074F")]
  public sealed class MultiPlayGimmickEventParamFormatter : 
    IMessagePackFormatter<MultiPlayGimmickEventParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001336")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001337")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001F3B")]
    [Address(RVA = "0xC87E00", Offset = "0xC86C00", VA = "0x10C87E00")]
    public MultiPlayGimmickEventParamFormatter()
    {
    }

    [Token(Token = "0x6001F3C")]
    [Address(RVA = "0xC87D00", Offset = "0xC86B00", VA = "0x10C87D00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      MultiPlayGimmickEventParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001F3D")]
    [Address(RVA = "0xC87A20", Offset = "0xC86820", VA = "0x10C87A20", Slot = "5")]
    public MultiPlayGimmickEventParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (MultiPlayGimmickEventParam) null;
    }
  }
}
