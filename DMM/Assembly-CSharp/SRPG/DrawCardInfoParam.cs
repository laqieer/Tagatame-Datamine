// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardInfoParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AAB")]
  public class DrawCardInfoParam
  {
    [Token(Token = "0x40062D8")]
    [FieldOffset(Offset = "0x8")]
    public OInt CardNum;
    [Token(Token = "0x40062D9")]
    [FieldOffset(Offset = "0x1C")]
    public OInt MissNum;
    [Token(Token = "0x40062DA")]
    [FieldOffset(Offset = "0x30")]
    public string DcRewardId;
    [Token(Token = "0x40062DB")]
    [FieldOffset(Offset = "0x34")]
    private DrawCardRewardParam mDcReward;

    [Token(Token = "0x17000C52")]
    public DrawCardRewardParam DcReward
    {
      [Token(Token = "0x6006DF4"), Address(RVA = "0x35CE30", Offset = "0x35BC30", VA = "0x1035CE30")] get
      {
        return (DrawCardRewardParam) null;
      }
    }

    [Token(Token = "0x6006DF5")]
    [Address(RVA = "0x35CDD0", Offset = "0x35BBD0", VA = "0x1035CDD0")]
    public void Deserialize(JSON_DrawCardParam.DrawInfo json)
    {
    }

    [Token(Token = "0x6006DF6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DrawCardInfoParam()
    {
    }
  }
}
