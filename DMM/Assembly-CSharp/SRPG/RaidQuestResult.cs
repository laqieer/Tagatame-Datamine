// Decompiled with JetBrains decompiler
// Type: SRPG.RaidQuestResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028F8")]
  public class RaidQuestResult
  {
    [Token(Token = "0x400C50E")]
    [FieldOffset(Offset = "0x8")]
    public int index;
    [Token(Token = "0x400C50F")]
    [FieldOffset(Offset = "0xC")]
    public int pexp;
    [Token(Token = "0x400C510")]
    [FieldOffset(Offset = "0x10")]
    public int uexp;
    [Token(Token = "0x400C511")]
    [FieldOffset(Offset = "0x14")]
    public int gold;
    [Token(Token = "0x400C512")]
    [FieldOffset(Offset = "0x18")]
    public QuestResult.DropItemData[] drops;

    [Token(Token = "0x600B972")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RaidQuestResult()
    {
    }
  }
}
