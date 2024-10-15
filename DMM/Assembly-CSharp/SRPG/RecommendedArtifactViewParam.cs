// Decompiled with JetBrains decompiler
// Type: SRPG.RecommendedArtifactViewParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CA6")]
  public class RecommendedArtifactViewParam
  {
    [Token(Token = "0x400708A")]
    [FieldOffset(Offset = "0x8")]
    private bool m_IsRecommend;

    [Token(Token = "0x17000F4A")]
    public bool IsRecommend
    {
      [Token(Token = "0x6007603"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007604")]
    [Address(RVA = "0x396910", Offset = "0x395710", VA = "0x10396910")]
    public RecommendedArtifactViewParam(bool isRecommend)
    {
    }
  }
}
