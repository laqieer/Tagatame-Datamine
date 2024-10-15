// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityPowerUpResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F2D")]
  [AddComponentMenu("UI/AbilityPowerUpResult")]
  public class AbilityPowerUpResult : MonoBehaviour
  {
    [Token(Token = "0x4008332")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private AbilityPowerUpResultContent contentBase;
    [Token(Token = "0x4008333")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform contanteParent;
    [Token(Token = "0x4008334")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int onePageContentsMax;
    [Token(Token = "0x4008335")]
    [FieldOffset(Offset = "0x18")]
    private List<AbilityPowerUpResultContent.Param> paramList;
    [Token(Token = "0x4008336")]
    [FieldOffset(Offset = "0x1C")]
    private List<AbilityPowerUpResultContent> contentList;

    [Token(Token = "0x1700124E")]
    public bool IsEnd
    {
      [Token(Token = "0x6007FA5"), Address(RVA = "0x402BA0", Offset = "0x4019A0", VA = "0x10402BA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007FA6")]
    [Address(RVA = "0x402A50", Offset = "0x401850", VA = "0x10402A50")]
    private void Start()
    {
    }

    [Token(Token = "0x6007FA7")]
    [Address(RVA = "0x402980", Offset = "0x401780", VA = "0x10402980")]
    public void SetData(ConceptCardData currentCardData, int prevAwakeCount)
    {
    }

    [Token(Token = "0x6007FA8")]
    [Address(RVA = "0x402700", Offset = "0x401500", VA = "0x10402700")]
    public void ApplyContent()
    {
    }

    [Token(Token = "0x6007FA9")]
    [Address(RVA = "0x402AF0", Offset = "0x4018F0", VA = "0x10402AF0")]
    public AbilityPowerUpResult()
    {
    }
  }
}
