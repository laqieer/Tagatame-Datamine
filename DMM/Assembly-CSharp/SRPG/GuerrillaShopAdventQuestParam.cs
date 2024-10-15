// Decompiled with JetBrains decompiler
// Type: SRPG.GuerrillaShopAdventQuestParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B1A")]
  public class GuerrillaShopAdventQuestParam
  {
    [Token(Token = "0x400674F")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006750")]
    [FieldOffset(Offset = "0xC")]
    public string qid;

    [Token(Token = "0x6006FD6")]
    [Address(RVA = "0x36E1E0", Offset = "0x36CFE0", VA = "0x1036E1E0")]
    public bool Deserialize(JSON_GuerrillaShopAdventQuestParam json) => new bool();

    [Token(Token = "0x6006FD7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuerrillaShopAdventQuestParam()
    {
    }
  }
}
