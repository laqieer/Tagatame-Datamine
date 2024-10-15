// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceStarRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001965")]
  public class AdvanceStarRewardParam
  {
    [Token(Token = "0x4005C71")]
    [FieldOffset(Offset = "0x8")]
    public int NeedStarNum;
    [Token(Token = "0x4005C72")]
    [FieldOffset(Offset = "0xC")]
    public string RewardId;

    [Token(Token = "0x600678C")]
    [Address(RVA = "0x31B680", Offset = "0x31A480", VA = "0x1031B680")]
    public void Deserialize(JSON_AdvanceStarRewardParam json)
    {
    }

    [Token(Token = "0x600678D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdvanceStarRewardParam()
    {
    }
  }
}
