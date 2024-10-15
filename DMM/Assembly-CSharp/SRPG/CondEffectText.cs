// Decompiled with JetBrains decompiler
// Type: SRPG.CondEffectText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E9E")]
  [AddComponentMenu("Common/CondEffectText")]
  public class CondEffectText : MonoBehaviour
  {
    [Token(Token = "0x4002CE6")]
    [FieldOffset(Offset = "0xC")]
    public RichBitmapText Text;

    [Token(Token = "0x6003CD6")]
    [Address(RVA = "0x10F27D0", Offset = "0x10F15D0", VA = "0x110F27D0")]
    public void SetText(EUnitCondition condition)
    {
    }

    [Token(Token = "0x6003CD7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public CondEffectText()
    {
    }
  }
}
