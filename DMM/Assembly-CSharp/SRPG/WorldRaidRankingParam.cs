// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidRankingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D70")]
  public class WorldRaidRankingParam : ContentSource.Param
  {
    [Token(Token = "0x400E27F")]
    [FieldOffset(Offset = "0x10")]
    public WorldRaidRankingData WorldRaidRanking;
    [Token(Token = "0x400E280")]
    [FieldOffset(Offset = "0x14")]
    private WorldRaidRankingContentNode mNode;

    [Token(Token = "0x600D3DC")]
    [Address(RVA = "0x9E9AA0", Offset = "0x9E88A0", VA = "0x109E9AA0", Slot = "12")]
    public override void OnEnable(ContentNode node)
    {
    }

    [Token(Token = "0x600D3DD")]
    [Address(RVA = "0x490820", Offset = "0x48F620", VA = "0x10490820", Slot = "13")]
    public override void OnDisable(ContentNode node)
    {
    }

    [Token(Token = "0x600D3DE")]
    [Address(RVA = "0x9E9B60", Offset = "0x9E8960", VA = "0x109E9B60")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600D3DF")]
    [Address(RVA = "0x418450", Offset = "0x417250", VA = "0x10418450")]
    public WorldRaidRankingParam()
    {
    }
  }
}
