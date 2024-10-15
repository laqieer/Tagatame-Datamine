// Decompiled with JetBrains decompiler
// Type: SRPG.RewardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002954")]
  public class RewardData
  {
    [Token(Token = "0x400C735")]
    [FieldOffset(Offset = "0x8")]
    public int Exp;
    [Token(Token = "0x400C736")]
    [FieldOffset(Offset = "0xC")]
    public int Gold;
    [Token(Token = "0x400C737")]
    [FieldOffset(Offset = "0x10")]
    public int Coin;
    [Token(Token = "0x400C738")]
    [FieldOffset(Offset = "0x14")]
    public int ArenaMedal;
    [Token(Token = "0x400C739")]
    [FieldOffset(Offset = "0x18")]
    public int MultiCoin;
    [Token(Token = "0x400C73A")]
    [FieldOffset(Offset = "0x1C")]
    public int KakeraCoin;
    [Token(Token = "0x400C73B")]
    [FieldOffset(Offset = "0x20")]
    public int Stamina;
    [Token(Token = "0x400C73C")]
    [FieldOffset(Offset = "0x24")]
    public List<ItemData> Items;
    [Token(Token = "0x400C73D")]
    [FieldOffset(Offset = "0x28")]
    public List<ArtifactRewardData> Artifacts;
    [Token(Token = "0x400C73E")]
    [FieldOffset(Offset = "0x2C")]
    public List<int> ItemsBeforeAmount;
    [Token(Token = "0x400C73F")]
    [FieldOffset(Offset = "0x30")]
    public bool IsOverLimit;
    [Token(Token = "0x400C740")]
    [FieldOffset(Offset = "0x34")]
    public Dictionary<string, GiftRecieveItemData> GiftRecieveItemDataDic;

    [Token(Token = "0x600BAF1")]
    [Address(RVA = "0x825980", Offset = "0x824780", VA = "0x10825980")]
    public RewardData()
    {
    }

    [Token(Token = "0x600BAF2")]
    [Address(RVA = "0x825C10", Offset = "0x824A10", VA = "0x10825C10")]
    public RewardData(TrophyStarMissionRewardParam trophy)
    {
    }

    [Token(Token = "0x600BAF3")]
    [Address(RVA = "0x825AC0", Offset = "0x8248C0", VA = "0x10825AC0")]
    public RewardData(TrophyParam trophy)
    {
    }

    [Token(Token = "0x600BAF4")]
    [Address(RVA = "0x8253C0", Offset = "0x8241C0", VA = "0x108253C0")]
    public void AddReward(TrophyParam trophy)
    {
    }

    [Token(Token = "0x600BAF5")]
    [Address(RVA = "0x824ED0", Offset = "0x823CD0", VA = "0x10824ED0")]
    public void AddReward(TrophyStarMissionRewardParam trophy)
    {
    }

    [Token(Token = "0x600BAF6")]
    [Address(RVA = "0x825360", Offset = "0x824160", VA = "0x10825360")]
    public void AddReward(ArtifactParam param, int num)
    {
    }

    [Token(Token = "0x600BAF7")]
    [Address(RVA = "0x824AA0", Offset = "0x8238A0", VA = "0x10824AA0")]
    public void AddRewardArtifacts(ArtifactParam artifact_param, int num)
    {
    }

    [Token(Token = "0x600BAF8")]
    [Address(RVA = "0x825910", Offset = "0x824710", VA = "0x10825910")]
    public void AddReward(ItemParam param, int num)
    {
    }

    [Token(Token = "0x600BAF9")]
    [Address(RVA = "0x824D60", Offset = "0x823B60", VA = "0x10824D60")]
    public void AddRewardItems(ItemParam item_param, int num)
    {
    }

    [Token(Token = "0x600BAFA")]
    [Address(RVA = "0x825390", Offset = "0x824190", VA = "0x10825390")]
    public void AddReward(ConceptCardParam param, int num)
    {
    }

    [Token(Token = "0x600BAFB")]
    [Address(RVA = "0x825270", Offset = "0x824070", VA = "0x10825270")]
    private void AddReward(string iname, GiftTypes giftTipe, int rarity, int num)
    {
    }

    [Token(Token = "0x600BAFC")]
    [Address(RVA = "0x8250F0", Offset = "0x823EF0", VA = "0x108250F0")]
    public void AddReward(GiftRecieveItemData giftRecieveItemData)
    {
    }

    [Token(Token = "0x600BAFD")]
    [Address(RVA = "0x824BF0", Offset = "0x8239F0", VA = "0x10824BF0")]
    public void AddRewardCrystal(CrystalParam _param, int _num, int _rank)
    {
    }
  }
}
