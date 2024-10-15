// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityPowerUpResultContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F2E")]
  [AddComponentMenu("UI/AbilityPowerUpResultContent")]
  public class AbilityPowerUpResultContent : MonoBehaviour
  {
    [Token(Token = "0x6007FAA")]
    [Address(RVA = "0x402670", Offset = "0x401470", VA = "0x10402670")]
    public void SetData(AbilityPowerUpResultContent.Param param)
    {
    }

    [Token(Token = "0x6007FAB")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AbilityPowerUpResultContent()
    {
    }

    [Token(Token = "0x2001F2F")]
    public class Param
    {
      [Token(Token = "0x4008337")]
      [FieldOffset(Offset = "0x8")]
      public AbilityParam data;

      [Token(Token = "0x6007FAC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Param()
      {
      }
    }
  }
}
