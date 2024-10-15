// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRankingContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028E9")]
  public class RaidRankingContentParam : ContentSource.Param
  {
    [Token(Token = "0x400C4BB")]
    [FieldOffset(Offset = "0x10")]
    public RaidRankingData mData;
    [Token(Token = "0x400C4BC")]
    [FieldOffset(Offset = "0x14")]
    private RaidRankingContentNode mNode;

    [Token(Token = "0x600B92B")]
    [Address(RVA = "0x805B90", Offset = "0x804990", VA = "0x10805B90", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600B92C")]
    [Address(RVA = "0x490820", Offset = "0x48F620", VA = "0x10490820", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600B92D")]
    [Address(RVA = "0x805CB0", Offset = "0x804AB0", VA = "0x10805CB0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600B92E")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public RaidRankingContentParam()
    {
    }
  }
}
