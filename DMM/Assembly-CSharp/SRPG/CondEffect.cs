// Decompiled with JetBrains decompiler
// Type: SRPG.CondEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E9D")]
  [MessagePackObject(true)]
  public class CondEffect
  {
    [Token(Token = "0x4002CE2")]
    [FieldOffset(Offset = "0x8")]
    public CondEffectParam param;
    [Token(Token = "0x4002CE3")]
    [FieldOffset(Offset = "0xC")]
    public OInt turn;
    [Token(Token = "0x4002CE4")]
    [FieldOffset(Offset = "0x20")]
    public OInt rate;
    [Token(Token = "0x4002CE5")]
    [FieldOffset(Offset = "0x34")]
    public OInt value;

    [Token(Token = "0x170004BA")]
    public bool IsCurse
    {
      [Token(Token = "0x6003CCE"), Address(RVA = "0x10F3130", Offset = "0x10F1F30", VA = "0x110F3130")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6003CCF")]
    [Address(RVA = "0x10F2E80", Offset = "0x10F1C80", VA = "0x110F2E80")]
    public static CondEffect CreateCondEffect(CondEffectParam param, int rank, int rankcap)
    {
      return (CondEffect) null;
    }

    [Token(Token = "0x6003CD0")]
    [Address(RVA = "0x10F2F10", Offset = "0x10F1D10", VA = "0x110F2F10")]
    public void UpdateCurrentValues(int rank, int rankcap)
    {
    }

    [Token(Token = "0x6003CD1")]
    [Address(RVA = "0x3E8840", Offset = "0x3E7640", VA = "0x103E8840")]
    private int GetRankValue(int rank, int rankcap, int ini, int max) => new int();

    [Token(Token = "0x6003CD2")]
    [Address(RVA = "0x10F2E10", Offset = "0x10F1C10", VA = "0x110F2E10")]
    public bool ContainsCondition(EUnitCondition condition) => new bool();

    [Token(Token = "0x6003CD3")]
    [Address(RVA = "0x10F2D90", Offset = "0x10F1B90", VA = "0x110F2D90")]
    private void Clear()
    {
    }

    [Token(Token = "0x6003CD4")]
    [Address(RVA = "0x10F29B0", Offset = "0x10F17B0", VA = "0x110F29B0")]
    public bool CheckEnableCondTarget(Unit target) => new bool();

    [Token(Token = "0x6003CD5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CondEffect()
    {
    }
  }
}
