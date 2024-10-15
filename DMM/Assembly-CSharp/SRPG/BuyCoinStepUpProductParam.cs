// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinStepUpProductParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A3A")]
  public class BuyCoinStepUpProductParam : BuyCoinProductParam
  {
    [Token(Token = "0x4006094")]
    [FieldOffset(Offset = "0x50")]
    private int mStepIndex;

    [Token(Token = "0x17000BB2")]
    public int StepIndex
    {
      [Token(Token = "0x6006BE0"), Address(RVA = "0x3490F0", Offset = "0x347EF0", VA = "0x103490F0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006BE1")]
    [Address(RVA = "0x34FD00", Offset = "0x34EB00", VA = "0x1034FD00")]
    public void SetIndex(int index)
    {
    }

    [Token(Token = "0x6006BE2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinStepUpProductParam()
    {
    }
  }
}
