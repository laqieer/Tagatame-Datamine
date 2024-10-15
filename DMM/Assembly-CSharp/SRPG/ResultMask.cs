// Decompiled with JetBrains decompiler
// Type: SRPG.ResultMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C67")]
  [AddComponentMenu("Battle/BattleUI/ResultMask")]
  public class ResultMask : MonoBehaviour
  {
    [Token(Token = "0x400217E")]
    [FieldOffset(Offset = "0xC")]
    public RawImage ImgBg;

    [Token(Token = "0x60030ED")]
    [Address(RVA = "0x1024700", Offset = "0x1023500", VA = "0x11024700")]
    public void SetBg(Texture2D tex)
    {
    }

    [Token(Token = "0x60030EE")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ResultMask()
    {
    }
  }
}
