// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinStepUpProductParent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A38")]
  public class BuyCoinStepUpProductParent : BuyCoinProductParam
  {
    [Token(Token = "0x4006092")]
    [FieldOffset(Offset = "0x50")]
    public List<BuyCoinStepUpProductParam> m_Params;

    [Token(Token = "0x6006BDB")]
    [Address(RVA = "0x34FD10", Offset = "0x34EB10", VA = "0x1034FD10", Slot = "4")]
    public override eProductType GetProductType() => new eProductType();

    [Token(Token = "0x6006BDC")]
    [Address(RVA = "0x34FD20", Offset = "0x34EB20", VA = "0x1034FD20")]
    public BuyCoinStepUpProductParam GetStepParam(int index) => (BuyCoinStepUpProductParam) null;

    [Token(Token = "0x6006BDD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinStepUpProductParent()
    {
    }
  }
}
