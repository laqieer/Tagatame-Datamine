// Decompiled with JetBrains decompiler
// Type: SRPG.SkillPowerUpResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AC2")]
  [AddComponentMenu("UI/SkillPowerUpResult")]
  public class SkillPowerUpResult : MonoBehaviour
  {
    [Token(Token = "0x400D08B")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SkillPowerUpResultContent contentBase;
    [Token(Token = "0x400D08C")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform contanteParent;
    [Token(Token = "0x400D08D")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int onePageContentsHightMax;
    [Token(Token = "0x400D08E")]
    [FieldOffset(Offset = "0x18")]
    private List<SkillPowerUpResult.DispParam> dispParamList;
    [Token(Token = "0x400D08F")]
    [FieldOffset(Offset = "0x1C")]
    private List<SkillPowerUpResultContent> contentList;

    [Token(Token = "0x170019FE")]
    public bool IsEnd
    {
      [Token(Token = "0x600C342"), Address(RVA = "0x8CCFE0", Offset = "0x8CBDE0", VA = "0x108CCFE0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C343")]
    [Address(RVA = "0x8CCE90", Offset = "0x8CBC90", VA = "0x108CCE90")]
    private void Start()
    {
    }

    [Token(Token = "0x600C344")]
    [Address(RVA = "0x8CCAE0", Offset = "0x8CB8E0", VA = "0x108CCAE0")]
    public void SetData(
      ConceptCardData currentCardData,
      int prevAwakeCount,
      int prevLevel,
      bool includeMaxPowerUp)
    {
    }

    [Token(Token = "0x600C345")]
    [Address(RVA = "0x8CC2E0", Offset = "0x8CB0E0", VA = "0x108CC2E0")]
    public void ApplyContent()
    {
    }

    [Token(Token = "0x600C346")]
    [Address(RVA = "0x8CCF30", Offset = "0x8CBD30", VA = "0x108CCF30")]
    public SkillPowerUpResult()
    {
    }

    [Token(Token = "0x2002AC3")]
    private class DispParam
    {
      [Token(Token = "0x400D090")]
      [FieldOffset(Offset = "0x8")]
      public SkillPowerUpResultContent.Param sourceParam;
      [Token(Token = "0x400D091")]
      [FieldOffset(Offset = "0xC")]
      public List<ParamTypes> dispTypeList;
      [Token(Token = "0x400D092")]
      [FieldOffset(Offset = "0x10")]
      public List<ParamTypes> dispTypeListMul;

      [Token(Token = "0x600C347")]
      [Address(RVA = "0x8C1730", Offset = "0x8C0530", VA = "0x108C1730")]
      public DispParam()
      {
      }
    }
  }
}
