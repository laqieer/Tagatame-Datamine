// Decompiled with JetBrains decompiler
// Type: SRPG.GvGBattleResultUnitContentData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200259D")]
  public class GvGBattleResultUnitContentData
  {
    [Token(Token = "0x400AE74")]
    [FieldOffset(Offset = "0x8")]
    public Unit mUnit;
    [Token(Token = "0x400AE75")]
    [FieldOffset(Offset = "0xC")]
    public int mHp;

    [Token(Token = "0x600A70B")]
    [Address(RVA = "0x37BC60", Offset = "0x37AA60", VA = "0x1037BC60")]
    public void Deserilize(Unit unit, int hp)
    {
    }

    [Token(Token = "0x600A70C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GvGBattleResultUnitContentData()
    {
    }
  }
}
