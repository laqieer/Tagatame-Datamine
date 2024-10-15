// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.AIActionTypeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000585")]
  public sealed class AIActionTypeFormatter : 
    IMessagePackFormatter<AIActionType>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60019DD")]
    [Address(RVA = "0x6936A0", Offset = "0x6924A0", VA = "0x106936A0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      AIActionType value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60019DE")]
    [Address(RVA = "0x693650", Offset = "0x692450", VA = "0x10693650", Slot = "5")]
    public AIActionType Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new AIActionType();
    }

    [Token(Token = "0x60019DF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AIActionTypeFormatter()
    {
    }
  }
}
