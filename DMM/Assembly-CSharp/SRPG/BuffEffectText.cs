// Decompiled with JetBrains decompiler
// Type: SRPG.BuffEffectText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E79")]
  [AddComponentMenu("Common/BuffEffectText")]
  public class BuffEffectText : MonoBehaviour
  {
    [Token(Token = "0x4002C46")]
    [FieldOffset(Offset = "0xC")]
    public RichBitmapText Text;

    [Token(Token = "0x6003C09")]
    [Address(RVA = "0x10E2010", Offset = "0x10E0E10", VA = "0x110E2010")]
    public void SetText(ParamTypes type, bool down)
    {
    }

    [Token(Token = "0x6003C0A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BuffEffectText()
    {
    }
  }
}
