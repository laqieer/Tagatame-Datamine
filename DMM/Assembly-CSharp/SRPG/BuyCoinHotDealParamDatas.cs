// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinHotDealParamDatas
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019C5")]
  public class BuyCoinHotDealParamDatas
  {
    [Token(Token = "0x4005EB6")]
    [FieldOffset(Offset = "0x8")]
    private List<SRPG.BuyCoinHotDealParam> mBuyCoinHotDealParam;

    [Token(Token = "0x17000B29")]
    public List<SRPG.BuyCoinHotDealParam> BuyCoinHotDealParam
    {
      [Token(Token = "0x600691B"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<SRPG.BuyCoinHotDealParam>) null;
      }
    }

    [Token(Token = "0x600691C")]
    [Address(RVA = "0x34E240", Offset = "0x34D040", VA = "0x1034E240")]
    public void Deserialize(JSON_BuyCoinHotDealParam[] json)
    {
    }

    [Token(Token = "0x600691D")]
    [Address(RVA = "0x34E330", Offset = "0x34D130", VA = "0x1034E330")]
    public BuyCoinHotDealParamDatas()
    {
    }
  }
}
