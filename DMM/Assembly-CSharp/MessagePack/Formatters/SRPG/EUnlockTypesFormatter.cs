// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.EUnlockTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000553")]
  public sealed class EUnlockTypesFormatter : 
    IMessagePackFormatter<QuestClearUnlockUnitDataParam.EUnlockTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x6001947")]
    [Address(RVA = "0x69C260", Offset = "0x69B060", VA = "0x1069C260", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      QuestClearUnlockUnitDataParam.EUnlockTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001948")]
    [Address(RVA = "0x69C210", Offset = "0x69B010", VA = "0x1069C210", Slot = "5")]
    public QuestClearUnlockUnitDataParam.EUnlockTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new QuestClearUnlockUnitDataParam.EUnlockTypes();
    }

    [Token(Token = "0x6001949")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EUnlockTypesFormatter()
    {
    }
  }
}
