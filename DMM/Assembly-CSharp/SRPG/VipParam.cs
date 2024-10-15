// Decompiled with JetBrains decompiler
// Type: SRPG.VipParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EEE")]
  public class VipParam
  {
    [Token(Token = "0x4008220")]
    [FieldOffset(Offset = "0x8")]
    public int PlayerLevel;
    [Token(Token = "0x4008221")]
    [FieldOffset(Offset = "0xC")]
    public int NextRankNeedPoint;
    [Token(Token = "0x4008222")]
    [FieldOffset(Offset = "0x10")]
    public int Ticket;
    [Token(Token = "0x4008223")]
    [FieldOffset(Offset = "0x14")]
    public int BuyCoinBonus;
    [Token(Token = "0x4008224")]
    [FieldOffset(Offset = "0x18")]
    public int BuyCoinNum;
    [Token(Token = "0x4008225")]
    [FieldOffset(Offset = "0x1C")]
    public int BuyStaminaNum;
    [Token(Token = "0x4008226")]
    [FieldOffset(Offset = "0x20")]
    public int ResetEliteNum;
    [Token(Token = "0x4008227")]
    [FieldOffset(Offset = "0x24")]
    public int ResetArenaNum;

    [Token(Token = "0x6007E6E")]
    [Address(RVA = "0x3FDB60", Offset = "0x3FC960", VA = "0x103FDB60")]
    public bool Deserialize(JSON_VipParam json) => new bool();

    [Token(Token = "0x6007E6F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VipParam()
    {
    }
  }
}
