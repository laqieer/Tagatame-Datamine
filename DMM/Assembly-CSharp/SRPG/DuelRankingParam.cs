// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002322")]
  public class DuelRankingParam : ContentSource.Param
  {
    [Token(Token = "0x4009CE3")]
    [FieldOffset(Offset = "0x10")]
    public DuelPlayerData mDuelRankingData;
    [Token(Token = "0x4009CE4")]
    [FieldOffset(Offset = "0x14")]
    public int mRankingViewMax;
    [Token(Token = "0x4009CE5")]
    [FieldOffset(Offset = "0x18")]
    private DuelRankingContentNode mNode;

    [Token(Token = "0x600972A")]
    [Address(RVA = "0x59ACB0", Offset = "0x599AB0", VA = "0x1059ACB0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600972B")]
    [Address(RVA = "0x492EB0", Offset = "0x491CB0", VA = "0x10492EB0", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600972C")]
    [Address(RVA = "0x59AD70", Offset = "0x599B70", VA = "0x1059AD70")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600972D")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public DuelRankingParam()
    {
    }
  }
}
