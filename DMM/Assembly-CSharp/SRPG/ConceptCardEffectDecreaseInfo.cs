// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardEffectDecreaseInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E98")]
  public class ConceptCardEffectDecreaseInfo
  {
    [Token(Token = "0x4002CD6")]
    public const int DECREASE_RATE_DEFAULT = 0;
    [Token(Token = "0x4002CD7")]
    [FieldOffset(Offset = "0x8")]
    public ConceptCardData m_ConceptCardData;
    [Token(Token = "0x4002CD8")]
    [FieldOffset(Offset = "0xC")]
    public bool m_IsDecreaseEffect;

    [Token(Token = "0x6003CC5")]
    [Address(RVA = "0x305760", Offset = "0x304560", VA = "0x10305760")]
    public ConceptCardEffectDecreaseInfo(ConceptCardData conceptCard, bool isDecreaseEffect)
    {
    }
  }
}
