// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002825")]
  public class PointQuestGuildData
  {
    [Token(Token = "0x400BF52")]
    [FieldOffset(Offset = "0x8")]
    public int Id;
    [Token(Token = "0x400BF53")]
    [FieldOffset(Offset = "0xC")]
    public string Name;
    [Token(Token = "0x400BF54")]
    [FieldOffset(Offset = "0x10")]
    public int Rank;

    [Token(Token = "0x600B520")]
    [Address(RVA = "0x34D780", Offset = "0x34C580", VA = "0x1034D780")]
    public bool Deserialize(JSON_PointQuestGuildData json) => new bool();

    [Token(Token = "0x600B521")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestGuildData()
    {
    }
  }
}
