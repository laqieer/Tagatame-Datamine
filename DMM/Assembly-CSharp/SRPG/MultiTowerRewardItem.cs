// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerRewardItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BF5")]
  public class MultiTowerRewardItem
  {
    [Token(Token = "0x4006C37")]
    [FieldOffset(Offset = "0x8")]
    public int round_st;
    [Token(Token = "0x4006C38")]
    [FieldOffset(Offset = "0xC")]
    public int round_ed;
    [Token(Token = "0x4006C39")]
    [FieldOffset(Offset = "0x10")]
    public MultiTowerRewardItem.RewardType type;
    [Token(Token = "0x4006C3A")]
    [FieldOffset(Offset = "0x14")]
    public string itemname;
    [Token(Token = "0x4006C3B")]
    [FieldOffset(Offset = "0x18")]
    public int num;

    [Token(Token = "0x6007331")]
    [Address(RVA = "0x37CB70", Offset = "0x37B970", VA = "0x1037CB70")]
    public void Deserialize(JSON_MultiTowerRewardItem json)
    {
    }

    [Token(Token = "0x6007332")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiTowerRewardItem()
    {
    }

    [Token(Token = "0x2001BF6")]
    public enum RewardType : byte
    {
      [Token(Token = "0x4006C3D")] None,
      [Token(Token = "0x4006C3E")] Item,
      [Token(Token = "0x4006C3F")] Coin,
      [Token(Token = "0x4006C40")] Artifact,
      [Token(Token = "0x4006C41")] Award,
      [Token(Token = "0x4006C42")] Unit,
      [Token(Token = "0x4006C43")] Gold,
    }
  }
}
