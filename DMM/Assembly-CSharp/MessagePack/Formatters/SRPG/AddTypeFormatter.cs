// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AddTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200056F")]
  public sealed class AddTypeFormatter : 
    IMessagePackFormatter<TobiraLearnAbilityParam.AddType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600199B")]
    [Address(RVA = "0x693740", Offset = "0x692540", VA = "0x10693740", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TobiraLearnAbilityParam.AddType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600199C")]
    [Address(RVA = "0x6936F0", Offset = "0x6924F0", VA = "0x106936F0", Slot = "5")]
    public TobiraLearnAbilityParam.AddType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new TobiraLearnAbilityParam.AddType();
    }

    [Token(Token = "0x600199D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AddTypeFormatter()
    {
    }
  }
}
